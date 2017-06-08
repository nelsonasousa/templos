<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ocorrencias
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
        Me.txtIDOcorrencia = New System.Windows.Forms.TextBox()
        Me.txtOcorrencia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdIncluir = New System.Windows.Forms.Button()
        Me.grpBotoes = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdPesquisar = New System.Windows.Forms.Button()
        Me.cmdExcluir = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.lblDigita = New System.Windows.Forms.Label()
        Me.grpRegistro.SuspendLayout()
        Me.grpBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpRegistro
        '
        Me.grpRegistro.Controls.Add(Me.txtIDOcorrencia)
        Me.grpRegistro.Controls.Add(Me.txtOcorrencia)
        Me.grpRegistro.Controls.Add(Me.Label1)
        Me.grpRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRegistro.Location = New System.Drawing.Point(10, 12)
        Me.grpRegistro.Name = "grpRegistro"
        Me.grpRegistro.Size = New System.Drawing.Size(440, 88)
        Me.grpRegistro.TabIndex = 2
        Me.grpRegistro.TabStop = False
        Me.grpRegistro.Text = "Registro:"
        '
        'txtIDOcorrencia
        '
        Me.txtIDOcorrencia.BackColor = System.Drawing.SystemColors.Control
        Me.txtIDOcorrencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDOcorrencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDOcorrencia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIDOcorrencia.Location = New System.Drawing.Point(249, 10)
        Me.txtIDOcorrencia.Name = "txtIDOcorrencia"
        Me.txtIDOcorrencia.Size = New System.Drawing.Size(49, 13)
        Me.txtIDOcorrencia.TabIndex = 8
        Me.txtIDOcorrencia.Visible = False
        '
        'txtOcorrencia
        '
        Me.txtOcorrencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcorrencia.Location = New System.Drawing.Point(110, 26)
        Me.txtOcorrencia.MaxLength = 0
        Me.txtOcorrencia.Name = "txtOcorrencia"
        Me.txtOcorrencia.Size = New System.Drawing.Size(318, 21)
        Me.txtOcorrencia.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ocorrência:"
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
        'grpBotoes
        '
        Me.grpBotoes.Controls.Add(Me.cmdCancelar)
        Me.grpBotoes.Controls.Add(Me.cmdIncluir)
        Me.grpBotoes.Controls.Add(Me.cmdPesquisar)
        Me.grpBotoes.Controls.Add(Me.cmdExcluir)
        Me.grpBotoes.Controls.Add(Me.cmdAlterar)
        Me.grpBotoes.Location = New System.Drawing.Point(10, 106)
        Me.grpBotoes.Name = "grpBotoes"
        Me.grpBotoes.Size = New System.Drawing.Size(440, 91)
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
        Me.cmdCancelar.Location = New System.Drawing.Point(259, 9)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 76)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Limpar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.FlatAppearance.BorderSize = 0
        Me.cmdPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPesquisar.Image = Global.Templos.My.Resources.Resources.procura
        Me.cmdPesquisar.Location = New System.Drawing.Point(353, 9)
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
        'lblDigita
        '
        Me.lblDigita.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDigita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigita.ForeColor = System.Drawing.Color.Blue
        Me.lblDigita.Location = New System.Drawing.Point(0, 212)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(462, 23)
        Me.lblDigita.TabIndex = 4
        Me.lblDigita.Text = "Label5"
        Me.lblDigita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Ocorrencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 235)
        Me.Controls.Add(Me.lblDigita)
        Me.Controls.Add(Me.grpRegistro)
        Me.Controls.Add(Me.grpBotoes)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Ocorrencias"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Ocorrências."
        Me.grpRegistro.ResumeLayout(False)
        Me.grpRegistro.PerformLayout()
        Me.grpBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents txtIDOcorrencia As System.Windows.Forms.TextBox
    Friend WithEvents txtOcorrencia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdIncluir As System.Windows.Forms.Button
    Friend WithEvents grpBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
    Friend WithEvents cmdExcluir As System.Windows.Forms.Button
    Friend WithEvents cmdAlterar As System.Windows.Forms.Button
    Friend WithEvents lblDigita As System.Windows.Forms.Label
End Class
