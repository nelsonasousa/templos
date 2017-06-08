<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Membros
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblDigita = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtNome2 = New System.Windows.Forms.TextBox()
        Me.TBMembro = New System.Windows.Forms.TabControl()
        Me.TbContato = New System.Windows.Forms.TabPage()
        Me.cboEstCivil = New System.Windows.Forms.ComboBox()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mskCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblInscricao = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.lblCGC = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRG = New System.Windows.Forms.Label()
        Me.txtIE = New System.Windows.Forms.TextBox()
        Me.txtCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.mskFax = New System.Windows.Forms.MaskedTextBox()
        Me.mskTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtPessoa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbOutros = New System.Windows.Forms.TabPage()
        Me.cboIDClasse = New System.Windows.Forms.ComboBox()
        Me.chk_Permanente = New System.Windows.Forms.CheckBox()
        Me.lbl_Idade = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btInsereClasse = New System.Windows.Forms.Button()
        Me.DGClasses = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDataNascimento = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btLocalizaMae = New System.Windows.Forms.Button()
        Me.btLocalizaPai = New System.Windows.Forms.Button()
        Me.txtIDPai = New System.Windows.Forms.TextBox()
        Me.txtIDMae = New System.Windows.Forms.TextBox()
        Me.txtNomeMae = New System.Windows.Forms.TextBox()
        Me.txtNomePai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboIDStatus = New Templos.ComboboxAutoComplete()
        Me.cboSexo = New Templos.ComboboxAutoComplete()
        Me.grpBotoes = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdIncluir = New System.Windows.Forms.Button()
        Me.cmdExcluir = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.txtIDPessoa = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ntxt_Cadastros = New System.Windows.Forms.TextBox()
        Me.txt_Filtro = New System.Windows.Forms.TextBox()
        Me.DgLocaliza = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TBMembro.SuspendLayout()
        Me.TbContato.SuspendLayout()
        Me.TbOutros.SuspendLayout()
        CType(Me.DGClasses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBotoes.SuspendLayout()
        CType(Me.DgLocaliza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDigita
        '
        Me.lblDigita.BackColor = System.Drawing.SystemColors.Control
        Me.lblDigita.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDigita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigita.ForeColor = System.Drawing.Color.Blue
        Me.lblDigita.Location = New System.Drawing.Point(0, 426)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(915, 25)
        Me.lblDigita.TabIndex = 1
        Me.lblDigita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNome2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TBMembro)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpBotoes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDPessoa)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ntxt_Cadastros)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_Filtro)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DgLocaliza)
        Me.SplitContainer1.Size = New System.Drawing.Size(915, 426)
        Me.SplitContainer1.SplitterDistance = 667
        Me.SplitContainer1.TabIndex = 0
        '
        'txtNome2
        '
        Me.txtNome2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome2.Location = New System.Drawing.Point(98, 12)
        Me.txtNome2.MaxLength = 0
        Me.txtNome2.Name = "txtNome2"
        Me.txtNome2.ReadOnly = True
        Me.txtNome2.Size = New System.Drawing.Size(404, 21)
        Me.txtNome2.TabIndex = 1
        '
        'TBMembro
        '
        Me.TBMembro.Controls.Add(Me.TbContato)
        Me.TBMembro.Controls.Add(Me.TbOutros)
        Me.TBMembro.Location = New System.Drawing.Point(11, 39)
        Me.TBMembro.Name = "TBMembro"
        Me.TBMembro.SelectedIndex = 0
        Me.TBMembro.Size = New System.Drawing.Size(644, 284)
        Me.TBMembro.TabIndex = 2
        '
        'TbContato
        '
        Me.TbContato.Controls.Add(Me.cboEstCivil)
        Me.TbContato.Controls.Add(Me.cboEstado)
        Me.TbContato.Controls.Add(Me.Label12)
        Me.TbContato.Controls.Add(Me.mskCelular)
        Me.TbContato.Controls.Add(Me.Label17)
        Me.TbContato.Controls.Add(Me.lblInscricao)
        Me.TbContato.Controls.Add(Me.txtEmail)
        Me.TbContato.Controls.Add(Me.Label4)
        Me.TbContato.Controls.Add(Me.txtCidade)
        Me.TbContato.Controls.Add(Me.txtCEP)
        Me.TbContato.Controls.Add(Me.lblCGC)
        Me.TbContato.Controls.Add(Me.Label11)
        Me.TbContato.Controls.Add(Me.Label8)
        Me.TbContato.Controls.Add(Me.txtBairro)
        Me.TbContato.Controls.Add(Me.Label7)
        Me.TbContato.Controls.Add(Me.txtEndereco)
        Me.TbContato.Controls.Add(Me.Label6)
        Me.TbContato.Controls.Add(Me.lblRG)
        Me.TbContato.Controls.Add(Me.txtIE)
        Me.TbContato.Controls.Add(Me.txtCNPJ)
        Me.TbContato.Controls.Add(Me.mskFax)
        Me.TbContato.Controls.Add(Me.mskTelefone)
        Me.TbContato.Controls.Add(Me.txtPessoa)
        Me.TbContato.Controls.Add(Me.Label2)
        Me.TbContato.Controls.Add(Me.Label1)
        Me.TbContato.Location = New System.Drawing.Point(4, 22)
        Me.TbContato.Name = "TbContato"
        Me.TbContato.Padding = New System.Windows.Forms.Padding(3)
        Me.TbContato.Size = New System.Drawing.Size(636, 258)
        Me.TbContato.TabIndex = 0
        Me.TbContato.Text = "Contato"
        Me.TbContato.UseVisualStyleBackColor = True
        '
        'cboEstCivil
        '
        Me.cboEstCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEstCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEstCivil.FormattingEnabled = True
        Me.cboEstCivil.Items.AddRange(New Object() {"Casado", "Solteiro", "Viúvo", "Divorciado"})
        Me.cboEstCivil.Location = New System.Drawing.Point(372, 179)
        Me.cboEstCivil.Name = "cboEstCivil"
        Me.cboEstCivil.Size = New System.Drawing.Size(93, 21)
        Me.cboEstCivil.TabIndex = 22
        '
        'cboEstado
        '
        Me.cboEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(372, 127)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(93, 21)
        Me.cboEstado.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(304, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Est. Civ.:"
        '
        'mskCelular
        '
        Me.mskCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCelular.Location = New System.Drawing.Point(99, 179)
        Me.mskCelular.Mask = "(99) 00000-0000"
        Me.mskCelular.Name = "mskCelular"
        Me.mskCelular.Size = New System.Drawing.Size(105, 21)
        Me.mskCelular.TabIndex = 20
        Me.mskCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(36, 180)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 15)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Celular:"
        '
        'lblInscricao
        '
        Me.lblInscricao.AutoSize = True
        Me.lblInscricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInscricao.Location = New System.Drawing.Point(315, 21)
        Me.lblInscricao.Name = "lblInscricao"
        Me.lblInscricao.Size = New System.Drawing.Size(35, 15)
        Me.lblInscricao.TabIndex = 2
        Me.lblInscricao.Text = "RG.:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(100, 206)
        Me.txtEmail.MaxLength = 0
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(365, 21)
        Me.txtEmail.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Email:"
        '
        'txtCidade
        '
        Me.txtCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(99, 125)
        Me.txtCidade.MaxLength = 0
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(238, 21)
        Me.txtCidade.TabIndex = 13
        '
        'txtCEP
        '
        Me.txtCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCEP.Location = New System.Drawing.Point(372, 100)
        Me.txtCEP.Mask = "00000-999"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(92, 21)
        Me.txtCEP.TabIndex = 11
        Me.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblCGC
        '
        Me.lblCGC.AutoSize = True
        Me.lblCGC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCGC.Location = New System.Drawing.Point(54, 24)
        Me.lblCGC.Name = "lblCGC"
        Me.lblCGC.Size = New System.Drawing.Size(37, 15)
        Me.lblCGC.TabIndex = 0
        Me.lblCGC.Text = "CPF:"
        Me.lblCGC.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(332, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 15)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Fax:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Cidade / UF:"
        '
        'txtBairro
        '
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(99, 100)
        Me.txtBairro.MaxLength = 0
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(238, 21)
        Me.txtBairro.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Bairro / CEP:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(100, 74)
        Me.txtEndereco.MaxLength = 0
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(364, 21)
        Me.txtEndereco.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Endereço:"
        '
        'lblRG
        '
        Me.lblRG.AutoSize = True
        Me.lblRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRG.Location = New System.Drawing.Point(316, 21)
        Me.lblRG.Name = "lblRG"
        Me.lblRG.Size = New System.Drawing.Size(31, 15)
        Me.lblRG.TabIndex = 3
        Me.lblRG.Text = "RG:"
        '
        'txtIE
        '
        Me.txtIE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIE.Location = New System.Drawing.Point(356, 21)
        Me.txtIE.MaxLength = 0
        Me.txtIE.Name = "txtIE"
        Me.txtIE.Size = New System.Drawing.Size(108, 21)
        Me.txtIE.TabIndex = 4
        '
        'txtCNPJ
        '
        Me.txtCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCNPJ.Location = New System.Drawing.Point(100, 21)
        Me.txtCNPJ.Mask = "000,000,000-00"
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(151, 21)
        Me.txtCNPJ.TabIndex = 1
        Me.txtCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mskFax
        '
        Me.mskFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFax.Location = New System.Drawing.Point(372, 152)
        Me.mskFax.Mask = "(99) 0000-0000"
        Me.mskFax.Name = "mskFax"
        Me.mskFax.Size = New System.Drawing.Size(92, 21)
        Me.mskFax.TabIndex = 18
        Me.mskFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskFax.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mskTelefone
        '
        Me.mskTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTelefone.Location = New System.Drawing.Point(100, 152)
        Me.mskTelefone.Mask = "(99) 0000-0000"
        Me.mskTelefone.Name = "mskTelefone"
        Me.mskTelefone.Size = New System.Drawing.Size(104, 21)
        Me.mskTelefone.TabIndex = 16
        Me.mskTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtPessoa
        '
        Me.txtPessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPessoa.Location = New System.Drawing.Point(100, 47)
        Me.txtPessoa.MaxLength = 0
        Me.txtPessoa.Name = "txtPessoa"
        Me.txtPessoa.Size = New System.Drawing.Size(364, 21)
        Me.txtPessoa.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Telefone:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nome:"
        '
        'TbOutros
        '
        Me.TbOutros.Controls.Add(Me.cboIDClasse)
        Me.TbOutros.Controls.Add(Me.chk_Permanente)
        Me.TbOutros.Controls.Add(Me.lbl_Idade)
        Me.TbOutros.Controls.Add(Me.Label15)
        Me.TbOutros.Controls.Add(Me.btInsereClasse)
        Me.TbOutros.Controls.Add(Me.DGClasses)
        Me.TbOutros.Controls.Add(Me.Label13)
        Me.TbOutros.Controls.Add(Me.txtDataNascimento)
        Me.TbOutros.Controls.Add(Me.Label10)
        Me.TbOutros.Controls.Add(Me.Label9)
        Me.TbOutros.Controls.Add(Me.btLocalizaMae)
        Me.TbOutros.Controls.Add(Me.btLocalizaPai)
        Me.TbOutros.Controls.Add(Me.txtIDPai)
        Me.TbOutros.Controls.Add(Me.txtIDMae)
        Me.TbOutros.Controls.Add(Me.txtNomeMae)
        Me.TbOutros.Controls.Add(Me.txtNomePai)
        Me.TbOutros.Controls.Add(Me.Label5)
        Me.TbOutros.Controls.Add(Me.Label3)
        Me.TbOutros.Controls.Add(Me.Label22)
        Me.TbOutros.Controls.Add(Me.cboIDStatus)
        Me.TbOutros.Controls.Add(Me.cboSexo)
        Me.TbOutros.Location = New System.Drawing.Point(4, 22)
        Me.TbOutros.Name = "TbOutros"
        Me.TbOutros.Padding = New System.Windows.Forms.Padding(3)
        Me.TbOutros.Size = New System.Drawing.Size(636, 258)
        Me.TbOutros.TabIndex = 1
        Me.TbOutros.Text = "Outras Informações"
        Me.TbOutros.UseVisualStyleBackColor = True
        '
        'cboIDClasse
        '
        Me.cboIDClasse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboIDClasse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIDClasse.FormattingEnabled = True
        Me.cboIDClasse.Location = New System.Drawing.Point(363, 226)
        Me.cboIDClasse.Name = "cboIDClasse"
        Me.cboIDClasse.Size = New System.Drawing.Size(199, 21)
        Me.cboIDClasse.TabIndex = 20
        '
        'chk_Permanente
        '
        Me.chk_Permanente.AutoSize = True
        Me.chk_Permanente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_Permanente.Location = New System.Drawing.Point(213, 97)
        Me.chk_Permanente.Name = "chk_Permanente"
        Me.chk_Permanente.Size = New System.Drawing.Size(124, 17)
        Me.chk_Permanente.TabIndex = 15
        Me.chk_Permanente.Text = "Membro Permanente"
        Me.chk_Permanente.UseVisualStyleBackColor = True
        Me.chk_Permanente.Visible = False
        '
        'lbl_Idade
        '
        Me.lbl_Idade.Location = New System.Drawing.Point(29, 120)
        Me.lbl_Idade.Name = "lbl_Idade"
        Me.lbl_Idade.Size = New System.Drawing.Size(308, 18)
        Me.lbl_Idade.TabIndex = 16
        Me.lbl_Idade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(360, 195)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(208, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "* Dê duplo click na linha acima para excluir."
        '
        'btInsereClasse
        '
        Me.btInsereClasse.Location = New System.Drawing.Point(572, 225)
        Me.btInsereClasse.Name = "btInsereClasse"
        Me.btInsereClasse.Size = New System.Drawing.Size(49, 20)
        Me.btInsereClasse.TabIndex = 0
        Me.btInsereClasse.Text = "Inserir"
        Me.btInsereClasse.UseVisualStyleBackColor = True
        '
        'DGClasses
        '
        Me.DGClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGClasses.Location = New System.Drawing.Point(363, 18)
        Me.DGClasses.Name = "DGClasses"
        Me.DGClasses.RowHeadersVisible = False
        Me.DGClasses.Size = New System.Drawing.Size(259, 174)
        Me.DGClasses.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Dt. Nasc.:"
        '
        'txtDataNascimento
        '
        Me.txtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataNascimento.Location = New System.Drawing.Point(97, 97)
        Me.txtDataNascimento.Name = "txtDataNascimento"
        Me.txtDataNascimento.Size = New System.Drawing.Size(106, 20)
        Me.txtDataNascimento.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(163, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Status:"
        Me.Label10.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(367, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(247, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "O aluno faz parte desse(s) departamento(s):"
        '
        'btLocalizaMae
        '
        Me.btLocalizaMae.Location = New System.Drawing.Point(336, 42)
        Me.btLocalizaMae.Name = "btLocalizaMae"
        Me.btLocalizaMae.Size = New System.Drawing.Size(21, 24)
        Me.btLocalizaMae.TabIndex = 7
        Me.btLocalizaMae.Text = "+"
        Me.btLocalizaMae.UseVisualStyleBackColor = True
        '
        'btLocalizaPai
        '
        Me.btLocalizaPai.Location = New System.Drawing.Point(336, 16)
        Me.btLocalizaPai.Name = "btLocalizaPai"
        Me.btLocalizaPai.Size = New System.Drawing.Size(21, 24)
        Me.btLocalizaPai.TabIndex = 3
        Me.btLocalizaPai.Text = "+"
        Me.btLocalizaPai.UseVisualStyleBackColor = True
        '
        'txtIDPai
        '
        Me.txtIDPai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDPai.Location = New System.Drawing.Point(13, 17)
        Me.txtIDPai.MaxLength = 0
        Me.txtIDPai.Name = "txtIDPai"
        Me.txtIDPai.Size = New System.Drawing.Size(40, 21)
        Me.txtIDPai.TabIndex = 0
        Me.txtIDPai.Text = "0"
        Me.txtIDPai.Visible = False
        '
        'txtIDMae
        '
        Me.txtIDMae.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDMae.Location = New System.Drawing.Point(13, 45)
        Me.txtIDMae.MaxLength = 0
        Me.txtIDMae.Name = "txtIDMae"
        Me.txtIDMae.Size = New System.Drawing.Size(40, 21)
        Me.txtIDMae.TabIndex = 4
        Me.txtIDMae.Text = "0"
        Me.txtIDMae.Visible = False
        '
        'txtNomeMae
        '
        Me.txtNomeMae.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeMae.Location = New System.Drawing.Point(97, 42)
        Me.txtNomeMae.MaxLength = 0
        Me.txtNomeMae.Name = "txtNomeMae"
        Me.txtNomeMae.Size = New System.Drawing.Size(233, 21)
        Me.txtNomeMae.TabIndex = 6
        '
        'txtNomePai
        '
        Me.txtNomePai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomePai.Location = New System.Drawing.Point(97, 17)
        Me.txtNomePai.MaxLength = 0
        Me.txtNomePai.Name = "txtNomePai"
        Me.txtNomePai.Size = New System.Drawing.Size(233, 21)
        Me.txtNomePai.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Mãe:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pai:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(49, 72)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 15)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Sexo:"
        '
        'cboIDStatus
        '
        Me.cboIDStatus.FormattingEnabled = True
        Me.cboIDStatus.Location = New System.Drawing.Point(216, 72)
        Me.cboIDStatus.Name = "cboIDStatus"
        Me.cboIDStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboIDStatus.TabIndex = 11
        Me.cboIDStatus.Visible = False
        '
        'cboSexo
        '
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"M", "F"})
        Me.cboSexo.Location = New System.Drawing.Point(97, 71)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(51, 21)
        Me.cboSexo.TabIndex = 9
        '
        'grpBotoes
        '
        Me.grpBotoes.Controls.Add(Me.cmdCancelar)
        Me.grpBotoes.Controls.Add(Me.cmdIncluir)
        Me.grpBotoes.Controls.Add(Me.cmdExcluir)
        Me.grpBotoes.Controls.Add(Me.cmdAlterar)
        Me.grpBotoes.Location = New System.Drawing.Point(11, 329)
        Me.grpBotoes.Name = "grpBotoes"
        Me.grpBotoes.Size = New System.Drawing.Size(640, 91)
        Me.grpBotoes.TabIndex = 3
        Me.grpBotoes.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatAppearance.BorderSize = 0
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Red
        Me.cmdCancelar.Image = Global.Templos.My.Resources.Resources.limpar
        Me.cmdCancelar.Location = New System.Drawing.Point(180, 9)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 76)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "Limpar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = True
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
        'cmdExcluir
        '
        Me.cmdExcluir.FlatAppearance.BorderSize = 0
        Me.cmdExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExcluir.ForeColor = System.Drawing.Color.Red
        Me.cmdExcluir.Image = Global.Templos.My.Resources.Resources.excluir
        Me.cmdExcluir.Location = New System.Drawing.Point(559, 9)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(75, 76)
        Me.cmdExcluir.TabIndex = 3
        Me.cmdExcluir.Text = "&Excluir"
        Me.cmdExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExcluir.UseVisualStyleBackColor = True
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
        'txtIDPessoa
        '
        Me.txtIDPessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDPessoa.Location = New System.Drawing.Point(15, 12)
        Me.txtIDPessoa.MaxLength = 0
        Me.txtIDPessoa.Name = "txtIDPessoa"
        Me.txtIDPessoa.ReadOnly = True
        Me.txtIDPessoa.Size = New System.Drawing.Size(63, 21)
        Me.txtIDPessoa.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Digite aqui para localizar:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(97, 403)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Cadastros:"
        '
        'ntxt_Cadastros
        '
        Me.ntxt_Cadastros.Enabled = False
        Me.ntxt_Cadastros.Location = New System.Drawing.Point(160, 400)
        Me.ntxt_Cadastros.Name = "ntxt_Cadastros"
        Me.ntxt_Cadastros.ReadOnly = True
        Me.ntxt_Cadastros.Size = New System.Drawing.Size(77, 20)
        Me.ntxt_Cadastros.TabIndex = 4
        Me.ntxt_Cadastros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Filtro
        '
        Me.txt_Filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Filtro.Location = New System.Drawing.Point(7, 34)
        Me.txt_Filtro.MaxLength = 0
        Me.txt_Filtro.Name = "txt_Filtro"
        Me.txt_Filtro.Size = New System.Drawing.Size(230, 21)
        Me.txt_Filtro.TabIndex = 1
        '
        'DgLocaliza
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgLocaliza.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgLocaliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgLocaliza.Location = New System.Drawing.Point(7, 61)
        Me.DgLocaliza.Name = "DgLocaliza"
        Me.DgLocaliza.RowHeadersVisible = False
        Me.DgLocaliza.Size = New System.Drawing.Size(230, 321)
        Me.DgLocaliza.TabIndex = 2
        '
        'Frm_Membros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 451)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lblDigita)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Membros"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Pessoas."
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TBMembro.ResumeLayout(False)
        Me.TbContato.ResumeLayout(False)
        Me.TbContato.PerformLayout()
        Me.TbOutros.ResumeLayout(False)
        Me.TbOutros.PerformLayout()
        CType(Me.DGClasses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBotoes.ResumeLayout(False)
        CType(Me.DgLocaliza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDigita As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtNome2 As System.Windows.Forms.TextBox
    Friend WithEvents TBMembro As System.Windows.Forms.TabControl
    Friend WithEvents TbContato As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents mskCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblInscricao As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCGC As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblRG As System.Windows.Forms.Label
    Friend WithEvents txtIE As System.Windows.Forms.TextBox
    Friend WithEvents txtCNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskFax As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPessoa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbOutros As System.Windows.Forms.TabPage
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btInsereClasse As System.Windows.Forms.Button
    Friend WithEvents DGClasses As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDataNascimento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboIDStatus As Templos.ComboboxAutoComplete
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btLocalizaMae As System.Windows.Forms.Button
    Friend WithEvents btLocalizaPai As System.Windows.Forms.Button
    Friend WithEvents txtIDPai As System.Windows.Forms.TextBox
    Friend WithEvents txtIDMae As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeMae As System.Windows.Forms.TextBox
    Friend WithEvents txtNomePai As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboSexo As Templos.ComboboxAutoComplete
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents grpBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdIncluir As System.Windows.Forms.Button
    Friend WithEvents cmdExcluir As System.Windows.Forms.Button
    Friend WithEvents cmdAlterar As System.Windows.Forms.Button
    Friend WithEvents txtIDPessoa As System.Windows.Forms.TextBox
    Friend WithEvents DgLocaliza As System.Windows.Forms.DataGridView
    Friend WithEvents txt_Filtro As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ntxt_Cadastros As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Idade As System.Windows.Forms.Label
    Friend WithEvents chk_Permanente As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cboEstCivil As ComboBox
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents cboIDClasse As ComboBox
End Class
