<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Lista_Membros
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
        Me.rd_Classe = New System.Windows.Forms.RadioButton()
        Me.rd_Todos = New System.Windows.Forms.RadioButton()
        Me.cbo_Classe = New System.Windows.Forms.ComboBox()
        Me.btImprime = New System.Windows.Forms.Button()
        Me.lblDigita = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rd_Classe)
        Me.GroupBox1.Controls.Add(Me.rd_Todos)
        Me.GroupBox1.Controls.Add(Me.cbo_Classe)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por:"
        '
        'rd_Classe
        '
        Me.rd_Classe.AutoSize = True
        Me.rd_Classe.Location = New System.Drawing.Point(6, 64)
        Me.rd_Classe.Name = "rd_Classe"
        Me.rd_Classe.Size = New System.Drawing.Size(90, 17)
        Me.rd_Classe.TabIndex = 2
        Me.rd_Classe.Text = "Classe/Grupo"
        Me.rd_Classe.UseVisualStyleBackColor = True
        '
        'rd_Todos
        '
        Me.rd_Todos.AutoSize = True
        Me.rd_Todos.Checked = True
        Me.rd_Todos.Location = New System.Drawing.Point(6, 30)
        Me.rd_Todos.Name = "rd_Todos"
        Me.rd_Todos.Size = New System.Drawing.Size(55, 17)
        Me.rd_Todos.TabIndex = 1
        Me.rd_Todos.TabStop = True
        Me.rd_Todos.Text = "Todos"
        Me.rd_Todos.UseVisualStyleBackColor = True
        '
        'cbo_Classe
        '
        Me.cbo_Classe.FormattingEnabled = True
        Me.cbo_Classe.Location = New System.Drawing.Point(115, 64)
        Me.cbo_Classe.Name = "cbo_Classe"
        Me.cbo_Classe.Size = New System.Drawing.Size(170, 21)
        Me.cbo_Classe.TabIndex = 0
        Me.cbo_Classe.Visible = False
        '
        'btImprime
        '
        Me.btImprime.FlatAppearance.BorderSize = 0
        Me.btImprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btImprime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImprime.Image = Global.Templos.My.Resources.Resources.impressora
        Me.btImprime.Location = New System.Drawing.Point(158, 122)
        Me.btImprime.Name = "btImprime"
        Me.btImprime.Size = New System.Drawing.Size(73, 75)
        Me.btImprime.TabIndex = 17
        Me.btImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btImprime.UseVisualStyleBackColor = True
        '
        'lblDigita
        '
        Me.lblDigita.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDigita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigita.ForeColor = System.Drawing.Color.Blue
        Me.lblDigita.Location = New System.Drawing.Point(0, 227)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(396, 23)
        Me.lblDigita.TabIndex = 18
        Me.lblDigita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Lista_Membros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 250)
        Me.Controls.Add(Me.lblDigita)
        Me.Controls.Add(Me.btImprime)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Lista_Membros"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listagem de Pessoas."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_Classe As System.Windows.Forms.ComboBox
    Friend WithEvents btImprime As System.Windows.Forms.Button
    Friend WithEvents lblDigita As System.Windows.Forms.Label
    Friend WithEvents rd_Classe As System.Windows.Forms.RadioButton
    Friend WithEvents rd_Todos As System.Windows.Forms.RadioButton
End Class
