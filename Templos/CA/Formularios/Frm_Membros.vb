
Public Class Frm_Membros
    Dim strIDClasse As String
    Dim str_SQL_Localiza As String

#Region "Rotinas do programador"

    Private Sub CarregaGridLocaliza()
        Dim dsGrid As New DataSet
        Dim Busca As New ClsDados
        Dim decTotalProdutos As Decimal = 0
        Dim dblTotalProdutos As Double = 0

        Dim strSQL As String
        Dim strFiltro As String = txt_Filtro.Text


        'limpa o grid
        LimpaGridLocaliza()

        If strFiltro = Nothing Then
            strSQL = "SELECT Tbl_Pessoas.IDPessoa, Tbl_Pessoas.Pessoa  FROM Tbl_Pessoas" &
            " WHERE Tbl_Pessoas.TipoPessoa='Membro' ORDER BY Tbl_Pessoas.Pessoa;"

        Else
            strSQL = "SELECT Tbl_Pessoas.IDPessoa, Tbl_Pessoas.Pessoa FROM Tbl_Pessoas" &
            " WHERE Tbl_Pessoas.Pessoa Like '%" & strFiltro & "%' AND Tbl_Pessoas.TipoPessoa='Membro' ORDER BY Tbl_Pessoas.Pessoa;"

        End If


        dsGrid = Busca.RetornarDataSet(strSQL)


        'preenche a DGProdutos
        With DgLocaliza

            .DataSource = dsGrid.Tables(0)

            .Columns(0).Name = "IDPessoa"
            .Columns(0).Width = 60
            .Columns(0).HeaderText = "IDPessoa"
            .Columns(0).Visible = False

            .Columns(1).Name = "Pessoa"
            .Columns(1).Width = 220
            .Columns(1).HeaderText = "Pessoas Cadastradas"
            .Columns(1).ReadOnly = True

        End With
        ntxt_Cadastros.Text = DgLocaliza.RowCount

    End Sub
    Private Sub LimpaGridLocaliza()
        DGLocaliza.Columns.Clear()
    End Sub

    Private Sub CarregaEstados()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select Estado From Tbl_Estados order by Estado")

        dt.Columns.Add("Estado", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Estado") = dr("Estado")
            dt.Rows.Add(NovaDr)
        Next

        'preenche a combobox com os nomes das entidades e seleciona o primeiro valor    
        With cboEstado
            .DataSource = dt
            .DisplayMember = "Estado"
            .ValueMember = "Estado"
        End With

    End Sub
    Private Sub CarregaClasses()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select IDClasse,Classe From Tbl_Classes" &
                                   "  order by Classe")

        dt.Columns.Add("Classe", GetType(System.String))
        dt.Columns.Add("IDClasse", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Classe") = dr("Classe")
            NovaDr("IDClasse") = dr("IDClasse")
            dt.Rows.Add(NovaDr)
        Next

        'preenche a combobox com os nomes das Classes e seleciona o primeiro valor    
        With cboIDclasse
            .DataSource = dt
            .DisplayMember = "Classe"
            .ValueMember = "IDClasse"
        End With

        cboIDClasse.Text = String.Empty

    End Sub
    Private Sub CarregaStatus()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select IDStatus,Status From Tbl_Status" &
                                   " order by Status")

        dt.Columns.Add("Status", GetType(System.String))
        dt.Columns.Add("IDStatus", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Status") = dr("Status")
            NovaDr("IDStatus") = dr("IDStatus")
            dt.Rows.Add(NovaDr)
        Next

        'preenche a combobox com os nomes das Statuss e seleciona o primeiro valor    
        With cboIDStatus
            .DataSource = dt
            .DisplayMember = "Status"
            .ValueMember = "IDStatus"
        End With


    End Sub
    Private Sub CarregaGridClasses(ByVal strfiltro As String)
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim strSQL As String = "SELECT Tbl_Pessoas_Grupos.IDClasse,Tbl_Pessoas_Grupos.IDPessoa," &
                                   " Tbl_Classes.Classe,Tbl_Pessoas_Grupos.Contar_Presenca, Tbl_Pessoas_Grupos.DataMatricula" &
                                   " FROM Tbl_Pessoas_Grupos, Tbl_Classes" &
                                   " WHERE Tbl_Pessoas_Grupos.IDClasse = Tbl_Classes.IDClasse" &
                                   " AND Tbl_Pessoas_Grupos.IDPessoa=" & strfiltro & " AND DataBaixa IS NULL;"
        'limpa o grid
        LimpaGridClasses()

        ds = Busca.RetornarDataSet(strSQL)

        'preenche a DGProdutos
        With DGClasses

            .DataSource = ds.Tables(0)

            .Columns(0).Visible = False
            .Columns(0).Name = "IDClasse"

            .Columns(1).Visible = False
            .Columns(1).Name = "IDPessoa"

            .Columns(2).Name = "Classe"
            .Columns(2).Width = 110
            .Columns(2).HeaderText = "Classe"
            .Columns(2).ReadOnly = True

            .Columns(3).Name = "Contar_Presenca"
            .Columns(3).Width = 70
            .Columns(3).HeaderText = "Presenca"

            .Columns(4).Name = "DataMatricula"
            .Columns(4).Width = 70
            .Columns(4).HeaderText = "Dt. Matricula"
            .Columns(4).ReadOnly = True



        End With


    End Sub
    Private Sub LimpaGridClasses()
        DGClasses.Columns.Clear()
    End Sub
    Private Sub MostraRegistro()
        'Verifica se a string com o ID a ser localizado está carregada com valor > 0(zero).
        'Se valor for = 0(zero) mostra o form vazio.
        If strIDLocaliza > 0 Then

            Dim Localiza As New ClsMembros

            Localiza.IDPessoa = strIDLocaliza 'Passa o valor da string de localização para a classe.

            Localiza.Buscar() 'Chama o método de localização da classe.

            'Prenche os campos do form com os dados retonados pela localização

            txtIDPessoa.Text = Localiza.IDPessoa

            txtCNPJ.Text = Localiza.CNPJ
            txtIE.Text = Localiza.IE
            txtPessoa.Text = Localiza.Pessoa
            txtNome2.Text = Localiza.Pessoa
            txtEndereco.Text = Localiza.Endereco
            txtBairro.Text = Localiza.Bairro
            txtCEP.Text = Localiza.CEP
            txtCidade.Text = Localiza.Cidade
            cboEstado.Text = Localiza.UF
            mskTelefone.Text = Localiza.Telefone
            mskFax.Text = Localiza.Fax
            txtEmail.Text = Localiza.Email
            mskCelular.Text = Localiza.Celular
            txtIDPai.Text = Localiza.IDPai
            txtIDMae.Text = Localiza.IDMae
            txtNomePai.Text = Localiza.NomePai
            txtNomeMae.Text = Localiza.NomeMae
            cboSexo.Text = Localiza.Sexo
            cboEstCivil.Text = Localiza.EstadoCivil
            CarregaGridClasses(txtIDPessoa.Text)
            cboIDStatus.SelectedValue = Localiza.IDStatus
            chk_Permanente.Checked = Localiza.Permanente
            ' CarregaGridOcorrencias()
            txtDataNascimento.Value = Localiza.DataNascimento
            lblDigita.Text = "Última alteração feita por: " & Localiza.NomeUser & " em " & Localiza.DataDigita
            strIDLocaliza = 0 'Descarrega string de localização.
            ParaAlterar(grpBotoes)
        Else
            If txtIDPessoa.Text = Nothing Then
                ParaGravar(grpBotoes)
                lblDigita.Text = "Informe os dados do novo registro"

            End If
        End If
    End Sub

#End Region

#Region "Código dos botões"

    Private Sub cmdIncluir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdIncluir.Click
        Dim incluir As New ClsMembros

        If txtPessoa.Text.Trim = Nothing Then
            MsgBox("Nome da pessoa necessário", 16, strSistema)
            Exit Sub
        End If

        incluir.TipoPessoa = "Membro"
        incluir.CNPJ = txtCNPJ.Text
        incluir.IE = txtIE.Text
        incluir.Pessoa = txtPessoa.Text
        incluir.Endereco = txtEndereco.Text
        incluir.Bairro = txtBairro.Text
        incluir.CEP = txtCEP.Text
        incluir.Cidade = txtCidade.Text
        incluir.UF = cboEstado.Text
        incluir.Telefone = mskTelefone.Text
        incluir.Fax = mskFax.Text
        incluir.Email = txtEmail.Text
        incluir.Celular = mskCelular.Text
        If txtIDPai.Text = "" Then
            incluir.IDPai = 0
        Else
            incluir.IDPai = txtIDPai.Text
        End If
        If txtIDMae.Text = "" Then
            incluir.IDMae = 0
        Else
            incluir.IDMae = txtIDMae.Text
        End If
        incluir.NomePai = UCase(RemoveAcentos(txtNomePai.Text))
        incluir.NomeMae = UCase(RemoveAcentos(txtNomeMae.Text))
        incluir.IDStatus = cboIDStatus.SelectedValue
        incluir.EstadoCivil = cboEstCivil.Text
        'incluir.Obs = txtobs.Text
        incluir.Sexo = cboSexo.Text
        incluir.DataNascimento = Format(txtDataNascimento.Value, "yyyy/MM/dd")
        incluir.NomeUser = strNomeUser
        incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")
        incluir.Permanente = chk_Permanente.Checked
        Try
            'Chama a rotina de gravação da classe
            incluir.Gravar()

            txtIDPessoa.Text = incluir.BuscarId
            txtNome2.Text = txtPessoa.Text
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao incluir no cadastro de membros ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            incluir = Nothing
        End Try

        MsgBox("Registro Cadastrado com sucesso.", 64, strSistema)

        'Carrega combos
        CarregaEstados()

        'Direciona o foco
        txtCNPJ.Focus()

    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        Dim alterar As New ClsMembros

        If txtIDPessoa.Text.Trim = Nothing Then
            MsgBox("Você precisa selecionar um Membro.", 16, strSistema)
            Exit Sub
        End If
        alterar.IDPessoa = txtIDPessoa.Text

        alterar.CNPJ = txtCNPJ.Text
        alterar.IE = txtIE.Text
        alterar.Pessoa = txtPessoa.Text
        alterar.Endereco = txtEndereco.Text
        alterar.Bairro = txtBairro.Text
        alterar.CEP = txtCEP.Text
        alterar.Cidade = txtCidade.Text
        alterar.UF = cboEstado.Text
        alterar.Telefone = mskTelefone.Text
        alterar.Fax = mskFax.Text
        alterar.Email = txtEmail.Text
        alterar.Celular = mskCelular.Text
        alterar.IDPai = txtIDPai.Text
        alterar.IDMae = txtIDMae.Text
        alterar.NomePai = UCase(RemoveAcentos(txtNomePai.Text))
        alterar.NomeMae = UCase(RemoveAcentos(txtNomeMae.Text))
        alterar.IDStatus = cboIDStatus.SelectedValue
        alterar.EstadoCivil = cboEstCivil.Text
        'incluir.Obs = txtobs.Text
        alterar.Sexo = cboSexo.Text
        alterar.DataNascimento = Format(txtDataNascimento.Value, "yyy/MM/dd")
        alterar.NomeUser = strNomeUser
        alterar.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")
        alterar.Permanente = chk_Permanente.Checked

        Try
            alterar.Editar()
        Catch ex As Exception
            MsgBox("Ao alterar no cadastro de membros ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            alterar = Nothing
        End Try

        MsgBox("Registro Alterado com Sucesso", 64, strSistema)

        'Direciona o foco
        txtCNPJ.Focus()

    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        Dim Excluir As New ClsMembros

        Excluir.IDPessoa = txtIDPessoa.Text

        Excluir.Pessoa = txtPessoa.Text

        Dim ret As Integer

        ret = MsgBox("Deseja realmente excluir: " & Excluir.Pessoa & " ?", 36, strSistema)

        If ret = vbYes Then
            Excluir.Excluir()
            MsgBox("Registro Excluído com Sucesso", 64, strSistema)
        Else
            MsgBox("Operação Cancelada", 64, strSistema)
        End If

        'Limpa o Form
        LimparTab(TBMembro)

        'Carrega combos
        CarregaEstados()
        CarregaGridLocaliza()
        'Direciona o foco
        txtCNPJ.Focus()

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        'Limpa o Form
        LimparTab(TBMembro)

        'Carrega combos
        CarregaEstados()
        LimpaGridClasses()
        ParaGravar(grpBotoes)
        lblDigita.Text = "Informe os dados do novo registro"
        txtIDMae.Text = 0
        txtIDPai.Text = 0
        txtNome2.Text = ""
        txtIDPessoa.Text = ""
        txtPessoa.Text = ""
        CarregaGridLocaliza()
        strIDLocaliza = 0
        txtDataNascimento.Value = Date.Today()
        'Direciona o foco
        TBMembro.SelectedIndex = 0
        txtCNPJ.Focus()

    End Sub

    Private Sub btLocalizaPai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLocalizaPai.Click
        Frm_Localiza_Pais.Text = "Localizando o Pai do aluno."

        Frm_Localiza_Pais.Tag = "VwLocalizaPai" 'Aqui guardamos o nome da tabela

        Frm_Localiza_Pais.Show()

    End Sub
    Private Sub btLocalizaMae_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLocalizaMae.Click
        Frm_Localiza_Pais.Text = "Localizando a Mãe do aluno."

        Frm_Localiza_Pais.Tag = "VwLocalizaMae" 'Aqui guardamos o nome da tabela

        Frm_Localiza_Pais.Show()
    End Sub
    Private Sub btInsereClasse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInsereClasse.Click
        Dim insere As New ClsClasseAlunos
        insere.IDClasse = cboIDclasse.SelectedValue
        insere.IDPessoa = txtIDPessoa.Text
        insere.DataMatricula = Format(Date.Today, "yyyy/MM/dd")
        insere.NomeUser = strNomeUser
        insere.DataDigita = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")

        If ((insere.VerificaMatricula) And (insere.VerificaClasse)) Then
            MsgBox("Este aluno já está numa classe de escola dominical", 48, strSistema)
            Exit Sub
            insere = Nothing
        Else

            Try
                insere.Gravar()
                CarregaGridClasses(txtIDPessoa.Text)
            Catch ex As Exception
                MsgBox("Ao inserir o aluno numa classe ocorreu o erro: " & ex.Message)
                Exit Sub
            Finally
                insere = Nothing
            End Try
        End If


    End Sub

#End Region


    'Evento ao entrar no formulário
    Private Sub Frm_Clientes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        MostraRegistro()

    End Sub
    Private Sub Frm_Clientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal

        'Carrega as funções.
        CarregaEstados()
        CarregaClasses()
        CarregaStatus()
        CarregaGridLocaliza()

        cboEstado.Text = String.Empty
        cboIDClasse.Text = String.Empty

        'Direciona o foco
        txtCNPJ.Focus()

    End Sub

    'Evento ao entrar no campo

    Private Sub txtCNPJ_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNPJ.GotFocus
        lblDigita.Text = "Informe o CNPJ/CPF."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtCNPJ.SelectionStart = 0
        Me.txtCNPJ.SelectionLength = Len(Me.txtCNPJ.Text) 'Tamanho campo

    End Sub
    Private Sub txtIE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIE.GotFocus
        lblDigita.Text = "Informe  inscrição estadual ou RG."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtIE.SelectionStart = 0
        Me.txtIE.SelectionLength = Len(Me.txtIE.Text) 'Tamanho campo

    End Sub
    Private Sub txtPessoa_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPessoa.GotFocus
        lblDigita.Text = "Informe o nome da pessoa."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtPessoa.SelectionStart = 0
        Me.txtPessoa.SelectionLength = Len(Me.txtPessoa.Text) 'Tamanho campo

    End Sub
    Private Sub txtEndereco_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEndereco.GotFocus
        lblDigita.Text = "Informe o endereço da pessoa."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtEndereco.SelectionStart = 0
        Me.txtEndereco.SelectionLength = Len(Me.txtEndereco.Text) 'Tamanho campo

    End Sub
    Private Sub txtBairro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBairro.GotFocus
        lblDigita.Text = "Informe o bairro da pessoa."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtBairro.SelectionStart = 0
        Me.txtBairro.SelectionLength = Len(Me.txtBairro.Text) 'Tamanho campo

    End Sub
    Private Sub txtCEP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCEP.GotFocus
        lblDigita.Text = "Informe o CEP da pessoa."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtCEP.SelectionStart = 0
        Me.txtCEP.SelectionLength = Len(Me.txtCEP.Text) 'Tamanho campo

    End Sub
    Private Sub txtCidade_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCidade.GotFocus
        lblDigita.Text = "Escolha a cidade da pessoa."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtCidade.SelectionStart = 0
        Me.txtCidade.SelectionLength = Len(Me.txtCidade.Text) 'Tamanho campo

    End Sub
    Private Sub cboEstado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEstado.GotFocus
        lblDigita.Text = "Escolha a unidade da federação do funcionário ou tercerizada."

    End Sub
    Private Sub mskTelefone_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskTelefone.GotFocus
        lblDigita.Text = "Informe o número do telefone da pessoa."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.mskTelefone.SelectionStart = 0
        Me.mskTelefone.SelectionLength = Len(Me.mskTelefone.Text) 'Tamanho campo

    End Sub
    Private Sub mskFax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskFax.GotFocus
        lblDigita.Text = "Informe o número do Fax da pessoa."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.mskFax.SelectionStart = 0
        Me.mskFax.SelectionLength = Len(Me.mskFax.Text) 'Tamanho campo

    End Sub
    Private Sub txtEMail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.GotFocus
        lblDigita.Text = "Informe o email da pessoa."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.SelectionLength = Len(Me.txtEmail.Text) 'Tamanho campo

    End Sub
    Private Sub mskCelular_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskCelular.GotFocus
        lblDigita.Text = "Informe o celular da pessoa."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.mskCelular.SelectionStart = 0
        Me.mskCelular.SelectionLength = Len(Me.mskCelular.Text) 'Tamanho campo

    End Sub
    Private Sub cboSexo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSexo.GotFocus
        lblDigita.Text = "Informe o sexo."

    End Sub
    Private Sub txtNomePai_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomePai.GotFocus
        lblDigita.Text = "Informe o nome do Pai. Ou clique no botão[+] para localizar."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtNomePai.SelectionStart = 0
        Me.txtNomePai.SelectionLength = Len(Me.txtNomePai.Text) 'Tamanho campo

    End Sub
    Private Sub txtNomeMae_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomeMae.GotFocus
        lblDigita.Text = "Informe o nome da Mãe. Ou clique no botão[+] para localizar."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtNomeMae.SelectionStart = 0
        Me.txtNomeMae.SelectionLength = Len(Me.txtNomeMae.Text) 'Tamanho campo

    End Sub
    Private Sub cboEstCivil_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEstCivil.GotFocus
        lblDigita.Text = "Informe o estado civil."

    End Sub
    Private Sub cboIDclasse_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboIDClasse.GotFocus
        lblDigita.Text = "Informe a classe a que pernce o aluno."
    End Sub

    Private Sub txtCNPJ_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCNPJ.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtIE.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtIE.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtIE.Focus()
        End If

    End Sub
    Private Sub txtIE_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIE.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtPessoa.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtPessoa.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtCNPJ.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtPessoa.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtCNPJ.Focus()
        End If

    End Sub
    Private Sub txtNome_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPessoa.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtEndereco.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtEndereco.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtIE.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtEndereco.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtIE.Focus()
        End If
        CarregaGridLocaliza()

    End Sub
    Private Sub txtEndereco_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEndereco.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtBairro.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtBairro.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtPessoa.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtBairro.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtPessoa.Focus()
        End If

    End Sub
    Private Sub txtBairro_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBairro.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtCEP.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtCEP.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtEndereco.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtCEP.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtEndereco.Focus()
        End If

    End Sub
    Private Sub txtCEP_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCEP.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtCidade.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtCidade.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtBairro.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtCidade.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtBairro.Focus()
        End If

    End Sub
    Private Sub txtCidade_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCidade.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.cboEstado.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.cboEstado.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtCEP.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.cboEstado.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtCEP.Focus()
        End If

    End Sub
    Private Sub cboEstado_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboEstado.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.mskTelefone.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.mskTelefone.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtCidade.Focus()
        End If

    End Sub
    Private Sub mskTelefone_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskTelefone.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.mskFax.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.mskFax.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.cboEstado.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.mskFax.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.cboEstado.Focus()
        End If

    End Sub
    Private Sub mskFax_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskFax.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.mskCelular.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.mskCelular.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.mskTelefone.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.mskCelular.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.mskTelefone.Focus()
        End If

    End Sub
    Private Sub txtEmail_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            TBMembro.SelectedIndex = 1
            txtNomePai.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            TBMembro.SelectedIndex = 1
            txtNomePai.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.cboEstCivil.Focus()
        End If

    End Sub
    Private Sub mskCelular_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles mskCelular.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode = 13 Then
            cboEstCivil.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            cboEstCivil.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            cboEstCivil.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.mskFax.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.mskFax.Focus()
        End If

    End Sub
    Private Sub cboSexo_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cboSexo.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode = 13 Then
            cboIDStatus.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            cboIDStatus.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtNomeMae.Focus()
        End If

    End Sub
    Private Sub cboEstCivil_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboEstCivil.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtEmail.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtEmail.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.mskCelular.Focus()
        End If
    End Sub

    Private Sub txtNomeMae_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNomeMae.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            cboSexo.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            cboSexo.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            cboSexo.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtNomePai.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtNomePai.Focus()
        End If
    End Sub
    Private Sub txtNomePai_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNomePai.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtNomeMae.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtNomeMae.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtNomeMae.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtEmail.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtEmail.Focus()
        End If
    End Sub

    Private Sub txtPessoa_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPessoa.Validated
        txtPessoa.Text = UCase(RemoveAcentos(txtPessoa.Text))
    End Sub
    Private Sub txtNomeMae_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomeMae.Validated
        txtNomeMae.Text = UCase(RemoveAcentos(txtNomeMae.Text))
    End Sub
    Private Sub txtNomePai_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomePai.Validated
        txtNomePai.Text = UCase(RemoveAcentos(txtNomePai.Text))
    End Sub
    Private Sub txtEndereco_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEndereco.Validated
        txtEndereco.Text = UCase(RemoveAcentos(txtEndereco.Text))
    End Sub
    Private Sub txtBairro_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBairro.Validated
        txtBairro.Text = UCase(RemoveAcentos(txtBairro.Text))
    End Sub
    Private Sub txtCidade_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCidade.Validated
        txtCidade.Text = UCase(RemoveAcentos(txtCidade.Text))
    End Sub

    Private Sub cboIDStatus_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboIDStatus.GotFocus
        lblDigita.Text = "Informe o status do membro nos quadros do Templos."
    End Sub

    Private Sub txtDataNascimento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDataNascimento.GotFocus
        lblDigita.Text = "Informe a data de nascimento da pessoa."
    End Sub

    Private Sub txtDataNascimento_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDataNascimento.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = System.Windows.Forms.Keys.Down Then
            If cmdAlterar.Enabled = True Then
                cmdAlterar.Focus()
            Else
                cmdIncluir.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.cboIDStatus.Focus()
        End If
    End Sub

    Private Sub cboIDStatus_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboIDStatus.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim keycode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If keycode = 13 Then
            Me.txtDataNascimento.Focus()
        ElseIf keycode = System.Windows.Forms.Keys.Right Then
            Me.txtDataNascimento.Focus()
        ElseIf keycode = System.Windows.Forms.Keys.Left Then
            Me.cboSexo.Focus()
        End If
    End Sub

    Private Sub DGClasses_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGClasses.DoubleClick
        If txtIDPessoa.Text <> Nothing Then
            If Confirma("A exclusão pode prejudicar futuros relatórios." & vbCrLf &
                        "Uma opção é a rotina de transferência do Aluno." & vbCrLf &
                        "Confirma exclusão mesmo assim?") Then

                Dim exclui As New ClsClasseAlunos
                exclui.IDClasse = strIDClasse
                exclui.IDPessoa = txtIDPessoa.Text
                exclui.Excluir()
                CarregaGridClasses(txtIDPessoa.Text)
            End If
        Else
            MsgBox("Você precisa escolher um membro.", 64, strSistema)
            Exit Sub
        End If

    End Sub

    Private Sub DGClasses_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGClasses.RowEnter
        If Not DGClasses.Rows(e.RowIndex).Cells(0).Value Is DBNull.Value Then
            strIDClasse = DGClasses.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub

    Private Sub DgLocaliza_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgLocaliza.Click
        MostraRegistro()
    End Sub

    Private Sub DGLocaliza_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgLocaliza.RowEnter
        If Not DgLocaliza.Rows(e.RowIndex).Cells(0).Value Is DBNull.Value Then
            strIDLocaliza = DgLocaliza.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub

    Private Sub txtDataNascimento_ValueChanged(sender As Object, e As EventArgs) Handles txtDataNascimento.ValueChanged
        lbl_Idade.Text = CalculaTempo(txtDataNascimento.Value)
    End Sub

    Private Sub txt_Filtro_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_Filtro.KeyUp
        CarregaGridLocaliza()
    End Sub

    Private Sub DGClasses_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGClasses.CellValueChanged
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Dim insere As New ClsClasseAlunos
        insere.IDClasse = DGClasses.Rows(e.RowIndex).Cells("IDClasse").Value
        insere.IDPessoa = txtIDPessoa.Text
        insere.DataMatricula = Format(Date.Today, "yyyy/MM/dd")
        insere.Contar_Presenca = DGClasses.Rows(e.RowIndex).Cells("Contar_Presenca").Value
        insere.NomeUser = strNomeUser
        insere.DataDigita = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            insere.Editar()
            CarregaGridClasses(txtIDPessoa.Text)
        Catch ex As Exception
            MsgBox("Ao inserir o aluno numa classe ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            insere = Nothing
        End Try

    End Sub

    Private Sub txtEndereco_Enter(sender As Object, e As EventArgs) Handles txtEndereco.Enter
        Dim templo As New ClsTemplo
        templo.IDTemplo = 1
        templo.Buscar()

        txtCEP.Text = templo.CEP
        txtCidade.Text = templo.Cidade
        cboEstado.Text = templo.UF

        templo = Nothing


    End Sub

    Private Sub TBMembro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TBMembro.SelectedIndexChanged
        cboIDClasse.Text = String.Empty

    End Sub
End Class