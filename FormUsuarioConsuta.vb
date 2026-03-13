
Imports MySql.Data.MySqlClient

Public Class FormUsuarioConsuta
    Public ModoEdicao As Boolean
    Public UsuarioID As Integer

    Private Sub MostrarUsuarios()

        Try
            Using cn As New MySqlConnection(connString)
                cn.Open()

                Dim sql As String =
                    "SELECT id, login, nome, email, administrador, ativo " &
                    "FROM Usuarios ORDER BY login"

                Using da As New MySqlDataAdapter(sql, cn)
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox("❌ Falha ao carregar usuários:" & vbNewLine &
                   ex.Message, vbCritical, sistema)
        End Try

    End Sub

    Private Sub ConfigurarGrade()

        With DataGridView1

            .Columns("id").Visible = False

            .Columns("login").HeaderText = "Nome de login"
            .Columns("login").Width = 120

            .Columns("nome").HeaderText = "Nome real"
            .Columns("nome").Width = 200

            .Columns("email").HeaderText = "Email"
            .Columns("email").Width = 200

            .Columns("administrador").HeaderText = "Adm"
            .Columns("administrador").Width = 50
            .Columns("administrador").HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter
            .Columns("administrador").DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter

            .Columns("ativo").HeaderText = "Ativo"
            .Columns("ativo").Width = 50
            .Columns("ativo").HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter
            .Columns("ativo").DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter

        End With

    End Sub
    Private Sub FormUsuarioConsuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarUsuarios()
        ConfigurarGrade()

        ' Somente admin pode editar
        If UsuarioAdmin <> "S" Then
            BtnEditar.Enabled = False
        End If

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            FormUsuarioCadastro.ModoEdicao = True
            FormUsuarioCadastro.UsuarioID = row.Cells("id").Value
            FormUsuarioCadastro.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        Dim frm As New FormUsuarioCadastro()
        frm.ModoEdicao = False
        frm.ShowDialog()

        MostrarUsuarios()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MsgBox("Selecione um usuário.", vbInformation, sistema)
            Exit Sub
        End If

        If UsuarioAdmin = "N" Then
            MsgBox("❌ Apenas administradores podem alterar usuários.", vbCritical, sistema)
            Exit Sub
        End If

        Dim frm As New FormUsuarioCadastro()
        frm.ModoEdicao = True
        frm.UsuarioID = DataGridView1.CurrentRow.Cells("id").Value
        frm.ShowDialog()

        MostrarUsuarios()
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        ' Verificar se existe linha selecionada no DataGridView
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Selecione um usuário para excluir.", sistema,
                       MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Verificar se o usuário atual é administrador (Usando a variável do Module)
        If UsuarioAdmin <> "S" Then
            MessageBox.Show("Apenas administradores podem excluir usuários.", sistema,
                       MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Obter o ID do usuário selecionado
        Dim usuarioID As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells("id").Value)
        Dim loginUsuario As String = DataGridView1.CurrentRow.Cells("login").Value.ToString()
        Dim nomeUsuario As String = DataGridView1.CurrentRow.Cells("nome").Value.ToString()

        ' Impedir exclusão do próprio usuário logado (administrador não pode excluir a si mesmo)
        If usuarioID = UsuarioLogadoID Then
            MessageBox.Show("Você não pode excluir o próprio usuário.", sistema,
               MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ' Confirmar exclusão com o usuário
        Dim resultado = MessageBox.Show($"Deseja realmente excluir o usuário '{nomeUsuario}' (login: {loginUsuario})?",
                                   "Confirmar Exclusão",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Using cn As New MySqlConnection(connString)
                cn.Open()

                ' Primeiro verificar se existem consultas vinculadas a este usuário
                Dim sqlVerifica As String = "SELECT COUNT(*) FROM consultas WHERE usuario_id = @id"
                Using cmdVerifica As New MySqlCommand(sqlVerifica, cn)
                    cmdVerifica.Parameters.AddWithValue("@id", usuarioID)
                    Dim totalConsultas As Integer = Convert.ToInt32(cmdVerifica.ExecuteScalar())

                    If totalConsultas > 0 Then
                        MessageBox.Show($"Este usuário possui {totalConsultas} consulta(s) vinculada(s). Exclusão não permitida.",
                                   sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                ' Se não tiver consultas, prosseguir com a exclusão
                Dim sql As String = "DELETE FROM Usuarios WHERE id = @id"

                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", usuarioID)

                    Try
                        Dim registrosAfetados As Integer = cmd.ExecuteNonQuery()

                        If registrosAfetados > 0 Then
                            MessageBox.Show($"Usuário '{nomeUsuario}' excluído com sucesso!",
                                       sistema,
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information)

                            ' Recarregar os dados na DataGridView
                            MostrarUsuarios()
                        End If

                    Catch ex As MySqlException
                        ' Verificar se é erro de chave estrangeira
                        If ex.Number = 1451 Then ' Erro de chave estrangeira no MySQL
                            MessageBox.Show("Não é possível excluir este usuário pois existem registros vinculados a ele.",
                                       sistema,
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error)
                        Else
                            MessageBox.Show("Erro ao excluir usuário: " & ex.Message,
                                       sistema,
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error)
                        End If
                    End Try
                End Using
            End Using
        End If
    End Sub
End Class