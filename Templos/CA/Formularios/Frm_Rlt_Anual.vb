Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class Frm_Rlt_Anual

    Private Sub Carrega_Cbo_Anos()

        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        Dim sSQL As String = "SELECT Year([DataEscola]) AS Ano_Escola FROM Tbl_Escola_Dominical GROUP BY Year([DataEscola])" &
            " ORDER BY Year([DataEscola]);"
        ds = Busca.RetornarDataSet(sSQL)

        dt.Columns.Add("Ano_Escola", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Ano_Escola") = dr("Ano_Escola")
            dt.Rows.Add(NovaDr)
        Next

        With cbo_Anos
            .DataSource = dt
            .DisplayMember = "Ano_Escola"
            .ValueMember = "Ano_Escola"
        End With


    End Sub

    Private Sub btImprime_Click(sender As Object, e As EventArgs) Handles btImprime.Click
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dtMain = New DataTable
        Dim rptv = New ReportViewer()
        rptv.ProcessingMode = ProcessingMode.Local

        Dim nome_arquivo_pdf As String = ""
        Dim sTitulo As String = ""
        Dim sTotais As String = ""
        Dim dtAno As String = cbo_Anos.Text


        lblDigita.Text = "Aguarde...montando relatório."
        Application.DoEvents()

        Dim strSQL As String = "SELECT Year([DataEscola]) AS Ano_Escola,Count(Tbl_Escola_Dominical_Det.IDEscola) AS Domingos, Tbl_Classes.Classe," &
            " Avg(Tbl_Escola_Dominical_Det.TotalMatriculados) AS Med_Matriculados,Avg(Tbl_Escola_Dominical_Det.AlunosPresentes) AS Med_Presentes, Avg(Tbl_Escola_Dominical_Det.TotalMatriculados-Tbl_Escola_Dominical_Det.AlunosPresentes) AS Med_Ausentes," &
            " Avg(Tbl_Escola_Dominical_Det.Biblias) AS Med_Biblias, Avg(Tbl_Escola_Dominical_Det.Revistas) AS Med_Revistas," &
            " Avg(Tbl_Escola_Dominical_Det.Visitantes) AS Med_Visitantes, Sum(Tbl_Escola_Dominical_Det.Ofertas) AS TT_Ofertas," &
            " Avg(Tbl_Escola_Dominical_Det.Ofertas) AS Med_Ofertas" &
            " FROM Tbl_Escola_Dominical INNER JOIN (Tbl_Escola_Dominical_Det INNER JOIN Tbl_Classes ON Tbl_Escola_Dominical_Det.IDClasse" &
            " = Tbl_Classes.IDClasse) ON Tbl_Escola_Dominical.IDEscola = Tbl_Escola_Dominical_Det.IDEscola" &
            " GROUP BY Year([DataEscola]), Tbl_Classes.Classe HAVING (((Year([DataEscola]))=" & dtAno & "));"


        nome_arquivo_pdf = strPathReport & "\Resumo_" & cbo_Anos.Text & ".pdf"
        rptv.LocalReport.ReportPath = Application.StartupPath & "\CA\Relatorios\Rpt_Resumo_Anual.rdlc"
        sTitulo = "Resumo Anual Escola Dominical"

        'Busca dados ro relatório principal
        dtMain = Busca.RetornarDataTAble(strSQL)
        Dim DS_Main = New ReportDataSource("DS_Main", dtMain)

        '/Monta strings do cabeçalho
        Dim templo = New ClsTemplo()
        templo.IDTemplo = 1
        templo.Buscar()


        Dim cabecalho As String = templo.Templo + Environment.NewLine + templo.Endereco +
            " - " + templo.Bairro + Environment.NewLine + templo.CEP + " - " +
            templo.Cidade + " - " + templo.UF.ToString() + Environment.NewLine +
            "CNPJ:" + templo.CNPJ + "   I.Est.: " + templo.IE

        Dim params(3) As ReportParameter
        params(0) = New ReportParameter("RPT_Titulo", sTitulo, True)
        params(1) = New ReportParameter("RPT_Sistema", Application.ProductName + Environment.NewLine + "Versão: " + Application.ProductVersion, True)
        params(2) = New ReportParameter("RPT_Obs1", cabecalho, True)
        params(3) = New ReportParameter("RPT_Totais", sTotais, True)


        rptv.LocalReport.SetParameters(params)

        rptv.LocalReport.DataSources.Clear()
        rptv.LocalReport.DataSources.Add(DS_Main)

        ' Add the handler for the subreport

        rptv.LocalReport.Refresh()

        ' //variáveis para renderizar o relatório
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing


        Try
            '//Constrói o relsatório num array de bytes
            Dim bytes As Byte() = rptv.LocalReport.Render("PDF", Nothing, mimeType, encoding, extension, streamids, warnings)



            '//cria o relatório no formato pdf na pasta da variável nome_arquivo

            Dim fs As New FileStream(nome_arquivo_pdf, FileMode.Create)

            fs.Write(bytes, 0, bytes.Length)
            fs.Close()

            ' //abre um processo para rodar o pdf
            Process.Start(nome_arquivo_pdf)

        Catch ex As Exception

            MessageBox.Show("Ocorreu um erro ao gerar relatório. Detalhe: " + ex.Message, Application.ProductName + "Versão: " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        lblDigita.Text = " "
        Application.DoEvents()


    End Sub

    Private Sub Frm_Rlt_Anual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Frm_Principal

        Carrega_Cbo_Anos()
    End Sub
End Class