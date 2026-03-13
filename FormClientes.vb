Imports System.Data.SqlClient

Public Class FormClientes
    Private conexao As SqlConnection
    Private adaptador As SqlDataAdapter
    Private tabela As DataTable
    Private modoEdicao As Boolean = False
    Private clienteId As Integer = 0

    Public Sub New(conn As SqlConnection)
        InitializeComponent()
        conexao = conn
    End Sub

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarClientes()
        ConfigurarGrid()
        LimparCampos()
    End Sub

    Private Sub ConfigurarGrid()
        dgvClientes.AutoGenerateColumns = False

        ' Configurar colunas
        dgvClientes.Columns.Add("ClienteID", "Código")
        dgvClientes.Columns.Add("Nome", "Nome")
        dgvClientes.Columns.Add("CPF", "CPF")
        dgvClientes.Columns.Add("Telefone", "Telefone")
        dgvClientes.Columns.Add("Celular", "Celular")
        dgvClientes.Columns.Add("Email", "Email")
        dgvClientes.Columns.Add("Cidade", "Cidade")

        ' Definir propriedades das colunas
        dgvClientes.Columns("ClienteID").Width = 60
        dgvClientes.Columns("Nome").Width = 200
        dgvClientes.Columns("CPF").Width = 100
        dgvClientes.Columns("Telefone").Width = 100
        dgvClientes.Columns("Celular").Width = 100
        dgvClientes.Columns("Email").Width = 150
        dgvClientes.Columns("Cidade").Width = 100
    End Sub

    Private Sub CarregarClientes()
        Try
            Dim query As String = "SELECT * FROM Clientes ORDER BY Nome"
            adaptador = New SqlDataAdapter(query, conexao)
            tabela = New DataTable()
            adaptador.Fill(tabela)
            dgvClientes.DataSource = tabela
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar clientes: " & ex.Message, "Erro",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataRowView = DirectCast(dgvClientes.Rows(e.RowIndex).DataBoundItem, DataRowView)
            PreencherCampos(row.Row)
        End If
    End Sub

    Private Sub PreencherCampos(row As DataRow)
        clienteId = Convert.ToInt32(row("ClienteID"))
        txtNome.Text = row("Nome").ToString()
        txtCPF.Text = row("CPF").ToString()
        txtRG.Text = row("RG").ToString()
        dtpNascimento.Value = If(row("DataNascimento") Is DBNull.Value, Today, Convert.ToDateTime(row("DataNascimento")))
        txtTelefone.Text = row("Telefone").ToString()
        txtCelular.Text = row("Celular").ToString()
        txtEmail.Text = row("Email").ToString()
        txtEndereco.Text = row("Endereco").ToString()
        txtNumero.Text = row("Numero").ToString()
        txtComplemento.Text = row("Complemento").ToString()
        txtBairro.Text = row("Bairro").ToString()
        txtCidade.Text = row("Cidade").ToString()
        cmbEstado.Text = row("Estado").ToString()
        txtCEP.Text = row("CEP").ToString()
        txtObservacoes.Text = row("Observacoes").ToString()

        modoEdicao = True
    End Sub

    Private Sub LimparCampos()
        clienteId = 0
        txtNome.Clear()
        txtCPF.Clear()
        txtRG.Clear()
        dtpNascimento.Value = Today
        txtTelefone.Clear()
        txtCelular.Clear()
        txtEmail.Clear()
        txtEndereco.Clear()
        txtNumero.Clear()
        txtComplemento.Clear()
        txtBairro.Clear()
        txtCidade.Clear()
        cmbEstado.SelectedIndex = -1
        txtCEP.Clear()
        txtObservacoes.Clear()

        modoEdicao = False
        txtNome.Focus()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        LimparCampos()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If Not ValidarCampos() Then Exit Sub

        Try
            If modoEdicao Then
                ' Atualizar cliente existente
                Dim query As String = "UPDATE Clientes SET Nome=@Nome, CPF=@CPF, RG=@RG, DataNascimento=@DataNascimento, " &
                                     "Telefone=@Telefone, Celular=@Celular, Email=@Email, Endereco=@Endereco, " &
                                     "Numero=@Numero, Complemento=@Complemento, Bairro=@Bairro, Cidade=@Cidade, " &
                                     "Estado=@Estado, CEP=@CEP, Observacoes=@Observacoes WHERE ClienteID=@ClienteID"

                Using cmd As New SqlCommand(query, conexao)
                    cmd.Parameters.AddWithValue("@ClienteID", clienteId)
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text)
                    cmd.Parameters.AddWithValue("@CPF", txtCPF.Text)
                    cmd.Parameters.AddWithValue("@RG", txtRG.Text)
                    cmd.Parameters.AddWithValue("@DataNascimento", dtpNascimento.Value)
                    cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text)
                    cmd.Parameters.AddWithValue("@Celular", txtCelular.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text)
                    cmd.Parameters.AddWithValue("@Numero", txtNumero.Text)
                    cmd.Parameters.AddWithValue("@Complemento", txtComplemento.Text)
                    cmd.Parameters.AddWithValue("@Bairro", txtBairro.Text)
                    cmd.Parameters.AddWithValue("@Cidade", txtCidade.Text)
                    cmd.Parameters.AddWithValue("@Estado", cmbEstado.Text)
                    cmd.Parameters.AddWithValue("@CEP", txtCEP.Text)
                    cmd.Parameters.AddWithValue("@Observacoes", txtObservacoes.Text)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso",
                              MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Inserir novo cliente
                Dim query As String = "INSERT INTO Clientes (Nome, CPF, RG, DataNascimento, Telefone, Celular, Email, " &
                                     "Endereco, Numero, Complemento, Bairro, Cidade, Estado, CEP, Observacoes) " &
                                     "VALUES (@Nome, @CPF, @RG, @DataNascimento, @Telefone, @Celular, @Email, " &
                                     "@Endereco, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @CEP, @Observacoes)"

                Using cmd As New SqlCommand(query, conexao)
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text)
                    cmd.Parameters.AddWithValue("@CPF", txtCPF.Text)
                    cmd.Parameters.AddWithValue("@RG", txtRG.Text)
                    cmd.Parameters.AddWithValue("@DataNascimento", dtpNascimento.Value)
                    cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text)
                    cmd.Parameters.AddWithValue("@Celular", txtCelular.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text)
                    cmd.Parameters.AddWithValue("@Numero", txtNumero.Text)
                    cmd.Parameters.AddWithValue("@Complemento", txtComplemento.Text)
                    cmd.Parameters.AddWithValue("@Bairro", txtBairro.Text)
                    cmd.Parameters.AddWithValue("@Cidade", txtCidade.Text)
                    cmd.Parameters.AddWithValue("@Estado", cmbEstado.Text)
                    cmd.Parameters.AddWithValue("@CEP", txtCEP.Text)
                    cmd.Parameters.AddWithValue("@Observacoes", txtObservacoes.Text)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso",
                              MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CarregarClientes()
            LimparCampos()

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar cliente: " & ex.Message, "Erro",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(txtNome.Text) Then
            MessageBox.Show("O nome do cliente é obrigatório!", "Validação",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNome.Focus()
            Return False
        End If
        Return True
    End Function
End Class