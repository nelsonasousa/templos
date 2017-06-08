<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Fluxo_Caixa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpBotoes = New System.Windows.Forms.GroupBox()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.cmdIncluir = New System.Windows.Forms.Button()
        Me.cmdExcluir = New System.Windows.Forms.Button()
        Me.cmdBaixar = New System.Windows.Forms.Button()
        Me.grpRegistro = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ctxt_Total_Debito_Aberto = New System.Windows.Forms.TextBox()
        Me.ctxt_Total_Credito_Aberto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgFluxo_Caixa = New System.Windows.Forms.DataGridView()
        Me.ctxt_Total_Debito_Baixado = New System.Windows.Forms.TextBox()
        Me.ctxt_Total_Credito_Baixado = New System.Windows.Forms.TextBox()
        Me.txtIDMovFinanceiro = New System.Windows.Forms.TextBox()
        Me.grpBotoes.SuspendLayout()
        Me.grpRegistro.SuspendLayout()
        CType(Me.dgFluxo_Caixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBotoes
        '
        Me.grpBotoes.Controls.Add(Me.cmdAlterar)
        Me.grpBotoes.Controls.Add(Me.cmdIncluir)
        Me.grpBotoes.Controls.Add(Me.cmdExcluir)
        Me.grpBotoes.Controls.Add(Me.cmdBaixar)
        Me.grpBotoes.Location = New System.Drawing.Point(13, 382)
        Me.grpBotoes.Name = "grpBotoes"
        Me.grpBotoes.Size = New System.Drawing.Size(752, 91)
        Me.grpBotoes.TabIndex = 1
        Me.grpBotoes.TabStop = False
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
        Me.cmdExcluir.Location = New System.Drawing.Point(168, 9)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(75, 76)
        Me.cmdExcluir.TabIndex = 2
        Me.cmdExcluir.Text = "&Excluir"
        Me.cmdExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExcluir.UseVisualStyleBackColor = True
        '
        'cmdBaixar
        '
        Me.cmdBaixar.FlatAppearance.BorderSize = 0
        Me.cmdBaixar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBaixar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBaixar.Image = Global.Templos.My.Resources.Resources.vendas1
        Me.cmdBaixar.Location = New System.Drawing.Point(246, 9)
        Me.cmdBaixar.Name = "cmdBaixar"
        Me.cmdBaixar.Size = New System.Drawing.Size(75, 76)
        Me.cmdBaixar.TabIndex = 3
        Me.cmdBaixar.Text = "&Baixar"
        Me.cmdBaixar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdBaixar.UseVisualStyleBackColor = True
        '
        'grpRegistro
        '
        Me.grpRegistro.Controls.Add(Me.Label1)
        Me.grpRegistro.Controls.Add(Me.Label4)
        Me.grpRegistro.Controls.Add(Me.ctxt_Total_Debito_Aberto)
        Me.grpRegistro.Controls.Add(Me.ctxt_Total_Credito_Aberto)
        Me.grpRegistro.Controls.Add(Me.Label3)
        Me.grpRegistro.Controls.Add(Me.Label2)
        Me.grpRegistro.Controls.Add(Me.dgFluxo_Caixa)
        Me.grpRegistro.Controls.Add(Me.ctxt_Total_Debito_Baixado)
        Me.grpRegistro.Controls.Add(Me.ctxt_Total_Credito_Baixado)
        Me.grpRegistro.Controls.Add(Me.txtIDMovFinanceiro)
        Me.grpRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRegistro.Location = New System.Drawing.Point(13, 8)
        Me.grpRegistro.Name = "grpRegistro"
        Me.grpRegistro.Size = New System.Drawing.Size(753, 368)
        Me.grpRegistro.TabIndex = 0
        Me.grpRegistro.TabStop = False
        Me.grpRegistro.Text = "Registro:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(458, 345)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 15)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Total Débitos em Aberto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(454, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 15)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Total Créditos em Aberto:"
        '
        'ctxt_Total_Debito_Aberto
        '
        Me.ctxt_Total_Debito_Aberto.BackColor = System.Drawing.SystemColors.Control
        Me.ctxt_Total_Debito_Aberto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctxt_Total_Debito_Aberto.ForeColor = System.Drawing.Color.Red
        Me.ctxt_Total_Debito_Aberto.Location = New System.Drawing.Point(629, 339)
        Me.ctxt_Total_Debito_Aberto.MaxLength = 0
        Me.ctxt_Total_Debito_Aberto.Name = "ctxt_Total_Debito_Aberto"
        Me.ctxt_Total_Debito_Aberto.ReadOnly = True
        Me.ctxt_Total_Debito_Aberto.Size = New System.Drawing.Size(117, 21)
        Me.ctxt_Total_Debito_Aberto.TabIndex = 83
        Me.ctxt_Total_Debito_Aberto.Text = "0"
        Me.ctxt_Total_Debito_Aberto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ctxt_Total_Credito_Aberto
        '
        Me.ctxt_Total_Credito_Aberto.BackColor = System.Drawing.SystemColors.Control
        Me.ctxt_Total_Credito_Aberto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctxt_Total_Credito_Aberto.ForeColor = System.Drawing.Color.Green
        Me.ctxt_Total_Credito_Aberto.Location = New System.Drawing.Point(629, 312)
        Me.ctxt_Total_Credito_Aberto.MaxLength = 0
        Me.ctxt_Total_Credito_Aberto.Name = "ctxt_Total_Credito_Aberto"
        Me.ctxt_Total_Credito_Aberto.ReadOnly = True
        Me.ctxt_Total_Credito_Aberto.Size = New System.Drawing.Size(117, 21)
        Me.ctxt_Total_Credito_Aberto.TabIndex = 82
        Me.ctxt_Total_Credito_Aberto.Text = "0"
        Me.ctxt_Total_Credito_Aberto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 15)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Total Débitos Baixados:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 15)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Total Créditos Baixados:"
        '
        'dgFluxo_Caixa
        '
        Me.dgFluxo_Caixa.AllowUserToAddRows = False
        Me.dgFluxo_Caixa.AllowUserToDeleteRows = False
        Me.dgFluxo_Caixa.AllowUserToResizeColumns = False
        Me.dgFluxo_Caixa.AllowUserToResizeRows = False
        Me.dgFluxo_Caixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFluxo_Caixa.Location = New System.Drawing.Point(11, 46)
        Me.dgFluxo_Caixa.Name = "dgFluxo_Caixa"
        Me.dgFluxo_Caixa.RowHeadersVisible = False
        Me.dgFluxo_Caixa.Size = New System.Drawing.Size(735, 262)
        Me.dgFluxo_Caixa.TabIndex = 79
        '
        'ctxt_Total_Debito_Baixado
        '
        Me.ctxt_Total_Debito_Baixado.BackColor = System.Drawing.SystemColors.Control
        Me.ctxt_Total_Debito_Baixado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctxt_Total_Debito_Baixado.ForeColor = System.Drawing.Color.Black
        Me.ctxt_Total_Debito_Baixado.Location = New System.Drawing.Point(177, 339)
        Me.ctxt_Total_Debito_Baixado.MaxLength = 0
        Me.ctxt_Total_Debito_Baixado.Name = "ctxt_Total_Debito_Baixado"
        Me.ctxt_Total_Debito_Baixado.ReadOnly = True
        Me.ctxt_Total_Debito_Baixado.Size = New System.Drawing.Size(117, 21)
        Me.ctxt_Total_Debito_Baixado.TabIndex = 74
        Me.ctxt_Total_Debito_Baixado.Text = "0"
        Me.ctxt_Total_Debito_Baixado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ctxt_Total_Credito_Baixado
        '
        Me.ctxt_Total_Credito_Baixado.BackColor = System.Drawing.SystemColors.Control
        Me.ctxt_Total_Credito_Baixado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctxt_Total_Credito_Baixado.ForeColor = System.Drawing.Color.Black
        Me.ctxt_Total_Credito_Baixado.Location = New System.Drawing.Point(177, 312)
        Me.ctxt_Total_Credito_Baixado.MaxLength = 0
        Me.ctxt_Total_Credito_Baixado.Name = "ctxt_Total_Credito_Baixado"
        Me.ctxt_Total_Credito_Baixado.ReadOnly = True
        Me.ctxt_Total_Credito_Baixado.Size = New System.Drawing.Size(117, 21)
        Me.ctxt_Total_Credito_Baixado.TabIndex = 73
        Me.ctxt_Total_Credito_Baixado.Text = "0"
        Me.ctxt_Total_Credito_Baixado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIDMovFinanceiro
        '
        Me.txtIDMovFinanceiro.BackColor = System.Drawing.SystemColors.Control
        Me.txtIDMovFinanceiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDMovFinanceiro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIDMovFinanceiro.Location = New System.Drawing.Point(202, 20)
        Me.txtIDMovFinanceiro.Name = "txtIDMovFinanceiro"
        Me.txtIDMovFinanceiro.Size = New System.Drawing.Size(49, 20)
        Me.txtIDMovFinanceiro.TabIndex = 3
        Me.txtIDMovFinanceiro.Visible = False
        '
        'Frm_Fluxo_Caixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 499)
        Me.Controls.Add(Me.grpBotoes)
        Me.Controls.Add(Me.grpRegistro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Fluxo_Caixa"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fluxo de Caixa"
        Me.grpBotoes.ResumeLayout(False)
        Me.grpRegistro.ResumeLayout(False)
        Me.grpRegistro.PerformLayout()
        CType(Me.dgFluxo_Caixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents cmdIncluir As System.Windows.Forms.Button
    Friend WithEvents cmdExcluir As System.Windows.Forms.Button
    Friend WithEvents cmdBaixar As System.Windows.Forms.Button
    Friend WithEvents grpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents txtIDMovFinanceiro As System.Windows.Forms.TextBox
    Friend WithEvents ctxt_Total_Debito_Baixado As System.Windows.Forms.TextBox
    Friend WithEvents ctxt_Total_Credito_Baixado As System.Windows.Forms.TextBox
    Friend WithEvents cmdAlterar As System.Windows.Forms.Button
    Friend WithEvents dgFluxo_Caixa As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ctxt_Total_Debito_Aberto As TextBox
    Friend WithEvents ctxt_Total_Credito_Aberto As TextBox
End Class
