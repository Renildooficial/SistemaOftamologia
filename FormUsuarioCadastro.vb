Imports MySql.Data.MySqlClient



Public Class FormUsuarioCadastro
    Public Property ModoEdicao As Boolean
    Public Property UsuarioID As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        If ValidarForm() Then
            SalvarUsuario()
            LimparCampos()
        End If

    End Sub

    Private Function ValidarForm() As Boolean

        If TxtLogin.Text.Trim = "" Then
            MsgBox("Informe o login do usuário.", vbExclamation, sistema)
            TxtLogin.Focus()
            Return False
        End If

        If TxtLogin.Text.Length > 15 Then
            MsgBox("O nome de usuario deve ter no máximo 15 caracteres.", vbExclamation, sistema)
            TxtLogin.Focus()
            Return False
        End If

        If TxtNome.Text.Trim = "" Then
            MsgBox("Informe o nome completo do usuário.", vbExclamation, sistema)
            TxtNome.Focus()
            Return False
        End If

        If TxtNome.Text.Length > 70 Then
            MsgBox("O nome deve ter no máximo 70 caracteres.", vbExclamation, sistema)
            TxtNome.Focus()
            Return False
        End If

        If TxtSenha.Text.Length < 4 Then
            MsgBox("A senha deve ter pelo menos 4 caracteres.", vbExclamation, sistema)
            TxtSenha.Focus()
            Return False
        End If

        If TxtSenha.Text.Length > 30 Then
            MsgBox("A senha deve ter no máximo 30 caracteres.", vbExclamation, sistema)
            TxtSenha.Focus()
            Return False
        End If

        Return True

    End Function

    Private Function SalvarUsuario() As Boolean

        If Not ValidarForm() Then Return False

        Try

            Dim sql As String

            If CLng("0" & LblID.Text) = 0 Then
                ' INSERT
                sql = "INSERT INTO Usuarios (login, nome, email, senha, administrador, ativo) " &
                  "VALUES (@login, @nome, @email, @senha, @administrador, @ativo)"
            Else
                ' UPDATE
                sql = "UPDATE Usuarios SET login=@login, nome=@nome, email=@email, senha=@senha, " &
                  "administrador=@administrador, ativo=@ativo WHERE id=@id"
            End If

            Using cn As New MySqlConnection(connString)
                cn.Open()

                Using cmd As New MySqlCommand(sql, cn)

                    cmd.Parameters.AddWithValue("@login", TxtLogin.Text.Trim)
                    cmd.Parameters.AddWithValue("@nome", TxtNome.Text.Trim)
                    cmd.Parameters.AddWithValue("@email", TxtEmail.Text.Trim)
                    cmd.Parameters.AddWithValue("@senha", TxtSenha.Text.Trim)
                    cmd.Parameters.AddWithValue("@administrador", If(ChkAdministrador.Checked, "S", "N"))
                    cmd.Parameters.AddWithValue("@ativo", If(ChkAtivo.Checked, "S", "N"))

                    If CLng("0" & LblID.Text) <> 0 Then
                        cmd.Parameters.AddWithValue("@id", CLng(LblID.Text))
                    End If

                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MsgBox("✅ Usuário salvo com sucesso!", vbInformation, sistema)
            Return True

        Catch ex As Exception
            MsgBox("❌ Erro ao salvar usuário: " & ex.Message, vbCritical, sistema)
            Return False
        End Try

    End Function


    Private Sub FormUsuarioCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModoEdicao Then
            ' Carrega dados do usuário selecionado
            Using cn As New MySqlConnection(connString)
                cn.Open()

                Dim sql As String = "SELECT login, nome, email, administrador, ativo FROM Usuarios WHERE id=@id"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", UsuarioID)

                    Using dr = cmd.ExecuteReader()
                        If dr.Read() Then
                            LblID.Text = UsuarioID
                            TxtLogin.Text = dr("login")
                            TxtNome.Text = dr("nome")
                            TxtEmail.Text = dr("email")

                            ChkAdministrador.Checked = dr("administrador").ToString() = "S"
                            ChkAtivo.Checked = dr("ativo").ToString() = "S"
                        End If
                    End Using
                End Using
            End Using
        Else
            LimparCampos() ' Limpa para adicionar novo usuário
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ChkAdministrador_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAdministrador.CheckedChanged

    End Sub

    Private Sub ChkAtivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAtivo.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LimparCampos()
    End Sub

    Private Sub LimparCampos()
        TxtLogin.Clear()
        TxtNome.Clear()
        TxtEmail.Clear()
        TxtSenha.Clear()
        ChkAdministrador.Checked = False
        ChkAtivo.Checked = True ' Por padrão, usuário ativo
        LblID.Text = "0"
        TxtLogin.Focus()

        MsgBox("Campos limpos com sucesso!", vbInformation, "Sistema")
    End Sub

    Private Sub Btntestar_Click(sender As Object, e As EventArgs) Handles Btntestar.Click

        Try
            Using cn As New MySqlConnection(connString)
                cn.Open()
                MsgBox("✅ Conectado com sucesso ao MySQL!" & vbCrLf &
                   "Servidor: " & cn.DataSource, vbInformation, sistema)
            End Using
        Catch ex As Exception
            MsgBox("❌ Erro de conexão: " & ex.Message, vbCritical, sistema)
        End Try

    End Sub

    Private Sub TxtSenha_TextChanged(sender As Object, e As EventArgs) Handles TxtSenha.TextChanged

    End Sub

    Private Sub TxtLogin_TextChanged(sender As Object, e As EventArgs) Handles TxtLogin.TextChanged

    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        FormMenu.Show()
        Hide()
    End Sub
End Class