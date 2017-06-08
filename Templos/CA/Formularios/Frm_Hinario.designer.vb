<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Hinario
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
        Me.txt_Hino = New System.Windows.Forms.TextBox
        Me.bt_Abrir = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.grp_Filtro = New System.Windows.Forms.GroupBox
        Me.rd_Hinos = New System.Windows.Forms.RadioButton
        Me.rd_Louvores = New System.Windows.Forms.RadioButton
        Me.rd_Adoracao = New System.Windows.Forms.RadioButton
        Me.rd_Infantis = New System.Windows.Forms.RadioButton
        Me.rd_Todos = New System.Windows.Forms.RadioButton
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Hino
        '
        Me.txt_Hino.Location = New System.Drawing.Point(161, 351)
        Me.txt_Hino.Name = "txt_Hino"
        Me.txt_Hino.Size = New System.Drawing.Size(242, 20)
        Me.txt_Hino.TabIndex = 0
        '
        'bt_Abrir
        '
        Me.bt_Abrir.Location = New System.Drawing.Point(409, 349)
        Me.bt_Abrir.Name = "bt_Abrir"
        Me.bt_Abrir.Size = New System.Drawing.Size(60, 23)
        Me.bt_Abrir.TabIndex = 1
        Me.bt_Abrir.Text = "Abrir"
        Me.bt_Abrir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(161, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(308, 317)
        Me.DataGridView1.TabIndex = 2
        '
        'grp_Filtro
        '
        Me.grp_Filtro.Controls.Add(Me.rd_Todos)
        Me.grp_Filtro.Controls.Add(Me.rd_Infantis)
        Me.grp_Filtro.Controls.Add(Me.rd_Adoracao)
        Me.grp_Filtro.Controls.Add(Me.rd_Louvores)
        Me.grp_Filtro.Controls.Add(Me.rd_Hinos)
        Me.grp_Filtro.Location = New System.Drawing.Point(12, 12)
        Me.grp_Filtro.Name = "grp_Filtro"
        Me.grp_Filtro.Size = New System.Drawing.Size(124, 330)
        Me.grp_Filtro.TabIndex = 3
        Me.grp_Filtro.TabStop = False
        Me.grp_Filtro.Text = "Filtrar"
        '
        'rd_Hinos
        '
        Me.rd_Hinos.AutoSize = True
        Me.rd_Hinos.Location = New System.Drawing.Point(6, 92)
        Me.rd_Hinos.Name = "rd_Hinos"
        Me.rd_Hinos.Size = New System.Drawing.Size(105, 17)
        Me.rd_Hinos.TabIndex = 0
        Me.rd_Hinos.TabStop = True
        Me.rd_Hinos.Text = "Hinos e Cânticos"
        Me.rd_Hinos.UseVisualStyleBackColor = True
        '
        'rd_Louvores
        '
        Me.rd_Louvores.AutoSize = True
        Me.rd_Louvores.Location = New System.Drawing.Point(6, 115)
        Me.rd_Louvores.Name = "rd_Louvores"
        Me.rd_Louvores.Size = New System.Drawing.Size(69, 17)
        Me.rd_Louvores.TabIndex = 1
        Me.rd_Louvores.TabStop = True
        Me.rd_Louvores.Text = "Louvores"
        Me.rd_Louvores.UseVisualStyleBackColor = True
        '
        'rd_Adoracao
        '
        Me.rd_Adoracao.AutoSize = True
        Me.rd_Adoracao.Location = New System.Drawing.Point(6, 138)
        Me.rd_Adoracao.Name = "rd_Adoracao"
        Me.rd_Adoracao.Size = New System.Drawing.Size(71, 17)
        Me.rd_Adoracao.TabIndex = 2
        Me.rd_Adoracao.TabStop = True
        Me.rd_Adoracao.Text = "Adoração"
        Me.rd_Adoracao.UseVisualStyleBackColor = True
        '
        'rd_Infantis
        '
        Me.rd_Infantis.AutoSize = True
        Me.rd_Infantis.Location = New System.Drawing.Point(6, 161)
        Me.rd_Infantis.Name = "rd_Infantis"
        Me.rd_Infantis.Size = New System.Drawing.Size(59, 17)
        Me.rd_Infantis.TabIndex = 3
        Me.rd_Infantis.TabStop = True
        Me.rd_Infantis.Text = "Infantis"
        Me.rd_Infantis.UseVisualStyleBackColor = True
        '
        'rd_Todos
        '
        Me.rd_Todos.AutoSize = True
        Me.rd_Todos.Location = New System.Drawing.Point(8, 37)
        Me.rd_Todos.Name = "rd_Todos"
        Me.rd_Todos.Size = New System.Drawing.Size(55, 17)
        Me.rd_Todos.TabIndex = 4
        Me.rd_Todos.TabStop = True
        Me.rd_Todos.Text = "Todos"
        Me.rd_Todos.UseVisualStyleBackColor = True
        '
        'Frm_Hinario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 383)
        Me.Controls.Add(Me.grp_Filtro)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bt_Abrir)
        Me.Controls.Add(Me.txt_Hino)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Hinario"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hinos e Cãnticos."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Filtro.ResumeLayout(False)
        Me.grp_Filtro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Hino As System.Windows.Forms.TextBox
    Friend WithEvents bt_Abrir As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents grp_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents rd_Louvores As System.Windows.Forms.RadioButton
    Friend WithEvents rd_Hinos As System.Windows.Forms.RadioButton
    Friend WithEvents rd_Infantis As System.Windows.Forms.RadioButton
    Friend WithEvents rd_Adoracao As System.Windows.Forms.RadioButton
    Friend WithEvents rd_Todos As System.Windows.Forms.RadioButton
End Class
