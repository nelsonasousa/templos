Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class Frm_Lista_Presencas

    Dim str_SQL_Sub_Report(3) As String
    Dim sDatas(11) As String

    Public Sub SubreportProcessingEvent(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)

        Try
            Dim ds_Subs As DataSet
            Dim Busca As New ClsDados

            For I = 0 To (2) 'Faz loop pela qtde de subs informada na int_Qtde_subs

                ds_Subs = Busca.RetornarDataSet(str_SQL_Sub_Report(I))

                Dim rptDataSource As New ReportDataSource("DS_Det" & I, ds_Subs.Tables(0))

                e.DataSources.Add(rptDataSource)

            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Carrega_Cbo_Classes()

        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select IDClasse,Classe From Tbl_Classes" & _
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

        'preenche a combobox com os nomes das Livros e seleciona o primeiro valor    
        With cbo_Classe
            .DataSource = dt
            .DisplayMember = "Classe"
            .ValueMember = "IDClasse"
        End With


    End Sub

    Private Function Carrega_Trimestre() As Boolean
        Dim bRet As Boolean = True
        Dim iDias As Integer = DateDiff("d", txt_Data_Inicial.Value, txt_Data_Inicial.Value.AddDays(77))
        Dim dAux As Date = txt_Data_Inicial.Value
        Dim iQtdeDom As Integer = 0

        For I = 0 To iDias

            If Weekday(dAux) = 1 Then

                sDatas(iQtdeDom) = Format(dAux, "yyyy/MM/dd")
                iQtdeDom += 1
            End If
            dAux = DateAdd("d", 1, dAux)
        Next

        If iQtdeDom <> 12 Then
            bRet = False
        End If

        Return bRet

    End Function
    Private Sub btImprime_Click(sender As Object, e As EventArgs) Handles btImprime.Click


        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dtMain = New DataTable
        Dim rptv = New ReportViewer()
        rptv.ProcessingMode = ProcessingMode.Local

        Dim nome_arquivo_pdf As String = ""
        Dim sTitulo As String = ""
        Dim sTotais As String = ""
        Dim dtIni As String = Format(txt_Data_Inicial.Value, "yyyy/MM/dd")
        Dim dtFim As String = Format(txt_Data_Inicial.Value.AddDays(77), "yyyy/MM/dd")

        If Weekday(dtIni) <> 1 Then

            MessageBox.Show("A data inicial deve ser um domingo." & vbCrLf + "Informe nova data de início.", Application.ProductName + "Versão: " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        lblDigita.Text = "Aguarde...montando relatório."
        Application.DoEvents()

        If Not Carrega_Trimestre() Then
            MessageBox.Show("A quantidade de domingos deve ser igual a 12(doze)." & vbCrLf + "Informe nova data de início.", Application.ProductName + "Versão: " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Busca.ExecutaSQL("DELETE * FROM Tbl_Trimestre;") 'Limpa Tbl_Trimestre

        Busca.ExecutaSQL("INSERT INTO Tbl_Trimestre (D1,D2,D3,D4,D5,D6,D7,D8,D9,D10,D11,D12)" & _
                         " Values(#" & sDatas(0) & "#,#" & sDatas(1) & "#,#" & sDatas(2) & "#," & _
                         " #" & sDatas(3) & "#,#" & sDatas(4) & "#,#" & sDatas(5) & "#," & _
                         " #" & sDatas(6) & "#,#" & sDatas(7) & "#,#" & sDatas(8) & "#," & _
                         " #" & sDatas(9) & "#,#" & sDatas(10) & "#,#" & sDatas(11) & "#);") 'Preenche Tbl_Trimestre

        Dim strSQL As String = "SELECT * FROM Tbl_Classes WHERE IDClasse=" & cbo_Classe.SelectedValue & ";"

        str_SQL_Sub_Report(2) = "SELECT * FROM Tbl_Trimestre;"

        str_SQL_Sub_Report(1) = "SELECT Tbl_Pessoas.Pessoa, Tbl_Pessoas.DataNascimento" & _
            " FROM (Tbl_Classes INNER JOIN Tbl_Pessoas_Grupos ON Tbl_Classes.IDClasse = Tbl_Pessoas_Grupos.IDClasse)" & _
            " INNER JOIN Tbl_Pessoas ON Tbl_Pessoas_Grupos.IDPessoa = Tbl_Pessoas.IDPessoa" & _
            " WHERE(((Tbl_Classes.IDClasse) =" & cbo_Classe.SelectedValue & ") And ((Tbl_Pessoas_Grupos.Contar_Presenca) = NO)" & _
            " AND (Tbl_Pessoas_Grupos.DataBaixa IS NULL))" & _
            " ORDER BY Tbl_Pessoas.Pessoa;"

        str_SQL_Sub_Report(0) = "SELECT Tbl_Pessoas.Pessoa, Tbl_Pessoas.DataNascimento" & _
            " FROM (Tbl_Classes INNER JOIN Tbl_Pessoas_Grupos ON Tbl_Classes.IDClasse = Tbl_Pessoas_Grupos.IDClasse)" & _
            " INNER JOIN Tbl_Pessoas ON Tbl_Pessoas_Grupos.IDPessoa = Tbl_Pessoas.IDPessoa" & _
            " WHERE(((Tbl_Classes.IDClasse) =" & cbo_Classe.SelectedValue & ") And ((Tbl_Pessoas_Grupos.Contar_Presenca) = Yes)" & _
            " AND (Tbl_Pessoas_Grupos.DataBaixa IS NULL))" & _
            " ORDER BY Tbl_Pessoas.Pessoa;"


        nome_arquivo_pdf = strPathReport & "\Chamada_" & cbo_Classe.Text & ".pdf"
        rptv.LocalReport.ReportPath = Application.StartupPath & "\CA\Relatorios\Rpt_Chamadas.rdlc"
        sTitulo = "CLASSE " & cbo_Classe.Text

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
        AddHandler rptv.LocalReport.SubreportProcessing, AddressOf SubreportProcessingEvent

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

        lblDigita.Text = "Escolha o departamento e informe a data inicial"
        Application.DoEvents()


    End Sub

    Private Sub Frm_Lista_Presencas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MdiParent = Frm_Principal

        Carrega_Cbo_Classes()
        lblDigita.Text = "Escolha o departamento e informe a data inicial"
        Application.DoEvents()


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class