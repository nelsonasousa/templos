
Public Class Frm_Empresta_Livro
    Dim strIDEmprestimo As String
    Dim strIDLivro As String

    Private Sub CarregaLivros()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select IDLivro,Titulo From Tbl_Livros" & _
                                   " WHERE Disponivel='Sim' order by Titulo")

        dt.Columns.Add("Titulo", GetType(System.String))
        dt.Columns.Add("IDLivro", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Titulo") = dr("Titulo")
            NovaDr("IDLivro") = dr("IDLivro")
            dt.Rows.Add(NovaDr)
        Next

        'preenche a combobox com os nomes das Livros e seleciona o primeiro valor    
        With cboIDLivro
            .DataSource = dt
            .DisplayMember = "Titulo"
            .ValueMember = "IDLivro"
        End With


    End Sub
    Private Sub CarregaPessoas()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select IDPessoa,Pessoa From Tbl_Pessoas" & _
                                   " WHERE TipoPessoa<>'Fornecedor' AND IDPessoa>1 order by Pessoa")

        dt.Columns.Add("Pessoa", GetType(System.String))
        dt.Columns.Add("IDPessoa", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Pessoa") = dr("Pessoa")
            NovaDr("IDPessoa") = dr("IDPessoa")
            dt.Rows.Add(NovaDr)
        Next

        'preenche a combobox com os nomes das Livros e seleciona o primeiro valor    
        With cboIDPessoa
            .DataSource = dt
            .DisplayMember = "Pessoa"
            .ValueMember = "IDPessoa"
        End With


    End Sub
    Private Sub CarregaGridEmprestimos()
        Dim ds As New DataSet
        Dim Busca As New ClsDados

        'limpa o grid
        LimpaGridEmprestimos()

        ds = Busca.RetornarDataSet("SELECT Tbl_Emprestimos.IDEmprestimo, Tbl_Emprestimos.IDMembro," & _
                                   " Tbl_Emprestimos.IDLivro, Tbl_Livros.Titulo, Tbl_Pessoas.Pessoa," & _
                                   " Tbl_Emprestimos.DataEmprestimo" & _
                                   " FROM (Tbl_Emprestimos INNER JOIN Tbl_Pessoas ON Tbl_Emprestimos.IDMembro = Tbl_Pessoas.IDPessoa)" & _
                                   " INNER JOIN Tbl_Livros ON Tbl_Emprestimos.IDLivro = Tbl_Livros.IDLivro" & _
                                   " WHERE DataDevolucao IS NULL" & _
                                   " ORDER BY Tbl_Livros.Titulo, Tbl_Emprestimos.DataEmprestimo;")

        'preenche a DGProdutos
        With DGEmprestimos

            .DataSource = ds.Tables(0)

            .Columns(0).Visible = False
            .Columns(0).Name = "IDEmprestimo"

            .Columns(1).Visible = False
            .Columns(1).Name = "IDMembro"

            .Columns(2).Visible = False
            .Columns(2).Name = "IDLivro"

            .Columns(3).Name = "Titulo"
            .Columns(3).Width = 220
            .Columns(3).HeaderText = "Título"
            .Columns(3).ReadOnly = True

            .Columns(4).Name = "Pessoa"
            .Columns(4).Width = 220
            .Columns(4).HeaderText = "Pessoa"
            .Columns(4).ReadOnly = True

            .Columns(5).Name = "DataEmprestimo"
            .Columns(5).Width = 80
            .Columns(5).HeaderText = "Dt.Empréstimo"
            .Columns(5).ReadOnly = True

        End With


    End Sub
    Private Sub LimpaGridEmprestimos()
        DGEmprestimos.Columns.Clear()
    End Sub

    Private Sub btEmprestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEmprestar.Click
        Dim empresta As New ClsEmprestimos

        empresta.IDLivro = cboIDLivro.SelectedValue
        empresta.IDMembro = cboIDPessoa.SelectedValue
        empresta.DataEmprestimo = Format(Date.Today, "yyyy/MM/dd")
        empresta.NomeUser = strNomeUser
        empresta.DataDigita = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")
        empresta.Disponivel = "Nao"
        Try
            empresta.Gravar()
            empresta.Disponibiliza()
            CarregaLivros()
            CarregaGridEmprestimos()
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao emprestar um livro ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            empresta = Nothing
        End Try

        MsgBox("Livro emprestado com sucesso.", 64, strSistema)

        Limpar(GrpEmprestar)

        cboIDLivro.Focus()
    End Sub

    Private Sub DGEmprestimos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGEmprestimos.DoubleClick
        Dim empresta As New ClsEmprestimos

        empresta.IDEmprestimo = strIDEmprestimo
        empresta.IDLivro = strIDLivro
        empresta.DataDevolucao = Format(Date.Today, "yyyy/MM/dd")
        empresta.NomeUser = strNomeUser
        empresta.DataDigita = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")
        empresta.Disponivel = "Sim"
        Try
            empresta.Devolver()
            empresta.Disponibiliza()
            CarregaLivros()
            CarregaGridEmprestimos()
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao emprestar um livro ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            empresta = Nothing
        End Try

        MsgBox("Livro devolvido com sucesso.", 64, strSistema)

        Limpar(GrpEmprestar)

        cboIDLivro.Focus()
    End Sub

    Private Sub DGEmprestimos_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGEmprestimos.RowEnter
        If Not DGEmprestimos.Rows(e.RowIndex).Cells(0).Value Is DBNull.Value Then
            strIDEmprestimo = DGEmprestimos.Rows(e.RowIndex).Cells(0).Value
            strIDLivro = DGEmprestimos.Rows(e.RowIndex).Cells(2).Value
        End If
    End Sub

    Private Sub Frm_Empresta_Livro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal
        CarregaLivros()
        CarregaPessoas()
        CarregaGridEmprestimos()
    End Sub

    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        '   Dim ' crReportDocument As New ReportDocument

        Dim strSQL As String = "SELECT Tbl_Emprestimos.DataEmprestimo,Tbl_Livros.Titulo,Tbl_Pessoas.Pessoa," & _
        " Tbl_Pessoas.Telefone FROM (Tbl_Emprestimos INNER JOIN Tbl_Pessoas" & _
        " ON Tbl_Emprestimos.IDMembro = Tbl_Pessoas.IDPessoa)" & _
        " INNER JOIN Tbl_Livros ON Tbl_Emprestimos.IDLivro = Tbl_Livros.IDLivro" & _
        " WHERE Tbl_Emprestimos.DataDevolucao IS NULL ORDER BY Tbl_Emprestimos.DataEmprestimo"

        Try

            '1 passo: carregar o relatório
            Dim strReportPath As String = "C:\Projetos\VBNET\SGT\SGT\Emprestimos.rpt"
            'Dim strReportPath As String = strPathReport & "\Emprestimos.rpt"
            ' crReportDocument.Load(strReportPath)
            ' crReportDocument.SummaryInfo.ReportAuthor = strSistema
            ' crReportDocument.SummaryInfo.ReportTitle = "Livros Emprestados"
            ds = Busca.RetornarDataSet(strSQL)

            'configurando para impressão em Landscape
            '' crReportDocument.PrintOptions.PaperOrientation = PaperOrientation.Landscape

            '2 passo: passar os dados para o relatório (datatable)
            'carregando os dados 
            ' crReportDocument.SetDataSource(ds.Tables(0))


            '
            'visualizando o relatório
            '

            'criar uma instância do form printpreview
            '       Dim ofrmPrintPreview As New Frm_Report

            'definindo o ReportSource do printpreview
            'ofrmPrintPreview.crPrintPreview.DisplayGroupTree = False
            '   ofrmPrintPreview.crPrintPreview.ReportSource = ' crReportDocument
            '  ofrmPrintPreview.Text = "Relatório de Livros Emprestados"

            'exibir o form
            '   ofrmPrintPreview.Show()

        Catch ex As Exception
            MsgBox("Ocorreu o erro: " & ex.Message)
            Exit Sub

        End Try
    End Sub
End Class