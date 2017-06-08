
Public Class Frm_Usuarios

#Region "Código dos botões"
    Private Sub cmdIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIncluir.Click
        Dim incluir As New ClsUsuarios()

        If txtSenha.Text.Trim = Nothing Then
            MsgBox("Você precisa informar a senha.", 16, strSistema)
            Exit Sub
        End If

        If txtLogin.Text.Trim = Nothing Then
            MsgBox("Você precisa informar um login.", 16, strSistema)
            Exit Sub
        End If

        incluir.Usuario = txtLogin.Text
        incluir.Senha = GeraHash(txtSenha.Text)
        incluir.NomeUser = strNomeUser
        incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            incluir.Gravar()
        Catch ex As Exception
            MsgBox("Ao incluir no cadastro de usuário ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            incluir = Nothing
        End Try

        MsgBox("Registro efetuado com Sucesso", 64, strSistema)

        txtLogin.Focus()
    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        Dim alterar As New ClsUsuarios()

        If txtIDPessoa.Text.Trim = Nothing Then
            MsgBox("Você precisa selecionar uma pessoa.", 16, strSistema)
            Exit Sub
        End If
        If txtSenha.Text.Trim = Nothing Then
            MsgBox("Você precisa informar a senha.", 16, strSistema)
            Exit Sub
        End If
        If txtLogin.Text.Trim = Nothing Then
            MsgBox("Você precisa informar um login.", 16, strSistema)
            Exit Sub
        End If

        alterar.IDUsuario = txtIDPessoa.Text
        alterar.Usuario = txtLogin.Text
        alterar.Senha = GeraHash(txtSenha.Text)
        alterar.NomeUser = strNomeUser
        alterar.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            alterar.Editar()
        Catch ex As Exception
            MsgBox("Ao alterar no cadastro de usuário ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            alterar = Nothing
        End Try

        MsgBox("Registro Alterado com Sucesso", 64, strSistema)

        txtLogin.Focus()

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Limpar(grpRegistro)
        ParaGravar(grpBotoes)
        lblDigita.Text = "Informe os dados do novo registro"
        txtLogin.Focus()

    End Sub
    Private Sub cmdPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click
        Frm_Localizar.Text = "Pesquisa dados do cadastro de usuários."

        Frm_Localizar.Tag = "VwLocalizaUsuario" 'Aqui guardamos o nome da tabela

        Frm_Localizar.Show()

    End Sub

#End Region

#Region "Eventos dos campos"

    'Evento ao entrar no formulário
    Private Sub Frm_Usuarios_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Verifica se a string com o ID a ser localizado está carregada com valor > 0(zero).
        'Se valor for = 0(zero) mostra o form vazio.
        If strIDLocaliza > 0 Then

            Dim Localiza As New ClsUsuarios

            Localiza.IDUsuario = strIDLocaliza 'Passa o valor da string de localização para a classe.

            Localiza.Buscar() 'Chama o método de localização da classe.

            'Prenche os campos do form com os dados retonados pela localização
            txtIDPessoa.Text = Localiza.IDUsuario
            txtLogin.Text = Localiza.Usuario

            lblDigita.Text = "Última alteração feita por: " & Localiza.NomeUser & " em " & Localiza.DataDigita
            strIDLocaliza = 0 'Descarrega string de localização.
            ParaAlterar(grpBotoes)
        Else
            ParaGravar(grpBotoes)
            lblDigita.Text = "Informe os dados do novo registro"
        End If

    End Sub
    Private Sub Frm_Usuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal

        txtLogin.Focus()

    End Sub

    'Evento ao entrar no campo
    Private Sub txtLogin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLogin.GotFocus
        lblDigita.Text = "Informe o login do usuário."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtLogin.SelectionStart = 0
        Me.txtLogin.SelectionLength = Len(Me.txtLogin.Text) 'Tamanho campo

    End Sub

    Private Sub txtSenha_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSenha.GotFocus
        lblDigita.Text = "Informe a senha do usuário."
        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtSenha.SelectionStart = 0
        Me.txtSenha.SelectionLength = Len(Me.txtSenha.Text) 'Tamanho campo

    End Sub

    'Evento do teclado
    Private Sub txtLogin_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtLogin.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Down.
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtSenha.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtSenha.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtSenha.Focus()
        End If

    End Sub

    Private Sub txtSenha_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtSenha.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000


        If KeyCode = 13 Then
            Me.cmdAlterar.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.cmdAlterar.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtLogin.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.cmdAlterar.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtLogin.Focus()
        End If


    End Sub

#End Region
End Class