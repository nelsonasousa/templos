<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Usuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpBotoes = New System.Windows.Forms.GroupBox()
        Me.cmdPesquisar = New System.Windows.Forms.Button()
        Me.grpRegistro = New System.Windows.Forms.GroupBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIDPessoa = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDigita = New System.Windows.Forms.Label()
        Me.cmdIncluir = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.grpBotoes.SuspendLayout()
        Me.grpRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBotoes
        '
        Me.grpBotoes.Controls.Add(Me.cmdIncluir)
        Me.grpBotoes.Controls.Add(Me.cmdCancelar)
        Me.grpBotoes.Controls.Add(Me.cmdPesquisar)
        Me.grpBotoes.Controls.Add(Me.cmdAlterar)
        Me.grpBotoes.Location = New System.Drawing.Point(13, 104)
        Me.grpBotoes.Name = "grpBotoes"
        Me.grpBotoes.Size = New System.Drawing.Size(416, 91)
        Me.grpBotoes.TabIndex = 1
        Me.grpBotoes.TabStop = False
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.FlatAppearance.BorderSize = 0
        Me.cmdPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPesquisar.Location = New System.Drawing.Point(330, 9)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 76)
        Me.cmdPesquisar.TabIndex = 4
        Me.cmdPesquisar.Text = "&Pesquisar"
        Me.cmdPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'grpRegistro
        '
        Me.grpRegistro.Controls.Add(Me.txtSenha)
        Me.grpRegistro.Controls.Add(Me.Label2)
        Me.grpRegistro.Controls.Add(Me.txtIDPessoa)
        Me.grpRegistro.Controls.Add(Me.txtLogin)
        Me.grpRegistro.Controls.Add(Me.Label1)
        Me.grpRegistro.Location = New System.Drawing.Point(12, 12)
        Me.grpRegistro.Name = "grpRegistro"
        Me.grpRegistro.Size = New System.Drawing.Size(416, 86)
        Me.grpRegistro.TabIndex = 0
        Me.grpRegistro.TabStop = False
        Me.grpRegistro.Text = "Registro:"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(88, 46)
        Me.txtSenha.MaxLength = 0
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Senha:"
        '
        'txtIDPessoa
        '
        Me.txtIDPessoa.BackColor = System.Drawing.SystemColors.Control
        Me.txtIDPessoa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDPessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDPessoa.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIDPessoa.Location = New System.Drawing.Point(207, 46)
        Me.txtIDPessoa.Name = "txtIDPessoa"
        Me.txtIDPessoa.Size = New System.Drawing.Size(49, 13)
        Me.txtIDPessoa.TabIndex = 7
        Me.txtIDPessoa.Visible = False
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(88, 20)
        Me.txtLogin.MaxLength = 0
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(314, 20)
        Me.txtLogin.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Login:"
        '
        'lblDigita
        '
        Me.lblDigita.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDigita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigita.ForeColor = System.Drawing.Color.Blue
        Me.lblDigita.Location = New System.Drawing.Point(0, 199)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(441, 23)
        Me.lblDigita.TabIndex = 2
        Me.lblDigita.Text = "Label5"
        Me.lblDigita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdIncluir
        '
        Me.cmdIncluir.FlatAppearance.BorderSize = 0
        Me.cmdIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIncluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIncluir.Image = Global.Templos.My.Resources.Resources.incluir
        Me.cmdIncluir.Location = New System.Drawing.Point(6, 9)
        Me.cmdIncluir.Name = "cmdIncluir"
        Me.cmdIncluir.Size = New System.Drawing.Size(75, 76)
        Me.cmdIncluir.TabIndex = 5
        Me.cmdIncluir.Text = "&Incluir"
        Me.cmdIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdIncluir.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatAppearance.BorderSize = 0
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Red
        Me.cmdCancelar.Image = Global.Templos.My.Resources.Resources.limpar
        Me.cmdCancelar.Location = New System.Drawing.Point(249, 9)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 76)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Limpar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAlterar
        '
        Me.cmdAlterar.FlatAppearance.BorderSize = 0
        Me.cmdAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAlterar.Image = Global.Templos.My.Resources.Resources.alterar
        Me.cmdAlterar.Location = New System.Drawing.Point(87, 9)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.Size = New System.Drawing.Size(75, 76)
        Me.cmdAlterar.TabIndex = 1
        Me.cmdAlterar.Text = "&Alterar"
        Me.cmdAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAlterar.UseVisualStyleBackColor = True
        '
        'Frm_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 222)
        Me.Controls.Add(Me.grpBotoes)
        Me.Controls.Add(Me.grpRegistro)
        Me.Controls.Add(Me.lblDigita)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Usuarios"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Usuários do Sistema."
        Me.grpBotoes.ResumeLayout(False)
        Me.grpRegistro.ResumeLayout(False)
        Me.grpRegistro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
    Friend WithEvents cmdAlterar As System.Windows.Forms.Button
    Friend WithEvents grpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIDPessoa As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDigita As System.Windows.Forms.Label
    Friend WithEvents cmdIncluir As System.Windows.Forms.Button
End Class
