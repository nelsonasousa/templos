<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Permissoes
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGFormsSistema = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DGFormsUser = New System.Windows.Forms.DataGridView
        Me.btPermitir = New System.Windows.Forms.Button
        Me.btBloquear = New System.Windows.Forms.Button
        Me.txtQtdeForms = New System.Windows.Forms.TextBox
        Me.txtQtdeFormsUser = New System.Windows.Forms.TextBox
        Me.cboIDVendedor = New Templos.ComboboxAutoComplete
        CType(Me.DGFormsSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGFormsUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Escolha o funcionário:"
        '
        'DGFormsSistema
        '
        Me.DGFormsSistema.AllowUserToAddRows = False
        Me.DGFormsSistema.AllowUserToDeleteRows = False
        Me.DGFormsSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGFormsSistema.ColumnHeadersVisible = False
        Me.DGFormsSistema.Location = New System.Drawing.Point(12, 100)
        Me.DGFormsSistema.Name = "DGFormsSistema"
        Me.DGFormsSistema.Size = New System.Drawing.Size(270, 210)
        Me.DGFormsSistema.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Formulários do Sistema:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(358, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Permissões do Usuário:"
        '
        'DGFormsUser
        '
        Me.DGFormsUser.AllowUserToAddRows = False
        Me.DGFormsUser.AllowUserToDeleteRows = False
        Me.DGFormsUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGFormsUser.ColumnHeadersVisible = False
        Me.DGFormsUser.Location = New System.Drawing.Point(358, 100)
        Me.DGFormsUser.Name = "DGFormsUser"
        Me.DGFormsUser.Size = New System.Drawing.Size(270, 210)
        Me.DGFormsUser.TabIndex = 4
        '
        'btPermitir
        '
        Me.btPermitir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPermitir.Location = New System.Drawing.Point(298, 165)
        Me.btPermitir.Name = "btPermitir"
        Me.btPermitir.Size = New System.Drawing.Size(47, 38)
        Me.btPermitir.TabIndex = 6
        Me.btPermitir.Text = ">>>"
        Me.btPermitir.UseVisualStyleBackColor = True
        '
        'btBloquear
        '
        Me.btBloquear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBloquear.Location = New System.Drawing.Point(298, 226)
        Me.btBloquear.Name = "btBloquear"
        Me.btBloquear.Size = New System.Drawing.Size(47, 38)
        Me.btBloquear.TabIndex = 7
        Me.btBloquear.Text = "<<<"
        Me.btBloquear.UseVisualStyleBackColor = True
        '
        'txtQtdeForms
        '
        Me.txtQtdeForms.BackColor = System.Drawing.SystemColors.Control
        Me.txtQtdeForms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdeForms.Location = New System.Drawing.Point(175, 77)
        Me.txtQtdeForms.Name = "txtQtdeForms"
        Me.txtQtdeForms.ReadOnly = True
        Me.txtQtdeForms.Size = New System.Drawing.Size(38, 21)
        Me.txtQtdeForms.TabIndex = 8
        Me.txtQtdeForms.TabStop = False
        '
        'txtQtdeFormsUser
        '
        Me.txtQtdeFormsUser.BackColor = System.Drawing.SystemColors.Control
        Me.txtQtdeFormsUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdeFormsUser.Location = New System.Drawing.Point(524, 77)
        Me.txtQtdeFormsUser.Name = "txtQtdeFormsUser"
        Me.txtQtdeFormsUser.ReadOnly = True
        Me.txtQtdeFormsUser.Size = New System.Drawing.Size(38, 21)
        Me.txtQtdeFormsUser.TabIndex = 9
        Me.txtQtdeFormsUser.TabStop = False
        '
        'cboIDVendedor
        '
        Me.cboIDVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIDVendedor.FormattingEnabled = True
        Me.cboIDVendedor.Location = New System.Drawing.Point(290, 29)
        Me.cboIDVendedor.Name = "cboIDVendedor"
        Me.cboIDVendedor.Size = New System.Drawing.Size(157, 23)
        Me.cboIDVendedor.TabIndex = 0
        '
        'Frm_Permissoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(642, 329)
        Me.Controls.Add(Me.txtQtdeFormsUser)
        Me.Controls.Add(Me.txtQtdeForms)
        Me.Controls.Add(Me.btBloquear)
        Me.Controls.Add(Me.btPermitir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGFormsUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGFormsSistema)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboIDVendedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Permissoes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Permissões de Acesso."
        CType(Me.DGFormsSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGFormsUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboIDVendedor As Templos.ComboboxAutoComplete
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGFormsSistema As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DGFormsUser As System.Windows.Forms.DataGridView
    Friend WithEvents btPermitir As System.Windows.Forms.Button
    Friend WithEvents btBloquear As System.Windows.Forms.Button
    Friend WithEvents txtQtdeForms As System.Windows.Forms.TextBox
    Friend WithEvents txtQtdeFormsUser As System.Windows.Forms.TextBox
End Class
