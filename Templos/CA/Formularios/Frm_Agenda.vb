Public Class Frm_Agenda

#Region "Código dos botões"

    Private Sub cmdIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIncluir.Click

        Dim incluir As New clsAgenda()

        If txtNome.Text.Trim = Nothing Then
            MsgBox("Nome é necessário", 16, strSistema)
            Exit Sub
        End If

        'Carrega as variáveis da classe clsAgenda com os valores do formulário
        incluir.Nome = SmartCase(txtNome.Text)
        incluir.Telefone = mskTelefone.Text
        incluir.Obs = txtObs.Text.Trim
        incluir.NomeUser = strNomeUser
        incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            'Chama a rotina de gravação da classe
            incluir.Gravar()
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao incluir na agenda ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            incluir = Nothing
        End Try

        MsgBox("Registro Cadastrado com sucesso.", 64, strSistema)

        Limpar(grpRegistro)

        txtNome.Focus()

    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        Dim alterar As New clsAgenda()

        If txtIDAgenda.Text.Trim = Nothing Then
            MsgBox("Você precisa selecionar uma pessoa.", 16, strSistema)
            Exit Sub
        End If
        alterar.IDAgenda = txtIDAgenda.Text
        alterar.Nome = SmartCase(txtNome.Text)
        alterar.Telefone = mskTelefone.Text
        alterar.Obs = txtObs.Text.Trim
        alterar.NomeUser = strNomeUser
        alterar.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            alterar.Editar()
        Catch ex As Exception
            MsgBox("Ao alterar na agenda ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            alterar = Nothing
        End Try

        MsgBox("Registro Alterado com Sucesso", 64, strSistema)

        txtNome.Focus()

    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        Dim Excluir As New clsAgenda

        Excluir.IDAgenda = txtIDAgenda.Text

        Excluir.Nome = txtNome.Text

        Dim ret As Integer

        ret = MsgBox("Deseja excluir: " & Excluir.Nome & " ?", 36, strSistema)

        If ret = vbYes Then
            Excluir.Excluir()
            MsgBox("Registro Excluído com Sucesso", 64, strSistema)
        Else
            MsgBox("Operação Cancelada", 64, strSistema)
        End If

        Limpar(grpRegistro)

        txtNome.Focus()

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Limpar(grpRegistro)
        ParaGravar(grpBotoes)
        txtNome.Focus()

    End Sub
    Private Sub cmdPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click
        Frm_Localizar.Text = "Pesquisa dados da Agenda."

        Frm_Localizar.Tag = "VwLocalizaAgenda" 'Aqui guardamos o nome da tabela

        Frm_Localizar.Show()

    End Sub

#End Region


    'Evento ao entrar no formulário
    Private Sub Frm_Agenda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Verifica se a string com o ID a ser localizado está carregada com valor > 0(zero).
        'Se valor for = 0(zero) mostra o form vazio.
        If strIDLocaliza > 0 Then

            Dim Localiza As New clsAgenda

            Localiza.IDAgenda = strIDLocaliza 'Passa o valor da string de localização para a classe.

            Localiza.Buscar() 'Chama o método de localização da classe.

            'Prenche os campos do form com os dados retonados pela localização
            txtIDAgenda.Text = Localiza.IDAgenda
            txtNome.Text = Localiza.Nome
            mskTelefone.Text = Localiza.Telefone
            txtObs.Text = Localiza.Obs.Trim
            lblDigita.Text = "Última alteração feita por: " & Localiza.NomeUser & " em " & Localiza.DataDigita
            strIDLocaliza = 0 'Descarrega string de localização.
            ParaAlterar(grpBotoes)
        Else
            ParaGravar(grpBotoes)
        End If

    End Sub
    Private Sub Frm_Agenda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal

        txtNome.Focus()

    End Sub

    'Evento ao entrar no campo
    Private Sub txtNome_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNome.GotFocus
        lblDigita.Text = "Informe o nome da pessoa ou empresa."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtNome.SelectionStart = 0
        Me.txtNome.SelectionLength = Len(Me.txtNome.Text) 'Tamanho campo

    End Sub
    Private Sub mskTelefone_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskTelefone.GotFocus
        lblDigita.Text = "Informe o número do telefone."

        If mskTelefone.Text = "" Then
            'Coloca a máscara na caixa
            mskTelefone.Mask = "(##)-####-####"
        End If

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.mskTelefone.SelectionStart = 0
        Me.mskTelefone.SelectionLength = Len(Me.mskTelefone.Text) 'Tamanho campo

    End Sub
    Private Sub txtObs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObs.GotFocus
        lblDigita.Text = "Informe outras informações pertinentes ao registro."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtObs.SelectionStart = 0
        Me.txtObs.SelectionStart = Len(Me.txtObs.Text) 'Tamanho campo

    End Sub

    'Evento do teclado
    Private Sub txtNome_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNome.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.mskTelefone.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.mskTelefone.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.mskTelefone.Focus()
        End If
    End Sub
    Private Sub mskTelefone_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskTelefone.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtObs.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtObs.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtNome.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtObs.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtNome.Focus()
        End If
    End Sub
    Private Sub txtObs_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObs.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If cmdIncluir.Enabled = True Then
            If KeyCode = 13 Then
                Me.cmdIncluir.Focus()
            ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
                Me.cmdIncluir.Focus()
            ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
                Me.mskTelefone.Focus()
            End If

        ElseIf cmdAlterar.Enabled = True Then
            If KeyCode = 13 Then
                Me.cmdAlterar.Focus()
            ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
                Me.cmdAlterar.Focus()
            ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
                Me.mskTelefone.Focus()
            End If

        End If

    End Sub

    Private Sub txtNome_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNome.Validated
        txtNome.Text = SmartCase(txtNome.Text)
    End Sub
End Class
