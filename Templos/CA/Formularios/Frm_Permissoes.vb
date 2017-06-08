Public Class Frm_Permissoes
    Dim strFormulario As String, strIDForm As String
    Dim booBloquear As Boolean
    Dim IntForms As Integer = 24
    Dim MeusForms(IntForms, 2) As String

    Private Sub CarregaForms(ByVal strFiltro As String)
        Dim ds As New DataSet
        Dim Busca As New ClsDados


        ds = Busca.RetornarDataSet("SELECT Tbl_Forms.idform, Tbl_Forms.Formulario, Tbl_Forms.Descricao" & _
                                   " FROM Tbl_Forms LEFT JOIN (SELECT IDForm FROM Tbl_Forms_Users" & _
                                   " WHERE IDUser=" & strFiltro & ") AS VwFormsUsers ON Tbl_Forms.idform =" & _
                                   " VwFormsUsers.IDFORM WHERE (((VwFormsUsers.IDFORM) Is Null)) ORDER BY Tbl_Forms.Descricao")

        'preenche a DGformsSistema
        With DGFormsSistema

            .DataSource = ds.Tables(0)

            .Columns(0).Visible = False
            .Columns(0).Name = "IDForm"

            .Columns(1).Name = "Formulario"
            .Columns(1).Visible = False

            .Columns(2).Name = "Descricao"
            .Columns(2).Width = 210
            .Columns(2).HeaderText = "Formulário"
            .Columns(2).ReadOnly = True

        End With

        txtQtdeForms.Text = ds.Tables(0).Rows.Count

    End Sub
    Private Sub CarregaFormsUser(ByVal strFiltro As Integer)
        Dim ds As New DataSet
        Dim Busca As New ClsDados

        ds = Busca.RetornarDataSet("SELECT Tbl_Forms_Users.IDUser,Tbl_Forms_Users.IDForm,Tbl_Forms_Users.Formulario,Tbl_Forms.Descricao" & _
                                   " FROM Tbl_Forms INNER JOIN Tbl_Forms_Users ON Tbl_Forms.IDForm=Tbl_Forms_Users.IDForm" & _
                                   " WHERE Tbl_Forms_Users.IDUser=" & strFiltro & " ORDER BY Descricao")

        'preenche a DGProdutos
        With DGFormsUser

            .DataSource = ds.Tables(0)

            .Columns(0).Name = "IDUser"
            .Columns(0).Visible = False

            .Columns(1).Name = "IDForm"
            .Columns(1).Visible = False


            .Columns(2).Name = "Formulario"
            .Columns(2).Visible = False

            .Columns(3).Name = "Formulario"
            .Columns(3).Width = 210
            .Columns(3).HeaderText = "Formulário"
            .Columns(3).ReadOnly = True

        End With

        txtQtdeFormsUser.Text = ds.Tables(0).Rows.Count
    End Sub
    Private Sub CarregaUsuarios()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable
        Dim strSQL As String = "Select IDUser,Usuario From Tbl_Usuarios " & _
                                " order by Usuario"

        ds = Busca.RetornarDataSet(strSQL)

        dt.Columns.Add("Usuario", GetType(System.String))
        dt.Columns.Add("IDUser", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Usuario") = dr("Usuario")
            NovaDr("IDUser") = dr("IDUser")
            dt.Rows.Add(NovaDr)
        Next
        'define o estilo da combobox
        'cboIDVendedor.DropDownStyle = ComboBoxStyle.DropDownList

        'preenche a combobox com os nomes dos vendedores 
        With cboIDVendedor
            .DataSource = dt
            .DisplayMember = "Usuario"
            .ValueMember = "IDUser"
        End With
        cboIDVendedor.Text = Nothing
    End Sub
    Private Sub VerificaFormsCad()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim I As Integer

        'Forms que nunca serão usados
        '1-Sobre
        '2-splash
        '3-Frm_Principal
        '4-Frm_Login
        '5-Frm_Report
        '6-Frm_Localizar
        '7-Frm_Localizar_Base
        '8-Frm_Bkp

        MeusForms(0, 0) = "Frm_Permissoes"
        MeusForms(0, 1) = "Permissoes de Usuários"
        MeusForms(1, 0) = "Frm_Agenda"
        MeusForms(1, 1) = "Agenda de Telefones"
        MeusForms(2, 0) = "Frm_Classes"
        MeusForms(2, 1) = "Cadastro de Grupos e Classes"
        MeusForms(3, 0) = "Frm_Escola_Dominical"
        MeusForms(3, 1) = "Escola Dominical"
        MeusForms(4, 0) = "Frm_Fluxo_Caixa"
        MeusForms(4, 1) = "Fluxo de Caixa"
        MeusForms(5, 0) = "Frm_Fornecedores"
        MeusForms(5, 1) = "Cadastro de Fornecedores"
        MeusForms(6, 0) = "Frm_Funcionarios"
        MeusForms(6, 1) = "Cadastro de Funcionários"
        MeusForms(7, 0) = "Frm_Membros"
        MeusForms(7, 1) = "Cadastro de Membros"
        MeusForms(8, 0) = "Frm_Patrimonio"
        MeusForms(8, 1) = "Patrimônio do Templos"
        MeusForms(9, 0) = "Frm_Status"
        MeusForms(9, 1) = "Cadastro de Status"
        MeusForms(10, 0) = "Frm_Tarefas_User"
        MeusForms(10, 1) = "Tarefas de Usuários"
        MeusForms(11, 0) = "Frm_Templo"
        MeusForms(11, 1) = "Dados do Templos"
        MeusForms(12, 0) = "Frm_Usuarios"
        MeusForms(12, 1) = "Cadastro de Usuários do sistema"
        MeusForms(13, 0) = "Frm_Livros"
        MeusForms(13, 1) = "Cadastro de Livros"
        MeusForms(14, 0) = "Frm_Empresta_Livro"
        MeusForms(14, 1) = "Empréstimos de Livros"
        MeusForms(15, 0) = "Frm_Eventos"
        MeusForms(15, 1) = "Cadastro de Eventos"
        MeusForms(16, 0) = "Frm_Muda_Classe"
        MeusForms(16, 1) = "Transfere Aluno de classe"
        MeusForms(17, 0) = "Frm_Aniversariantes"
        MeusForms(17, 1) = "Aniversariantes do Mês"
        MeusForms(18, 0) = "Frm_Ocorrencias"
        MeusForms(18, 1) = "Cadastro de Ocorrências"
        MeusForms(19, 0) = "Frm_Pessoas_Ocorrencias"
        MeusForms(19, 1) = "Inclusão de Ocorrências"
        MeusForms(20, 0) = "Frm_Lista_Fluxo_Caixa"
        MeusForms(20, 1) = "Relatório de Fluxo Caixa"
        MeusForms(21, 0) = "Frm_Lista_Membros"
        MeusForms(21, 1) = "Relatório de Membros"
        MeusForms(22, 0) = "Frm_Controle_Atas"
        MeusForms(22, 1) = "Controle de Atas"
        MeusForms(23, 0) = "Frm_Rlt_Anual"
        MeusForms(23, 1) = "Resumo Anual Escola"
        'MeusForms(24, 0) = "Frm_Modelos_Joias"
        'MeusForms(24, 1) = "Cadastro de Modelos de Jóias"
        'MeusForms(25, 0) = "Frm_Pedras_Joias"
        'MeusForms(25, 1) = "Tipos de Pedras"
        'MeusForms(26, 0) = "Frm_Ourives"
        'MeusForms(26, 1) = "Controle de Ourivesaria"
        'MeusForms(27, 0) = "Frm_Cad_Ourives"
        'MeusForms(27, 1) = "Cadastro de Ourives"
        'MeusForms(28, 0) = "Frm_Financeiro"
        'MeusForms(28, 1) = "Cadastro de Contas Pagar/Receber"
        'MeusForms(29, 0) = "Frm_Acerto_Comissao"
        'MeusForms(29, 1) = "Pagamento Serviços/Comissões"
        'MeusForms(30, 0) = "Frm_BaixaContas"
        'MeusForms(30, 1) = "Baixa Contas do Financeiro"
        'MeusForms(31, 0) = "Frm_Lista_Financeiro"
        'MeusForms(31, 1) = "Listagem dos movimentos de Caixa"
        'MeusForms(32, 0) = "Frm_Mov_Estoque"
        'MeusForms(32, 1) = "Compras e Vendas"
        'MeusForms(33, 0) = "Frm_Acerta_Estoque"
        'MeusForms(33, 1) = "Acerto de Estoque"
        'MeusForms(34, 0) = "Frm_Bancos"
        'MeusForms(34, 1) = "Cadastro de Bancos"
        'MeusForms(35, 0) = "Frm_Fecha_Caixa"
        'MeusForms(35, 1) = "Fechamento de Caixa"
        'MeusForms(36, 0) = "Frm_Muda_Obs"
        'MeusForms(36, 1) = "Mudar Obs/Defeito da OS"
        'MeusForms(37, 0) = "Frm_Lista_Ourives"
        'MeusForms(37, 1) = "Lista OS com Ourives"
        'MeusForms(38, 0) = "Frm_Categorias"
        'MeusForms(38, 1) = "Cadastro de Categorias"
        'MeusForms(39, 0) = "Frm_Paga_Ourives"
        'MeusForms(39, 1) = "Pagamentos de Ourives"
        'MeusForms(40, 0) = "Frm_Lista_OS_Status"
        'MeusForms(40, 1) = "Lista OS por Status"
        'MeusForms(41, 0) = "Frm_Promissorias"
        'MeusForms(41, 1) = "Impressão de Promissórias"
        'MeusForms(42, 0) = "Frm_Lista_Vendas"
        'MeusForms(42, 1) = "Listagem de Vendas"
        'MeusForms(43, 0) = "Frm_Cancela_Nota"
        'MeusForms(43, 1) = "Cancelamento de Nota"
        'MeusForms(43, 0) = "Frm_Produtos"
        'MeusForms(43, 1) = "Cadastro de Produtos"
        'MeusForms(44, 0) = "Frm_Quadro_Horas"
        'MeusForms(44, 1) = "Quadro de Horas"
        'MeusForms(45, 0) = "Frm_SubCategoria"
        'MeusForms(45, 1) = "Cadastro de SubCategorias"
        'MeusForms(46, 0) = "Frm_Tamanhos"
        'MeusForms(46, 1) = "Cadastro de Tamanhos"
        'MeusForms(47, 0) = "Frm_Tarefas_User"
        'MeusForms(47, 1) = "Cadastro Tarefas Usuários"
        'MeusForms(48, 0) = "Frm_Telemarketing"
        'MeusForms(48, 1) = "Telemarketing"
        'MeusForms(49, 0) = "Frm_Transportadora"
        'MeusForms(49, 1) = "Cadastro de Transportadora"
        'MeusForms(50, 0) = "Frm_Usuarios"
        'MeusForms(50, 1) = "Cadastro de Usuários"
        'MeusForms(51, 0) = "Frm_Apuracao_Tempo"
        'MeusForms(51, 1) = "Apuração do tempo de Produção"
        'MeusForms(52, 0) = "Frm_Historico_Produto"
        'MeusForms(52, 1) = "Histórico Movimentação de Produtos"
        'MeusForms(53, 0) = "Frm_Ordem_Producao"
        'MeusForms(53, 1) = "Controle de Produção"
        'MeusForms(54, 0) = "Frm_Produtos_Impostos"
        'MeusForms(54, 1) = "Impostos da NFe"
        'MeusForms(55, 0) = "Frm_Lista_Clientes_Produtos"
        'MeusForms(55, 1) = "Listagem de Produtos do Cliente"
        'MeusForms(56, 0) = "Frm_Bordero"
        'MeusForms(56, 1) = "Borderô de Pagamentos"
        'MeusForms(57, 0) = "Frm_Lista_Vendas_Vendedor"
        'MeusForms(57, 1) = "Listagem de Comissões"
        'MeusForms(59, 0) = "Frm_Servicos"
        'MeusForms(59, 1) = "Cadastro de Serviços"
        'MeusForms(60, 0) = "Frm_OS"
        'MeusForms(60, 1) = "Ordem de Serviços"
        'MeusForms(62, 0) = "Frm_Pedidos"
        'MeusForms(62, 1) = "Pedidos Por Grades"
        '

        ds = Busca.RetornarDataSet("SELECT Tbl_Forms.idform, Tbl_Forms.Formulario, Tbl_Forms.Descricao" & _
                                   " FROM Tbl_Forms;")

        If ds.Tables(0).Rows.Count < IntForms Then

            For I = 0 To (IntForms - 1)
                Dim incluir As New ClsForms
                Dim strFiltro As String = MeusForms(I, 0)
                incluir.Formulario = MeusForms(I, 0)
                incluir.Descricao = MeusForms(I, 1)
                incluir.NomeUser = strNomeUser
                incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")
                ds = Busca.RetornarDataSet("SELECT Tbl_Forms.Formulario" & _
                                           " FROM Tbl_Forms WHERE Tbl_Forms.Formulario='" & strFiltro & "';")
                If ds.Tables(0).Rows.Count = 0 Then
                    incluir.Gravar()
                End If
            Next

        End If

    End Sub

    Private Sub Frm_Permissoes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal
        CarregaUsuarios()
        VerificaFormsCad()
    End Sub

    Private Sub cboIDVendedor_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboIDVendedor.SelectionChangeCommitted
        CarregaFormsUser(cboIDVendedor.SelectedValue)
        CarregaForms(cboIDVendedor.SelectedValue)
    End Sub
    Private Sub btPermitir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPermitir.Click
        If booBloquear = True Then
            MsgBox("Você precisa escolher um formulário.", 16, strSistema)
            Exit Sub
        End If

        Dim permitir As New ClsPermissoes

        permitir.IDUser = cboIDVendedor.SelectedValue
        permitir.IDForm = strIDForm
        permitir.Formulario = GeraHash(strFormulario)
        permitir.NomeUser = strNomeUser
        permitir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            permitir.Gravar()
        Catch ex As Exception
            MsgBox("Ao incluir permissão ocorreu o erro: " & ex.Message, 16, strSistema)
            Exit Sub

        End Try
        CarregaForms(cboIDVendedor.SelectedValue)
        CarregaFormsUser(cboIDVendedor.SelectedValue)
    End Sub
    Private Sub btBloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBloquear.Click

        If booBloquear = False Then
            MsgBox("Você precisa escolher um formulário do usuário.", 16, strSistema)
            Exit Sub
        End If

        If Confirma("Confirma exclusão da permissão?") Then
            Dim bloquear As New ClsPermissoes

            bloquear.IDForm = strIDForm
            bloquear.IDUser = cboIDVendedor.SelectedValue
            Try
                bloquear.Excluir()
            Catch ex As Exception
                MsgBox("Ao excluir permissão ocorreu o erro: " & ex.Message)
                Exit Sub

            End Try
            CarregaForms(cboIDVendedor.SelectedValue)
            CarregaFormsUser(cboIDVendedor.SelectedValue)
        End If
    End Sub
    Private Sub DGFormsSistema_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGFormsSistema.RowEnter
        If Not DGFormsSistema.Rows(e.RowIndex).Cells(0).Value Is DBNull.Value Then
            strIDForm = DGFormsSistema.Rows(e.RowIndex).Cells(0).Value
            strFormulario = DGFormsSistema.Rows(e.RowIndex).Cells(1).Value
        End If
        booBloquear = False
    End Sub
    Private Sub DGFormsUser_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGFormsUser.RowEnter
        If Not DGFormsUser.Rows(e.RowIndex).Cells(0).Value Is DBNull.Value Then
            strIDForm = DGFormsUser.Rows(e.RowIndex).Cells(1).Value
        End If
        booBloquear = True
    End Sub
End Class