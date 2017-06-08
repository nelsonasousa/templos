<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Empresta_Livro
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
        Me.GrpEmprestar = New System.Windows.Forms.GroupBox()
        Me.btEmprestar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGEmprestimos = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btImprimir = New System.Windows.Forms.Button()
        Me.cboIDPessoa = New Templos.ComboboxAutoComplete()
        Me.cboIDLivro = New Templos.ComboboxAutoComplete()
        Me.GrpEmprestar.SuspendLayout()
        CType(Me.DGEmprestimos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpEmprestar
        '
        Me.GrpEmprestar.Controls.Add(Me.btEmprestar)
        Me.GrpEmprestar.Controls.Add(Me.Label2)
        Me.GrpEmprestar.Controls.Add(Me.Label1)
        Me.GrpEmprestar.Controls.Add(Me.cboIDPessoa)
        Me.GrpEmprestar.Controls.Add(Me.cboIDLivro)
        Me.GrpEmprestar.Location = New System.Drawing.Point(12, 12)
        Me.GrpEmprestar.Name = "GrpEmprestar"
        Me.GrpEmprestar.Size = New System.Drawing.Size(525, 76)
        Me.GrpEmprestar.TabIndex = 0
        Me.GrpEmprestar.TabStop = False
        Me.GrpEmprestar.Text = "Emprestimo"
        '
        'btEmprestar
        '
        Me.btEmprestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEmprestar.Location = New System.Drawing.Point(444, 35)
        Me.btEmprestar.Name = "btEmprestar"
        Me.btEmprestar.Size = New System.Drawing.Size(75, 35)
        Me.btEmprestar.TabIndex = 4
        Me.btEmprestar.Text = "Emprestar"
        Me.btEmprestar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Emprestar para:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Livro:"
        '
        'DGEmprestimos
        '
        Me.DGEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGEmprestimos.Location = New System.Drawing.Point(12, 115)
        Me.DGEmprestimos.Name = "DGEmprestimos"
        Me.DGEmprestimos.RowHeadersVisible = False
        Me.DGEmprestimos.Size = New System.Drawing.Size(525, 220)
        Me.DGEmprestimos.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dê 2 cliques no livro para devolver."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Livros Emprestados:"
        '
        'btImprimir
        '
        Me.btImprimir.FlatAppearance.BorderSize = 0
        Me.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImprimir.Image = Global.Templos.My.Resources.Resources.impressora
        Me.btImprimir.Location = New System.Drawing.Point(256, 341)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(68, 74)
        Me.btImprimir.TabIndex = 16
        Me.btImprimir.Text = "Imprimir"
        Me.btImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btImprimir.UseVisualStyleBackColor = True
        '
        'cboIDPessoa
        '
        Me.cboIDPessoa.FormattingEnabled = True
        Me.cboIDPessoa.Location = New System.Drawing.Point(225, 49)
        Me.cboIDPessoa.Name = "cboIDPessoa"
        Me.cboIDPessoa.Size = New System.Drawing.Size(205, 21)
        Me.cboIDPessoa.TabIndex = 1
        '
        'cboIDLivro
        '
        Me.cboIDLivro.FormattingEnabled = True
        Me.cboIDLivro.Location = New System.Drawing.Point(6, 49)
        Me.cboIDLivro.Name = "cboIDLivro"
        Me.cboIDLivro.Size = New System.Drawing.Size(213, 21)
        Me.cboIDLivro.TabIndex = 0
        '
        'Frm_Empresta_Livro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 421)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGEmprestimos)
        Me.Controls.Add(Me.GrpEmprestar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Empresta_Livro"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empréstimo/Devolução de Livros"
        Me.GrpEmprestar.ResumeLayout(False)
        Me.GrpEmprestar.PerformLayout()
        CType(Me.DGEmprestimos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpEmprestar As System.Windows.Forms.GroupBox
    Friend WithEvents cboIDLivro As Templos.ComboboxAutoComplete
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboIDPessoa As Templos.ComboboxAutoComplete
    Friend WithEvents btEmprestar As System.Windows.Forms.Button
    Friend WithEvents DGEmprestimos As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btImprimir As System.Windows.Forms.Button
End Class
