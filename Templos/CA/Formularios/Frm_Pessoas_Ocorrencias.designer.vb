<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Pessoas_Ocorrencias
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
        Me.grpRegistro = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDataOcorrencia = New System.Windows.Forms.DateTimePicker()
        Me.btInserir = New System.Windows.Forms.Button()
        Me.lblDigita = New System.Windows.Forms.Label()
        Me.dg_Ocorrencias = New System.Windows.Forms.DataGridView()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cboOcorrencia = New Templos.ComboboxAutoComplete()
        Me.cboPessoa = New Templos.ComboboxAutoComplete()
        Me.grpRegistro.SuspendLayout()
        CType(Me.dg_Ocorrencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpRegistro
        '
        Me.grpRegistro.Controls.Add(Me.Label3)
        Me.grpRegistro.Controls.Add(Me.Label2)
        Me.grpRegistro.Controls.Add(Me.Label1)
        Me.grpRegistro.Controls.Add(Me.txtDataOcorrencia)
        Me.grpRegistro.Controls.Add(Me.btInserir)
        Me.grpRegistro.Controls.Add(Me.cboOcorrencia)
        Me.grpRegistro.Controls.Add(Me.cboPessoa)
        Me.grpRegistro.Location = New System.Drawing.Point(12, 9)
        Me.grpRegistro.Name = "grpRegistro"
        Me.grpRegistro.Size = New System.Drawing.Size(319, 205)
        Me.grpRegistro.TabIndex = 0
        Me.grpRegistro.TabStop = False
        Me.grpRegistro.Text = "Inserir Ocorrência:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Data:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ocorrência:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Membro:"
        '
        'txtDataOcorrencia
        '
        Me.txtDataOcorrencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataOcorrencia.Location = New System.Drawing.Point(86, 117)
        Me.txtDataOcorrencia.Name = "txtDataOcorrencia"
        Me.txtDataOcorrencia.Size = New System.Drawing.Size(97, 20)
        Me.txtDataOcorrencia.TabIndex = 3
        '
        'btInserir
        '
        Me.btInserir.Location = New System.Drawing.Point(123, 157)
        Me.btInserir.Name = "btInserir"
        Me.btInserir.Size = New System.Drawing.Size(75, 23)
        Me.btInserir.TabIndex = 2
        Me.btInserir.Text = "Inserir"
        Me.btInserir.UseVisualStyleBackColor = True
        '
        'lblDigita
        '
        Me.lblDigita.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDigita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigita.ForeColor = System.Drawing.Color.Blue
        Me.lblDigita.Location = New System.Drawing.Point(0, 304)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(657, 23)
        Me.lblDigita.TabIndex = 3
        Me.lblDigita.Text = "Label5"
        Me.lblDigita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dg_Ocorrencias
        '
        Me.dg_Ocorrencias.AllowUserToAddRows = False
        Me.dg_Ocorrencias.AllowUserToDeleteRows = False
        Me.dg_Ocorrencias.AllowUserToResizeColumns = False
        Me.dg_Ocorrencias.AllowUserToResizeRows = False
        Me.dg_Ocorrencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Ocorrencias.Location = New System.Drawing.Point(337, 21)
        Me.dg_Ocorrencias.Name = "dg_Ocorrencias"
        Me.dg_Ocorrencias.Size = New System.Drawing.Size(308, 192)
        Me.dg_Ocorrencias.TabIndex = 4
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatAppearance.BorderSize = 0
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Red
        Me.cmdCancelar.Image = Global.Templos.My.Resources.Resources.limpar
        Me.cmdCancelar.Location = New System.Drawing.Point(17, 220)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 76)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Limpar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cboOcorrencia
        '
        Me.cboOcorrencia.FormattingEnabled = True
        Me.cboOcorrencia.Location = New System.Drawing.Point(86, 79)
        Me.cboOcorrencia.Name = "cboOcorrencia"
        Me.cboOcorrencia.Size = New System.Drawing.Size(217, 21)
        Me.cboOcorrencia.TabIndex = 1
        '
        'cboPessoa
        '
        Me.cboPessoa.FormattingEnabled = True
        Me.cboPessoa.Location = New System.Drawing.Point(86, 43)
        Me.cboPessoa.Name = "cboPessoa"
        Me.cboPessoa.Size = New System.Drawing.Size(217, 21)
        Me.cboPessoa.TabIndex = 0
        '
        'Frm_Pessoas_Ocorrencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 327)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.dg_Ocorrencias)
        Me.Controls.Add(Me.lblDigita)
        Me.Controls.Add(Me.grpRegistro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Pessoas_Ocorrencias"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pessoas x Ocorrências"
        Me.grpRegistro.ResumeLayout(False)
        Me.grpRegistro.PerformLayout()
        CType(Me.dg_Ocorrencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents cboPessoa As Templos.ComboboxAutoComplete
    Friend WithEvents txtDataOcorrencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents btInserir As System.Windows.Forms.Button
    Friend WithEvents cboOcorrencia As Templos.ComboboxAutoComplete
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDigita As System.Windows.Forms.Label
    Friend WithEvents dg_Ocorrencias As System.Windows.Forms.DataGridView
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
