

'Variáveis do formulário
Public Class Frm_Login
    Private intTentativas As Integer = 1

    
    Private Sub CarregaUsuarios()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable


        ds = Busca.RetornarDataSet("Select IDUser,Usuario From Tbl_Usuarios order by Usuario")

        dt.Columns.Add("Usuario", GetType(System.String))
        dt.Columns.Add("IDUser", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Usuario") = dr("Usuario")
            NovaDr("IDUser") = dr("IDUser")
            dt.Rows.Add(NovaDr)
        Next

        'preenche a combobox com os nomes das entidades e seleciona o primeiro valor    
        With cboUsuario
            .DataSource = dt
            .DisplayMember = "Usuario"
            .ValueMember = "IDUser"
        End With


    End Sub
    Private Function VerificaSenha(ByVal strFiltro As String) As Boolean
        Dim senhaID As String = ""
        Dim Busca As New ClsDados
        Dim ds As New DataSet

        ds = Busca.RetornarDataSet("Select IDUser,Usuario,Senha From Tbl_Usuarios where IDUser=" & strFiltro & "")

        VerificaSenha = False

        If ds.Tables(0).Rows.Count > 0 Then
            senhaID = Trim(ds.Tables(0).Rows(0).Item(2))
        End If
        'Hash da senha 123
        'X6KF4b6+CmYj4zr8BKH71Q==           

        If GeraHash(txtSenha.Text).Equals(Trim(senhaID)) Then
            VerificaSenha = True
        End If

    End Function


    Private Sub Frm_Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblTentativas.Text = intTentativas & " Tentativas(5)"

       

        CarregaUsuarios()

    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click

        If VerificaSenha(Trim(cboUsuario.SelectedValue)) = True Then
            'Pega variáveis públicas mais utilizadas

            strNomeUser = Trim(cboUsuario.Text)
            strIDUser = cboUsuario.SelectedValue
            strDataSistema = Format(Date.Today, "dd/MM/yyyy")
            'Abre o form principal e esconde o login
            Frm_Principal.Show() '
            Me.Close()
        Else
            MessageBox.Show("Senha/Usuário Incorreto(s)", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtSenha.Text = ""
            intTentativas += 1
            lblTentativas.Text = intTentativas & " Tentativas(5)"
            Me.txtSenha.Focus()
            If intTentativas = 6 Then
                MessageBox.Show("Número máximo de tentativas excedido.", strSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End
            End If
        End If

    End Sub
    Private Sub btCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancela.Click
        Me.Close()

    End Sub

    Private Sub cboUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUsuario.GotFocus
        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.cboUsuario.SelectionStart = 0
        Me.cboUsuario.SelectionLength = Len(Me.cboUsuario.Text) 'Tamanho campo

        cboUsuario.DroppedDown = True

    End Sub
    Private Sub cboUsuario_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUsuario.SelectedValueChanged
        txtSenha.Focus()
    End Sub

    'Aqui começa a rotina de teclado
    Private Sub cboUsuario_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cboUsuario.KeyUp

        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtSenha.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtSenha.Focus()
        End If

    End Sub
    Private Sub txtSenha_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtSenha.KeyUp

        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.btOK.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.btOK.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.cboUsuario.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.btOK.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.cboUsuario.Focus()
        End If

    End Sub

End Class