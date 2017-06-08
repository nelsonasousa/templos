<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Bkp
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
        Me.btBkp = New System.Windows.Forms.Button
        Me.FDialogBkp = New System.Windows.Forms.FolderBrowserDialog
        Me.txtLocal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpData = New System.Windows.Forms.GroupBox
        Me.CBHora = New System.Windows.Forms.CheckBox
        Me.CBData = New System.Windows.Forms.CheckBox
        Me.btLocal = New System.Windows.Forms.Button
        Me.grpData.SuspendLayout()
        Me.SuspendLayout()
        '
        'btBkp
        '
        Me.btBkp.Location = New System.Drawing.Point(154, 209)
        Me.btBkp.Name = "btBkp"
        Me.btBkp.Size = New System.Drawing.Size(105, 45)
        Me.btBkp.TabIndex = 0
        Me.btBkp.Text = "Criar Cópia"
        Me.btBkp.UseVisualStyleBackColor = True
        '
        'txtLocal
        '
        Me.txtLocal.Location = New System.Drawing.Point(45, 154)
        Me.txtLocal.Multiline = True
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.ReadOnly = True
        Me.txtLocal.Size = New System.Drawing.Size(302, 40)
        Me.txtLocal.TabIndex = 1
        Me.txtLocal.Text = "E:\"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pasta Destino e Nome do Arquivo de Backup:"
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.CBHora)
        Me.grpData.Controls.Add(Me.CBData)
        Me.grpData.Location = New System.Drawing.Point(45, 12)
        Me.grpData.Name = "grpData"
        Me.grpData.Size = New System.Drawing.Size(329, 80)
        Me.grpData.TabIndex = 5
        Me.grpData.TabStop = False
        Me.grpData.Text = "Acrescentar ao nome:"
        '
        'CBHora
        '
        Me.CBHora.AutoSize = True
        Me.CBHora.Location = New System.Drawing.Point(274, 30)
        Me.CBHora.Name = "CBHora"
        Me.CBHora.Size = New System.Drawing.Size(49, 17)
        Me.CBHora.TabIndex = 6
        Me.CBHora.Text = "Hora"
        Me.CBHora.UseVisualStyleBackColor = True
        '
        'CBData
        '
        Me.CBData.AutoSize = True
        Me.CBData.Checked = True
        Me.CBData.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBData.Location = New System.Drawing.Point(15, 30)
        Me.CBData.Name = "CBData"
        Me.CBData.Size = New System.Drawing.Size(49, 17)
        Me.CBData.TabIndex = 5
        Me.CBData.Text = "Data"
        Me.CBData.UseVisualStyleBackColor = True
        '
        'btLocal
        '
        Me.btLocal.Location = New System.Drawing.Point(353, 154)
        Me.btLocal.Name = "btLocal"
        Me.btLocal.Size = New System.Drawing.Size(39, 40)
        Me.btLocal.TabIndex = 7
        Me.btLocal.Text = "..."
        Me.btLocal.UseVisualStyleBackColor = True
        '
        'Frm_Bkp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 266)
        Me.Controls.Add(Me.btLocal)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLocal)
        Me.Controls.Add(Me.btBkp)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Bkp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup da Base de Dados."
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btBkp As System.Windows.Forms.Button
    Friend WithEvents FDialogBkp As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtLocal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpData As System.Windows.Forms.GroupBox
    Friend WithEvents CBHora As System.Windows.Forms.CheckBox
    Friend WithEvents CBData As System.Windows.Forms.CheckBox
    Friend WithEvents btLocal As System.Windows.Forms.Button
End Class
