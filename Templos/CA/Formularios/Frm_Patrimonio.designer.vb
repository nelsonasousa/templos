<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Patrimonio
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
        Me.lblDigita = New System.Windows.Forms.Label()
        Me.grpBotoes = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdIncluir = New System.Windows.Forms.Button()
        Me.cmdPesquisar = New System.Windows.Forms.Button()
        Me.cmdExcluir = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.grpRegistro = New System.Windows.Forms.GroupBox()
        Me.txtIDPatrimonio = New System.Windows.Forms.TextBox()
        Me.txtAparelhoFiscal = New System.Windows.Forms.CheckBox()
        Me.txtUsado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtValorCompra = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDtUlt_Revisao = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDtCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboCor = New Templos.ComboboxAutoComplete()
        Me.txtTensao = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDepreciacao = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDtRegistro = New System.Windows.Forms.DateTimePicker()
        Me.txtNotaFiscal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboFornecedor = New Templos.ComboboxAutoComplete()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpBotoes.SuspendLayout()
        Me.grpRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDigita
        '
        Me.lblDigita.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDigita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigita.ForeColor = System.Drawing.Color.Blue
        Me.lblDigita.Location = New System.Drawing.Point(0, 364)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(465, 21)
        Me.lblDigita.TabIndex = 2
        Me.lblDigita.Text = "Label5"
        Me.lblDigita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpBotoes
        '
        Me.grpBotoes.Controls.Add(Me.cmdCancelar)
        Me.grpBotoes.Controls.Add(Me.cmdIncluir)
        Me.grpBotoes.Controls.Add(Me.cmdPesquisar)
        Me.grpBotoes.Controls.Add(Me.cmdExcluir)
        Me.grpBotoes.Controls.Add(Me.cmdAlterar)
        Me.grpBotoes.Location = New System.Drawing.Point(12, 271)
        Me.grpBotoes.Name = "grpBotoes"
        Me.grpBotoes.Size = New System.Drawing.Size(441, 91)
        Me.grpBotoes.TabIndex = 1
        Me.grpBotoes.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatAppearance.BorderSize = 0
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Red
        Me.cmdCancelar.Image = Global.Templos.My.Resources.Resources.limpar
        Me.cmdCancelar.Location = New System.Drawing.Point(261, 9)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 76)
        Me.cmdCancelar.TabIndex = 3
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
        'cmdPesquisar
        '
        Me.cmdPesquisar.FlatAppearance.BorderSize = 0
        Me.cmdPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPesquisar.Image = Global.Templos.My.Resources.Resources.procura
        Me.cmdPesquisar.Location = New System.Drawing.Point(355, 9)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 76)
        Me.cmdPesquisar.TabIndex = 4
        Me.cmdPesquisar.Text = "&Pesquisar"
        Me.cmdPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'cmdExcluir
        '
        Me.cmdExcluir.FlatAppearance.BorderSize = 0
        Me.cmdExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExcluir.ForeColor = System.Drawing.Color.Red
        Me.cmdExcluir.Image = Global.Templos.My.Resources.Resources.excluir
        Me.cmdExcluir.Location = New System.Drawing.Point(168, 9)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(75, 76)
        Me.cmdExcluir.TabIndex = 2
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
        'grpRegistro
        '
        Me.grpRegistro.Controls.Add(Me.txtIDPatrimonio)
        Me.grpRegistro.Controls.Add(Me.txtAparelhoFiscal)
        Me.grpRegistro.Controls.Add(Me.txtUsado)
        Me.grpRegistro.Controls.Add(Me.Label10)
        Me.grpRegistro.Controls.Add(Me.txtValorCompra)
        Me.grpRegistro.Controls.Add(Me.Label11)
        Me.grpRegistro.Controls.Add(Me.Label7)
        Me.grpRegistro.Controls.Add(Me.txtDtUlt_Revisao)
        Me.grpRegistro.Controls.Add(Me.Label5)
        Me.grpRegistro.Controls.Add(Me.txtDtCompra)
        Me.grpRegistro.Controls.Add(Me.Label2)
        Me.grpRegistro.Controls.Add(Me.Label16)
        Me.grpRegistro.Controls.Add(Me.cboCor)
        Me.grpRegistro.Controls.Add(Me.txtTensao)
        Me.grpRegistro.Controls.Add(Me.Label9)
        Me.grpRegistro.Controls.Add(Me.txtSerie)
        Me.grpRegistro.Controls.Add(Me.Label6)
        Me.grpRegistro.Controls.Add(Me.txtDepreciacao)
        Me.grpRegistro.Controls.Add(Me.Label15)
        Me.grpRegistro.Controls.Add(Me.txtDtRegistro)
        Me.grpRegistro.Controls.Add(Me.txtNotaFiscal)
        Me.grpRegistro.Controls.Add(Me.Label12)
        Me.grpRegistro.Controls.Add(Me.Label4)
        Me.grpRegistro.Controls.Add(Me.cboFornecedor)
        Me.grpRegistro.Controls.Add(Me.txtModelo)
        Me.grpRegistro.Controls.Add(Me.txtDescricao)
        Me.grpRegistro.Controls.Add(Me.Label3)
        Me.grpRegistro.Controls.Add(Me.Label1)
        Me.grpRegistro.Location = New System.Drawing.Point(12, 12)
        Me.grpRegistro.Name = "grpRegistro"
        Me.grpRegistro.Size = New System.Drawing.Size(441, 253)
        Me.grpRegistro.TabIndex = 0
        Me.grpRegistro.TabStop = False
        Me.grpRegistro.Text = "Registro:"
        '
        'txtIDPatrimonio
        '
        Me.txtIDPatrimonio.Location = New System.Drawing.Point(193, 45)
        Me.txtIDPatrimonio.MaxLength = 0
        Me.txtIDPatrimonio.Name = "txtIDPatrimonio"
        Me.txtIDPatrimonio.Size = New System.Drawing.Size(42, 20)
        Me.txtIDPatrimonio.TabIndex = 64
        Me.txtIDPatrimonio.Visible = False
        '
        'txtAparelhoFiscal
        '
        Me.txtAparelhoFiscal.AutoSize = True
        Me.txtAparelhoFiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAparelhoFiscal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtAparelhoFiscal.Location = New System.Drawing.Point(87, 228)
        Me.txtAparelhoFiscal.Name = "txtAparelhoFiscal"
        Me.txtAparelhoFiscal.Size = New System.Drawing.Size(125, 19)
        Me.txtAparelhoFiscal.TabIndex = 13
        Me.txtAparelhoFiscal.Text = "Aparelho Fiscal"
        Me.txtAparelhoFiscal.UseVisualStyleBackColor = True
        '
        'txtUsado
        '
        Me.txtUsado.Location = New System.Drawing.Point(87, 202)
        Me.txtUsado.MaxLength = 0
        Me.txtUsado.Name = "txtUsado"
        Me.txtUsado.Size = New System.Drawing.Size(341, 20)
        Me.txtUsado.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Usado em:"
        '
        'txtValorCompra
        '
        Me.txtValorCompra.Location = New System.Drawing.Point(328, 123)
        Me.txtValorCompra.MaxLength = 0
        Me.txtValorCompra.Name = "txtValorCompra"
        Me.txtValorCompra.Size = New System.Drawing.Size(100, 20)
        Me.txtValorCompra.TabIndex = 8
        Me.txtValorCompra.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(267, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "$ Compra:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Últ.Revisão:"
        '
        'txtDtUlt_Revisao
        '
        Me.txtDtUlt_Revisao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDtUlt_Revisao.Location = New System.Drawing.Point(87, 123)
        Me.txtDtUlt_Revisao.Name = "txtDtUlt_Revisao"
        Me.txtDtUlt_Revisao.Size = New System.Drawing.Size(100, 20)
        Me.txtDtUlt_Revisao.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(250, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Data Compra:"
        '
        'txtDtCompra
        '
        Me.txtDtCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDtCompra.Location = New System.Drawing.Point(328, 97)
        Me.txtDtCompra.Name = "txtDtCompra"
        Me.txtDtCompra.Size = New System.Drawing.Size(100, 20)
        Me.txtDtCompra.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Data Registro:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(296, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "Cor:"
        '
        'cboCor
        '
        Me.cboCor.FormattingEnabled = True
        Me.cboCor.Location = New System.Drawing.Point(328, 71)
        Me.cboCor.Name = "cboCor"
        Me.cboCor.Size = New System.Drawing.Size(100, 21)
        Me.cboCor.TabIndex = 4
        '
        'txtTensao
        '
        Me.txtTensao.Location = New System.Drawing.Point(87, 71)
        Me.txtTensao.MaxLength = 0
        Me.txtTensao.Name = "txtTensao"
        Me.txtTensao.Size = New System.Drawing.Size(100, 20)
        Me.txtTensao.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Tensão:"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(328, 45)
        Me.txtSerie.MaxLength = 0
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(100, 20)
        Me.txtSerie.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(256, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Série/Placa:"
        '
        'txtDepreciacao
        '
        Me.txtDepreciacao.Location = New System.Drawing.Point(328, 149)
        Me.txtDepreciacao.MaxLength = 0
        Me.txtDepreciacao.Name = "txtDepreciacao"
        Me.txtDepreciacao.Size = New System.Drawing.Size(100, 20)
        Me.txtDepreciacao.TabIndex = 10
        Me.txtDepreciacao.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(242, 149)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "$ Depreciação:"
        '
        'txtDtRegistro
        '
        Me.txtDtRegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDtRegistro.Location = New System.Drawing.Point(87, 97)
        Me.txtDtRegistro.Name = "txtDtRegistro"
        Me.txtDtRegistro.Size = New System.Drawing.Size(100, 20)
        Me.txtDtRegistro.TabIndex = 5
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.Location = New System.Drawing.Point(87, 149)
        Me.txtNotaFiscal.MaxLength = 0
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.Size = New System.Drawing.Size(100, 20)
        Me.txtNotaFiscal.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Nota Fiscal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Fornecedor:"
        '
        'cboFornecedor
        '
        Me.cboFornecedor.FormattingEnabled = True
        Me.cboFornecedor.Location = New System.Drawing.Point(87, 175)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Size = New System.Drawing.Size(341, 21)
        Me.cboFornecedor.TabIndex = 11
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(87, 45)
        Me.txtModelo.MaxLength = 0
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(100, 20)
        Me.txtModelo.TabIndex = 1
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(87, 19)
        Me.txtDescricao.MaxLength = 0
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(341, 20)
        Me.txtDescricao.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Modelo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Descrição:"
        '
        'Frm_Patrimonio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 385)
        Me.Controls.Add(Me.lblDigita)
        Me.Controls.Add(Me.grpBotoes)
        Me.Controls.Add(Me.grpRegistro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Patrimonio"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Patrimônios."
        Me.grpBotoes.ResumeLayout(False)
        Me.grpRegistro.ResumeLayout(False)
        Me.grpRegistro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDigita As System.Windows.Forms.Label
    Friend WithEvents grpBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdIncluir As System.Windows.Forms.Button
    Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
    Friend WithEvents cmdExcluir As System.Windows.Forms.Button
    Friend WithEvents cmdAlterar As System.Windows.Forms.Button
    Friend WithEvents grpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents txtDepreciacao As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDtRegistro As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNotaFiscal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboFornecedor As Templos.ComboboxAutoComplete
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTensao As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboCor As Templos.ComboboxAutoComplete
    Friend WithEvents txtValorCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDtUlt_Revisao As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDtCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsado As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAparelhoFiscal As System.Windows.Forms.CheckBox
    Friend WithEvents txtIDPatrimonio As System.Windows.Forms.TextBox
End Class
