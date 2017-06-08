<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Controle_Atas
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txt_Qtde_Paginas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Nome_Doc = New System.Windows.Forms.TextBox()
        Me.txt_Folha = New System.Windows.Forms.TextBox()
        Me.txt_Livro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDigita = New System.Windows.Forms.Label()
        Me.txt_Pasta = New System.Windows.Forms.TextBox()
        Me.txt_IDAta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Resumo = New System.Windows.Forms.TextBox()
        Me.txt_Palavras_Chave = New System.Windows.Forms.TextBox()
        Me.txt_Data_Ata = New System.Windows.Forms.DateTimePicker()
        Me.cbo_IDClasse = New System.Windows.Forms.ComboBox()
        Me.grpBotoes = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.bt_Salvar = New System.Windows.Forms.Button()
        Me.cmdExcluir = New System.Windows.Forms.Button()
        Me.dg_Localiza = New System.Windows.Forms.DataGridView()
        Me.bt_Abre_Doc = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ntxt_Cadastros = New System.Windows.Forms.TextBox()
        Me.txt_Filtro = New System.Windows.Forms.TextBox()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpBotoes.SuspendLayout()
        CType(Me.dg_Localiza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Qtde_Paginas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Nome_Doc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Folha)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Livro)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDigita)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Pasta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_IDAta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Resumo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Palavras_Chave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Data_Ata)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbo_IDClasse)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpBotoes)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dg_Localiza)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bt_Abre_Doc)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ntxt_Cadastros)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_Filtro)
        Me.SplitContainer1.Size = New System.Drawing.Size(787, 455)
        Me.SplitContainer1.SplitterDistance = 538
        Me.SplitContainer1.TabIndex = 0
        '
        'txt_Qtde_Paginas
        '
        Me.txt_Qtde_Paginas.Location = New System.Drawing.Point(195, 79)
        Me.txt_Qtde_Paginas.Name = "txt_Qtde_Paginas"
        Me.txt_Qtde_Paginas.Size = New System.Drawing.Size(71, 20)
        Me.txt_Qtde_Paginas.TabIndex = 10
        Me.txt_Qtde_Paginas.Text = "1"
        Me.txt_Qtde_Paginas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(192, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Qtde Páginas:"
        '
        'txt_Nome_Doc
        '
        Me.txt_Nome_Doc.Enabled = False
        Me.txt_Nome_Doc.Location = New System.Drawing.Point(304, 79)
        Me.txt_Nome_Doc.Name = "txt_Nome_Doc"
        Me.txt_Nome_Doc.Size = New System.Drawing.Size(220, 20)
        Me.txt_Nome_Doc.TabIndex = 12
        '
        'txt_Folha
        '
        Me.txt_Folha.Location = New System.Drawing.Point(118, 79)
        Me.txt_Folha.Name = "txt_Folha"
        Me.txt_Folha.Size = New System.Drawing.Size(71, 20)
        Me.txt_Folha.TabIndex = 8
        Me.txt_Folha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Livro
        '
        Me.txt_Livro.Location = New System.Drawing.Point(12, 79)
        Me.txt_Livro.Name = "txt_Livro"
        Me.txt_Livro.Size = New System.Drawing.Size(100, 20)
        Me.txt_Livro.TabIndex = 6
        Me.txt_Livro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Livro:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(115, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Folha:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Pasta da Ata:"
        '
        'lblDigita
        '
        Me.lblDigita.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDigita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigita.ForeColor = System.Drawing.Color.Blue
        Me.lblDigita.Location = New System.Drawing.Point(0, 432)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(538, 23)
        Me.lblDigita.TabIndex = 21
        Me.lblDigita.Text = "Label5"
        Me.lblDigita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Pasta
        '
        Me.txt_Pasta.Enabled = False
        Me.txt_Pasta.Location = New System.Drawing.Point(11, 118)
        Me.txt_Pasta.Name = "txt_Pasta"
        Me.txt_Pasta.Size = New System.Drawing.Size(515, 20)
        Me.txt_Pasta.TabIndex = 14
        Me.txt_Pasta.Text = "C:\Methodus\Templos\Atas\"
        '
        'txt_IDAta
        '
        Me.txt_IDAta.Location = New System.Drawing.Point(210, 4)
        Me.txt_IDAta.Name = "txt_IDAta"
        Me.txt_IDAta.Size = New System.Drawing.Size(100, 20)
        Me.txt_IDAta.TabIndex = 2
        Me.txt_IDAta.TabStop = False
        Me.txt_IDAta.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Resumo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Palavras Chave:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nome Doc:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(418, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Classe:"
        '
        'txt_Resumo
        '
        Me.txt_Resumo.Location = New System.Drawing.Point(11, 196)
        Me.txt_Resumo.Multiline = True
        Me.txt_Resumo.Name = "txt_Resumo"
        Me.txt_Resumo.Size = New System.Drawing.Size(513, 132)
        Me.txt_Resumo.TabIndex = 19
        '
        'txt_Palavras_Chave
        '
        Me.txt_Palavras_Chave.Location = New System.Drawing.Point(11, 157)
        Me.txt_Palavras_Chave.Name = "txt_Palavras_Chave"
        Me.txt_Palavras_Chave.Size = New System.Drawing.Size(513, 20)
        Me.txt_Palavras_Chave.TabIndex = 17
        '
        'txt_Data_Ata
        '
        Me.txt_Data_Ata.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_Data_Ata.Location = New System.Drawing.Point(420, 28)
        Me.txt_Data_Ata.Name = "txt_Data_Ata"
        Me.txt_Data_Ata.Size = New System.Drawing.Size(104, 20)
        Me.txt_Data_Ata.TabIndex = 4
        '
        'cbo_IDClasse
        '
        Me.cbo_IDClasse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_IDClasse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_IDClasse.FormattingEnabled = True
        Me.cbo_IDClasse.Location = New System.Drawing.Point(11, 27)
        Me.cbo_IDClasse.Name = "cbo_IDClasse"
        Me.cbo_IDClasse.Size = New System.Drawing.Size(298, 21)
        Me.cbo_IDClasse.TabIndex = 1
        '
        'grpBotoes
        '
        Me.grpBotoes.Controls.Add(Me.cmdCancelar)
        Me.grpBotoes.Controls.Add(Me.bt_Salvar)
        Me.grpBotoes.Controls.Add(Me.cmdExcluir)
        Me.grpBotoes.Location = New System.Drawing.Point(12, 334)
        Me.grpBotoes.Name = "grpBotoes"
        Me.grpBotoes.Size = New System.Drawing.Size(514, 91)
        Me.grpBotoes.TabIndex = 20
        Me.grpBotoes.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatAppearance.BorderSize = 0
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Image = Global.Templos.My.Resources.Resources.limpar
        Me.cmdCancelar.Location = New System.Drawing.Point(87, 9)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 76)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "Limpar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'bt_Salvar
        '
        Me.bt_Salvar.FlatAppearance.BorderSize = 0
        Me.bt_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Salvar.Image = Global.Templos.My.Resources.Resources.incluir
        Me.bt_Salvar.Location = New System.Drawing.Point(6, 9)
        Me.bt_Salvar.Name = "bt_Salvar"
        Me.bt_Salvar.Size = New System.Drawing.Size(75, 76)
        Me.bt_Salvar.TabIndex = 0
        Me.bt_Salvar.Text = "Salvar"
        Me.bt_Salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_Salvar.UseVisualStyleBackColor = True
        '
        'cmdExcluir
        '
        Me.cmdExcluir.FlatAppearance.BorderSize = 0
        Me.cmdExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExcluir.ForeColor = System.Drawing.Color.Black
        Me.cmdExcluir.Image = Global.Templos.My.Resources.Resources.excluir
        Me.cmdExcluir.Location = New System.Drawing.Point(433, 16)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(75, 69)
        Me.cmdExcluir.TabIndex = 2
        Me.cmdExcluir.Text = "&Excluir"
        Me.cmdExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExcluir.UseVisualStyleBackColor = True
        '
        'dg_Localiza
        '
        Me.dg_Localiza.AllowUserToAddRows = False
        Me.dg_Localiza.AllowUserToDeleteRows = False
        Me.dg_Localiza.AllowUserToResizeColumns = False
        Me.dg_Localiza.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_Localiza.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dg_Localiza.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_Localiza.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_Localiza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Localiza.Location = New System.Drawing.Point(7, 51)
        Me.dg_Localiza.Name = "dg_Localiza"
        Me.dg_Localiza.RowHeadersVisible = False
        Me.dg_Localiza.Size = New System.Drawing.Size(230, 277)
        Me.dg_Localiza.TabIndex = 5
        '
        'bt_Abre_Doc
        '
        Me.bt_Abre_Doc.Location = New System.Drawing.Point(7, 387)
        Me.bt_Abre_Doc.Name = "bt_Abre_Doc"
        Me.bt_Abre_Doc.Size = New System.Drawing.Size(230, 32)
        Me.bt_Abre_Doc.TabIndex = 4
        Me.bt_Abre_Doc.Text = "Abrir Documento"
        Me.bt_Abre_Doc.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(105, 353)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Qtde.:"
        '
        'ntxt_Cadastros
        '
        Me.ntxt_Cadastros.Enabled = False
        Me.ntxt_Cadastros.Location = New System.Drawing.Point(156, 350)
        Me.ntxt_Cadastros.Name = "ntxt_Cadastros"
        Me.ntxt_Cadastros.ReadOnly = True
        Me.ntxt_Cadastros.Size = New System.Drawing.Size(77, 20)
        Me.ntxt_Cadastros.TabIndex = 3
        Me.ntxt_Cadastros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Filtro
        '
        Me.txt_Filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Filtro.Location = New System.Drawing.Point(7, 24)
        Me.txt_Filtro.MaxLength = 0
        Me.txt_Filtro.Name = "txt_Filtro"
        Me.txt_Filtro.Size = New System.Drawing.Size(230, 21)
        Me.txt_Filtro.TabIndex = 0
        '
        'Frm_Controle_Atas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 455)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.Name = "Frm_Controle_Atas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Atas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpBotoes.ResumeLayout(False)
        CType(Me.dg_Localiza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grpBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents bt_Salvar As System.Windows.Forms.Button
    Friend WithEvents cmdExcluir As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ntxt_Cadastros As System.Windows.Forms.TextBox
    Friend WithEvents txt_Filtro As System.Windows.Forms.TextBox
    Friend WithEvents txt_Resumo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Palavras_Chave As System.Windows.Forms.TextBox
    Friend WithEvents txt_Data_Ata As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_IDClasse As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_IDAta As System.Windows.Forms.TextBox
    Friend WithEvents txt_Pasta As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblDigita As System.Windows.Forms.Label
    Friend WithEvents bt_Abre_Doc As System.Windows.Forms.Button
    Friend WithEvents txt_Nome_Doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_Folha As System.Windows.Forms.TextBox
    Friend WithEvents txt_Livro As System.Windows.Forms.TextBox
    Friend WithEvents txt_Qtde_Paginas As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dg_Localiza As System.Windows.Forms.DataGridView
End Class
