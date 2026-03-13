<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarioCadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsuarioCadastro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.TxtLogin = New System.Windows.Forms.TextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.ChkAdministrador = New System.Windows.Forms.CheckBox()
        Me.ChkAtivo = New System.Windows.Forms.CheckBox()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.Btntestar = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome de Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nome Completo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 190)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(93, 230)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Senha"
        '
        'LblID
        '
        Me.LblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(162, 50)
        Me.LblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(76, 32)
        Me.LblID.TabIndex = 5
        Me.LblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtLogin
        '
        Me.TxtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLogin.Location = New System.Drawing.Point(162, 94)
        Me.TxtLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLogin.MaxLength = 15
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.Size = New System.Drawing.Size(428, 27)
        Me.TxtLogin.TabIndex = 10
        '
        'TxtNome
        '
        Me.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNome.Location = New System.Drawing.Point(162, 140)
        Me.TxtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNome.MaxLength = 70
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(428, 27)
        Me.TxtNome.TabIndex = 10
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(162, 184)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmail.MaxLength = 70
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(428, 27)
        Me.TxtEmail.TabIndex = 10
        '
        'TxtSenha
        '
        Me.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSenha.Location = New System.Drawing.Point(162, 225)
        Me.TxtSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSenha.MaxLength = 30
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.Size = New System.Drawing.Size(428, 27)
        Me.TxtSenha.TabIndex = 10
        '
        'ChkAdministrador
        '
        Me.ChkAdministrador.AutoSize = True
        Me.ChkAdministrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAdministrador.Location = New System.Drawing.Point(165, 282)
        Me.ChkAdministrador.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkAdministrador.Name = "ChkAdministrador"
        Me.ChkAdministrador.Size = New System.Drawing.Size(121, 22)
        Me.ChkAdministrador.TabIndex = 10
        Me.ChkAdministrador.Text = "Administrador"
        Me.ChkAdministrador.UseVisualStyleBackColor = True
        '
        'ChkAtivo
        '
        Me.ChkAtivo.AutoSize = True
        Me.ChkAtivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAtivo.Location = New System.Drawing.Point(466, 282)
        Me.ChkAtivo.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkAtivo.Name = "ChkAtivo"
        Me.ChkAtivo.Size = New System.Drawing.Size(62, 22)
        Me.ChkAtivo.TabIndex = 10
        Me.ChkAtivo.Text = "Ativo"
        Me.ChkAtivo.UseVisualStyleBackColor = True
        '
        'BtnVoltar
        '
        Me.BtnVoltar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnVoltar.Location = New System.Drawing.Point(0, 392)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(60, 24)
        Me.BtnVoltar.TabIndex = 15
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = False
        '
        'Btntestar
        '
        Me.Btntestar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btntestar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btntestar.Image = Global.SistemaOftamologia.My.Resources.Resources.magnifier
        Me.Btntestar.Location = New System.Drawing.Point(480, 334)
        Me.Btntestar.Name = "Btntestar"
        Me.Btntestar.Size = New System.Drawing.Size(110, 56)
        Me.Btntestar.TabIndex = 14
        Me.Btntestar.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.Crimson
        Me.BtnLimpar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BtnLimpar.Image = Global.SistemaOftamologia.My.Resources.Resources.trash_bin
        Me.BtnLimpar.Location = New System.Drawing.Point(321, 334)
        Me.BtnLimpar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(123, 56)
        Me.BtnLimpar.TabIndex = 13
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.AliceBlue
        Me.BtnSalvar.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnSalvar.Image = Global.SistemaOftamologia.My.Resources.Resources.bookmark__1_
        Me.BtnSalvar.Location = New System.Drawing.Point(162, 334)
        Me.BtnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(124, 56)
        Me.BtnSalvar.TabIndex = 12
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'FormUsuarioCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(656, 417)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.Btntestar)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.ChkAtivo)
        Me.Controls.Add(Me.ChkAdministrador)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.TxtLogin)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormUsuarioCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblID As Label
    Friend WithEvents TxtLogin As TextBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents ChkAdministrador As CheckBox
    Friend WithEvents ChkAtivo As CheckBox
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents Btntestar As Button
    Friend WithEvents BtnVoltar As Button
End Class
