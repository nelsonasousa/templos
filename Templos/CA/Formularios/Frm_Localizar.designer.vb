<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Localizar
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdFiltrar = New System.Windows.Forms.Button
        Me.txtBusca = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbParam = New System.Windows.Forms.ComboBox
        Me.cmbCampo = New System.Windows.Forms.ComboBox
        Me.Dgv1 = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdFiltrar)
        Me.GroupBox1.Controls.Add(Me.txtBusca)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbParam)
        Me.GroupBox1.Controls.Add(Me.cmbCampo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 82)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parâmetros da Consulta:"
        '
        'cmdFiltrar
        '
        Me.cmdFiltrar.FlatAppearance.BorderSize = 0
        Me.cmdFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFiltrar.Location = New System.Drawing.Point(457, 10)
        Me.cmdFiltrar.Name = "cmdFiltrar"
        Me.cmdFiltrar.Size = New System.Drawing.Size(68, 66)
        Me.cmdFiltrar.TabIndex = 3
        Me.cmdFiltrar.Text = "&Filtrar"
        Me.cmdFiltrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFiltrar.UseVisualStyleBackColor = True
        '
        'txtBusca
        '
        Me.txtBusca.BackColor = System.Drawing.SystemColors.Control
        Me.txtBusca.Location = New System.Drawing.Point(273, 39)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(128, 20)
        Me.txtBusca.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Valor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Parâmetro:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Campo:"
        '
        'cmbParam
        '
        Me.cmbParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParam.FormattingEnabled = True
        Me.cmbParam.Location = New System.Drawing.Point(146, 39)
        Me.cmbParam.Name = "cmbParam"
        Me.cmbParam.Size = New System.Drawing.Size(109, 21)
        Me.cmbParam.TabIndex = 1
        '
        'cmbCampo
        '
        Me.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCampo.FormattingEnabled = True
        Me.cmbCampo.Location = New System.Drawing.Point(15, 39)
        Me.cmbCampo.Name = "cmbCampo"
        Me.cmbCampo.Size = New System.Drawing.Size(109, 21)
        Me.cmbCampo.TabIndex = 0
        '
        'Dgv1
        '
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Location = New System.Drawing.Point(13, 91)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.ReadOnly = True
        Me.Dgv1.Size = New System.Drawing.Size(530, 290)
        Me.Dgv1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(258, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "*Dê 2(dois) cliques na linha para selecionar."
        '
        'Frm_Localizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 405)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Dgv1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Localizar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localiza"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBusca As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbParam As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCampo As System.Windows.Forms.ComboBox
    Friend WithEvents Dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdFiltrar As System.Windows.Forms.Button
End Class
