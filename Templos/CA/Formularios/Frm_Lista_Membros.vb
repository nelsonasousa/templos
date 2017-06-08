Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class Frm_Lista_Membros

    Private Sub CarregaClasses()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("SELECT Tbl_Classes.IDClasse, Tbl_Classes.Classe" & _
                                   " FROM Tbl_Classes " & _
                                   " ORDER BY Tbl_Classes.Classe;")

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

    Private Sub rd_Todos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rd_Todos.CheckedChanged
        If rd_Todos.Checked Then
            cbo_Classe.Visible = False
            lblDigita.Text = "Lista todos os membros."
        Else
            cbo_Classe.Visible = True
            CarregaClasses()
            lblDigita.Text = "Lista os membros da classe/grupo escolhido."
        End If
    End Sub

    Private Sub btImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprime.Click

        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dtMain = New DataTable
        Dim rptv = New ReportViewer()
        rptv.ProcessingMode = ProcessingMode.Local
        Dim nome_arquivo_pdf As String = ""
        Dim sTitulo As String = ""
        Dim sTotais As String = ""
        Dim strSQL As String

        If rd_Todos.Checked Then
            strSQL = "SELECT Tbl_Pessoas.IDPessoa,Tbl_Pessoas.Pessoa,Tbl_Pessoas.Endereco,Tbl_Pessoas.Bairro,Tbl_Pessoas.Cidade," & _
                      " Tbl_Pessoas.Telefone,Tbl_Pessoas.Celular, Tbl_Pessoas.DataNascimento, Tbl_Status.Status" & _
                      " FROM Tbl_Pessoas INNER JOIN Tbl_Status ON Tbl_Pessoas.IDStatus = Tbl_Status.IDStatus" & _
                      " WHERE ((Tbl_Pessoas.TipoPessoa) ='Membro')  ORDER BY Tbl_Pessoas.Pessoa;"

            nome_arquivo_pdf = strPathReport & "Pessoas.pdf"
            rptv.LocalReport.ReportPath = Application.StartupPath & "\CA\Relatorios\Rpt_Pessoas.rdlc"
            sTitulo = "Listagem Geral de Pessoas"

        Else
            strSQL = "SELECT Tbl_Pessoas.IDPessoa,Tbl_Pessoas.Pessoa,Tbl_Pessoas.Endereco,Tbl_Pessoas.Bairro,Tbl_Pessoas.Cidade," & _
                      " Tbl_Pessoas.Telefone,Tbl_Pessoas.Celular, Tbl_Pessoas.DataNascimento, Tbl_Status.Status" & _
            " FROM ((Tbl_Pessoas INNER JOIN Tbl_Pessoas_Grupos ON Tbl_Pessoas.IDPessoa = Tbl_Pessoas_Grupos.IDPessoa)" & _
            " INNER JOIN Tbl_Status ON Tbl_Pessoas.IDStatus = Tbl_Status.IDStatus)" & _
            " WHERE (((Tbl_Pessoas.TipoPessoa) ='Membro') And ((Tbl_Pessoas_Grupos.DataBaixa) Is Null)" & _
            " And ((Tbl_Pessoas_Grupos.IDClasse) =" & cbo_Classe.SelectedValue & "))" & _
            " ORDER BY Tbl_Pessoas.Pessoa;"

            nome_arquivo_pdf = strPathReport & "\Classe_" & cbo_Classe.Text & ".pdf"
            rptv.LocalReport.ReportPath = Application.StartupPath & "\CA\Relatorios\Rpt_Pessoas.rdlc"
            sTitulo = "Listagem de Integrantes da Classe " & cbo_Classe.Text

        End If



        dtMain = Busca.RetornarDataTAble(strSQL)
        'ds = Busca.RetornarDataSet(strSQL)
        'Busca dados ro relatório principal
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
        '// rptv.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler)
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
    End Sub

    Private Sub Frm_Lista_Membros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal

    End Sub
End Class