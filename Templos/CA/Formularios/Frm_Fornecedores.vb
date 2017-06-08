
Public Class Frm_Fornecedores

#Region "Rotinas do programador"

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

#End Region

#Region "Código dos botões"

    Private Sub cmdIncluir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdIncluir.Click
        Dim incluir As New ClsFornecedores

        If txtNome.Text.Trim = Nothing Then
            MsgBox("Nome do Fornecedor necessário", 16, strSistema)
            Exit Sub
        ElseIf txtEndereco.Text.Trim = Nothing Then
            MsgBox("Endereço do Fornecedor necessário", 16, strSistema)
            Exit Sub
        ElseIf txtBairro.Text.Trim = Nothing Then
            MsgBox("Bairro do Fornecedor necessário", 16, strSistema)
            Exit Sub

        End If

        incluir.TipoPessoa = "Fornecedor"
        incluir.CNPJ = txtCNPJ.Text
        incluir.IE = txtIE.Text
        incluir.Pessoa = SmartCase(txtNome.Text)
        incluir.Endereco = txtEndereco.Text
        incluir.Bairro = txtBairro.Text
        incluir.CEP = txtCEP.Text
        incluir.Cidade = txtCidade.Text
        incluir.UF = cboEstado.Text
        incluir.Telefone = mskTelefone.Text
        incluir.Fax = mskFax.Text
        incluir.Site = txtSite.Text
        incluir.Email = txtEmail.Text
        incluir.NomeUser = strNomeUser
        incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            'Chama a rotina de gravação da classe
            incluir.Gravar()
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao incluir no cadastro de fornecedores ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            incluir = Nothing
        End Try

        MsgBox("Registro Cadastrado com sucesso.", 64, strSistema)

        Limpar(grpRegistro)

        'Carrega a combo
        CarregaEstados()

        'Direciona o foco
        cboPessoaJF.Focus()

    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        Dim alterar As New ClsFornecedores

        If txtIDPessoa.Text.Trim = Nothing Then
            MsgBox("Você precisa selecionar um Fornecedor.", 16, strSistema)
            Exit Sub
        End If
        alterar.IDPessoa = txtIDPessoa.Text

        alterar.CNPJ = txtCNPJ.Text
        alterar.IE = txtIE.Text
        alterar.Pessoa = SmartCase(txtNome.Text)
        alterar.Endereco = txtEndereco.Text
        alterar.Bairro = txtBairro.Text
        alterar.CEP = txtCEP.Text
        alterar.Cidade = txtCidade.Text
        alterar.UF = cboEstado.Text
        alterar.Telefone = mskTelefone.Text
        alterar.Fax = mskFax.Text
        alterar.Site = txtSite.Text
        alterar.Email = txtEmail.Text
        alterar.NomeUser = strNomeUser
        alterar.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            alterar.Editar()
        Catch ex As Exception
            MsgBox("Ao alterar no cadastro de fornecedores ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            alterar = Nothing
        End Try

        MsgBox("Registro Alterado com Sucesso", 64, strSistema)

        'Direciona o foco
        cboPessoaJF.Focus()

    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        Dim Excluir As New ClsFornecedores

        Excluir.IDPessoa = txtIDPessoa.Text

        Excluir.Pessoa = txtNome.Text

        Dim ret As Integer

        ret = MsgBox("Deseja excluir: " & Excluir.Pessoa & " ?", 36, strSistema)

        If ret = vbYes Then
            Excluir.Excluir()
            MsgBox("Registro Excluído com Sucesso", 64, strSistema)
        Else
            MsgBox("Operação Cancelada", 64, strSistema)
        End If

        Limpar(grpRegistro)

        'Carrega a combo
        CarregaEstados()

        'Direciona o foco
        cboPessoaJF.Focus()

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Limpar(grpRegistro)

        'Carrega a combo
        CarregaEstados()

        ParaGravar(grpBotoes)
        lblDigita.Text = "Informe os dados do novo registro"

        'Direciona o foco
        cboPessoaJF.Focus()

    End Sub
    Private Sub cmdPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click
        Frm_Localizar.Text = "Pesquisa dados dos Fornecedores."

        Frm_Localizar.Tag = "VwLocalizaFornecedor" 'Aqui guardamos o nome da tabela

        Frm_Localizar.Show()

    End Sub

#End Region

#Region "Eventos dos campos"

    'Evento ao entrar no formulário
    Private Sub Frm_Fornecedores_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Verifica se a string com o ID a ser localizado está carregada com valor > 0(zero).
        'Se valor for = 0(zero) mostra o form vazio.
        If strIDLocaliza > 0 Then

            Dim Localiza As New ClsFornecedores

            Localiza.IDPessoa = strIDLocaliza 'Passa o valor da string de localização para a classe.

            Localiza.Buscar() 'Chama o método de localização da classe.

            'Prenche os campos do form com os dados retonados pela localização
            txtIDPessoa.Text = Localiza.IDPessoa


            If Len(Trim(Localiza.CNPJ)) > 11 Then
                lblCPF.Text = "CNPJ:"
                lblRG.Text = "IE:"
                txtCNPJ.Mask = "99.999.999/9999-99"
                cboPessoaJF.Text = "Jurídica"
            Else
                lblCPF.Text = "CPF:"
                lblRG.Text = "RG:"
                txtCNPJ.Mask = "999.999.999-99"
                cboPessoaJF.Text = "Física"
            End If


            txtCNPJ.Text = Localiza.CNPJ
            txtIE.Text = Localiza.IE
            txtNome.Text = Localiza.Pessoa
            txtEndereco.Text = Localiza.Endereco
            txtBairro.Text = Localiza.Bairro
            txtCEP.Text = Localiza.CEP
            txtCidade.Text = Localiza.Cidade
            cboEstado.Text = Localiza.UF
            mskTelefone.Text = Localiza.Telefone
            mskFax.Text = Localiza.Fax
            txtSite.Text = Localiza.Site
            txtEmail.Text = Localiza.Email

            lblDigita.Text = "Última alteração feita por: " & Localiza.NomeUser & " em " & Localiza.DataDigita
            strIDLocaliza = 0 'Descarrega string de localização.
            ParaAlterar(grpBotoes)
        Else
            ParaGravar(grpBotoes)
            lblDigita.Text = "Informe os dados do novo registro"
        End If

    End Sub
    Private Sub Frm_Fornecedores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal

        'Carrega a combo
        CarregaEstados()

        'Direciona o foco
        cboPessoaJF.Focus()

    End Sub

    'Evento ao entrar no campo
    Private Sub cboPessoaJF_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPessoaJF.GotFocus
        lblDigita.Text = "Informe se é pessoa física ou jurídica."

    End Sub
    Private Sub txtCNPJ_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNPJ.GotFocus
        lblDigita.Text = "Informe o CNPJ/CPF do fornecedor."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtCNPJ.SelectionStart = 0
        Me.txtCNPJ.SelectionLength = Len(Me.txtCNPJ.Text) 'Tamanho campo

    End Sub
    Private Sub txtIE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIE.GotFocus
        lblDigita.Text = "Informe  inscrição estadual ou RG do fornecedor."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtIE.SelectionStart = 0
        Me.txtIE.SelectionLength = Len(Me.txtIE.Text) 'Tamanho campo

    End Sub
    Private Sub txtNome_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNome.GotFocus
        lblDigita.Text = "Informe o nome do fornecedor."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtNome.SelectionStart = 0
        Me.txtNome.SelectionLength = Len(Me.txtNome.Text) 'Tamanho campo

    End Sub
    Private Sub txtEndereco_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEndereco.GotFocus
        lblDigita.Text = "Informe o endereço do fornecedor."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtEndereco.SelectionStart = 0
        Me.txtEndereco.SelectionLength = Len(Me.txtEndereco.Text) 'Tamanho campo

    End Sub
    Private Sub txtBairro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBairro.GotFocus
        lblDigita.Text = "Informe o bairro."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtBairro.SelectionStart = 0
        Me.txtBairro.SelectionLength = Len(Me.txtBairro.Text) 'Tamanho campo

    End Sub
    Private Sub txtCEP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCEP.GotFocus
        lblDigita.Text = "Informe o CEP."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtCEP.SelectionStart = 0
        Me.txtCEP.SelectionLength = Len(Me.txtCEP.Text) 'Tamanho campo

    End Sub
    Private Sub txtCidade_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCidade.GotFocus
        lblDigita.Text = "Escolha a cidade do fornecedor."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtCidade.SelectionStart = 0
        Me.txtCidade.SelectionLength = Len(Me.txtCidade.Text) 'Tamanho campo

    End Sub
    Private Sub cboEstado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEstado.GotFocus
        lblDigita.Text = "Escolha a unidade da federação do fornecedor."

    End Sub
    Private Sub mskTelefone_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskTelefone.GotFocus
        lblDigita.Text = "Informe o número do telefone."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.mskTelefone.SelectionStart = 0
        Me.mskTelefone.SelectionLength = Len(Me.mskTelefone.Text) 'Tamanho campo

    End Sub
    Private Sub mskFax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskFax.GotFocus
        lblDigita.Text = "Informe o número do Fax."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.mskFax.SelectionStart = 0
        Me.mskFax.SelectionLength = Len(Me.mskFax.Text) 'Tamanho campo

    End Sub
    Private Sub txtSite_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSite.GotFocus
        lblDigita.Text = "Informe o número do Fax."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtSite.SelectionStart = 0
        Me.txtSite.SelectionLength = Len(Me.txtSite.Text) 'Tamanho campo

    End Sub
    Private Sub txtEMail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.GotFocus
        lblDigita.Text = "Informe o email do fornecedor."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtSite.SelectionStart = 0
        Me.txtSite.SelectionLength = Len(Me.txtSite.Text) 'Tamanho campo

    End Sub

    'Evento do teclado
    Private Sub cboPessoaJF_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPessoaJF.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtCNPJ.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtCNPJ.Focus()
        End If
    End Sub
    Private Sub txtCNPJ_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCNPJ.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtIE.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtIE.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.cboPessoaJF.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtIE.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.cboPessoaJF.Focus()
        End If

    End Sub
    Private Sub txtIE_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIE.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtNome.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtNome.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtCNPJ.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtNome.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtCNPJ.Focus()
        End If

    End Sub
    Private Sub txtNome_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNome.KeyUp
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
            Me.txtNome.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtBairro.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtNome.Focus()
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
    Private Sub txtCidades_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCidade.KeyUp
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
            Me.txtSite.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtSite.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.mskTelefone.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtSite.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.mskTelefone.Focus()
        End If

    End Sub
    Private Sub txtSite_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSite.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtEmail.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtEmail.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.mskFax.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.txtEmail.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.mskFax.Focus()
        End If

    End Sub
    Private Sub txtEmail_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            If cmdAlterar.Enabled = True Then
                cmdAlterar.Focus()
            Else
                cmdIncluir.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
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
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtSite.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtSite.Focus()
        End If

    End Sub


    'Evento de validação do CNPJ/CPF
    Private Sub cboPessoaJF_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPessoaJF.SelectedValueChanged
        If cboPessoaJF.Text.Trim = "Jurídica" Then
            txtCNPJ.Mask = "99.999.999/9999-99"
            lblCPF.Text = "CNPJ:"
            lblRG.Text = "I.E.:"

        Else
            txtCNPJ.Mask = "999.999.999-99"
            lblCPF.Text = "CPF:"
            lblRG.Text = "R.G.:"
        End If

        txtCNPJ.Focus()

    End Sub

    Private Sub txtCNPJ_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNPJ.LostFocus
        If txtIDPessoa.Text <> "" Then

            If Len(txtCNPJ.Text) > 11 Then
                If ValidaCNPJ(txtCNPJ.Text.Trim) Then
                    txtCNPJ.Mask = "99,999,999/9999-99"
                Else
                    MsgBox("CNPJ Inválido.", 16, strSistema)
                    txtCNPJ.Text = ""
                    txtCNPJ.Focus()
                    Exit Sub
                End If
            ElseIf Len(txtCNPJ.Text) = 11 Then
                If ValidaCPF(txtCNPJ.Text.Trim) Then
                    txtCNPJ.Mask = "999,999,999-99"
                Else
                    MsgBox("CPF Inválido.", 16, strSistema)
                    txtCNPJ.Text = ""
                    txtCNPJ.Focus()
                    Exit Sub
                End If
            ElseIf Len(txtCNPJ.Text) < 11 And Len(txtCNPJ.Text) > 0 Then
                MsgBox("Número de documento em formato inválido.", 16, strSistema)

                txtCNPJ.Focus()
                txtCNPJ.Text = ""
                Exit Sub
            End If
        End If
    End Sub

    'Evento ao sair do campo
    Private Sub cboPessoaJF_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPessoaJF.LostFocus
        If cboPessoaJF.Text.Trim = "Jurídica" Then
            lblCPF.Text = "CNPJ:"
            lblRG.Text = "I.E.:"

            txtCNPJ.Mask = "99.999.999/9999-99"
        Else
            lblCPF.Text = "CPF:"
            lblRG.Text = "RG:"

            txtCNPJ.Mask = "999.999.999-99"
        End If

    End Sub

    Private Sub txtNome_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNome.Validated
        txtNome.Text = SmartCase(txtNome.Text)
    End Sub
#End Region


End Class
