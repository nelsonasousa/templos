<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Lista_Presencas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_Classe = New Templos.ComboboxAutoComplete()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Data_Final = New System.Windows.Forms.DateTimePicker()
        Me.txt_Data_Inicial = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDigita = New System.Windows.Forms.Label()
        Me.btImprime = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_Classe)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_Data_Final)
        Me.GroupBox1.Controls.Add(Me.txt_Data_Inicial)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 103)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por:"
        '
        'cbo_Classe
        '
        Me.cbo_Classe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_Classe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Classe.FormattingEnabled = True
        Me.cbo_Classe.Location = New System.Drawing.Point(13, 42)
        Me.cbo_Classe.Name = "cbo_Classe"
        Me.cbo_Classe.Size = New System.Drawing.Size(165, 21)
        Me.cbo_Classe.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Dt. Final:"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Dt. Inicial:"
        '
        'txt_Data_Final
        '
        Me.txt_Data_Final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_Data_Final.Location = New System.Drawing.Point(290, 44)
        Me.txt_Data_Final.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Data_Final.Name = "txt_Data_Final"
        Me.txt_Data_Final.Size = New System.Drawing.Size(78, 20)
        Me.txt_Data_Final.TabIndex = 2
        Me.txt_Data_Final.Visible = False
        '
        'txt_Data_Inicial
        '
        Me.txt_Data_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_Data_Inicial.Location = New System.Drawing.Point(194, 44)
        Me.txt_Data_Inicial.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Data_Inicial.Name = "txt_Data_Inicial"
        Me.txt_Data_Inicial.Size = New System.Drawing.Size(78, 20)
        Me.txt_Data_Inicial.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Classe/Grupo:"
        '
        'lblDigita
        '
        Me.lblDigita.BackColor = System.Drawing.SystemColors.Control
        Me.lblDigita.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDigita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigita.ForeColor = System.Drawing.Color.Blue
        Me.lblDigita.Location = New System.Drawing.Point(0, 231)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(397, 25)
        Me.lblDigita.TabIndex = 2
        Me.lblDigita.Text = "123"
        Me.lblDigita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btImprime
        '
        Me.btImprime.FlatAppearance.BorderSize = 0
        Me.btImprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btImprime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImprime.Image = Global.Templos.My.Resources.Resources.impressora
        Me.btImprime.Location = New System.Drawing.Point(159, 144)
        Me.btImprime.Name = "btImprime"
        Me.btImprime.Size = New System.Drawing.Size(73, 75)
        Me.btImprime.TabIndex = 1
        Me.btImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btImprime.UseVisualStyleBackColor = True
        '
        'Frm_Lista_Presencas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 256)
        Me.Controls.Add(Me.lblDigita)
        Me.Controls.Add(Me.btImprime)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Frm_Lista_Presencas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listas de Presenças."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btImprime As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Data_Final As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Data_Inicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_Classe As Templos.ComboboxAutoComplete
    Friend WithEvents lblDigita As Label
End Class
