
Public Class Frm_Financeiro

#Region "Rotinas do programador"

    Private Sub CarregaSacados()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable


        ds = Busca.RetornarDataSet("Select IDPessoa,Pessoa From Tbl_Pessoas order by Pessoa")

        dt.Columns.Add("Pessoa", GetType(System.String))
        dt.Columns.Add("IDPessoa", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Pessoa") = dr("Pessoa")
            NovaDr("IDPessoa") = dr("IDPessoa")
            dt.Rows.Add(NovaDr)
        Next

        'preenche a combobox com os nomes das Pessoas e seleciona o primeiro valor    
        With cboIDProfessor
            .DataSource = dt
            .DisplayMember = "Pessoa"
            .ValueMember = "IDPessoa"
        End With

    End Sub
    Private Sub CarregaCategorias()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable


        ds = Busca.RetornarDataSet("Select IDCategoria,Categoria From Tbl_Categorias WHERE TipoCategoria='Financeiro' order by Categoria")

        dt.Columns.Add("Categoria", GetType(System.String))
        dt.Columns.Add("IDCategoria", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Categoria") = dr("Categoria")
            NovaDr("IDCategoria") = dr("IDCategoria")
            dt.Rows.Add(NovaDr)
        Next

        'preenche a combobox com os nomes das Categorias e seleciona o primeiro valor    
        With cboIDCategoria
            .DataSource = dt
            .DisplayMember = "Categoria"
            .ValueMember = "IDCategoria"
        End With

    End Sub

    Private Sub MostraRegistro()
        'Verifica se a string com o ID a ser localizado está carregada com valor > 0(zero).
        'Se valor for = 0(zero) mostra o form vazio.
        If strIDLocaliza > 0 Then

            Dim Localiza As New ClsFinanceiro

            Localiza.IDMovFinanceiro = strIDLocaliza 'Passa o valor da string de localização para a classe.

            Localiza.Buscar() 'Chama o método de localização da classe.

            'Carrega a combo
            CarregaSacados()
            CarregaCategorias()

            cboIDProfessor.SelectedValue = Localiza.IDPessoa

            cboIDCategoria.SelectedValue = Localiza.IDCategoria
            txtIDMovFinanceiro.Text = Localiza.IDMovFinanceiro
            cboTipo.Text = Localiza.TipoFinanceiro
            txtTitulo.Text = Localiza.Titulo
            txtEmissao.Value = Localiza.DataEmissao
            txtValor.Text = Localiza.ValorTitulo
            txtVencimento.Value = Localiza.DataVencimento
            txtObs.Text = Localiza.Observacao.Trim
            lblDigita.Text = "Última alteração feita por: " & Localiza.NomeUser & " em " & Localiza.DataDigita
            ParaAlterar(grpBotoes)

            strIDLocaliza = 0 'Descarrega string de localização.
        Else
            ParaGravar(grpBotoes)
            lblDigita.Text = "Informe os dados do novo registro"
        End If

    End Sub


#End Region

#Region "Código dos botões"

    Private Sub cmdIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIncluir.Click
        Dim incluir As New ClsFinanceiro()

        If txtTitulo.Text.Trim = Nothing Then
            MsgBox("Número do título é necessário", 16, strSistema)
            Exit Sub
        End If

        If cboTipo.Text = "Credito" Then
            incluir.TipoFinanceiro = "C"
        Else
            incluir.TipoFinanceiro = "D"
        End If
        incluir.Titulo = txtTitulo.Text
        incluir.IDPessoa = cboIDProfessor.SelectedValue
        incluir.DataEmissao = Format(txtEmissao.Value, "yyyy/MM/dd")
        incluir.DataVencimento = Format(txtVencimento.Value, "yyyy/MM/dd")
        incluir.ValorTitulo = txtValor.Text
        incluir.Observacao = txtObs.Text.Trim
        incluir.NomeUser = strNomeUser
        incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")
        incluir.IDCategoria = cboIDCategoria.SelectedValue
        Try
            'Chama a rotina de gravação da classe
            incluir.Gravar()
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao incluir no cadastro financeiro ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            incluir = Nothing
        End Try

        MsgBox("Registro Cadastrado com sucesso.", 64, strSistema)

        'Limpa o form
        Limpar(grpRegistro)

        'Direciona o foco
        cboTipo.Focus()

    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        Dim alterar As New ClsFinanceiro()

        If txtIDMovFinanceiro.Text.Trim = Nothing Then
            MsgBox("Você precisa selecionar um título.", 16, strSistema)
            Exit Sub
        End If

        alterar.IDMovFinanceiro = txtIDMovFinanceiro.Text
        alterar.TipoFinanceiro = cboTipo.Text
        alterar.Titulo = txtTitulo.Text
        alterar.IDPessoa = cboIDProfessor.SelectedValue
        alterar.DataEmissao = Format(txtEmissao.Value, "yyyy/MM/dd")
        alterar.DataVencimento = Format(txtVencimento.Value, "yyyy/MM/dd")
        alterar.ValorTitulo = txtValor.Text
        alterar.Observacao = txtObs.Text.Trim
        alterar.NomeUser = strNomeUser
        alterar.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")
        alterar.IDCategoria = cboIDCategoria.SelectedValue
        Try
            alterar.Editar()
        Catch ex As Exception
            MsgBox("Ao alterar no cadastro financeiro ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            alterar = Nothing
        End Try

        MsgBox("Registro Alterado com Sucesso", 64, strSistema)

        'Direciona o foco
        cboTipo.Focus()

    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        Dim Excluir As New ClsFinanceiro

        Excluir.IDMovFinanceiro = txtIDMovFinanceiro.Text

        Excluir.Titulo = txtTitulo.Text

        Dim ret As Integer

        ret = MsgBox("Deseja excluir: " & Excluir.Titulo & " ?", 36, strSistema)

        If ret = vbYes Then
            Excluir.Excluir()
            MsgBox("Registro Excluído com Sucesso", 64, strSistema)
        Else
            MsgBox("Operação Cancelada", 64, strSistema)
        End If

        'Limpa o form
        Limpar(grpRegistro)

        'Direciona o foco
        cboTipo.Focus()

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        'Limpa o form
        Limpar(grpRegistro)

        'Zera as caixas
        txtValor.Text = 0

        ParaGravar(grpBotoes)
        lblDigita.Text = "Informe os dados do novo registro"

        'Direciona o foco
        cboTipo.Focus()

    End Sub
    Private Sub cmdPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click
        Frm_Localizar.Text = "Pesquisa dados do movimento financeiro."

        Frm_Localizar.Tag = "VwLocalizaTitulos" 'Aqui guardamos o nome da tabela

        Frm_Localizar.Show()

    End Sub

#End Region

#Region "Eventos dos campos"

    Private Sub Frm_Financeiro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Carrega a combo
        CarregaSacados()
        CarregaCategorias()

        If Not Me.Tag = "Dialogo" Then
            MdiParent = Frm_Principal
        Else
            MostraRegistro()
        End If


        'Direciona o foco
        cboTipo.Focus()

    End Sub

    'Evento ao entrar no campo
    Private Sub cboTipo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.GotFocus
        lblDigita.Text = "Informe se é um movimento de Débito ou Crédito."

    End Sub
    Private Sub txtTitulo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTitulo.GotFocus
        lblDigita.Text = "Informe o número do título."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtTitulo.SelectionStart = 0
        Me.txtTitulo.SelectionLength = Len(Me.txtTitulo.Text) 'Tamanho campo

    End Sub
    Private Sub txtEmissao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        lblDigita.Text = "Informe a data de emissão do título."

    End Sub
    Private Sub txtValor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.GotFocus
        lblDigita.Text = "Informe o valor do título."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtValor.SelectionStart = 0
        Me.txtValor.SelectionLength = Len(Me.txtValor.Text) 'Tamanho campo

    End Sub
    Private Sub txtVencimento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        lblDigita.Text = "Informe a data de vencimento do título."

    End Sub
    Private Sub cboSacado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        lblDigita.Text = "Escolha o nome do Sacado."

    End Sub
    Private Sub txtObs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObs.GotFocus
        lblDigita.Text = "Informe suas observações para o título."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtObs.SelectionStart = 0
        Me.txtObs.SelectionStart = Len(Me.txtObs.Text) 'Tamanho campo

    End Sub

    'Evento do teclado
    Private Sub cboTipo_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cboTipo.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Down.
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtTitulo.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtTitulo.Focus()
        End If

    End Sub
    Private Sub txtTitulo_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtTitulo.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtEmissao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtEmissao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.cboTipo.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtEmissao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.cboTipo.Focus()
        End If

    End Sub
    Private Sub txtEmissao_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtEmissao.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtValor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtValor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtTitulo.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtValor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtTitulo.Focus()
        End If

    End Sub
    Private Sub txtValor_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtValor.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtVencimento.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtVencimento.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtEmissao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtVencimento.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtEmissao.Focus()
        End If

    End Sub
    Private Sub txtVencimento_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVencimento.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.cboIDProfessor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.cboIDProfessor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtValor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.cboIDProfessor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtValor.Focus()
        End If

    End Sub
    Private Sub cboSacado_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs)
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtObs.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtObs.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtVencimento.Focus()
        End If

    End Sub
    Private Sub txtObs_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtObs.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode = 13 Then
            If cmdAlterar.Enabled = True Then
                cmdAlterar.Focus()
            Else
                cmdIncluir.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            If cmdAlterar.Enabled = True Then
                cmdAlterar.Focus()
            Else
                cmdIncluir.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            If cmdAlterar.Enabled = True Then
                cmdAlterar.Focus()
            Else
                cmdIncluir.Focus()
            End If
        End If

    End Sub

    'Evento ao sair do campo
    Private Sub txtValor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.LostFocus
        'Formata moeda
        txtValor.Text = Format(txtValor.Text, "Standard")

    End Sub

#End Region

End Class