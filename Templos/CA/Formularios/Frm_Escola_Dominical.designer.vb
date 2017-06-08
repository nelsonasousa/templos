<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Escola_Dominical
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpResumo = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMatriculados = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalRevistas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalOfertas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalBiblias = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalPresentes = New System.Windows.Forms.TextBox()
        Me.ntxt_Ausentes = New System.Windows.Forms.TextBox()
        Me.txtVisitantes = New System.Windows.Forms.TextBox()
        Me.txtAlunosPresentes = New System.Windows.Forms.TextBox()
        Me.txtDataEscola = New System.Windows.Forms.DateTimePicker()
        Me.DGClasses = New System.Windows.Forms.DataGridView()
        Me.DGAlunos = New System.Windows.Forms.DataGridView()
        Me.cms_Alunos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grp_Localiza = New System.Windows.Forms.GroupBox()
        Me.dg_Localiza = New System.Windows.Forms.DataGridView()
        Me.txt_Data_Fechamento = New System.Windows.Forms.TextBox()
        Me.bt_Zerar = New System.Windows.Forms.Button()
        Me.btImprimir = New System.Windows.Forms.Button()
        Me.btConfirma = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_Revistas = New System.Windows.Forms.Label()
        Me.lbl_Biblias = New System.Windows.Forms.Label()
        Me.grpResumo.SuspendLayout()
        CType(Me.DGClasses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_Alunos.SuspendLayout()
        Me.grp_Localiza.SuspendLayout()
        CType(Me.dg_Localiza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpResumo
        '
        Me.grpResumo.Controls.Add(Me.Label11)
        Me.grpResumo.Controls.Add(Me.txtMatriculados)
        Me.grpResumo.Controls.Add(Me.Label10)
        Me.grpResumo.Controls.Add(Me.txtTotalRevistas)
        Me.grpResumo.Controls.Add(Me.Label9)
        Me.grpResumo.Controls.Add(Me.txtTotalOfertas)
        Me.grpResumo.Controls.Add(Me.Label8)
        Me.grpResumo.Controls.Add(Me.txtTotalBiblias)
        Me.grpResumo.Controls.Add(Me.Label7)
        Me.grpResumo.Controls.Add(Me.Label6)
        Me.grpResumo.Controls.Add(Me.Label5)
        Me.grpResumo.Controls.Add(Me.Label4)
        Me.grpResumo.Controls.Add(Me.Label3)
        Me.grpResumo.Controls.Add(Me.txtTotalPresentes)
        Me.grpResumo.Controls.Add(Me.ntxt_Ausentes)
        Me.grpResumo.Controls.Add(Me.txtVisitantes)
        Me.grpResumo.Controls.Add(Me.txtAlunosPresentes)
        Me.grpResumo.Controls.Add(Me.txtDataEscola)
        Me.grpResumo.Location = New System.Drawing.Point(146, 430)
        Me.grpResumo.Name = "grpResumo"
        Me.grpResumo.Size = New System.Drawing.Size(678, 83)
        Me.grpResumo.TabIndex = 0
        Me.grpResumo.TabStop = False
        Me.grpResumo.Text = "Resumo Geral"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(97, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 36)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Matriculados:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtMatriculados
        '
        Me.txtMatriculados.Location = New System.Drawing.Point(100, 57)
        Me.txtMatriculados.Name = "txtMatriculados"
        Me.txtMatriculados.ReadOnly = True
        Me.txtMatriculados.Size = New System.Drawing.Size(64, 20)
        Me.txtMatriculados.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(485, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 36)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Revistas:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtTotalRevistas
        '
        Me.txtTotalRevistas.Location = New System.Drawing.Point(488, 57)
        Me.txtTotalRevistas.Name = "txtTotalRevistas"
        Me.txtTotalRevistas.ReadOnly = True
        Me.txtTotalRevistas.Size = New System.Drawing.Size(55, 20)
        Me.txtTotalRevistas.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(547, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 36)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "R$ Ofertas:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtTotalOfertas
        '
        Me.txtTotalOfertas.Location = New System.Drawing.Point(550, 57)
        Me.txtTotalOfertas.Name = "txtTotalOfertas"
        Me.txtTotalOfertas.ReadOnly = True
        Me.txtTotalOfertas.Size = New System.Drawing.Size(55, 20)
        Me.txtTotalOfertas.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(424, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 36)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Bíblias:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtTotalBiblias
        '
        Me.txtTotalBiblias.Location = New System.Drawing.Point(427, 57)
        Me.txtTotalBiblias.Name = "txtTotalBiblias"
        Me.txtTotalBiblias.ReadOnly = True
        Me.txtTotalBiblias.Size = New System.Drawing.Size(55, 20)
        Me.txtTotalBiblias.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(359, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 36)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Total Presentes:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(228, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 36)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Ausentes"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(292, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 36)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Visitantes:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(167, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 36)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Alunos Presentes:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Escola do dia:"
        '
        'txtTotalPresentes
        '
        Me.txtTotalPresentes.Location = New System.Drawing.Point(362, 57)
        Me.txtTotalPresentes.Name = "txtTotalPresentes"
        Me.txtTotalPresentes.ReadOnly = True
        Me.txtTotalPresentes.Size = New System.Drawing.Size(55, 20)
        Me.txtTotalPresentes.TabIndex = 4
        '
        'ntxt_Ausentes
        '
        Me.ntxt_Ausentes.Location = New System.Drawing.Point(231, 57)
        Me.ntxt_Ausentes.Name = "ntxt_Ausentes"
        Me.ntxt_Ausentes.ReadOnly = True
        Me.ntxt_Ausentes.Size = New System.Drawing.Size(55, 20)
        Me.ntxt_Ausentes.TabIndex = 3
        '
        'txtVisitantes
        '
        Me.txtVisitantes.Location = New System.Drawing.Point(292, 57)
        Me.txtVisitantes.Name = "txtVisitantes"
        Me.txtVisitantes.ReadOnly = True
        Me.txtVisitantes.Size = New System.Drawing.Size(55, 20)
        Me.txtVisitantes.TabIndex = 2
        '
        'txtAlunosPresentes
        '
        Me.txtAlunosPresentes.Location = New System.Drawing.Point(170, 57)
        Me.txtAlunosPresentes.Name = "txtAlunosPresentes"
        Me.txtAlunosPresentes.ReadOnly = True
        Me.txtAlunosPresentes.Size = New System.Drawing.Size(55, 20)
        Me.txtAlunosPresentes.TabIndex = 1
        '
        'txtDataEscola
        '
        Me.txtDataEscola.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataEscola.Location = New System.Drawing.Point(6, 57)
        Me.txtDataEscola.Name = "txtDataEscola"
        Me.txtDataEscola.Size = New System.Drawing.Size(88, 20)
        Me.txtDataEscola.TabIndex = 0
        '
        'DGClasses
        '
        Me.DGClasses.AllowUserToAddRows = False
        Me.DGClasses.AllowUserToDeleteRows = False
        Me.DGClasses.AllowUserToResizeColumns = False
        Me.DGClasses.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGClasses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGClasses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGClasses.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGClasses.Location = New System.Drawing.Point(146, 21)
        Me.DGClasses.Name = "DGClasses"
        Me.DGClasses.RowHeadersVisible = False
        Me.DGClasses.Size = New System.Drawing.Size(806, 159)
        Me.DGClasses.TabIndex = 1
        '
        'DGAlunos
        '
        Me.DGAlunos.AllowUserToAddRows = False
        Me.DGAlunos.AllowUserToDeleteRows = False
        Me.DGAlunos.AllowUserToResizeColumns = False
        Me.DGAlunos.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGAlunos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGAlunos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAlunos.ContextMenuStrip = Me.cms_Alunos
        Me.DGAlunos.Location = New System.Drawing.Point(147, 199)
        Me.DGAlunos.Name = "DGAlunos"
        Me.DGAlunos.RowHeadersVisible = False
        Me.DGAlunos.Size = New System.Drawing.Size(483, 203)
        Me.DGAlunos.TabIndex = 2
        '
        'cms_Alunos
        '
        Me.cms_Alunos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcluirToolStripMenuItem})
        Me.cms_Alunos.Name = "cms_Alunos"
        Me.cms_Alunos.Size = New System.Drawing.Size(144, 26)
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ExcluirToolStripMenuItem.Text = "Excluir Aluno"
        Me.ExcluirToolStripMenuItem.ToolTipText = "Exclui aluno desta lista e chamada."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Classes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lista de Presença:"
        '
        'grp_Localiza
        '
        Me.grp_Localiza.Controls.Add(Me.dg_Localiza)
        Me.grp_Localiza.Location = New System.Drawing.Point(12, 5)
        Me.grp_Localiza.Name = "grp_Localiza"
        Me.grp_Localiza.Size = New System.Drawing.Size(117, 508)
        Me.grp_Localiza.TabIndex = 18
        Me.grp_Localiza.TabStop = False
        Me.grp_Localiza.Text = "Domingos"
        '
        'dg_Localiza
        '
        Me.dg_Localiza.AllowUserToAddRows = False
        Me.dg_Localiza.AllowUserToDeleteRows = False
        Me.dg_Localiza.AllowUserToResizeColumns = False
        Me.dg_Localiza.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_Localiza.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_Localiza.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_Localiza.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_Localiza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Localiza.Location = New System.Drawing.Point(8, 18)
        Me.dg_Localiza.Name = "dg_Localiza"
        Me.dg_Localiza.RowHeadersVisible = False
        Me.dg_Localiza.Size = New System.Drawing.Size(96, 484)
        Me.dg_Localiza.TabIndex = 0
        '
        'txt_Data_Fechamento
        '
        Me.txt_Data_Fechamento.Location = New System.Drawing.Point(707, 291)
        Me.txt_Data_Fechamento.Name = "txt_Data_Fechamento"
        Me.txt_Data_Fechamento.Size = New System.Drawing.Size(100, 20)
        Me.txt_Data_Fechamento.TabIndex = 19
        Me.txt_Data_Fechamento.Visible = False
        '
        'bt_Zerar
        '
        Me.bt_Zerar.FlatAppearance.BorderSize = 0
        Me.bt_Zerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Zerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Zerar.Image = Global.Templos.My.Resources.Resources.limpar
        Me.bt_Zerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_Zerar.Location = New System.Drawing.Point(830, 339)
        Me.bt_Zerar.Name = "bt_Zerar"
        Me.bt_Zerar.Size = New System.Drawing.Size(85, 81)
        Me.bt_Zerar.TabIndex = 20
        Me.bt_Zerar.Text = "Limpar Domingo"
        Me.bt_Zerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_Zerar.UseVisualStyleBackColor = True
        '
        'btImprimir
        '
        Me.btImprimir.FlatAppearance.BorderSize = 0
        Me.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImprimir.Image = Global.Templos.My.Resources.Resources.impressora
        Me.btImprimir.Location = New System.Drawing.Point(654, 339)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(85, 81)
        Me.btImprimir.TabIndex = 15
        Me.btImprimir.Text = "Imprimir"
        Me.btImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btImprimir.UseVisualStyleBackColor = True
        '
        'btConfirma
        '
        Me.btConfirma.FlatAppearance.BorderSize = 0
        Me.btConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConfirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConfirma.Image = Global.Templos.My.Resources.Resources.fechamento
        Me.btConfirma.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btConfirma.Location = New System.Drawing.Point(739, 339)
        Me.btConfirma.Name = "btConfirma"
        Me.btConfirma.Size = New System.Drawing.Size(85, 81)
        Me.btConfirma.TabIndex = 14
        Me.btConfirma.Text = "Fechar"
        Me.btConfirma.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btConfirma.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(149, 404)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(222, 23)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Dê 2 cliques na coluna que deseja editar."
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(739, 183)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(213, 23)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Digiite nas células os valores desejados."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Revistas
        '
        Me.lbl_Revistas.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Revistas.ForeColor = System.Drawing.Color.Purple
        Me.lbl_Revistas.Location = New System.Drawing.Point(765, 229)
        Me.lbl_Revistas.Name = "lbl_Revistas"
        Me.lbl_Revistas.Size = New System.Drawing.Size(187, 23)
        Me.lbl_Revistas.TabIndex = 25
        Me.lbl_Revistas.Text = "Qtde Revistas Maior Total Presentes"
        Me.lbl_Revistas.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_Revistas.Visible = False
        '
        'lbl_Biblias
        '
        Me.lbl_Biblias.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Biblias.ForeColor = System.Drawing.Color.Red
        Me.lbl_Biblias.Location = New System.Drawing.Point(765, 206)
        Me.lbl_Biblias.Name = "lbl_Biblias"
        Me.lbl_Biblias.Size = New System.Drawing.Size(187, 23)
        Me.lbl_Biblias.TabIndex = 24
        Me.lbl_Biblias.Text = "Qtde Bíblias Maior Total Presentes"
        Me.lbl_Biblias.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_Biblias.Visible = False
        '
        'Frm_Escola_Dominical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 525)
        Me.Controls.Add(Me.lbl_Revistas)
        Me.Controls.Add(Me.lbl_Biblias)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.bt_Zerar)
        Me.Controls.Add(Me.txt_Data_Fechamento)
        Me.Controls.Add(Me.grp_Localiza)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btConfirma)
        Me.Controls.Add(Me.DGAlunos)
        Me.Controls.Add(Me.DGClasses)
        Me.Controls.Add(Me.grpResumo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Escola_Dominical"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimentação da Escola Dominical."
        Me.grpResumo.ResumeLayout(False)
        Me.grpResumo.PerformLayout()
        CType(Me.DGClasses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_Alunos.ResumeLayout(False)
        Me.grp_Localiza.ResumeLayout(False)
        CType(Me.dg_Localiza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpResumo As System.Windows.Forms.GroupBox
    Friend WithEvents txtDataEscola As System.Windows.Forms.DateTimePicker
    Friend WithEvents DGClasses As System.Windows.Forms.DataGridView
    Friend WithEvents DGAlunos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPresentes As System.Windows.Forms.TextBox
    Friend WithEvents ntxt_Ausentes As System.Windows.Forms.TextBox
    Friend WithEvents txtVisitantes As System.Windows.Forms.TextBox
    Friend WithEvents txtAlunosPresentes As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalOfertas As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotalBiblias As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btConfirma As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRevistas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMatriculados As System.Windows.Forms.TextBox
    Friend WithEvents btImprimir As System.Windows.Forms.Button
    Friend WithEvents cms_Alunos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExcluirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grp_Localiza As System.Windows.Forms.GroupBox
    Friend WithEvents dg_Localiza As System.Windows.Forms.DataGridView
    Friend WithEvents txt_Data_Fechamento As System.Windows.Forms.TextBox
    Friend WithEvents bt_Zerar As System.Windows.Forms.Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbl_Revistas As Label
    Friend WithEvents lbl_Biblias As Label
End Class
