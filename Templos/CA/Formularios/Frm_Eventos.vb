Public Class Frm_Eventos
#Region "Código dos botões"

    Private Sub cmdIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIncluir.Click

        Dim incluir As New ClsEventos()

        If txtEvento.Text.Trim = Nothing Or txtEvento.Text = "" Then
            MsgBox("Nome do evento é necessário", 16, strSistema)
            Exit Sub
        End If

        'Carrega as variáveis da classe clsEventos com os valores do formulário
        incluir.Evento = SmartCase(txtEvento.Text)
        incluir.DataRealizacao = Format(txtDataRealizacao.Value, "yyyy/MM/dd")
        incluir.HoraRealizacao = txtHoraRealizacao.Text
        incluir.Organizador = SmartCase(txtOrganizador.Text)
        incluir.Palestrante = SmartCase(txtPalestrante.Text)
        incluir.Observacao = txtObs.Text
        incluir.NomeUser = strNomeUser
        incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            'Chama a rotina de gravação da classe
            incluir.Gravar()
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao incluir um evento ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            incluir = Nothing
        End Try

        MsgBox("Registro Cadastrado com sucesso.", 64, strSistema)

        Limpar(grpRegistro)

        txtEvento.Focus()

    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        Dim alterar As New ClsEventos()

        If txtIDEvento.Text.Trim = Nothing Then
            MsgBox("Você precisa selecionar um evento.", 16, strSistema)
            Exit Sub
        End If

        If txtEvento.Text.Trim = Nothing Or txtEvento.Text = "" Then
            MsgBox("Nome do evento é necessário", 16, strSistema)
            Exit Sub
        End If

        alterar.IDEvento = txtIDEvento.Text
        alterar.Evento = SmartCase(txtEvento.Text)
        alterar.DataRealizacao = Format(txtDataRealizacao.Value, "yyyy/MM/dd")
        alterar.HoraRealizacao = txtHoraRealizacao.Text
        alterar.Organizador = SmartCase(txtOrganizador.Text)
        alterar.Palestrante = SmartCase(txtPalestrante.Text)
        alterar.Observacao = txtObs.Text
        alterar.NomeUser = strNomeUser
        alterar.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            alterar.Editar()
        Catch ex As Exception
            MsgBox("Ao alterar um evento ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            alterar = Nothing
        End Try

        MsgBox("Registro Alterado com Sucesso", 64, strSistema)

        txtEvento.Focus()

    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        Dim Excluir As New ClsEventos

        Excluir.IDEvento = txtIDEvento.Text

        Excluir.Evento = txtEvento.Text

        Dim ret As Integer

        ret = MsgBox("Deseja excluir: " & Excluir.Evento & " ?", 36, strSistema)

        If ret = vbYes Then
            Excluir.Excluir()
            MsgBox("Registro Excluído com Sucesso", 64, strSistema)
        Else
            MsgBox("Operação Cancelada", 64, strSistema)
        End If

        Limpar(grpRegistro)

        txtEvento.Focus()

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Limpar(grpRegistro)
        ParaGravar(grpBotoes)
        txtEvento.Focus()

    End Sub
    Private Sub cmdPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click
        Frm_Localizar.Text = "Pesquisa dados dos Eventos."

        Frm_Localizar.Tag = "VwLocalizaEventos" 'Aqui guardamos o nome da tabela

        Frm_Localizar.Show()

    End Sub

#End Region

    Private Sub Frm_Eventos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Verifica se a string com o ID a ser localizado está carregada com valor > 0(zero).
        'Se valor for = 0(zero) mostra o form vazio.
        If strIDLocaliza > 0 Then

            Dim Localiza As New ClsEventos

            Localiza.IDEvento = strIDLocaliza 'Passa o valor da string de localização para a classe.

            Localiza.Buscar() 'Chama o método de localização da classe.

            'Prenche os campos do form com os dados retonados pela localização
            txtIDEvento.Text = Localiza.IDEvento
            txtEvento.Text = Localiza.Evento
            txtDataRealizacao.Value = Localiza.DataRealizacao
            txtHoraRealizacao.Text = Localiza.HoraRealizacao
            txtOrganizador.Text = Localiza.Organizador
            txtPalestrante.Text = Localiza.Palestrante
            txtObs.Text = Localiza.Observacao
            lblDigita.Text = "Última alteração feita por: " & Localiza.NomeUser & " em " & Localiza.DataDigita
            strIDLocaliza = 0 'Descarrega string de localização.
            ParaAlterar(grpBotoes)
        Else
            ParaGravar(grpBotoes)
        End If

    End Sub
    Private Sub Frm_Eventos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal
        txtEvento.Focus()
    End Sub

    Private Sub txtDataRealizacao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDataRealizacao.GotFocus
        lblDigita.Text = "Informe a data do evento."
    End Sub
    Private Sub txtEvento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEvento.GotFocus
        lblDigita.Text = "Informe o nome do evento."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtEvento.SelectionStart = 0
        Me.txtEvento.SelectionLength = Len(Me.txtEvento.Text) 'Tamanho campo

    End Sub
    Private Sub txtHoraRealizacao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHoraRealizacao.GotFocus
        lblDigita.Text = "Informe hora de realizaçãodo evento."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtHoraRealizacao.SelectionStart = 0
        Me.txtHoraRealizacao.SelectionLength = Len(Me.txtHoraRealizacao.Text) 'Tamanho campo

    End Sub
    Private Sub txtOrganizador_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOrganizador.GotFocus
        lblDigita.Text = "Informe o nome do organizador responsável pelo evento."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtOrganizador.SelectionStart = 0
        Me.txtOrganizador.SelectionLength = Len(Me.txtOrganizador.Text) 'Tamanho campo

    End Sub
    Private Sub txtPalestrante_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPalestrante.GotFocus
        lblDigita.Text = "Informe o nome do palestrante do evento."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtPalestrante.SelectionStart = 0
        Me.txtPalestrante.SelectionLength = Len(Me.txtPalestrante.Text) 'Tamanho campo

    End Sub
    Private Sub txtObs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObs.GotFocus
        lblDigita.Text = "Informe as observações para o evento."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtObs.SelectionStart = 0
        Me.txtObs.SelectionLength = Len(Me.txtObs.Text) 'Tamanho campo
    End Sub


    Private Sub txtDataRealizacao_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDataRealizacao.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtHoraRealizacao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtHoraRealizacao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtEvento.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtHoraRealizacao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtEvento.Focus()
        End If
    End Sub
    Private Sub txtEvento_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEvento.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtDataRealizacao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtDataRealizacao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtDataRealizacao.Focus()
        End If
    End Sub
    Private Sub txtHoraRealizacao_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHoraRealizacao.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtOrganizador.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtOrganizador.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtOrganizador.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtDataRealizacao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtDataRealizacao.Focus()
        End If
    End Sub
    Private Sub txtOrganizador_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOrganizador.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtPalestrante.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtPalestrante.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtPalestrante.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtHoraRealizacao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtHoraRealizacao.Focus()
        End If
    End Sub
    Private Sub txtPalestrante_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPalestrante.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtObs.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtObs.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtObs.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtOrganizador.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtOrganizador.Focus()
        End If
    End Sub
    Private Sub txtObs_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObs.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            If cmdAlterar.Enabled = True Then
                cmdAlterar.Focus()
            Else
                cmdIncluir.Focus()
            End If

        End If
    End Sub
End Class