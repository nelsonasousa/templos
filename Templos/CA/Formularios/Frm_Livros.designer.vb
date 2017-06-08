<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Livros
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
        Me.lblDigita = New System.Windows.Forms.Label()
        Me.grpBotoes = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdIncluir = New System.Windows.Forms.Button()
        Me.cmdPesquisar = New System.Windows.Forms.Button()
        Me.cmdExcluir = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.grpRegistro = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtSinopse = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDataCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIDLivro = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpBotoes.SuspendLayout()
        Me.grpRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDigita
        '
        Me.lblDigita.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDigita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigita.ForeColor = System.Drawing.Color.Blue
        Me.lblDigita.Location = New System.Drawing.Point(0, 363)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(455, 23)
        Me.lblDigita.TabIndex = 9
        Me.lblDigita.Text = "Label5"
        Me.lblDigita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpBotoes
        '
        Me.grpBotoes.Controls.Add(Me.cmdCancelar)
        Me.grpBotoes.Controls.Add(Me.cmdIncluir)
        Me.grpBotoes.Controls.Add(Me.cmdPesquisar)
        Me.grpBotoes.Controls.Add(Me.cmdExcluir)
        Me.grpBotoes.Controls.Add(Me.cmdAlterar)
        Me.grpBotoes.Location = New System.Drawing.Point(12, 267)
        Me.grpBotoes.Name = "grpBotoes"
        Me.grpBotoes.Size = New System.Drawing.Size(426, 91)
        Me.grpBotoes.TabIndex = 8
        Me.grpBotoes.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatAppearance.BorderSize = 0
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Red
        Me.cmdCancelar.Image = Global.Templos.My.Resources.Resources.limpar
        Me.cmdCancelar.Location = New System.Drawing.Point(249, 9)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 76)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Limpar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdIncluir
        '
        Me.cmdIncluir.FlatAppearance.BorderSize = 0
        Me.cmdIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIncluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIncluir.Image = Global.Templos.My.Resources.Resources.incluir
        Me.cmdIncluir.Location = New System.Drawing.Point(6, 9)
        Me.cmdIncluir.Name = "cmdIncluir"
        Me.cmdIncluir.Size = New System.Drawing.Size(75, 76)
        Me.cmdIncluir.TabIndex = 0
        Me.cmdIncluir.Text = "&Incluir"
        Me.cmdIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdIncluir.UseVisualStyleBackColor = True
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.FlatAppearance.BorderSize = 0
        Me.cmdPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPesquisar.Image = Global.Templos.My.Resources.Resources.procura
        Me.cmdPesquisar.Location = New System.Drawing.Point(334, 9)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 76)
        Me.cmdPesquisar.TabIndex = 4
        Me.cmdPesquisar.Text = "&Pesquisar"
        Me.cmdPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'cmdExcluir
        '
        Me.cmdExcluir.FlatAppearance.BorderSize = 0
        Me.cmdExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExcluir.ForeColor = System.Drawing.Color.Red
        Me.cmdExcluir.Image = Global.Templos.My.Resources.Resources.excluir
        Me.cmdExcluir.Location = New System.Drawing.Point(168, 9)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(75, 76)
        Me.cmdExcluir.TabIndex = 2
        Me.cmdExcluir.Text = "&Excluir"
        Me.cmdExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExcluir.UseVisualStyleBackColor = True
        '
        'cmdAlterar
        '
        Me.cmdAlterar.FlatAppearance.BorderSize = 0
        Me.cmdAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAlterar.Image = Global.Templos.My.Resources.Resources.alterar
        Me.cmdAlterar.Location = New System.Drawing.Point(87, 9)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.Size = New System.Drawing.Size(75, 76)
        Me.cmdAlterar.TabIndex = 1
        Me.cmdAlterar.Text = "&Alterar"
        Me.cmdAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAlterar.UseVisualStyleBackColor = True
        '
        'grpRegistro
        '
        Me.grpRegistro.Controls.Add(Me.Label4)
        Me.grpRegistro.Controls.Add(Me.txtObs)
        Me.grpRegistro.Controls.Add(Me.txtSinopse)
        Me.grpRegistro.Controls.Add(Me.Label3)
        Me.grpRegistro.Controls.Add(Me.txtAutor)
        Me.grpRegistro.Controls.Add(Me.Label2)
        Me.grpRegistro.Controls.Add(Me.txtDataCompra)
        Me.grpRegistro.Controls.Add(Me.Label6)
        Me.grpRegistro.Controls.Add(Me.txtIDLivro)
        Me.grpRegistro.Controls.Add(Me.txtTitulo)
        Me.grpRegistro.Controls.Add(Me.Label1)
        Me.grpRegistro.Location = New System.Drawing.Point(12, 3)
        Me.grpRegistro.Name = "grpRegistro"
        Me.grpRegistro.Size = New System.Drawing.Size(426, 258)
        Me.grpRegistro.TabIndex = 7
        Me.grpRegistro.TabStop = False
        Me.grpRegistro.Text = "Registro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Obs.:"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(92, 192)
        Me.txtObs.MaxLength = 0
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(317, 54)
        Me.txtObs.TabIndex = 4
        '
        'txtSinopse
        '
        Me.txtSinopse.Location = New System.Drawing.Point(92, 71)
        Me.txtSinopse.MaxLength = 0
        Me.txtSinopse.Multiline = True
        Me.txtSinopse.Name = "txtSinopse"
        Me.txtSinopse.Size = New System.Drawing.Size(317, 89)
        Me.txtSinopse.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Sinopse:"
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(92, 45)
        Me.txtAutor.MaxLength = 0
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(317, 20)
        Me.txtAutor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Autor:"
        '
        'txtDataCompra
        '
        Me.txtDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataCompra.Location = New System.Drawing.Point(92, 166)
        Me.txtDataCompra.Name = "txtDataCompra"
        Me.txtDataCompra.Size = New System.Drawing.Size(100, 20)
        Me.txtDataCompra.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Data Compra:"
        '
        'txtIDLivro
        '
        Me.txtIDLivro.BackColor = System.Drawing.SystemColors.Control
        Me.txtIDLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDLivro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDLivro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIDLivro.Location = New System.Drawing.Point(293, 107)
        Me.txtIDLivro.Name = "txtIDLivro"
        Me.txtIDLivro.Size = New System.Drawing.Size(49, 13)
        Me.txtIDLivro.TabIndex = 7
        Me.txtIDLivro.Visible = False
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(92, 19)
        Me.txtTitulo.MaxLength = 0
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(317, 20)
        Me.txtTitulo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Título:"
        '
        'Frm_Livros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 386)
        Me.Controls.Add(Me.lblDigita)
        Me.Controls.Add(Me.grpBotoes)
        Me.Controls.Add(Me.grpRegistro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Livros"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Livros."
        Me.grpBotoes.ResumeLayout(False)
        Me.grpRegistro.ResumeLayout(False)
        Me.grpRegistro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDigita As System.Windows.Forms.Label
    Friend WithEvents grpBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdIncluir As System.Windows.Forms.Button
    Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
    Friend WithEvents cmdExcluir As System.Windows.Forms.Button
    Friend WithEvents cmdAlterar As System.Windows.Forms.Button
    Friend WithEvents grpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents txtSinopse As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDataCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIDLivro As System.Windows.Forms.TextBox
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
End Class
