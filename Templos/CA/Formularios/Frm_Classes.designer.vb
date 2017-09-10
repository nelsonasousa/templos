<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Classes
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
        Me.cboIDProfessor4 = New System.Windows.Forms.ComboBox()
        Me.cboIDProfessor3 = New System.Windows.Forms.ComboBox()
        Me.cboIDProfessor2 = New System.Windows.Forms.ComboBox()
        Me.cboIDProfessor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEscola = New System.Windows.Forms.CheckBox()
        Me.txtDataCriacao = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIDClasse = New System.Windows.Forms.TextBox()
        Me.txtClasse = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpBotoes.SuspendLayout
        Me.grpRegistro.SuspendLayout
        Me.SuspendLayout
        '
        'lblDigita
        '
        Me.lblDigita.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDigita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDigita.ForeColor = System.Drawing.Color.Blue
        Me.lblDigita.Location = New System.Drawing.Point(0, 409)
        Me.lblDigita.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(603, 28)
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
        Me.grpBotoes.Location = New System.Drawing.Point(16, 293)
        Me.grpBotoes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpBotoes.Name = "grpBotoes"
        Me.grpBotoes.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpBotoes.Size = New System.Drawing.Size(568, 112)
        Me.grpBotoes.TabIndex = 1
        Me.grpBotoes.TabStop = false
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatAppearance.BorderSize = 0
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Red
        Me.cmdCancelar.Image = Global.Templos.My.Resources.Resources.limpar
        Me.cmdCancelar.Location = New System.Drawing.Point(332, 11)
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 94)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Limpar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = true
        '
        'cmdIncluir
        '
        Me.cmdIncluir.FlatAppearance.BorderSize = 0
        Me.cmdIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIncluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdIncluir.Image = Global.Templos.My.Resources.Resources.incluir
        Me.cmdIncluir.Location = New System.Drawing.Point(8, 11)
        Me.cmdIncluir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdIncluir.Name = "cmdIncluir"
        Me.cmdIncluir.Size = New System.Drawing.Size(100, 94)
        Me.cmdIncluir.TabIndex = 0
        Me.cmdIncluir.Text = "&Incluir"
        Me.cmdIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdIncluir.UseVisualStyleBackColor = true
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.FlatAppearance.BorderSize = 0
        Me.cmdPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdPesquisar.Image = Global.Templos.My.Resources.Resources.procura
        Me.cmdPesquisar.Location = New System.Drawing.Point(445, 11)
        Me.cmdPesquisar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(100, 94)
        Me.cmdPesquisar.TabIndex = 4
        Me.cmdPesquisar.Text = "&Pesquisar"
        Me.cmdPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPesquisar.UseVisualStyleBackColor = true
        '
        'cmdExcluir
        '
        Me.cmdExcluir.FlatAppearance.BorderSize = 0
        Me.cmdExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdExcluir.ForeColor = System.Drawing.Color.Red
        Me.cmdExcluir.Image = Global.Templos.My.Resources.Resources.excluir
        Me.cmdExcluir.Location = New System.Drawing.Point(224, 11)
        Me.cmdExcluir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(100, 94)
        Me.cmdExcluir.TabIndex = 2
        Me.cmdExcluir.Text = "&Excluir"
        Me.cmdExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExcluir.UseVisualStyleBackColor = true
        '
        'cmdAlterar
        '
        Me.cmdAlterar.FlatAppearance.BorderSize = 0
        Me.cmdAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdAlterar.Image = Global.Templos.My.Resources.Resources.alterar
        Me.cmdAlterar.Location = New System.Drawing.Point(116, 11)
        Me.cmdAlterar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.Size = New System.Drawing.Size(100, 94)
        Me.cmdAlterar.TabIndex = 1
        Me.cmdAlterar.Text = "&Alterar"
        Me.cmdAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAlterar.UseVisualStyleBackColor = true
        '
        'grpRegistro
        '
        Me.grpRegistro.Controls.Add(Me.cboIDProfessor4)
        Me.grpRegistro.Controls.Add(Me.cboIDProfessor3)
        Me.grpRegistro.Controls.Add(Me.cboIDProfessor2)
        Me.grpRegistro.Controls.Add(Me.cboIDProfessor)
        Me.grpRegistro.Controls.Add(Me.Label5)
        Me.grpRegistro.Controls.Add(Me.Label4)
        Me.grpRegistro.Controls.Add(Me.Label3)
        Me.grpRegistro.Controls.Add(Me.Label2)
        Me.grpRegistro.Controls.Add(Me.txtEscola)
        Me.grpRegistro.Controls.Add(Me.txtDataCriacao)
        Me.grpRegistro.Controls.Add(Me.Label6)
        Me.grpRegistro.Controls.Add(Me.txtIDClasse)
        Me.grpRegistro.Controls.Add(Me.txtClasse)
        Me.grpRegistro.Controls.Add(Me.Label1)
        Me.grpRegistro.Location = New System.Drawing.Point(16, 7)
        Me.grpRegistro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpRegistro.Name = "grpRegistro"
        Me.grpRegistro.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpRegistro.Size = New System.Drawing.Size(568, 278)
        Me.grpRegistro.TabIndex = 0
        Me.grpRegistro.TabStop = false
        Me.grpRegistro.Text = "Registro:"
        '
        'cboIDProfessor4
        '
        Me.cboIDProfessor4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboIDProfessor4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIDProfessor4.FormattingEnabled = true
        Me.cboIDProfessor4.Location = New System.Drawing.Point(123, 188)
        Me.cboIDProfessor4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboIDProfessor4.Name = "cboIDProfessor4"
        Me.cboIDProfessor4.Size = New System.Drawing.Size(347, 24)
        Me.cboIDProfessor4.TabIndex = 11
        '
        'cboIDProfessor3
        '
        Me.cboIDProfessor3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboIDProfessor3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIDProfessor3.FormattingEnabled = true
        Me.cboIDProfessor3.Location = New System.Drawing.Point(123, 155)
        Me.cboIDProfessor3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboIDProfessor3.Name = "cboIDProfessor3"
        Me.cboIDProfessor3.Size = New System.Drawing.Size(347, 24)
        Me.cboIDProfessor3.TabIndex = 9
        '
        'cboIDProfessor2
        '
        Me.cboIDProfessor2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboIDProfessor2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIDProfessor2.FormattingEnabled = true
        Me.cboIDProfessor2.Location = New System.Drawing.Point(123, 122)
        Me.cboIDProfessor2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboIDProfessor2.Name = "cboIDProfessor2"
        Me.cboIDProfessor2.Size = New System.Drawing.Size(347, 24)
        Me.cboIDProfessor2.TabIndex = 7
        '
        'cboIDProfessor
        '
        Me.cboIDProfessor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboIDProfessor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIDProfessor.FormattingEnabled = true
        Me.cboIDProfessor.Location = New System.Drawing.Point(123, 89)
        Me.cboIDProfessor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboIDProfessor.Name = "cboIDProfessor"
        Me.cboIDProfessor.Size = New System.Drawing.Size(347, 24)
        Me.cboIDProfessor.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(7, 192)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Responsável 4:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(7, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Responsável 3:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(7, 126)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Responsável 2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(7, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Responsável 1:"
        '
        'txtEscola
        '
        Me.txtEscola.AutoSize = true
        Me.txtEscola.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.txtEscola.Checked = true
        Me.txtEscola.CheckState = System.Windows.Forms.CheckState.Checked
        Me.txtEscola.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.txtEscola.Location = New System.Drawing.Point(123, 222)
        Me.txtEscola.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEscola.Name = "txtEscola"
        Me.txtEscola.Size = New System.Drawing.Size(332, 21)
        Me.txtEscola.TabIndex = 12
        Me.txtEscola.Text = "Sair na Lista de Chamada da Escola Dominical?"
        Me.txtEscola.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.txtEscola.UseVisualStyleBackColor = true
        '
        'txtDataCriacao
        '
        Me.txtDataCriacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataCriacao.Location = New System.Drawing.Point(123, 57)
        Me.txtDataCriacao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDataCriacao.Name = "txtDataCriacao"
        Me.txtDataCriacao.Size = New System.Drawing.Size(132, 22)
        Me.txtDataCriacao.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(19, 62)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Data Criação:"
        '
        'txtIDClasse
        '
        Me.txtIDClasse.BackColor = System.Drawing.SystemColors.Control
        Me.txtIDClasse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDClasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtIDClasse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIDClasse.Location = New System.Drawing.Point(391, 265)
        Me.txtIDClasse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIDClasse.Name = "txtIDClasse"
        Me.txtIDClasse.Size = New System.Drawing.Size(65, 16)
        Me.txtIDClasse.TabIndex = 13
        Me.txtIDClasse.Visible = false
        '
        'txtClasse
        '
        Me.txtClasse.Location = New System.Drawing.Point(123, 23)
        Me.txtClasse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClasse.MaxLength = 0
        Me.txtClasse.Name = "txtClasse"
        Me.txtClasse.Size = New System.Drawing.Size(347, 22)
        Me.txtClasse.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(60, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Classe:"
        '
        'Frm_Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 437)
        Me.Controls.Add(Me.lblDigita)
        Me.Controls.Add(Me.grpBotoes)
        Me.Controls.Add(Me.grpRegistro)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Frm_Classes"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Departamentos."
        Me.grpBotoes.ResumeLayout(false)
        Me.grpRegistro.ResumeLayout(false)
        Me.grpRegistro.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lblDigita As System.Windows.Forms.Label
    Friend WithEvents grpBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdIncluir As System.Windows.Forms.Button
    Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
    Friend WithEvents cmdExcluir As System.Windows.Forms.Button
    Friend WithEvents cmdAlterar As System.Windows.Forms.Button
    Friend WithEvents grpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents txtDataCriacao As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIDClasse As System.Windows.Forms.TextBox
    Friend WithEvents txtClasse As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEscola As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboIDProfessor As ComboBox
    Friend WithEvents cboIDProfessor4 As ComboBox
    Friend WithEvents cboIDProfessor3 As ComboBox
    Friend WithEvents cboIDProfessor2 As ComboBox
End Class
