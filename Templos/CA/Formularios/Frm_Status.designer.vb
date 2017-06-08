<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Status
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
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdIncluir = New System.Windows.Forms.Button()
        Me.cmdPesquisar = New System.Windows.Forms.Button()
        Me.cmdExcluir = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.lblDigita = New System.Windows.Forms.Label()
        Me.grpRegistro = New System.Windows.Forms.GroupBox()
        Me.chk_Mostra = New System.Windows.Forms.CheckBox()
        Me.txtIDStatus = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpBotoes.SuspendLayout()
        Me.grpRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBotoes
        '
        Me.grpBotoes.Controls.Add(Me.cmdCancelar)
        Me.grpBotoes.Controls.Add(Me.cmdIncluir)
        Me.grpBotoes.Controls.Add(Me.cmdPesquisar)
        Me.grpBotoes.Controls.Add(Me.cmdExcluir)
        Me.grpBotoes.Controls.Add(Me.cmdAlterar)
        Me.grpBotoes.Location = New System.Drawing.Point(4, 110)
        Me.grpBotoes.Name = "grpBotoes"
        Me.grpBotoes.Size = New System.Drawing.Size(414, 91)
        Me.grpBotoes.TabIndex = 2
        Me.grpBotoes.TabStop = False
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
        Me.cmdPesquisar.Location = New System.Drawing.Point(330, 9)
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
        Me.lblDigita.Location = New System.Drawing.Point(0, 213)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(430, 23)
        Me.lblDigita.TabIndex = 3
        Me.lblDigita.Text = "Label5"
        Me.lblDigita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpRegistro
        '
        Me.grpRegistro.Controls.Add(Me.chk_Mostra)
        Me.grpRegistro.Controls.Add(Me.txtIDStatus)
        Me.grpRegistro.Controls.Add(Me.txtStatus)
        Me.grpRegistro.Controls.Add(Me.Label1)
        Me.grpRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRegistro.Location = New System.Drawing.Point(4, 12)
        Me.grpRegistro.Name = "grpRegistro"
        Me.grpRegistro.Size = New System.Drawing.Size(414, 92)
        Me.grpRegistro.TabIndex = 4
        Me.grpRegistro.TabStop = False
        Me.grpRegistro.Text = "Registro:"
        '
        'chk_Mostra
        '
        Me.chk_Mostra.AutoSize = True
        Me.chk_Mostra.Location = New System.Drawing.Point(78, 56)
        Me.chk_Mostra.Name = "chk_Mostra"
        Me.chk_Mostra.Size = New System.Drawing.Size(137, 19)
        Me.chk_Mostra.TabIndex = 9
        Me.chk_Mostra.Text = "Mostra Relatório."
        Me.chk_Mostra.UseVisualStyleBackColor = True
        '
        'txtIDStatus
        '
        Me.txtIDStatus.BackColor = System.Drawing.SystemColors.Control
        Me.txtIDStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDStatus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIDStatus.Location = New System.Drawing.Point(249, 10)
        Me.txtIDStatus.Name = "txtIDStatus"
        Me.txtIDStatus.Size = New System.Drawing.Size(49, 13)
        Me.txtIDStatus.TabIndex = 8
        Me.txtIDStatus.Visible = False
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(78, 29)
        Me.txtStatus.MaxLength = 0
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(318, 21)
        Me.txtStatus.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Status:"
        '
        'Frm_Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 236)
        Me.Controls.Add(Me.grpRegistro)
        Me.Controls.Add(Me.lblDigita)
        Me.Controls.Add(Me.grpBotoes)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Status"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Tipos ou Status de Membros."
        Me.grpBotoes.ResumeLayout(False)
        Me.grpRegistro.ResumeLayout(False)
        Me.grpRegistro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdIncluir As System.Windows.Forms.Button
    Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
    Friend WithEvents cmdExcluir As System.Windows.Forms.Button
    Friend WithEvents cmdAlterar As System.Windows.Forms.Button
    Friend WithEvents lblDigita As System.Windows.Forms.Label
    Friend WithEvents grpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents txtIDStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_Mostra As System.Windows.Forms.CheckBox
End Class
