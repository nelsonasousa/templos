Public Class Frm_Lista_Fluxo_Caixa

    Private Sub CarregaTblTemp()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim strDtInicial As String = Format(txtDataInicial.Value, "yyyy/MM/dd")
        Dim strDtFinal As String = Format(txtDataFinal.Value, "yyyy/MM/dd")

        Dim I As Integer

        If cboTipo.Text = "Previsto" Then
            ds = Busca.RetornarDataSet("SELECT Tbl_Mov_Financeiros.IDFinanceiro,Tbl_Mov_Financeiros.DataVencimento," & _
                                      " Tbl_Pessoas.Pessoa,Tbl_Mov_Financeiros.Titulo,Tbl_Mov_Financeiros.ValorTitulo AS CRD," & _
                                      " 0 AS DBT" & _
                                      " FROM Tbl_Mov_Financeiros INNER JOIN Tbl_Pessoas" & _
                                      " ON Tbl_Mov_Financeiros.IDPessoa = Tbl_Pessoas.IDPessoa" & _
                                      " WHERE (Tbl_Mov_Financeiros.TipoFinanceiro = 'C')" & _
                                      " AND ((Tbl_Mov_Financeiros.DataVencimento) BETWEEN #" & strDtInicial & "#" & _
                                      " AND #" & strDtFinal & "#)" & _
                                      " UNION ALL" & _
                                      " SELECT Tbl_Mov_Financeiros_1.IDFinanceiro,Tbl_Mov_Financeiros_1.DataVencimento," & _
                                      " Tbl_Pessoas_1.Pessoa, Tbl_Mov_Financeiros_1.Titulo, 0 AS Expr1," & _
                                      " Tbl_Mov_Financeiros_1.ValorTitulo AS CRD" & _
                                      " FROM Tbl_Mov_Financeiros AS Tbl_Mov_Financeiros_1 INNER JOIN" & _
                                      " Tbl_Pessoas AS Tbl_Pessoas_1 ON Tbl_Mov_Financeiros_1.IDPessoa" & _
                                      " = Tbl_Pessoas_1.IDPessoa WHERE  (Tbl_Mov_Financeiros_1.TipoFinanceiro = 'D')" & _
                                      " AND ((Tbl_Mov_Financeiros_1.DataVencimento) BETWEEN #" & strDtInicial & "#" & _
                                      " AND #" & strDtFinal & "#)" & _
                                      " ORDER BY Tbl_Mov_Financeiros.DataVencimento")
        Else
            ds = Busca.RetornarDataSet("SELECT Tbl_Mov_Financeiros.IDFinanceiro,Tbl_Mov_Financeiros.DataVencimento," & _
                           " Tbl_Pessoas.Pessoa,Tbl_Mov_Financeiros.Titulo,Tbl_Mov_Financeiros.ValorTitulo AS CRD," & _
                           " 0 AS DBT" & _
                           " FROM Tbl_Mov_Financeiros INNER JOIN Tbl_Pessoas" & _
                           " ON Tbl_Mov_Financeiros.IDPessoa = Tbl_Pessoas.IDPessoa" & _
                           " WHERE (Tbl_Mov_Financeiros.TipoFinanceiro = 'C')" & _
                           " AND ((Tbl_Mov_Financeiros.DataVencimento) BETWEEN #" & strDtInicial & "#" & _
                           " AND #" & strDtFinal & "#) AND Tbl_Mov_Financeiros.DataPagamento IS NOT NULL" & _
                           " UNION ALL" & _
                           " SELECT Tbl_Mov_Financeiros_1.IDFinanceiro,Tbl_Mov_Financeiros_1.DataVencimento," & _
                           " Tbl_Pessoas_1.Pessoa, Tbl_Mov_Financeiros_1.Titulo, 0 AS Expr1," & _
                           " Tbl_Mov_Financeiros_1.ValorTitulo AS CRD" & _
                           " FROM Tbl_Mov_Financeiros AS Tbl_Mov_Financeiros_1 INNER JOIN" & _
                           " Tbl_Pessoas AS Tbl_Pessoas_1 ON Tbl_Mov_Financeiros_1.IDPessoa" & _
                           " = Tbl_Pessoas_1.IDPessoa WHERE  (Tbl_Mov_Financeiros_1.TipoFinanceiro = 'D')" & _
                           " AND ((Tbl_Mov_Financeiros_1.DataVencimento) BETWEEN #" & strDtInicial & "#" & _
                           " AND #" & strDtFinal & "#) AND Tbl_Mov_Financeiros_1.DataPagamento IS NOT NULL" & _
                           " ORDER BY Tbl_Mov_Financeiros.DataVencimento")
        End If

        Dim gravar As New ClsFluxoCaixa

        gravar.ExcluirFluxo()


        For I = 0 To ds.Tables(0).Rows.Count - 1

            gravar.IDMovFinanceiro = ds.Tables(0).Rows(I).Item(0)
            gravar.DataVencimento = Format(ds.Tables(0).Rows(I).Item(1), "yyyy/MM/dd")
            gravar.Entidade = ds.Tables(0).Rows(I).Item(2)
            gravar.Titulo = ds.Tables(0).Rows(I).Item(3)
            gravar.CRD = ds.Tables(0).Rows(I).Item(4)
            gravar.DBT = ds.Tables(0).Rows(I).Item(5)

            gravar.GravarFluxo()
        Next

    End Sub

    Private Sub btImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprime.Click

        Dim ds As New DataSet
        Dim dsSaldo As New DataSet
        Dim Busca As New ClsDados
        '  Dim ' crReportDocument As New ReportDocument
        CarregaTblTemp()

        Dim strSQLFluxo As String = ("SELECT Tbl_Fluxo_Caixa.IDMov, Tbl_Fluxo_Caixa.DTMov," & _
                                     " Tbl_Fluxo_Caixa.Nome, Tbl_Fluxo_Caixa.Titulo," & _
                                     " [CD] AS CDT," & _
                                     " [DB] AS DBT," & _
                                     " Format((SELECT Sum(DD.CD - DD.DB) FROM Tbl_Fluxo_Caixa AS DD" & _
                                     " WHERE DD.IDMov <= Tbl_Fluxo_Caixa.IDMov),'Standard') AS Saldo" & _
                                     " FROM Tbl_Fluxo_Caixa ORDER BY Tbl_Fluxo_Caixa.IDMov;")

        Dim strSQLSaldo As String = ("Select TOP 1 * From Tbl_Saldos ORDER BY DataSaldo DESC;")


        Try

            '1 passo: carregar o relatório

            ' crReportDocument = New FluxoCaixa

            ' crReportDocument.SummaryInfo.ReportAuthor = strSistema
            ' crReportDocument.SummaryInfo.ReportTitle = "Fluxo de Caixa " & cboTipo.Text


            ds = Busca.RetornarDataSet(strSQLFluxo)
            dsSaldo = Busca.RetornarDataSet(strSQLSaldo)

            'configurando para impressão em Landscape
            '' crReportDocument.PrintOptions.PaperOrientation = PaperOrientation.Landscape

            '2 passo: passar os dados para o relatório (datatable)
            'carregando os dados 
            ' crReportDocument.SetDataSource(ds.Tables(0))
            ' crReportDocument.OpenSubreport("SaldoAnterior.rpt").SetDataSource(dsSaldo.Tables(0))

            '
            'visualizando o relatório
            '

            'criar uma instância do form printpreview
            ' Dim ofrmPrintPreview As New Frm_Report

            'definindo o ReportSource do printpreview
            'ofrmPrintPreview.crPrintPreview.DisplayGroupTree = False
            '    ofrmPrintPreview.crPrintPreview.ReportSource = ' crReportDocument

            'exibir o form
            '  ofrmPrintPreview.Show()

        Catch ex As Exception
            MsgBox("Ao carregar o relatório ocorreu o erro: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub Frm_Lista_Fluxo_Caixa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal

    End Sub
End Class