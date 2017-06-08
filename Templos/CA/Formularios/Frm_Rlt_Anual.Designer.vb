<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Rlt_Anual
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
        Me.lblDigita = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btImprime = New System.Windows.Forms.Button()
        Me.cbo_Anos = New Templos.ComboboxAutoComplete()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDigita
        '
        Me.lblDigita.BackColor = System.Drawing.SystemColors.Control
        Me.lblDigita.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDigita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigita.ForeColor = System.Drawing.Color.Blue
        Me.lblDigita.Location = New System.Drawing.Point(0, 237)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(384, 25)
        Me.lblDigita.TabIndex = 3
        Me.lblDigita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_Anos)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 103)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Escolha o ano:"
        '
        'btImprime
        '
        Me.btImprime.FlatAppearance.BorderSize = 0
        Me.btImprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btImprime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImprime.Image = Global.Templos.My.Resources.Resources.impressora
        Me.btImprime.Location = New System.Drawing.Point(155, 163)
        Me.btImprime.Name = "btImprime"
        Me.btImprime.Size = New System.Drawing.Size(73, 75)
        Me.btImprime.TabIndex = 5
        Me.btImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btImprime.UseVisualStyleBackColor = True
        '
        'cbo_Anos
        '
        Me.cbo_Anos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_Anos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Anos.FormattingEnabled = True
        Me.cbo_Anos.Location = New System.Drawing.Point(13, 42)
        Me.cbo_Anos.Name = "cbo_Anos"
        Me.cbo_Anos.Size = New System.Drawing.Size(119, 21)
        Me.cbo_Anos.TabIndex = 13
        '
        'Frm_Rlt_Anual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 262)
        Me.Controls.Add(Me.btImprime)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDigita)
        Me.MaximizeBox = False
        Me.Name = "Frm_Rlt_Anual"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumo Anual Escola Dominical"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDigita As Label
    Friend WithEvents btImprime As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbo_Anos As ComboboxAutoComplete
End Class
