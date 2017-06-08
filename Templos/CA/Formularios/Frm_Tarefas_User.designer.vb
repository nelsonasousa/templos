<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Tarefas_User
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btMarcarTodos = New System.Windows.Forms.Button
        Me.btMarcarUm = New System.Windows.Forms.Button
        Me.lblRecado = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGRecadosRecebidos = New System.Windows.Forms.DataGridView
        Me.Label5 = New System.Windows.Forms.Label
        Me.btEnviar = New System.Windows.Forms.Button
        Me.txtRecado = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCumprirAte = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboIDPessoa = New Templos.ComboboxAutoComplete
        Me.Label2 = New System.Windows.Forms.Label
        Me.DGRecadosEnviados = New System.Windows.Forms.DataGridView
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DGRecadosRecebidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGRecadosEnviados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btMarcarTodos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btMarcarUm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblRecado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DGRecadosRecebidos)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btEnviar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtRecado)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtCumprirAte)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cboIDPessoa)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DGRecadosEnviados)
        Me.SplitContainer1.Size = New System.Drawing.Size(671, 385)
        Me.SplitContainer1.SplitterDistance = 328
        Me.SplitContainer1.TabIndex = 14
        '
        'btMarcarTodos
        '
        Me.btMarcarTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMarcarTodos.Location = New System.Drawing.Point(12, 330)
        Me.btMarcarTodos.Name = "btMarcarTodos"
        Me.btMarcarTodos.Size = New System.Drawing.Size(86, 44)
        Me.btMarcarTodos.TabIndex = 21
        Me.btMarcarTodos.Text = "Baixar &Todos"
        Me.btMarcarTodos.UseVisualStyleBackColor = True
        '
        'btMarcarUm
        '
        Me.btMarcarUm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMarcarUm.Location = New System.Drawing.Point(231, 330)
        Me.btMarcarUm.Name = "btMarcarUm"
        Me.btMarcarUm.Size = New System.Drawing.Size(76, 44)
        Me.btMarcarUm.TabIndex = 20
        Me.btMarcarUm.Text = "Baixar &Este"
        Me.btMarcarUm.UseVisualStyleBackColor = True
        '
        'lblRecado
        '
        Me.lblRecado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRecado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecado.ForeColor = System.Drawing.Color.Blue
        Me.lblRecado.Location = New System.Drawing.Point(12, 144)
        Me.lblRecado.Name = "lblRecado"
        Me.lblRecado.Size = New System.Drawing.Size(295, 183)
        Me.lblRecado.TabIndex = 17
        Me.lblRecado.Text = "Clique acima para ver o recado."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "RECADOS PARA VOCÊ"
        '
        'DGRecadosRecebidos
        '
        Me.DGRecadosRecebidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRecadosRecebidos.Location = New System.Drawing.Point(12, 33)
        Me.DGRecadosRecebidos.Name = "DGRecadosRecebidos"
        Me.DGRecadosRecebidos.Size = New System.Drawing.Size(295, 108)
        Me.DGRecadosRecebidos.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Recado:"
        '
        'btEnviar
        '
        Me.btEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEnviar.Location = New System.Drawing.Point(144, 330)
        Me.btEnviar.Name = "btEnviar"
        Me.btEnviar.Size = New System.Drawing.Size(76, 44)
        Me.btEnviar.TabIndex = 36
        Me.btEnviar.Text = "E&nviar"
        Me.btEnviar.UseVisualStyleBackColor = True
        '
        'txtRecado
        '
        Me.txtRecado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecado.Location = New System.Drawing.Point(18, 209)
        Me.txtRecado.Multiline = True
        Me.txtRecado.Name = "txtRecado"
        Me.txtRecado.Size = New System.Drawing.Size(307, 115)
        Me.txtRecado.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Cumprir Até:"
        '
        'txtCumprirAte
        '
        Me.txtCumprirAte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtCumprirAte.Location = New System.Drawing.Point(238, 161)
        Me.txtCumprirAte.Name = "txtCumprirAte"
        Me.txtCumprirAte.Size = New System.Drawing.Size(87, 20)
        Me.txtCumprirAte.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Enviar para:"
        '
        'cboIDPessoa
        '
        Me.cboIDPessoa.FormattingEnabled = True
        Me.cboIDPessoa.Location = New System.Drawing.Point(18, 160)
        Me.cboIDPessoa.Name = "cboIDPessoa"
        Me.cboIDPessoa.Size = New System.Drawing.Size(202, 21)
        Me.cboIDPessoa.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "RECADOS ENVIADOS SEM RESPOSTA"
        '
        'DGRecadosEnviados
        '
        Me.DGRecadosEnviados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRecadosEnviados.Location = New System.Drawing.Point(18, 33)
        Me.DGRecadosEnviados.Name = "DGRecadosEnviados"
        Me.DGRecadosEnviados.Size = New System.Drawing.Size(307, 108)
        Me.DGRecadosEnviados.TabIndex = 29
        '
        'Frm_Tarefas_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 385)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Tarefas_User"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manutenção de recados e tarefas."
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DGRecadosRecebidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGRecadosEnviados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btMarcarTodos As System.Windows.Forms.Button
    Friend WithEvents btMarcarUm As System.Windows.Forms.Button
    Friend WithEvents lblRecado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGRecadosRecebidos As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btEnviar As System.Windows.Forms.Button
    Friend WithEvents txtRecado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCumprirAte As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboIDPessoa As Templos.ComboboxAutoComplete
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGRecadosEnviados As System.Windows.Forms.DataGridView
End Class
