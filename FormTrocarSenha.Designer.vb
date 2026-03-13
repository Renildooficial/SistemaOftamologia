<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTrocarSenha
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtSenhaAtual = New System.Windows.Forms.TextBox()
        Me.TxtSenhaNova = New System.Windows.Forms.TextBox()
        Me.TxtConfirmarSenhaNova = New System.Windows.Forms.TextBox()
        Me.CheckBoxMostrarSenha = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblUsuarioInfo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtSenhaAtual
        '
        Me.TxtSenhaAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSenhaAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSenhaAtual.Location = New System.Drawing.Point(189, 106)
        Me.TxtSenhaAtual.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSenhaAtual.MaxLength = 30
        Me.TxtSenhaAtual.Name = "TxtSenhaAtual"
        Me.TxtSenhaAtual.Size = New System.Drawing.Size(353, 27)
        Me.TxtSenhaAtual.TabIndex = 16
        Me.TxtSenhaAtual.UseSystemPasswordChar = True
        '
        'TxtSenhaNova
        '
        Me.TxtSenhaNova.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSenhaNova.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSenhaNova.Location = New System.Drawing.Point(189, 158)
        Me.TxtSenhaNova.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSenhaNova.MaxLength = 30
        Me.TxtSenhaNova.Name = "TxtSenhaNova"
        Me.TxtSenhaNova.Size = New System.Drawing.Size(353, 27)
        Me.TxtSenhaNova.TabIndex = 17
        Me.TxtSenhaNova.UseSystemPasswordChar = True
        '
        'TxtConfirmarSenhaNova
        '
        Me.TxtConfirmarSenhaNova.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtConfirmarSenhaNova.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConfirmarSenhaNova.Location = New System.Drawing.Point(189, 214)
        Me.TxtConfirmarSenhaNova.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtConfirmarSenhaNova.MaxLength = 30
        Me.TxtConfirmarSenhaNova.Name = "TxtConfirmarSenhaNova"
        Me.TxtConfirmarSenhaNova.Size = New System.Drawing.Size(353, 27)
        Me.TxtConfirmarSenhaNova.TabIndex = 18
        Me.TxtConfirmarSenhaNova.UseSystemPasswordChar = True
        '
        'CheckBoxMostrarSenha
        '
        Me.CheckBoxMostrarSenha.AutoSize = True
        Me.CheckBoxMostrarSenha.Location = New System.Drawing.Point(189, 264)
        Me.CheckBoxMostrarSenha.Name = "CheckBoxMostrarSenha"
        Me.CheckBoxMostrarSenha.Size = New System.Drawing.Size(116, 20)
        Me.CheckBoxMostrarSenha.TabIndex = 24
        Me.CheckBoxMostrarSenha.Text = "Mostrar Senha"
        Me.CheckBoxMostrarSenha.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Senha Atual"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Senha Nova"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Confirme a Senha"
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.MediumBlue
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLogin.Location = New System.Drawing.Point(202, 312)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(134, 42)
        Me.BtnLogin.TabIndex = 27
        Me.BtnLogin.Text = "Actualizar"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Crimson
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelar.Location = New System.Drawing.Point(386, 312)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(134, 42)
        Me.BtnCancelar.TabIndex = 28
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'LblUsuarioInfo
        '
        Me.LblUsuarioInfo.AutoSize = True
        Me.LblUsuarioInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuarioInfo.Location = New System.Drawing.Point(173, 59)
        Me.LblUsuarioInfo.Name = "LblUsuarioInfo"
        Me.LblUsuarioInfo.Size = New System.Drawing.Size(55, 20)
        Me.LblUsuarioInfo.TabIndex = 33
        Me.LblUsuarioInfo.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(117, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "User:"
        '
        'FormTrocarSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 408)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblUsuarioInfo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBoxMostrarSenha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtConfirmarSenhaNova)
        Me.Controls.Add(Me.TxtSenhaNova)
        Me.Controls.Add(Me.TxtSenhaAtual)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormTrocarSenha"
        Me.Text = "FormTrocarSenha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSenhaAtual As TextBox
    Friend WithEvents TxtSenhaNova As TextBox
    Friend WithEvents TxtConfirmarSenhaNova As TextBox
    Friend WithEvents CheckBoxMostrarSenha As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblUsuarioInfo As Label
    Friend WithEvents Label4 As Label
End Class
