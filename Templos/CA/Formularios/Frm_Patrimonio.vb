
Public Class Frm_Patrimonio

#Region "Rotinas do programador"

    Private Sub CarregaCor()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select IDCor,Cor From Tbl_Cores order by Cor")

        dt.Columns.Add("Cor", GetType(System.String))
        dt.Columns.Add("IDCor", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Cor") = dr("Cor")
            NovaDr("IDCor") = dr("IDCor")
            dt.Rows.Add(NovaDr)
        Next

        'preenche a combobox com os nomes das entidades e seleciona o primeiro valor    
        With cboCor
            .DataSource = dt
            .DisplayMember = "Cor"
            .ValueMember = "IDCor"
        End With

    End Sub
    Private Sub CarregaFornecedor()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select IDPessoa,Entidade From Tbl_Pessoas order by Entidade")

        dt.Columns.Add("Entidade", GetType(System.String))
        dt.Columns.Add("IDPessoa", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Entidade") = dr("Entidade")
            NovaDr("IDPessoa") = dr("IDPessoa")
            dt.Rows.Add(NovaDr)
        Next

        'preenche a combobox com os nomes das entidades e seleciona o primeiro valor    
        With cboFornecedor
            .DataSource = dt
            .DisplayMember = "Entidade"
            .ValueMember = "IDPessoa"
        End With

    End Sub

#End Region

#Region "Código dos botões"

    Private Sub cmdIncluir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdIncluir.Click
        Dim incluir As New ClsPatrimonio

        If txtDescricao.Text.Trim = Nothing Then
            MsgBox("Nome do cliente necessário", 16, strSistema)
            Exit Sub

        End If

        incluir.Descricao = txtDescricao.Text
        incluir.Modelo = txtModelo.Text
        incluir.Serie = txtSerie.Text
        incluir.Tensao = txtTensao.Text
        incluir.IDCor = cboCor.SelectedValue
        incluir.DataRegistro = Format(txtDtRegistro.Value, "yyyy/MM/dd HH:mm:ss")
        incluir.DataCompra = Format(txtDtCompra.Value, "yyyy/MM/dd HH:mm:ss")
        incluir.DataAtendimento = Format(txtDtUlt_Revisao.Value, "yyyy/MM/dd HH:mm:ss")
        incluir.ValorCompra = txtValorCompra.Text
        incluir.NotaFiscal = txtNotaFiscal.Text
        incluir.Depreciacao = txtDepreciacao.Text
        incluir.IDRevendedor = cboFornecedor.SelectedValue
        incluir.Local = txtUsado.Text

        If txtAparelhoFiscal.Checked = True Then
            incluir.AparelhoFiscal = "Sim"
        Else
            incluir.AparelhoFiscal = "Nao"
        End If

        incluir.NomeUser = strNomeUser
        incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            'Chama a rotina de gravação da classe
            incluir.Gravar()
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao incluir no cadastro do patrimônio ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            incluir = Nothing
        End Try

        MsgBox("Registro Cadastrado com sucesso.", 64, strSistema)

        'Limpar(grpRegistro)
        Limpar(grpRegistro)
        txtAparelhoFiscal.Checked = False

        'Carrega combo
        CarregaCor()
        CarregaFornecedor()

        'Direciona o foco
        txtDescricao.Focus()

    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        Dim alterar As New ClsPatrimonio

        If txtIDPatrimonio.Text.Trim = Nothing Then
            MsgBox("Você precisa selecionar um Fornecedor.", 16, strSistema)
            Exit Sub
        End If
        alterar.IDAparelho = txtIDPatrimonio.Text

        alterar.Descricao = txtDescricao.Text
        alterar.Modelo = txtModelo.Text
        alterar.Serie = txtSerie.Text
        alterar.Tensao = txtTensao.Text
        alterar.IDCor = cboCor.SelectedValue
        alterar.DataRegistro = Format(txtDtRegistro.Value, "yyyy/MM/dd HH:mm:ss")
        alterar.DataCompra = Format(txtDtCompra.Value, "yyyy/MM/dd HH:mm:ss")
        alterar.DataAtendimento = Format(txtDtUlt_Revisao.Value, "yyyy/MM/dd HH:mm:ss")
        alterar.ValorCompra = txtValorCompra.Text
        alterar.NotaFiscal = txtNotaFiscal.Text
        alterar.Depreciacao = txtDepreciacao.Text
        alterar.IDRevendedor = cboFornecedor.SelectedValue
        alterar.Local = txtUsado.Text

        If txtAparelhoFiscal.Checked = True Then
            alterar.AparelhoFiscal = "Sim"
        Else
            alterar.AparelhoFiscal = "Nao"
        End If

        alterar.NomeUser = strNomeUser
        alterar.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            alterar.Editar()
        Catch ex As Exception
            MsgBox("Ao alterar no cadastro do patrimônio ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            alterar = Nothing
        End Try

        MsgBox("Registro Alterado com Sucesso", 64, strSistema)

        'Direciona o foco
        txtDescricao.Focus()

    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        Dim Excluir As New ClsPatrimonio

        Excluir.IDAparelho = txtIDPatrimonio.Text

        Excluir.Descricao = txtDescricao.Text

        Dim ret As Integer

        ret = MsgBox("Deseja excluir: " & Excluir.Descricao & " ?", 36, strSistema)

        If ret = vbYes Then
            Excluir.Excluir()
            MsgBox("Registro Excluído com Sucesso", 64, strSistema)
        Else
            MsgBox("Operação Cancelada", 64, strSistema)
        End If

        'Limpar(grpRegistro)
        Limpar(grpRegistro)
        txtAparelhoFiscal.Checked = False

        'Carrega combo
        CarregaCor()
        CarregaFornecedor()

        'Direciona o foco
        txtDescricao.Focus()

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        'Limpar(grpRegistro)
        Limpar(grpRegistro)
        txtAparelhoFiscal.Checked = False

        'Zera as caixas
        txtValorCompra.Text = 0
        txtDepreciacao.Text = 0

        'Carrega combo
        CarregaCor()
        CarregaFornecedor()

        ParaGravar(grpBotoes)
        lblDigita.Text = "Informe os dados do novo registro"

        'Direciona o foco
        txtDescricao.Focus()

    End Sub
    Private Sub cmdPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click
        Frm_Localizar.Text = "Pesquisa dados do patrimônio."

        Frm_Localizar.Tag = "VwLocalizaPatrimonio" 'Aqui guardamos o nome da tabela

        Frm_Localizar.Show()

    End Sub

#End Region

#Region "Eventos dos campos"

    'Evento ao entrar no formulário
    Private Sub Frm_Patrimonio_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Verifica se a string com o ID a ser localizado está carregada com valor > 0(zero).
        'Se valor for = 0(zero) mostra o form vazio.
        If strIDLocaliza > 0 Then

            Dim Localiza As New ClsPatrimonio

            Localiza.IDAparelho = strIDLocaliza 'Passa o valor da string de localização para a classe.

            Localiza.Buscar() 'Chama o método de localização da classe.

            'Prenche os campos do form com os dados retonados pela localização
            txtIDPatrimonio.Text = Localiza.IDAparelho

            txtDescricao.Text = Localiza.Descricao
            txtModelo.Text = Localiza.Modelo
            txtSerie.Text = Localiza.Serie
            txtTensao.Text = Localiza.Tensao
            cboCor.SelectedValue = Localiza.IDCor
            txtDtRegistro.Value = Localiza.DataRegistro
            txtDtCompra.Value = Localiza.DataCompra
            txtDtUlt_Revisao.Value = Localiza.DataAtendimento
            txtValorCompra.Text = Localiza.ValorCompra
            txtNotaFiscal.Text = Localiza.NotaFiscal
            txtDepreciacao.Text = Localiza.Depreciacao
            cboFornecedor.SelectedValue = Localiza.IDRevendedor
            txtUsado.Text = Localiza.Local

            If Localiza.AparelhoFiscal = "Sim" Then
                txtAparelhoFiscal.Checked = True
            Else
                txtAparelhoFiscal.Checked = False
            End If

            lblDigita.Text = "Última alteração feita por: " & Localiza.NomeUser & " em " & Localiza.DataDigita
            strIDLocaliza = 0 'Descarrega string de localização.
            ParaAlterar(grpBotoes)
        Else
            ParaGravar(grpBotoes)
            lblDigita.Text = "Informe os dados do novo registro"
        End If

    End Sub
    Private Sub Frm_Patrimonio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal

        'Carrega combo
        CarregaCor()
        CarregaFornecedor()

        'Direciona o foco
        txtDescricao.Focus()

    End Sub

    'Evento ao entrar no campo
    Private Sub txtDescricao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescricao.GotFocus
        lblDigita.Text = "Informe o patrimônio."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtDescricao.SelectionStart = 0
        Me.txtDescricao.SelectionLength = Len(Me.txtDescricao.Text) 'Tamanho campo

    End Sub
    Private Sub txtModelo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModelo.GotFocus
        lblDigita.Text = "Informe o modelo do patrimônio."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtModelo.SelectionStart = 0
        Me.txtModelo.SelectionLength = Len(Me.txtModelo.Text) 'Tamanho campo

    End Sub
    Private Sub txtSerie_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerie.GotFocus
        lblDigita.Text = "Informe a série do patrimônio."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtSerie.SelectionStart = 0
        Me.txtSerie.SelectionLength = Len(Me.txtSerie.Text) 'Tamanho campo

    End Sub
    Private Sub txtTensao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTensao.GotFocus
        lblDigita.Text = "Informe a tensão em volts do patrimônio."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtTensao.SelectionStart = 0
        Me.txtTensao.SelectionLength = Len(Me.txtTensao.Text) 'Tamanho campo

    End Sub
    Private Sub cboCor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCor.GotFocus
        lblDigita.Text = "Informe a cor do patrimônio."

    End Sub
    Private Sub txtDtRegistro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDtRegistro.GotFocus
        lblDigita.Text = "Informe a data de registro do patrimônio."

    End Sub
    Private Sub txtDtCompra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDtCompra.GotFocus
        lblDigita.Text = "Informe a data da compra do patrimônio."

    End Sub
    Private Sub txtDtUlt_Revisao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDtUlt_Revisao.GotFocus
        lblDigita.Text = "Informe a data da última revisão do patrimônio."

    End Sub
    Private Sub txtValorCompra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorCompra.GotFocus
        lblDigita.Text = "Informe o valor da compra do patrimônio."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtValorCompra.SelectionStart = 0
        Me.txtValorCompra.SelectionLength = Len(Me.txtValorCompra.Text) 'Tamanho campo

    End Sub
    Private Sub txtNotaFiscal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNotaFiscal.GotFocus
        lblDigita.Text = "Informe o número da nota fiscal do patrimônio."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtNotaFiscal.SelectionStart = 0
        Me.txtNotaFiscal.SelectionLength = Len(Me.txtNotaFiscal.Text) 'Tamanho campo

    End Sub
    Private Sub txtDepreciacao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDepreciacao.GotFocus
        lblDigita.Text = "Informe a depreciação do patrimônio."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtDepreciacao.SelectionStart = 0
        Me.txtDepreciacao.SelectionLength = Len(Me.txtDepreciacao.Text) 'Tamanho campo

    End Sub
    Private Sub cboFornecedor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFornecedor.GotFocus
        lblDigita.Text = "Informe o fornecedor do patrimônio."

    End Sub
    Private Sub txtUsado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsado.GotFocus
        lblDigita.Text = "Informe onde será usado o patrimônio."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtUsado.SelectionStart = 0
        Me.txtUsado.SelectionLength = Len(Me.txtUsado.Text) 'Tamanho campo

    End Sub
    Private Sub txtAparelhoFiscal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAparelhoFiscal.GotFocus
        lblDigita.Text = "Marque para utilizar o patrimônio como aparelho fiscal."

    End Sub

    'Evento do teclado
    Private Sub txtDescricao_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescricao.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtModelo.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtModelo.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtModelo.Focus()

        End If

    End Sub
    Private Sub txtModelo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtModelo.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtSerie.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtSerie.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtDescricao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtSerie.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtDescricao.Focus()
        End If

    End Sub
    Private Sub txtSerie_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSerie.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtTensao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtTensao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtModelo.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtTensao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtModelo.Focus()
        End If

    End Sub
    Private Sub txtTensao_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTensao.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.cboCor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.cboCor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtSerie.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.cboCor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtSerie.Focus()
        End If

    End Sub
    Private Sub cboCor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCor.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtDtRegistro.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtDtRegistro.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtTensao.Focus()

        End If

    End Sub
    Private Sub txtDtRegistro_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDtRegistro.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtDtCompra.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtDtCompra.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.cboCor.Focus()
        End If

    End Sub
    Private Sub txtDtCompra_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDtCompra.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtDtUlt_Revisao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtDtUlt_Revisao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtDtRegistro.Focus()
        End If

    End Sub
    Private Sub txtDtUlt_Revisao_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDtUlt_Revisao.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtValorCompra.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtValorCompra.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtDtCompra.Focus()
        End If

    End Sub
    Private Sub txtValorCompra_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtValorCompra.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtNotaFiscal.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtNotaFiscal.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtDtUlt_Revisao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtNotaFiscal.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtDtUlt_Revisao.Focus()

        End If

    End Sub
    Private Sub txtNotaFiscal_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNotaFiscal.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtDepreciacao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtDepreciacao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtValorCompra.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtDepreciacao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtValorCompra.Focus()
        End If

    End Sub
    Private Sub txtDepreciacao_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDepreciacao.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.cboFornecedor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.cboFornecedor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtNotaFiscal.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.cboFornecedor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtNotaFiscal.Focus()
        End If

    End Sub
    Private Sub cboFornecedor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboFornecedor.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtUsado.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtUsado.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtDepreciacao.Focus()

        End If

    End Sub
    Private Sub txtUsado_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsado.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtAparelhoFiscal.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtAparelhoFiscal.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtAparelhoFiscal.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.cboFornecedor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.cboFornecedor.Focus()

        End If

    End Sub
    Private Sub txtAparelhoFiscal_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAparelhoFiscal.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            If cmdIncluir.Enabled = True Then
                Me.cmdIncluir.Focus()
            Else
                Me.cmdAlterar.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            If cmdIncluir.Enabled = True Then
                Me.cmdIncluir.Focus()
            Else
                Me.cmdAlterar.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            If cmdIncluir.Enabled = True Then
                Me.cmdIncluir.Focus()
            Else
                Me.cmdAlterar.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtUsado.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtUsado.Focus()

        End If

    End Sub

    'Evento ao sair do campo
    Private Sub txtValorCompra_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorCompra.LostFocus
        'Formata moeda
        txtValorCompra.Text = Format(txtValorCompra.Text, "Standard")

    End Sub
    Private Sub txtDepreciacao_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDepreciacao.LostFocus
        'Formata moeda
        txtDepreciacao.Text = Format(txtDepreciacao.Text, "Standard")

    End Sub

#End Region

End Class