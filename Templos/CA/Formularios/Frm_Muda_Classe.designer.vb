<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Muda_Classe
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
        Me.grpAluno = New System.Windows.Forms.GroupBox()
        Me.cboClasses = New System.Windows.Forms.ComboBox()
        Me.btConfirma = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblClasse = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboAluno = New Templos.ComboboxAutoComplete()
        Me.grpAluno.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAluno
        '
        Me.grpAluno.Controls.Add(Me.cboAluno)
        Me.grpAluno.Controls.Add(Me.cboClasses)
        Me.grpAluno.Controls.Add(Me.btConfirma)
        Me.grpAluno.Controls.Add(Me.Label2)
        Me.grpAluno.Controls.Add(Me.lblClasse)
        Me.grpAluno.Controls.Add(Me.Label1)
        Me.grpAluno.Location = New System.Drawing.Point(12, 12)
        Me.grpAluno.Name = "grpAluno"
        Me.grpAluno.Size = New System.Drawing.Size(344, 242)
        Me.grpAluno.TabIndex = 0
        Me.grpAluno.TabStop = False
        Me.grpAluno.Text = "Escolha o Aluno:"
        '
        'cboClasses
        '
        Me.cboClasses.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboClasses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClasses.FormattingEnabled = True
        Me.cboClasses.Location = New System.Drawing.Point(6, 158)
        Me.cboClasses.Name = "cboClasses"
        Me.cboClasses.Size = New System.Drawing.Size(325, 21)
        Me.cboClasses.TabIndex = 4
        '
        'btConfirma
        '
        Me.btConfirma.Location = New System.Drawing.Point(121, 197)
        Me.btConfirma.Name = "btConfirma"
        Me.btConfirma.Size = New System.Drawing.Size(75, 23)
        Me.btConfirma.TabIndex = 5
        Me.btConfirma.Text = "Confirma"
        Me.btConfirma.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Transferí-lo para a classe:"
        '
        'lblClasse
        '
        Me.lblClasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClasse.Location = New System.Drawing.Point(47, 96)
        Me.lblClasse.Name = "lblClasse"
        Me.lblClasse.Size = New System.Drawing.Size(234, 13)
        Me.lblClasse.TabIndex = 2
        Me.lblClasse.Text = "_"
        Me.lblClasse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "O aluno está matriculado/frequentando a classe:"
        '
        'cboAluno
        '
        Me.cboAluno.FormattingEnabled = True
        Me.cboAluno.Location = New System.Drawing.Point(9, 38)
        Me.cboAluno.Name = "cboAluno"
        Me.cboAluno.Size = New System.Drawing.Size(322, 21)
        Me.cboAluno.TabIndex = 0
        '
        'Frm_Muda_Classe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 266)
        Me.Controls.Add(Me.grpAluno)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Muda_Classe"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Muda o aluno de classe."
        Me.grpAluno.ResumeLayout(False)
        Me.grpAluno.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpAluno As System.Windows.Forms.GroupBox
    Friend WithEvents lblClasse As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btConfirma As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboClasses As System.Windows.Forms.ComboBox
    Friend WithEvents cboAluno As ComboboxAutoComplete
End Class
