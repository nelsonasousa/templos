<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Eventos
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
        Me.grpBotoes = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdIncluir = New System.Windows.Forms.Button()
        Me.cmdPesquisar = New System.Windows.Forms.Button()
        Me.cmdExcluir = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.lblDigita = New System.Windows.Forms.Label()
        Me.grpRegistro = New System.Windows.Forms.GroupBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPalestrante = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOrganizador = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHoraRealizacao = New System.Windows.Forms.MaskedTextBox()
        Me.txtDataRealizacao = New System.Windows.Forms.DateTimePicker()
        Me.txtIDEvento = New System.Windows.Forms.TextBox()
        Me.txtEvento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpBotoes.SuspendLayout()
        Me.grpRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBotoes
        '
        Me.grpBotoes.Controls.Add(Me.cmdCancelar)
        Me.grpBotoes.Controls.Add(Me.cmdIncluir)
        Me.grpBotoes.Controls.Add(Me.cmdPesquisar)
        Me.grpBotoes.Controls.Add(Me.cmdExcluir)
        Me.grpBotoes.Controls.Add(Me.cmdAlterar)
        Me.grpBotoes.Location = New System.Drawing.Point(7, 265)
        Me.grpBotoes.Name = "grpBotoes"
        Me.grpBotoes.Size = New System.Drawing.Size(439, 91)
        Me.grpBotoes.TabIndex = 4
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
        Me.cmdPesquisar.Location = New System.Drawing.Point(330, 9)
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
        'lblDigita
        '
        Me.lblDigita.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDigita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigita.ForeColor = System.Drawing.Color.Blue
        Me.lblDigita.Location = New System.Drawing.Point(0, 359)
        Me.lblDigita.Name = "lblDigita"
        Me.lblDigita.Size = New System.Drawing.Size(453, 23)
        Me.lblDigita.TabIndex = 5
        Me.lblDigita.Text = "Label5"
        Me.lblDigita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpRegistro
        '
        Me.grpRegistro.Controls.Add(Me.txtObs)
        Me.grpRegistro.Controls.Add(Me.Label6)
        Me.grpRegistro.Controls.Add(Me.Label5)
        Me.grpRegistro.Controls.Add(Me.txtPalestrante)
        Me.grpRegistro.Controls.Add(Me.Label4)
        Me.grpRegistro.Controls.Add(Me.txtOrganizador)
        Me.grpRegistro.Controls.Add(Me.Label3)
        Me.grpRegistro.Controls.Add(Me.txtHoraRealizacao)
        Me.grpRegistro.Controls.Add(Me.txtDataRealizacao)
        Me.grpRegistro.Controls.Add(Me.txtIDEvento)
        Me.grpRegistro.Controls.Add(Me.txtEvento)
        Me.grpRegistro.Controls.Add(Me.Label2)
        Me.grpRegistro.Controls.Add(Me.Label1)
        Me.grpRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRegistro.Location = New System.Drawing.Point(7, 6)
        Me.grpRegistro.Name = "grpRegistro"
        Me.grpRegistro.Size = New System.Drawing.Size(439, 253)
        Me.grpRegistro.TabIndex = 3
        Me.grpRegistro.TabStop = False
        Me.grpRegistro.Text = "Registro:"
        '
        'txtObs
        '
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.Location = New System.Drawing.Point(109, 135)
        Me.txtObs.MaxLength = 0
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(318, 104)
        Me.txtObs.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Observação:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(314, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Hora:"
        '
        'txtPalestrante
        '
        Me.txtPalestrante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPalestrante.Location = New System.Drawing.Point(109, 108)
        Me.txtPalestrante.MaxLength = 0
        Me.txtPalestrante.Name = "txtPalestrante"
        Me.txtPalestrante.Size = New System.Drawing.Size(318, 21)
        Me.txtPalestrante.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Palestrante:"
        '
        'txtOrganizador
        '
        Me.txtOrganizador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrganizador.Location = New System.Drawing.Point(109, 81)
        Me.txtOrganizador.MaxLength = 0
        Me.txtOrganizador.Name = "txtOrganizador"
        Me.txtOrganizador.Size = New System.Drawing.Size(318, 21)
        Me.txtOrganizador.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Responsável:"
        '
        'txtHoraRealizacao
        '
        Me.txtHoraRealizacao.Location = New System.Drawing.Point(363, 54)
        Me.txtHoraRealizacao.Mask = "00:00"
        Me.txtHoraRealizacao.Name = "txtHoraRealizacao"
        Me.txtHoraRealizacao.Size = New System.Drawing.Size(64, 21)
        Me.txtHoraRealizacao.TabIndex = 2
        Me.txtHoraRealizacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHoraRealizacao.ValidatingType = GetType(Date)
        '
        'txtDataRealizacao
        '
        Me.txtDataRealizacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataRealizacao.Location = New System.Drawing.Point(109, 54)
        Me.txtDataRealizacao.Name = "txtDataRealizacao"
        Me.txtDataRealizacao.Size = New System.Drawing.Size(99, 21)
        Me.txtDataRealizacao.TabIndex = 1
        '
        'txtIDEvento
        '
        Me.txtIDEvento.BackColor = System.Drawing.SystemColors.Control
        Me.txtIDEvento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIDEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDEvento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIDEvento.Location = New System.Drawing.Point(249, 10)
        Me.txtIDEvento.Name = "txtIDEvento"
        Me.txtIDEvento.Size = New System.Drawing.Size(49, 13)
        Me.txtIDEvento.TabIndex = 8
        Me.txtIDEvento.Visible = False
        '
        'txtEvento
        '
        Me.txtEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvento.Location = New System.Drawing.Point(109, 26)
        Me.txtEvento.MaxLength = 0
        Me.txtEvento.Name = "txtEvento"
        Me.txtEvento.Size = New System.Drawing.Size(318, 21)
        Me.txtEvento.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Data:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Evento:"
        '
        'Frm_Eventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 382)
        Me.Controls.Add(Me.grpBotoes)
        Me.Controls.Add(Me.lblDigita)
        Me.Controls.Add(Me.grpRegistro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Eventos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda de Eventos."
        Me.grpBotoes.ResumeLayout(False)
        Me.grpRegistro.ResumeLayout(False)
        Me.grpRegistro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdIncluir As System.Windows.Forms.Button
    Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
    Friend WithEvents cmdExcluir As System.Windows.Forms.Button
    Friend WithEvents cmdAlterar As System.Windows.Forms.Button
    Friend WithEvents lblDigita As System.Windows.Forms.Label
    Friend WithEvents grpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents txtHoraRealizacao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDataRealizacao As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtIDEvento As System.Windows.Forms.TextBox
    Friend WithEvents txtEvento As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPalestrante As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOrganizador As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
