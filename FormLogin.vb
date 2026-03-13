Imports MySql.Data.MySqlClient
Public Class FormLogin
    Private Sub TxtSenha_TextChanged(sender As Object, e As EventArgs) Handles TxtSenha.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If FazerLogin() Then
            Me.Hide()
            FormMenu.Show()
        End If

    End Sub
    Private Function FazerLogin() As Boolean

        If TxtLogin.Text.Trim = "" Or TxtSenha.Text.Trim = "" Then
            MsgBox("Informe o login e a senha!", vbExclamation, sistema)
            Return False
        End If

        Try
            Dim sql As String =
            "SELECT id, nome, administrador, ativo " &
            "FROM Usuarios " &
            "WHERE login=@login AND senha=@senha"

            Using cn As New MySqlConnection(connString)
                cn.Open()

                Using cmd As New MySqlCommand(sql, cn)

                    cmd.Parameters.AddWithValue("@login", TxtLogin.Text.Trim)
                    cmd.Parameters.AddWithValue("@senha", TxtSenha.Text.Trim)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()

                        If dr.Read() Then

                            If dr("ativo").ToString() = "N" Then
                                MsgBox("Usuário desativado!", vbCritical, sistema)
                                Return False
                            End If

                            ' 🔹 Guardando dados globais do usuário logado
                            UsuarioID = Convert.ToInt32(dr("id"))
                            UsuarioNome = dr("nome").ToString()
                            UsuarioAdmin = dr("administrador").ToString()

                            MsgBox("✅ Bem-vindo, " & UsuarioNome & "!",
                               vbInformation, sistema)

                            Return True

                        Else
                            MsgBox("Login ou senha incorretos!",
                               vbCritical, sistema)
                            Return False
                        End If

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Erro ao conectar: " & ex.Message,
               vbCritical, sistema)
            Return False
        End Try

    End Function
    Private Sub TxtLogin_TextChanged(sender As Object, e As EventArgs) Handles TxtLogin.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub CheckBoxMostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMostrarSenha.CheckedChanged
        If CheckBoxMostrarSenha.Checked Then
            ' Mostrar a senha
            TxtSenha.UseSystemPasswordChar = False
        Else
            ' Esconder a senha
            TxtSenha.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TxtSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnLogin.PerformClick()
        End If
    End Sub
End Class