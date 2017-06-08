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
        Me.cboIDProfessor = New System.Windows.Forms.ComboBox()
        Me.cboIDProfessor2 = New System.Windows.Forms.ComboBox()
        Me.cboIDProfessor3 = New System.Windows.Forms.ComboBox()
        Me.cboIDProfessor4 = New System.Windows.Forms.ComboBox()
        Me.grpBotoes.SuspendLayout()
        Me.grpRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDigita
        '
        Me.lblDigita.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDigita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigita.ForeColor = System.Drawing.Color.Blue
        Me.lblDigita.Location = New System.Drawing.Point(0, 332)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(452, 23)
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
        Me.grpBotoes.Location = New System.Drawing.Point(12, 238)
        Me.grpBotoes.Name = "grpBotoes"
        Me.grpBotoes.Size = New System.Drawing.Size(426, 91)
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
        Me.cmdPesquisar.Location = New System.Drawing.Point(334, 9)
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
        Me.grpRegistro.Location = New System.Drawing.Point(12, 6)
        Me.grpRegistro.Name = "grpRegistro"
        Me.grpRegistro.Size = New System.Drawing.Size(426, 226)
        Me.grpRegistro.TabIndex = 0
        Me.grpRegistro.TabStop = False
        Me.grpRegistro.Text = "Registro:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Responsável 4:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Responsável 3:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Responsável 2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Responsável 1:"
        '
        'txtEscola
        '
        Me.txtEscola.AutoSize = True
        Me.txtEscola.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.txtEscola.Checked = True
        Me.txtEscola.CheckState = System.Windows.Forms.CheckState.Checked
        Me.txtEscola.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.txtEscola.Location = New System.Drawing.Point(92, 180)
        Me.txtEscola.Name = "txtEscola"
        Me.txtEscola.Size = New System.Drawing.Size(113, 17)
        Me.txtEscola.TabIndex = 12
        Me.txtEscola.Text = "Escola Dominical?"
        Me.txtEscola.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.txtEscola.UseVisualStyleBackColor = True
        '
        'txtDataCriacao
        '
        Me.txtDataCriacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataCriacao.Location = New System.Drawing.Point(92, 46)
        Me.txtDataCriacao.Name = "txtDataCriacao"
        Me.txtDataCriacao.Size = New System.Drawing.Size(100, 20)
        Me.txtDataCriacao.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Data Criação:"
        '
        'txtIDClasse
        '
        Me.txtIDClasse.BackColor = System.Drawing.SystemColors.Control
        Me.txtIDClasse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDClasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDClasse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIDClasse.Location = New System.Drawing.Point(293, 215)
        Me.txtIDClasse.Name = "txtIDClasse"
        Me.txtIDClasse.Size = New System.Drawing.Size(49, 13)
        Me.txtIDClasse.TabIndex = 13
        Me.txtIDClasse.Visible = False
        '
        'txtClasse
        '
        Me.txtClasse.Location = New System.Drawing.Point(92, 19)
        Me.txtClasse.MaxLength = 0
        Me.txtClasse.Name = "txtClasse"
        Me.txtClasse.Size = New System.Drawing.Size(261, 20)
        Me.txtClasse.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Classe:"
        '
        'cboIDProfessor
        '
        Me.cboIDProfessor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboIDProfessor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIDProfessor.FormattingEnabled = True
        Me.cboIDProfessor.Location = New System.Drawing.Point(92, 72)
        Me.cboIDProfessor.Name = "cboIDProfessor"
        Me.cboIDProfessor.Size = New System.Drawing.Size(261, 21)
        Me.cboIDProfessor.TabIndex = 5
        '
        'cboIDProfessor2
        '
        Me.cboIDProfessor2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboIDProfessor2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIDProfessor2.FormattingEnabled = True
        Me.cboIDProfessor2.Location = New System.Drawing.Point(92, 99)
        Me.cboIDProfessor2.Name = "cboIDProfessor2"
        Me.cboIDProfessor2.Size = New System.Drawing.Size(261, 21)
        Me.cboIDProfessor2.TabIndex = 7
        '
        'cboIDProfessor3
        '
        Me.cboIDProfessor3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboIDProfessor3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIDProfessor3.FormattingEnabled = True
        Me.cboIDProfessor3.Location = New System.Drawing.Point(92, 126)
        Me.cboIDProfessor3.Name = "cboIDProfessor3"
        Me.cboIDProfessor3.Size = New System.Drawing.Size(261, 21)
        Me.cboIDProfessor3.TabIndex = 9
        '
        'cboIDProfessor4
        '
        Me.cboIDProfessor4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboIDProfessor4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIDProfessor4.FormattingEnabled = True
        Me.cboIDProfessor4.Location = New System.Drawing.Point(92, 153)
        Me.cboIDProfessor4.Name = "cboIDProfessor4"
        Me.cboIDProfessor4.Size = New System.Drawing.Size(261, 21)
        Me.cboIDProfessor4.TabIndex = 11
        '
        'Frm_Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 355)
        Me.Controls.Add(Me.lblDigita)
        Me.Controls.Add(Me.grpBotoes)
        Me.Controls.Add(Me.grpRegistro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Classes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Departamentos."
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
