Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class Frm_Aniversariantes

    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click

        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim rptv = New ReportViewer()
        rptv.ProcessingMode = ProcessingMode.Local
        Dim strMes As String = cboMes.SelectedText

        Select Case cboMes.SelectedItem
            Case "Janeiro"
                strMes = 1
            Case "Fevereiro"
                strMes = 2
            Case "Março"
                strMes = 3
            Case "Abril"
                strMes = 4
            Case "Maio"
                strMes = 5
            Case "Junho"
                strMes = 6
            Case "Julho"
                strMes = 7
            Case "Agosto"
                strMes = 8
            Case "Setembro"
                strMes = 9
            Case "Outubro"
                strMes = 10
            Case "Novembro"
                strMes = 11
            Case "Dezembro"
                strMes = 12
        End Select

        Dim strSQL As String

        If cboMes.Text = "Todos" Then
            strSQL = "SELECT IDPessoa,Pessoa,DataNascimento,Endereco,Bairro,Telefone,Celular,Email FROM Tbl_Pessoas" &
        " WHERE (TipoPessoa <> 'Fornecedor') ORDER BY Pessoa;"
        Else
            strSQL = "SELECT IDPessoa,Pessoa,DataNascimento,Endereco,Bairro,Telefone,Celular,Email FROM Tbl_Pessoas" &
        " WHERE (TipoPessoa <> 'Fornecedor')" &
        " AND (Month(DataNascimento)='" & strMes & "')" &
        " ORDER BY Pessoa;"

        End If

        Try


            Dim nome_arquivo_pdf As String = strPathReport & "\Aniversarios_" & cboMes.Text & ".pdf"
            rptv.LocalReport.ReportPath = Application.StartupPath & "\CA\Relatorios\Rpt_Pessoas.rdlc"
            Dim sTitulo As String = "Aniversariantes " & cboMes.Text

            'Busca dados ro relatório principal
            Dim dtMain As DataTable = Busca.RetornarDataTAble(strSQL)
            Dim DS_Main = New ReportDataSource("DS_Main", dtMain)

            '/Monta strings do cabeçalho
            Dim templo = New ClsTemplo()
            templo.IDTemplo = 1
            templo.Buscar()

            Dim cabecalho As String = templo.Templo & vbCrLf & templo.Endereco &
                " - " & templo.Bairro & vbCrLf & templo.CEP.ToString() & " - " &
            templo.Cidade.ToString() & " - " & templo.UF.ToString() & vbCrLf &
            "CNPJ:" & templo.CNPJ.ToString() & "   I.Est.: " & templo.IE.ToString()

            Dim params(3) As ReportParameter
            params(0) = New ReportParameter("RPT_Titulo", sTitulo, True)
            params(1) = New ReportParameter("RPT_Sistema", Application.ProductName & Environment.NewLine & "Versão: " & Application.ProductVersion, True)
            params(2) = New ReportParameter("RPT_Obs1", cabecalho, True)
            params(3) = New ReportParameter("RPT_Totais", "", True)


            rptv.LocalReport.SetParameters(params)

            rptv.LocalReport.DataSources.Clear()
            rptv.LocalReport.DataSources.Add(DS_Main)
            ' Add the handler for the subreport
            '   AddHandler rptv.LocalReport.SubreportProcessing, AddressOf SubreportProcessingEvent

            rptv.LocalReport.Refresh()

            ' //variáveis para renderizar o relatório
            Dim warnings As Warning() = Nothing
            Dim streamids As String() = Nothing
            Dim mimeType As String = Nothing
            Dim encoding As String = Nothing
            Dim extension As String = Nothing

            '//Constrói o relsatório num array de bytes
            Dim bytes As Byte() = rptv.LocalReport.Render("PDF", Nothing, mimeType, encoding, extension, streamids, warnings)



            '//cria o relatório no formato pdf na pasta da variável nome_arquivo
            Dim fs As New FileStream(nome_arquivo_pdf, FileMode.Create)

            fs.Write(bytes, 0, bytes.Length)
            fs.Close()

            ' //abre um processo para rodar o pdf
            Process.Start(nome_arquivo_pdf)

        Catch ex As Exception

            MessageBox.Show("Ocorreu um erro ao gerar relatório." & vbCrLf & "Detalhe: " & ex.Message & vbCrLf &
                            "Verifique se você tem instalado um programa que leia arquivos PDF." & vbCrLf &
                            "Na pasta 'C:\Methodus\Tools\' você encontra um.", Application.ProductName & "Versão: " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Frm_Aniversariantes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal
    End Sub
End Class