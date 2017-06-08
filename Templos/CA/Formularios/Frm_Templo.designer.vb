<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Templo
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
        Me.grpRegistro = New System.Windows.Forms.GroupBox()
        Me.btLocalizaLogo = New System.Windows.Forms.Button()
        Me.txtLogoPath = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBrIndividual = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.cboEstados = New Templos.ComboboxAutoComplete()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtIDTemplos = New System.Windows.Forms.TextBox()
        Me.grpLogotipoEmpresa = New System.Windows.Forms.GroupBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtTemplos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMensagem = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtIE = New System.Windows.Forms.TextBox()
        Me.txtCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblDigita = New System.Windows.Forms.Label()
        Me.grpBotoes = New System.Windows.Forms.GroupBox()
        Me.cmdIncluir = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.FBDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.grpRegistro.SuspendLayout()
        Me.grpLogotipoEmpresa.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpRegistro
        '
        Me.grpRegistro.Controls.Add(Me.btLocalizaLogo)
        Me.grpRegistro.Controls.Add(Me.txtLogoPath)
        Me.grpRegistro.Controls.Add(Me.Label4)
        Me.grpRegistro.Controls.Add(Me.txtBrIndividual)
        Me.grpRegistro.Controls.Add(Me.Label11)
        Me.grpRegistro.Controls.Add(Me.Label10)
        Me.grpRegistro.Controls.Add(Me.Label8)
        Me.grpRegistro.Controls.Add(Me.Label6)
        Me.grpRegistro.Controls.Add(Me.txtSite)
        Me.grpRegistro.Controls.Add(Me.txtFax)
        Me.grpRegistro.Controls.Add(Me.txtTelefone)
        Me.grpRegistro.Controls.Add(Me.txtCEP)
        Me.grpRegistro.Controls.Add(Me.cboEstados)
        Me.grpRegistro.Controls.Add(Me.txtCidade)
        Me.grpRegistro.Controls.Add(Me.txtIDTemplos)
        Me.grpRegistro.Controls.Add(Me.grpLogotipoEmpresa)
        Me.grpRegistro.Controls.Add(Me.Label9)
        Me.grpRegistro.Controls.Add(Me.txtEmail)
        Me.grpRegistro.Controls.Add(Me.Label39)
        Me.grpRegistro.Controls.Add(Me.Label5)
        Me.grpRegistro.Controls.Add(Me.txtBairro)
        Me.grpRegistro.Controls.Add(Me.txtEndereco)
        Me.grpRegistro.Controls.Add(Me.txtTemplos)
        Me.grpRegistro.Controls.Add(Me.Label3)
        Me.grpRegistro.Controls.Add(Me.Label2)
        Me.grpRegistro.Controls.Add(Me.Label1)
        Me.grpRegistro.Controls.Add(Me.txtMensagem)
        Me.grpRegistro.Controls.Add(Me.Label38)
        Me.grpRegistro.Controls.Add(Me.txtIE)
        Me.grpRegistro.Controls.Add(Me.txtCNPJ)
        Me.grpRegistro.Controls.Add(Me.Label16)
        Me.grpRegistro.Controls.Add(Me.Label17)
        Me.grpRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRegistro.Location = New System.Drawing.Point(10, 11)
        Me.grpRegistro.Name = "grpRegistro"
        Me.grpRegistro.Size = New System.Drawing.Size(640, 315)
        Me.grpRegistro.TabIndex = 0
        Me.grpRegistro.TabStop = False
        Me.grpRegistro.Text = "Registro:"
        '
        'btLocalizaLogo
        '
        Me.btLocalizaLogo.Location = New System.Drawing.Point(494, 208)
        Me.btLocalizaLogo.Name = "btLocalizaLogo"
        Me.btLocalizaLogo.Size = New System.Drawing.Size(113, 33)
        Me.btLocalizaLogo.TabIndex = 124
        Me.btLocalizaLogo.Text = "Localizar Logo"
        Me.btLocalizaLogo.UseVisualStyleBackColor = True
        '
        'txtLogoPath
        '
        Me.txtLogoPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogoPath.Location = New System.Drawing.Point(473, 160)
        Me.txtLogoPath.MaxLength = 0
        Me.txtLogoPath.Multiline = True
        Me.txtLogoPath.Name = "txtLogoPath"
        Me.txtLogoPath.ReadOnly = True
        Me.txtLogoPath.Size = New System.Drawing.Size(160, 47)
        Me.txtLogoPath.TabIndex = 123
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(473, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 15)
        Me.Label4.TabIndex = 112
        '
        'txtBrIndividual
        '
        Me.txtBrIndividual.Location = New System.Drawing.Point(473, 235)
        Me.txtBrIndividual.Name = "txtBrIndividual"
        Me.txtBrIndividual.Size = New System.Drawing.Size(160, 61)
        Me.txtBrIndividual.TabIndex = 111
        Me.txtBrIndividual.Text = "Controlar bíblias e revistas por aluno."
        Me.txtBrIndividual.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(337, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 15)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "CEP:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(346, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 15)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "UF:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(305, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 15)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Fax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Site:"
        '
        'txtSite
        '
        Me.txtSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSite.Location = New System.Drawing.Point(107, 181)
        Me.txtSite.MaxLength = 0
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(351, 21)
        Me.txtSite.TabIndex = 10
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(345, 154)
        Me.txtFax.Mask = "(99)0000-0000"
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(113, 21)
        Me.txtFax.TabIndex = 9
        Me.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFax.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(107, 154)
        Me.txtTelefone.Mask = "(99)0000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(110, 21)
        Me.txtTelefone.TabIndex = 8
        Me.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(381, 98)
        Me.txtCEP.Mask = "00000-999"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(77, 21)
        Me.txtCEP.TabIndex = 5
        Me.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'cboEstados
        '
        Me.cboEstados.FormattingEnabled = True
        Me.cboEstados.Location = New System.Drawing.Point(381, 125)
        Me.cboEstados.Name = "cboEstados"
        Me.cboEstados.Size = New System.Drawing.Size(77, 23)
        Me.cboEstados.TabIndex = 7
        '
        'txtCidade
        '
        Me.txtCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(107, 125)
        Me.txtCidade.MaxLength = 0
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(214, 21)
        Me.txtCidade.TabIndex = 6
        '
        'txtIDTemplos
        '
        Me.txtIDTemplos.Location = New System.Drawing.Point(6, 20)
        Me.txtIDTemplos.Name = "txtIDTemplos"
        Me.txtIDTemplos.Size = New System.Drawing.Size(34, 21)
        Me.txtIDTemplos.TabIndex = 16
        Me.txtIDTemplos.Visible = False
        '
        'grpLogotipoEmpresa
        '
        Me.grpLogotipoEmpresa.Controls.Add(Me.picLogo)
        Me.grpLogotipoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLogotipoEmpresa.Location = New System.Drawing.Point(473, 18)
        Me.grpLogotipoEmpresa.Name = "grpLogotipoEmpresa"
        Me.grpLogotipoEmpresa.Size = New System.Drawing.Size(160, 141)
        Me.grpLogotipoEmpresa.TabIndex = 15
        Me.grpLogotipoEmpresa.TabStop = False
        Me.grpLogotipoEmpresa.Text = "Logotipo do Templos."
        '
        'picLogo
        '
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLogo.Location = New System.Drawing.Point(6, 20)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(145, 113)
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(48, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 15)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "E-Mail:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(107, 208)
        Me.txtEmail.MaxLength = 0
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(351, 21)
        Me.txtEmail.TabIndex = 11
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(34, 157)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(67, 15)
        Me.Label39.TabIndex = 93
        Me.Label39.Text = "Telefone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Cidade:"
        '
        'txtBairro
        '
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(107, 98)
        Me.txtBairro.MaxLength = 0
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(214, 21)
        Me.txtBairro.TabIndex = 4
        '
        'txtEndereco
        '
        Me.txtEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(107, 71)
        Me.txtEndereco.MaxLength = 0
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(351, 21)
        Me.txtEndereco.TabIndex = 3
        '
        'txtTemplos
        '
        Me.txtTemplos.Location = New System.Drawing.Point(107, 43)
        Me.txtTemplos.MaxLength = 0
        Me.txtTemplos.Name = "txtTemplos"
        Me.txtTemplos.Size = New System.Drawing.Size(351, 21)
        Me.txtTemplos.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Bairro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Endereço:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Nome:"
        '
        'txtMensagem
        '
        Me.txtMensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensagem.Location = New System.Drawing.Point(107, 235)
        Me.txtMensagem.MaxLength = 0
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensagem.Size = New System.Drawing.Size(351, 47)
        Me.txtMensagem.TabIndex = 12
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(19, 235)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(82, 15)
        Me.Label38.TabIndex = 81
        Me.Label38.Text = "Mensagem:"
        '
        'txtIE
        '
        Me.txtIE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIE.Location = New System.Drawing.Point(345, 18)
        Me.txtIE.MaxLength = 0
        Me.txtIE.Name = "txtIE"
        Me.txtIE.Size = New System.Drawing.Size(113, 21)
        Me.txtIE.TabIndex = 1
        '
        'txtCNPJ
        '
        Me.txtCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCNPJ.Location = New System.Drawing.Point(107, 18)
        Me.txtCNPJ.Mask = "##-###-###/####-##"
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(133, 21)
        Me.txtCNPJ.TabIndex = 0
        Me.txtCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(307, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 15)
        Me.Label16.TabIndex = 75
        Me.Label16.Text = "I.E.:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(55, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 15)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "CNPJ:"
        '
        'lblDigita
        '
        Me.lblDigita.BackColor = System.Drawing.SystemColors.Control
        Me.lblDigita.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDigita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigita.ForeColor = System.Drawing.Color.Blue
        Me.lblDigita.Location = New System.Drawing.Point(0, 426)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(655, 27)
        Me.lblDigita.TabIndex = 2
        Me.lblDigita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpBotoes
        '
        Me.grpBotoes.Controls.Add(Me.cmdIncluir)
        Me.grpBotoes.Controls.Add(Me.cmdAlterar)
        Me.grpBotoes.Location = New System.Drawing.Point(10, 332)
        Me.grpBotoes.Name = "grpBotoes"
        Me.grpBotoes.Size = New System.Drawing.Size(640, 91)
        Me.grpBotoes.TabIndex = 1
        Me.grpBotoes.TabStop = False
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
        Me.cmdIncluir.TabIndex = 0
        Me.cmdIncluir.Text = "&Incluir"
        Me.cmdIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdIncluir.UseVisualStyleBackColor = True
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
        'Frm_Templo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 453)
        Me.Controls.Add(Me.lblDigita)
        Me.Controls.Add(Me.grpBotoes)
        Me.Controls.Add(Me.grpRegistro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Templo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Identificação do Templos."
        Me.grpRegistro.ResumeLayout(False)
        Me.grpRegistro.PerformLayout()
        Me.grpLogotipoEmpresa.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtTemplos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMensagem As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtIE As System.Windows.Forms.TextBox
    Friend WithEvents txtCNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents grpLogotipoEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents lblDigita As System.Windows.Forms.Label
    Friend WithEvents grpBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAlterar As System.Windows.Forms.Button
    Friend WithEvents txtIDTemplos As System.Windows.Forms.TextBox
    Friend WithEvents cmdIncluir As System.Windows.Forms.Button
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents cboEstados As Templos.ComboboxAutoComplete
    Friend WithEvents txtFax As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSite As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBrIndividual As System.Windows.Forms.CheckBox
    Friend WithEvents btLocalizaLogo As System.Windows.Forms.Button
    Friend WithEvents txtLogoPath As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FBDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
End Class
