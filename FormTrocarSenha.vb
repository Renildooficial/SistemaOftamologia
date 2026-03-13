Imports MySql.Data.MySqlClient

Public Class FormTrocarSenha
    Private Sub FormTrocarSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Limpar campos ao abrir
        TxtSenhaAtual.Clear()
        TxtSenhaNova.Clear()
        TxtConfirmarSenhaNova.Clear()
        TxtSenhaAtual.Focus()

        ' Mostrar nome do usuário (opcional)
        LblUsuarioInfo.Text = $"{UsuarioNome}"
    End Sub

    Private Sub CheckBoxMostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMostrarSenha.CheckedChanged
        ' Mostrar ou ocultar as senhas
        TxtSenhaAtual.UseSystemPasswordChar = Not CheckBoxMostrarSenha.Checked
        TxtSenhaNova.UseSystemPasswordChar = Not CheckBoxMostrarSenha.Checked
        TxtConfirmarSenhaNova.UseSystemPasswordChar = Not CheckBoxMostrarSenha.Checked
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ' Validar campos
        If Not ValidarCampos() Then
            Exit Sub
        End If

        ' Verificar se a senha atual está correta
        If Not VerificarSenhaAtual() Then
            MsgBox("❌ Senha atual incorreta!", vbCritical, sistema)
            TxtSenhaAtual.Clear()
            TxtSenhaAtual.Focus()
            Exit Sub
        End If

        ' Atualizar a senha
        If AtualizarSenha() Then
            MsgBox("✅ Senha alterada com sucesso!", vbInformation, sistema)
            Me.Close()
        End If
    End Sub

    Private Function ValidarCampos() As Boolean
        ' Validar senha atual
        If String.IsNullOrWhiteSpace(TxtSenhaAtual.Text) Then
            MsgBox("Por favor, informe a senha atual!", vbExclamation, sistema)
            TxtSenhaAtual.Focus()
            Return False
        End If

        ' Validar nova senha
        If String.IsNullOrWhiteSpace(TxtSenhaNova.Text) Then
            MsgBox("Por favor, informe a nova senha!", vbExclamation, sistema)
            TxtSenhaNova.Focus()
            Return False
        End If

        ' Validar tamanho mínimo da senha (opcional)
        If TxtSenhaNova.Text.Length < 4 Then
            MsgBox("A nova senha deve ter pelo menos 4 caracteres!", vbExclamation, sistema)
            TxtSenhaNova.Focus()
            Return False
        End If

        ' Validar confirmação
        If String.IsNullOrWhiteSpace(TxtConfirmarSenhaNova.Text) Then
            MsgBox("Por favor, confirme a nova senha!", vbExclamation, sistema)
            TxtConfirmarSenhaNova.Focus()
            Return False
        End If

        ' Verificar se nova senha e confirmação coincidem
        If TxtSenhaNova.Text <> TxtConfirmarSenhaNova.Text Then
            MsgBox("❌ A nova senha e a confirmação não coincidem!", vbCritical, sistema)
            TxtConfirmarSenhaNova.Clear()
            TxtConfirmarSenhaNova.Focus()
            Return False
        End If

        ' Verificar se a nova senha é diferente da atual
        If TxtSenhaNova.Text = TxtSenhaAtual.Text Then
            MsgBox("❌ A nova senha deve ser diferente da senha atual!", vbExclamation, sistema)
            TxtSenhaNova.Clear()
            TxtConfirmarSenhaNova.Clear()
            TxtSenhaNova.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function VerificarSenhaAtual() As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM Usuarios WHERE id = @id AND senha = @senha"

            Using cn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", UsuarioID)
                    cmd.Parameters.AddWithValue("@senha", TxtSenhaAtual.Text.Trim)

                    cn.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("❌ Erro ao verificar senha: " & ex.Message, vbCritical, sistema)
            Return False
        End Try
    End Function

    Private Function AtualizarSenha() As Boolean
        Try
            Dim sql As String = "UPDATE Usuarios SET senha = @novaSenha WHERE id = @id"

            Using cn As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@novaSenha", TxtSenhaNova.Text.Trim)
                    cmd.Parameters.AddWithValue("@id", UsuarioID)

                    cn.Open()
                    cmd.ExecuteNonQuery()

                    Return True
                End Using
            End Using
        Catch ex As Exception
            MsgBox("❌ Erro ao atualizar senha: " & ex.Message, vbCritical, sistema)
            Return False
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        If MsgBox("Deseja cancelar a alteração de senha?", vbQuestion + vbYesNo, sistema) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub LblUsuarioInfo_Click(sender As Object, e As EventArgs) Handles LblUsuarioInfo.Click

    End Sub

End Class