Public Class FormMenu

    Private Sub FormMenu(sender As Object, e As EventArgs) Handles MyBase.Load

        LblUsuario.Text = "Usuário: " & UsuarioNome

        ' 🔐 Controle de permissão
        If UsuarioAdmin = "N" Then
            CadastrarUsuarioToolStripMenuItem.Visible = False
            ConsultarUsuarioToolStripMenuItem.Visible = False
        End If

    End Sub
    Private Sub AplicarPermissoes()
        CadastrarUsuarioToolStripMenuItem.Visible = (UsuarioAdmin = "S")
        ConsultarUsuarioToolStripMenuItem.Visible = (UsuarioAdmin = "S")
    End Sub
    Private Sub CadastrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrToolStripMenuItem.Click

    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click

    End Sub

    Private Sub ControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlToolStripMenuItem.Click

    End Sub

    Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub CadastrarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub CadastrarUsuarioToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CadastrarUsuarioToolStripMenuItem.Click
        Dim frm As New FormUsuarioCadastro
        frm.ShowDialog()

    End Sub

    Private Sub MenuStrip1_ItemClicked_1(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ConsultarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarUsuarioToolStripMenuItem.Click
        Dim frm As New FormUsuarioConsuta
        frm.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblUsuario_Click(sender As Object, e As EventArgs) Handles LblUsuario.Click

    End Sub

    Private Sub FormMenu_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TrocarSenhaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrocarSenhaToolStripMenuItem.Click
        Dim frm As New FormTrocarSenha
        frm.ShowDialog()
    End Sub

    Private Sub FormMenu_Load_2(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormMenu_Load_3(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
