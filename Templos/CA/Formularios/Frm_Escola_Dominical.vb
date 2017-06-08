Imports Microsoft.Reporting.WinForms
Imports System.IO


Public Class Frm_Escola_Dominical
    Dim strIDEscola As String
    Dim strIDClasse As String
    Dim iLinhaClasse As Integer, iLinhaAluno As Integer
    Dim iLinhaLocaliza As Integer = 0
    Dim iColunaClasse As Integer, iColunaAluno As Integer
    Dim strIDAluno As String, strBr As String
    Dim str_SQL_Sub_Report(4) As String
    Dim bInsereAluno As Boolean

    Public Sub SubreportProcessingEvent(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)

        Try
            Dim ds_Subs As DataSet
            Dim Busca As New ClsDados

            For I = 0 To (4) 'Faz loop pela qtde de subs informada na int_Qtde_subs

                ds_Subs = Busca.RetornarDataSet(str_SQL_Sub_Report(I))

                Dim rptDataSource As New ReportDataSource("DS_Det" & I, ds_Subs.Tables(0))

                e.DataSources.Add(rptDataSource)

            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub AbreEscola()
        Dim abre As New ClsEscolaDominical
        Dim iAno As Integer = Date.Today.Year
        Dim iDiaMes As String = "01/01/"

        Dim iData As Date = CDate(iDiaMes & CStr(iAno))

        Do While iAno = iData.Year
            If iData.DayOfWeek = 0 Then

                abre.DataEscola = Format(iData, "yyyy/MM/dd")
                abre.NomeUser = strNomeUser
                abre.DataDigita = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")

                Try
                    abre.Gravar()
                Catch ex As Exception
                    'Caso ocorra erro mostra a menssagem abaixo
                    MsgBox("Ao abrir escola anual ocorreu o erro: " & ex.Message)
                    Exit Sub
                End Try

            End If
            iData = iData.AddDays(1)
        Loop

    End Sub
    Private Sub InsereClasses(ByVal strEscola As String)
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim I As Byte
        Dim insere As New ClsEscolaDominical

        insere.IDEscola = strEscola
        insere.NomeUser = strNomeUser
        insere.DataDigita = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")


        ds = Busca.RetornarDataSet("SELECT Tbl_Classes.IDClasse" &
                                   " FROM Tbl_Classes" &
                                   " WHERE Escola='Sim' AND DataDesativa IS NULL" &
                                   " ORDER BY Tbl_Classes.IDClasse;")

        If ds.Tables(0).Rows.Count > 1 Then
            For I = 0 To ds.Tables(0).Rows.Count - 1
                insere.IDClasse = ds.Tables(0).Rows(I).Item("IDClasse")
                insere.TotalMatriculados = RetornaMatriculados(ds.Tables(0).Rows(I).Item("IDClasse"))
                insere.AlunosPresentes = RetornaMatriculados(ds.Tables(0).Rows(I).Item("IDClasse"))
                insere.Biblias = 0
                insere.Revistas = 0
                If insere.TotalMatriculados > 0 Then
                    insere.InsereClasse()
                End If
            Next
        End If

    End Sub
    Private Sub InsereAlunos(ByVal strEscola As String)
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim I As Byte
        Dim insere As New ClsEscolaDominical

        insere.IDEscola = strEscola
        insere.NomeUser = strNomeUser
        insere.DataEscola = Format(txtDataEscola.Value, "yyyy/MM/dd")
        insere.DataDigita = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")

        ds = Busca.RetornarDataSet("SELECT Tbl_Pessoas_Grupos.IDClasse,Tbl_Pessoas_Grupos.IDPessoa" &
                                   " FROM Tbl_Pessoas_Grupos INNER JOIN Tbl_Classes" &
                                   " ON Tbl_Pessoas_Grupos.IDClasse=Tbl_Classes.IDClasse" &
                                   " WHERE (((Tbl_Classes.Escola)='Sim') AND ((Tbl_Classes.DataDesativa) Is Null)" &
                                   " AND ((Tbl_Pessoas_Grupos.DataBaixa) Is Null) AND ((Tbl_Pessoas_Grupos.Contar_Presenca)=True))" &
                                   " ORDER BY Tbl_Pessoas_Grupos.IDPessoa;")

        If ds.Tables(0).Rows.Count > 1 Then
            For I = 0 To ds.Tables(0).Rows.Count - 1
                insere.IDClasse = ds.Tables(0).Rows(I).Item("IDClasse")
                insere.IDPessoa = ds.Tables(0).Rows(I).Item("IDPessoa")
                insere.Presente = "Sim"
                insere.Biblia = "Sim"
                insere.Revista = "Sim"
                Try
                    insere.InsereAluno()
                Catch ex As Exception
                    'Caso ocorra erro mostra a menssagem abaixo
                    MsgBox("Ao fazer a inserção do aluno ocorreu o erro: " & ex.Message & ":::" & insere.IDPessoa)
                    Exit Sub
                End Try
            Next
            bInsereAluno = False
        End If

    End Sub
    Private Sub EditaClasse()
        Dim edita As New ClsEscolaDominical

        edita.IDEscola = strIDEscola
        edita.IDClasse = strIDClasse
        edita.TotalMatriculados = DGAlunos.RowCount()
        edita.AlunosPresentes = edita.RetonaPresentes

        If strBr = "Não" Then
            edita.Biblias = DGClasses.Rows(iLinhaClasse).Cells("Biblias").Value
            edita.Revistas = DGClasses.Rows(iLinhaClasse).Cells("Revistas").Value
        Else
            edita.Biblias = edita.RetonaBiblias
            edita.Revistas = edita.RetonaRevistas
        End If


        edita.Visitantes = DGClasses.Rows(iLinhaClasse).Cells("Visitantes").Value
        edita.Ofertas = DGClasses.Rows(iLinhaClasse).Cells("Ofertas").Value
        edita.NomeUser = strNomeUser
        edita.DataDigita = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")

        edita.EditaClasse()

        edita = Nothing
    End Sub
    Private Sub CarregaBR()
        Dim br As New ClsTemplo
        br.IDTemplo = br.BuscarId
        strBr = br.BuscarBR()
        br = Nothing
    End Sub
    Private Sub CarregaGridClasses(ByVal strFiltro As String)
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim intMatriculados As Integer = 0, intPresentes As Integer = 0
        Dim intVisitantes As Integer = 0, intAusentes As Integer = 0
        Dim intBiblias As Integer = 0, intRevistas As Integer = 0
        Dim decOfertas As Decimal = 0, I As Integer = 0

        'limpa o grid
        LimpaGridClasses()

        Dim sSQL As String = "SELECT Tbl_Escola_Dominical_Det.IDEscola,Tbl_Escola_Dominical_Det.IDClasse," &
                                   " Tbl_Classes.Classe,Tbl_Escola_Dominical_Det.TotalMatriculados," &
                                   " Tbl_Escola_Dominical_Det.AlunosPresentes," &
                                   " Tbl_Escola_Dominical_Det.TotalMatriculados - Tbl_Escola_Dominical_Det.AlunosPresentes AS Ausentes," &
                                   " Tbl_Escola_Dominical_Det.Visitantes,Tbl_Escola_Dominical_Det.Biblias,Tbl_Escola_Dominical_Det.Revistas," &
                                   " Tbl_Escola_Dominical_Det.AlunosPresentes +Tbl_Escola_Dominical_Det.Visitantes AS TTPV," &
                                   " Tbl_Escola_Dominical_Det.Ofertas,IIF([TotalMatriculados]>0,([AlunosPresentes]/[TotalMatriculados])*100,0) AS Perc_Pre," &
                                   " IIF([TotalMatriculados]>0,([Biblias]/[AlunosPresentes])*100,0) AS Perc_Bib" &
                                   " FROM Tbl_Escola_Dominical_Det INNER JOIN Tbl_Classes " &
                                   " ON Tbl_Escola_Dominical_Det.IDClasse=Tbl_Classes.IDClasse" &
                                   " WHERE Tbl_Escola_Dominical_Det.IDEscola=" & strFiltro & " ORDER BY Tbl_Classes.IDClasse;"

        ds = Busca.RetornarDataSet(sSQL)

        'preenche a DGProdutos
        With DGClasses

            .DataSource = ds.Tables(0)

            .Columns(0).Visible = False
            .Columns(0).Name = "IDEscola"

            .Columns(1).Visible = False
            .Columns(1).Name = "IDClasse"

            .Columns(2).Name = "Classe"
            .Columns(2).Width = 150
            .Columns(2).HeaderText = "Classe"
            .Columns(2).ReadOnly = True

            .Columns(3).Name = "TotalMatriculados"
            .Columns(3).Width = 60
            .Columns(3).HeaderText = "Matriculados"

            .Columns(4).Name = "AlunosPresentes"
            .Columns(4).Width = 60
            .Columns(4).HeaderText = "Presentes"
            .Columns(4).ReadOnly = True

            .Columns(5).Name = "Ausentes"
            .Columns(5).Width = 70
            .Columns(5).HeaderText = "Ausentes"
            .Columns(5).ReadOnly = True

            .Columns(6).Name = "Visitantes"
            .Columns(6).Width = 60
            .Columns(6).HeaderText = "Visitas"

            .Columns(7).Name = "Biblias"
            .Columns(7).Width = 60
            .Columns(7).HeaderText = "Bíblias"
            If strBr = "Sim" Then
                .Columns(7).ReadOnly = True
            End If

            .Columns(8).Name = "Revistas"
            .Columns(8).Width = 60
            .Columns(8).HeaderText = "Revistas"
            If strBr = "Sim" Then
                .Columns(8).ReadOnly = True
            End If

            .Columns(9).Name = "TTPV"
            .Columns(9).Width = 60
            .Columns(9).HeaderText = "Total Pres."
            .Columns(9).ReadOnly = True

            .Columns(10).Name = "Ofertas"
            .Columns(10).Width = 80
            .Columns(10).HeaderText = "Ofertas"

            .Columns(11).Name = "Perc_Pre"
            .Columns(11).Width = 60
            .Columns(11).HeaderText = "% Pres."
            .Columns(11).ReadOnly = True
            .Columns(11).DefaultCellStyle.Format = "#,##0.00"

            .Columns(12).Name = "Perc_Bib"
            .Columns(12).Width = 60
            .Columns(12).HeaderText = "% Bíb."
            .Columns(12).ReadOnly = True
            .Columns(12).DefaultCellStyle.Format = "#,##0.00"



        End With
        For I = 0 To ds.Tables(0).Rows.Count - 1

            intMatriculados += ds.Tables(0).Rows(I).Item("TotalMatriculados")
            intPresentes += ds.Tables(0).Rows(I).Item("AlunosPresentes")
            intAusentes += ds.Tables(0).Rows(I).Item("Ausentes")
            intVisitantes += ds.Tables(0).Rows(I).Item("Visitantes")
            intBiblias += ds.Tables(0).Rows(I).Item("Biblias")
            intRevistas += ds.Tables(0).Rows(I).Item("Revistas")
            decOfertas += ds.Tables(0).Rows(I).Item("Ofertas")
        Next
        txtMatriculados.Text = intMatriculados
        txtAlunosPresentes.Text = intPresentes
        ntxt_Ausentes.Text = intAusentes
        txtVisitantes.Text = intVisitantes
        txtTotalPresentes.Text = intPresentes + intVisitantes
        txtTotalBiblias.Text = intBiblias
        txtTotalRevistas.Text = intRevistas
        txtTotalOfertas.Text = Format(decOfertas, "#,##0.00")

    End Sub
    Private Sub LimpaGridClasses()
        DGClasses.Columns.Clear()
    End Sub
    Private Sub CarregaGridPresenca(ByVal strClasse As String)
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim sSQL As String
        'limpa o grid
        LimpaGridPresenca()

        If strBr = "Sim" Then

            sSQL = "SELECT Tbl_Escola_Dominical_Presenca.IDEscola,Tbl_Escola_Dominical_Presenca.IDPessoa," &
                                       " Tbl_Escola_Dominical_Presenca.IDClasse,Tbl_Pessoas.Pessoa,Tbl_Escola_Dominical_Presenca.Presente,Tbl_Escola_Dominical_Presenca.Biblia," &
                                       " Tbl_Escola_Dominical_Presenca.Revista" &
                                       " FROM Tbl_Escola_Dominical_Presenca INNER JOIN Tbl_Pessoas" &
                                       " ON Tbl_Escola_Dominical_Presenca.IDPessoa = Tbl_Pessoas.IDPessoa" &
                                       " WHERE (Tbl_Escola_Dominical_Presenca.IDClasse =" & strClasse & ")" &
                                       " AND Tbl_Escola_Dominical_Presenca.IDEscola=" & strIDEscola & " ORDER BY Tbl_Pessoas.Pessoa;"

        Else
            sSQL = "SELECT Tbl_Escola_Dominical_Presenca.IDEscola,Tbl_Escola_Dominical_Presenca.IDPessoa," &
                           " Tbl_Escola_Dominical_Presenca.IDClasse,Tbl_Pessoas.Pessoa,Tbl_Escola_Dominical_Presenca.Presente" &
                           " FROM Tbl_Escola_Dominical_Presenca INNER JOIN Tbl_Pessoas" &
                           " ON Tbl_Escola_Dominical_Presenca.IDPessoa = Tbl_Pessoas.IDPessoa" &
                           " WHERE (Tbl_Escola_Dominical_Presenca.IDClasse =" & strClasse & ")" &
                           " AND Tbl_Escola_Dominical_Presenca.IDEscola=" & strIDEscola & " ORDER BY Tbl_Pessoas.Pessoa;"

        End If

        ds = Busca.RetornarDataSet(sSQL)

        'preenche a DGProdutos
        With DGAlunos

            .DataSource = ds.Tables(0)

            .Columns(0).Visible = False
            .Columns(0).Name = "IDEscola"

            .Columns(1).Visible = False
            .Columns(1).Name = "IDPessoa"

            .Columns(2).Visible = False
            .Columns(2).Name = "IDClasse"

            .Columns(3).Name = "Pessoa"
            .Columns(3).Width = 200
            .Columns(3).HeaderText = "Aluno"

            .Columns(4).Name = "Presente"
            .Columns(4).Width = 70
            .Columns(4).HeaderText = "Presente"

            If strBr = "Sim" Then
                .Columns(5).Name = "Biblia"
                .Columns(5).Width = 70
                .Columns(5).HeaderText = "Bíblia"

                .Columns(6).Name = "Revista"
                .Columns(6).Width = 70
                .Columns(6).HeaderText = "Revista"
            End If

        End With
    End Sub
    Private Sub LimpaGridPresenca()
        DGAlunos.Columns.Clear()
    End Sub
    Private Sub Carrega_Grid_Localiza()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim iAno As Integer = Date.Today.Year

        'limpa o grid
        Limpa_Grid_Localiza()

        Dim sSql = "SELECT IDEscola,DataEscola,DataFechamento FROM Tbl_Escola_Dominical WHERE (((Year([DataEscola]))=" & iAno & "))" &
                                   " ORDER BY Tbl_Escola_Dominical.DataEscola;"

        ds = Busca.RetornarDataSet(sSql)

        'preenche a DGProdutos
        With dg_Localiza

            .DataSource = ds.Tables(0)

            .Columns(0).Visible = False
            .Columns(0).Name = "IDEscola"

            .Columns(1).Name = "DataEscola"
            .Columns(1).Width = 150
            .Columns(1).HeaderText = "Data"
            .Columns(1).ReadOnly = True

            .Columns(2).Name = "DataFechamento"
            .Columns(2).Visible = False

        End With

        If ds.Tables(0).Rows.Count = 0 Then
            Exit Sub
        End If

        For I = 0 To ds.Tables(0).Rows.Count - 1
            If ds.Tables(0).Rows(I).Item("DataFechamento").ToString <> Nothing Then
                iLinhaLocaliza = I
            End If
        Next
        iLinhaLocaliza += 1

        If (iLinhaLocaliza <= dg_Localiza.Rows.Count) Then
            dg_Localiza.FirstDisplayedScrollingRowIndex = iLinhaLocaliza
            dg_Localiza.CurrentCell = dg_Localiza.Rows(iLinhaLocaliza).Cells(1)

            dg_Localiza.Rows(iLinhaLocaliza).Selected = True


        End If



    End Sub
    Private Sub Limpa_Grid_Localiza()
        dg_Localiza.Columns.Clear()
    End Sub


    Private Sub Frm_Escola_Dominical_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        MdiParent = Frm_Principal

        CarregaBR()

        Carrega_Grid_Localiza()

        bInsereAluno = True

        If dg_Localiza.RowCount <= 1 Then
            If Confirma("Confirma abertura do do ano: " & Date.Today.Year & " ? ") Then
                AbreEscola()
                Carrega_Grid_Localiza()
            End If
        End If

    End Sub


    Private Sub DGAlunos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGAlunos.DoubleClick

        If (txt_Data_Fechamento.Text = "") Or (txt_Data_Fechamento.Text = Nothing) Then

            Dim edita As New ClsEscolaDominical
            edita.IDClasse = strIDClasse
            edita.IDPessoa = strIDAluno
            edita.IDEscola = strIDEscola
            edita.BuscaAluno()

            edita.NomeUser = strNomeUser
            edita.DataDigita = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")

            If DGAlunos.CurrentCell.ColumnIndex = 4 Then
                If DGAlunos.CurrentCell.Value = "Sim" Then
                    DGAlunos.CurrentCell.Value = "Não"
                    edita.Presente = "Não"
                    edita.Biblia = "Não"
                    edita.Revista = "Não"
                Else
                    DGAlunos.CurrentCell.Value = "Sim"
                End If
                edita.Presente = DGAlunos.CurrentCell.Value
                edita.EditaPresenca()
            ElseIf DGAlunos.CurrentCell.ColumnIndex = 5 Then
                If DGAlunos.CurrentCell.Value = "Sim" Then
                    DGAlunos.CurrentCell.Value = "Não"
                Else
                    DGAlunos.CurrentCell.Value = "Sim"
                End If
                edita.Biblia = DGAlunos.CurrentCell.Value
                edita.EditaPresenca()
            ElseIf DGAlunos.CurrentCell.ColumnIndex = 6 Then
                If DGAlunos.CurrentCell.Value = "Sim" Then
                    DGAlunos.CurrentCell.Value = "Não"
                Else
                    DGAlunos.CurrentCell.Value = "Sim"
                End If
                edita.Revista = DGAlunos.CurrentCell.Value
                edita.EditaPresenca()
            ElseIf DGAlunos.CurrentCell.ColumnIndex = 3 Then
                If Confirma("Confirma exclusão do aluno deste domingo?") Then
                    edita.Exclui_Aluno()
                End If
                edita.EditaPresenca()
            End If
            CarregaGridPresenca(strIDClasse)

            DGAlunos.CurrentCell = DGAlunos.Rows(iLinhaAluno).Cells("Presente")
            DGAlunos.Rows(iLinhaAluno).Selected = True
            DGAlunos.FirstDisplayedScrollingColumnIndex = iColunaAluno

            DGAlunos.FirstDisplayedScrollingRowIndex = iLinhaAluno

            EditaClasse()
            CarregaGridClasses(strIDEscola)

            DGClasses.Rows(iLinhaClasse).Selected = True
            DGClasses.FirstDisplayedScrollingRowIndex = iLinhaClasse
            edita = Nothing

        End If


    End Sub
    Private Sub DGAlunos_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGAlunos.RowEnter
        If Not DGAlunos.Rows(e.RowIndex).Cells(0).Value Is DBNull.Value Then
            strIDEscola = DGAlunos.Rows(e.RowIndex).Cells("IDEscola").Value
            strIDAluno = DGAlunos.Rows(e.RowIndex).Cells("IDPessoa").Value
            strIDClasse = DGAlunos.Rows(e.RowIndex).Cells("IDClasse").Value

        End If
    End Sub

    Private Sub DGClasses_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGClasses.CellFormatting

        Dim int_Biblias As Integer = DGClasses.Rows(e.RowIndex).Cells("Biblias").Value
        Dim int_Matriculados As Integer = CInt(DGClasses.Rows(e.RowIndex).Cells("AlunosPresentes").Value) + CInt(DGClasses.Rows(e.RowIndex).Cells("Visitantes").Value)
        Dim int_revistas As Integer = DGClasses.Rows(e.RowIndex).Cells("Revistas").Value

        If int_Biblias > int_Matriculados Then
            DGClasses.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            lbl_Biblias.Visible = True
        ElseIf int_revistas > int_Matriculados Then
            DGClasses.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Purple
            lbl_Revistas.Visible = True
        Else
            DGClasses.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            lbl_Revistas.Visible = False
            lbl_Biblias.Visible = False
        End If

    End Sub
    Private Sub DGClasses_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGClasses.CellValueChanged
        Dim edita As New ClsEscolaDominical()


        If e.RowIndex < 0 Then
            Exit Sub
        End If

        edita.IDEscola = strIDEscola
        edita.IDClasse = strIDClasse
        edita.TotalMatriculados = DGClasses.Rows(e.RowIndex).Cells("TotalMatriculados").Value
        edita.AlunosPresentes = edita.RetonaPresentes
        edita.Biblias = DGClasses.Rows(e.RowIndex).Cells("Biblias").Value
        edita.Revistas = DGClasses.Rows(e.RowIndex).Cells("Revistas").Value
        edita.Visitantes = DGClasses.Rows(e.RowIndex).Cells("Visitantes").Value
        edita.Ofertas = DGClasses.Rows(e.RowIndex).Cells("Ofertas").Value
        edita.NomeUser = strNomeUser
        edita.DataDigita = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            edita.EditaClasse()
            CarregaGridClasses(strIDEscola)
            DGClasses.CurrentCell = DGClasses.Rows(iLinhaClasse).Cells(2)
            DGClasses.Rows(iLinhaClasse).Selected = True

            DGClasses.FirstDisplayedScrollingColumnIndex = iColunaClasse
            DGClasses.FirstDisplayedScrollingRowIndex = iLinhaClasse

        Catch ex As Exception
            MsgBox("Ocorreu o erro: " & ex.Message)
            Exit Sub

        End Try

    End Sub
    Private Sub DGClasses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGClasses.CellClick

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If DGClasses.RowCount > 0 Then

            iLinhaClasse = e.RowIndex
            iColunaClasse = e.ColumnIndex

            strIDClasse = DGClasses.Rows(e.RowIndex).Cells("IDClasse").Value
            CarregaGridPresenca(strIDClasse)
            If bInsereAluno Then
                If DGAlunos.RowCount = 0 Then
                    If Format(txtDataEscola.Value, "yyyy/MM/dd") <> Format(Date.Today, "yyyy/MM/dd") Then
                        If Confirma("O domingo selecionado não corresponde ao dia de hoje." & vbCrLf & "Deseja realmente inserir os alunos?") Then
                            InsereAlunos(strIDEscola)
                            CarregaGridPresenca(strIDClasse)
                        End If
                    Else
                        InsereAlunos(strIDEscola)

                        CarregaGridPresenca(strIDClasse)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click

        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dtMain = New DataTable
        Dim rptv = New ReportViewer()
        rptv.ProcessingMode = ProcessingMode.Local
        Dim nome_arquivo_pdf As String = ""
        Dim sTitulo As String = ""
        Dim sTotais As String = ""
        Dim dtDiaHoje As String = txtDataEscola.Value
        Dim dtSegunda As String = Format(txtDataEscola.Value.AddDays(-6), "yyyy/MM/dd")
        Dim dtMes As String = txtDataEscola.Value.Month
        Dim dtDAtaEscola As String = Format(txtDataEscola.Value, "yyyy/MM/dd")
        Dim dtInicial As String = Format(txtDataEscola.Value.AddDays(7), "yyyy/MM/dd")

        Dim strSQL As String = "SELECT * FROM Tbl_Escola_Dominical WHERE IDEscola=" & strIDEscola & ";"

        str_SQL_Sub_Report(0) = "SELECT Tbl_Escola_Dominical_Det.IDEscola,Tbl_Escola_Dominical_Det.IDClasse," &
                                   " Tbl_Classes.Classe,Tbl_Escola_Dominical_Det.TotalMatriculados," &
                                   " Tbl_Escola_Dominical_Det.AlunosPresentes," &
                                   " Tbl_Escola_Dominical_Det.TotalMatriculados - Tbl_Escola_Dominical_Det.AlunosPresentes AS Ausentes," &
                                   " Tbl_Escola_Dominical_Det.Visitantes,Tbl_Escola_Dominical_Det.Biblias,Tbl_Escola_Dominical_Det.Revistas," &
                                   " Tbl_Escola_Dominical_Det.AlunosPresentes +Tbl_Escola_Dominical_Det.Visitantes AS TTPV," &
                                   " Tbl_Escola_Dominical_Det.Ofertas,([AlunosPresentes]/[TotalMatriculados])*100 AS Perc_Pre," &
                                   " ([Biblias]/[AlunosPresentes])*100 AS Perc_Bib" &
                                   " FROM Tbl_Escola_Dominical_Det INNER JOIN Tbl_Classes " &
                                   " ON Tbl_Escola_Dominical_Det.IDClasse=Tbl_Classes.IDClasse" &
                                   " WHERE Tbl_Escola_Dominical_Det.IDEscola=" & strIDEscola & " ORDER BY Tbl_Classes.IDClasse;"

        Busca.ExecutaSQL("DELETE * FROM Tbl_Aniversarios;") 'Limpa Tbl_Aniversários
        Busca.ExecutaSQL("INSERT INTO Tbl_Aniversarios ( Pessoa, DataAniversario,Classe)" &
                         " SELECT Tbl_Pessoas.Pessoa, DateAdd('yyyy',Year(Now())-Year([DataNascimento]),[DataNascimento]) AS DT_Atualiuzada," &
                         " Tbl_Classes.Classe FROM (Tbl_Pessoas INNER JOIN Tbl_Pessoas_Grupos ON Tbl_Pessoas.IDPessoa = Tbl_Pessoas_Grupos.IDPessoa)" &
                         " INNER JOIN Tbl_Classes ON Tbl_Pessoas_Grupos.IDClasse = Tbl_Classes.IDClasse " &
                         " WHERE (((Tbl_Pessoas_Grupos.DataBaixa) Is Null) AND ((Tbl_Classes.Escola)='Sim'));") 'Preenche Tbl_Aniversarios

        str_SQL_Sub_Report(1) = "SELECT Tbl_Aniversarios.Pessoa, Tbl_Aniversarios.DataAniversario AS DataNascimento,Tbl_Aniversarios.Classe FROM Tbl_Aniversarios" &
            " WHERE (((Tbl_Aniversarios.DataAniversario) Between #" & dtSegunda & "# And #" & dtDAtaEscola & "#))" &
            " ORDER BY Tbl_Aniversarios.DataAniversario;"


        str_SQL_Sub_Report(2) = "SELECT Tbl_Classes.Classe, (([AlunosPresentes]/[TotalMatriculados])*100) AS Perc_Pre" &
            " FROM Tbl_Escola_Dominical_Det INNER JOIN Tbl_Classes ON Tbl_Escola_Dominical_Det.IDClasse = Tbl_Classes.IDClasse" &
            " WHERE ((Tbl_Escola_Dominical_Det.IDEscola)=" & strIDEscola & ")  " &
            " AND (([AlunosPresentes]/[TotalMatriculados])*100)=(SELECT Max((([AlunosPresentes]/[TotalMatriculados])*100))" &
            " FROM Tbl_Escola_Dominical_Det INNER JOIN Tbl_Classes ON Tbl_Escola_Dominical_Det.IDClasse = Tbl_Classes.IDClasse" &
            " WHERE (Tbl_Escola_Dominical_Det.IDEscola=" & strIDEscola & "))"

        str_SQL_Sub_Report(3) = "SELECT Tbl_Classes.Classe, IIf(([Biblias]/[AlunosPresentes])*100>100,100," &
            " ([Biblias]/[AlunosPresentes])*100) AS Perc_Bib" &
            " FROM Tbl_Escola_Dominical_Det INNER JOIN Tbl_Classes" &
            " ON Tbl_Escola_Dominical_Det.IDClasse = Tbl_Classes.IDClasse" &
            " WHERE (((IIf(([Biblias]/[AlunosPresentes])*100>100,100,([Biblias]/[AlunosPresentes])*100))=100)" &
            " And ((Tbl_Escola_Dominical_Det.IDEscola)=" & strIDEscola & ")) ORDER BY Tbl_Classes.Classe;"

        str_SQL_Sub_Report(4) = " Select DataRealizacao, HoraRealizacao, Evento, Organizador, Palestrante,Observacao" &
        " FROM Tbl_Eventos WHERE DataRealizacao BETWEEN #" & dtDAtaEscola & "# And #" & dtInicial & "#" &
        " ORDER BY DataRealizacao, HoraRealizacao"

        Try


            nome_arquivo_pdf = strPathReport & "\EBD_" & Format(txtDataEscola.Value, "dd_MM_yyyy") & ".pdf"
            rptv.LocalReport.ReportPath = Application.StartupPath & "\CA\Relatorios\Rpt_EBD.rdlc"
            sTitulo = "Relatório da Escola Dominical"

            'Busca dados ro relatório principal
            dtMain = Busca.RetornarDataTAble(strSQL)
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
    Private Sub btConfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirma.Click
        If Confirma("Confirma o fechamento do domingo?") Then
            Dim financ As New ClsFinanceiro()
            Dim escola As New ClsEscolaDominical

            escola.IDEscola = strIDEscola
            escola.AlunosPresentes = txtAlunosPresentes.Text
            escola.TotalMatriculados = txtMatriculados.Text
            escola.Biblias = txtTotalBiblias.Text
            escola.Revistas = txtTotalRevistas.Text
            escola.Visitantes = txtVisitantes.Text
            escola.Ofertas = txtTotalOfertas.Text
            escola.NomeUser = strNomeUser
            escola.DataDigita = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")
            escola.DataFechamento = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")

            financ.TipoFinanceiro = "C"
            financ.Titulo = "EBD-" & txtDataEscola.Value.DayOfYear & Month(txtDataEscola.Value) & Year(txtDataEscola.Value).ToString().Substring(2, 2)
            financ.IDPessoa = 1
            financ.DataEmissao = Format(txtDataEscola.Value, "yyyy/MM/dd")
            financ.DataVencimento = Format(txtDataEscola.Value, "yyyy/MM/dd")
            financ.ValorTitulo = txtTotalOfertas.Text
            financ.Observacao = "Ofertas da Escola"
            financ.NomeUser = strNomeUser
            financ.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")
            financ.IDCategoria = 1

            Try
                escola.Editar()
                financ.Gravar()
                MsgBox("Fechamento efetuado com sucesso.", 64, strSistema)
                btConfirma.Enabled = False
                grpResumo.Enabled = False
                Carrega_Grid_Localiza()
            Catch ex As Exception
                'Caso ocorra erro mostra a menssagem abaixo
                MsgBox("Ao fazer o fechamento de escola ocorreu o erro: " & ex.Message)
                Exit Sub
            Finally
                'Limpa a variável incluir
                financ = Nothing
                escola = Nothing
            End Try
        End If

    End Sub
    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        Dim edita As New ClsEscolaDominical
        edita.IDClasse = strIDClasse
        edita.IDPessoa = strIDAluno
        edita.IDEscola = strIDEscola

        Try
            edita.Exclui_Aluno()
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao excluir o aluno ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            CarregaGridPresenca(strIDClasse)
            EditaClasse()
            CarregaGridClasses(strIDEscola)
            DGClasses.Rows(iLinhaClasse).Selected = True
            edita = Nothing
        End Try
    End Sub

    Private Sub dg_Localiza_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Localiza.CellClick

        If dg_Localiza.RowCount > 0 Then
            LimpaGridClasses()
            LimpaGridPresenca()

            strIDEscola = dg_Localiza.Rows(e.RowIndex).Cells("IDEscola").Value
            txtDataEscola.Value = CDate(dg_Localiza.Rows(e.RowIndex).Cells("DataEscola").Value)
            txt_Data_Fechamento.Text = dg_Localiza.Rows(e.RowIndex).Cells("DataFechamento").Value.ToString()
            CarregaGridClasses(strIDEscola)
            If DGClasses.RowCount = 0 Then
                InsereClasses(strIDEscola)
                CarregaGridClasses(strIDEscola)
            End If
        End If

        If (txt_Data_Fechamento.Text = "") Or (txt_Data_Fechamento.Text = Nothing) Then
            btConfirma.Enabled = True
            DGAlunos.ReadOnly = False
            DGClasses.ReadOnly = False
        Else
            btConfirma.Enabled = False
            DGAlunos.ReadOnly = True
            DGClasses.ReadOnly = True

        End If
    End Sub

    Private Sub DGAlunos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGAlunos.CellFormatting
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If DGAlunos.Rows(e.RowIndex).Cells("Presente").Value = "Sim" Then
            DGAlunos.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        Else
            DGAlunos.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red

        End If

    End Sub

    Private Sub DGClasses_DoubleClick(sender As Object, e As EventArgs) Handles DGClasses.DoubleClick
        If Confirma("Deseja excluir a classe deste domingo?") Then
            Dim busca As New ClsDados
            Dim classe As New ClsEscolaDominical

            classe.IDEscola = DGClasses.Rows(iLinhaClasse).Cells("IDEscola").Value
            classe.IDClasse = DGClasses.Rows(iLinhaClasse).Cells("IDClasse").Value
            Try
                classe.Exclui_Classe_Domingo()
                CarregaGridClasses(strIDEscola)
            Catch ex As Exception
                'Caso ocorra erro mostra a menssagem abaixo
                MsgBox("Ao fazer o fechamento de escola ocorreu o erro: " & ex.Message)
                Exit Sub
            Finally
                'Limpa a variável incluir
                busca = Nothing
                classe = Nothing
            End Try
        End If
    End Sub

    Private Sub dg_Localiza_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dg_Localiza.CellFormatting

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If IsDBNull(dg_Localiza.Rows(e.RowIndex).Cells("DataFechamento").Value) Then
            dg_Localiza.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        Else
            dg_Localiza.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Green

        End If

    End Sub

    Private Sub bt_Zerar_Click(sender As Object, e As EventArgs) Handles bt_Zerar.Click

        If strIDEscola = 0 Then
            MsgBox("Você precisa escolher um domingo.", 48, strSistema)
            Exit Sub
        End If
        If Confirma("Deseja realmente limpar os dados deste domingo?") Then
            Dim busca As New ClsDados
            Dim detalhes As New ClsEscolaDominical

            detalhes.IDEscola = strIDEscola

            Try
                detalhes.Exclui_Todas_Classes_Domingo()
                detalhes.Exclui_Todos_Alunos_Domingo()
            Catch ex As Exception
                'Caso ocorra erro mostra a menssagem abaixo
                MsgBox("Ao limpar o domingo ocorreu o erro: " & ex.Message, 16, strSistema)
                Exit Sub
            Finally
                'Limpa a variável incluir
                LimpaGridClasses()
                LimpaGridPresenca()
            End Try


        End If


    End Sub

    Private Sub DGAlunos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGAlunos.CellClick
        iLinhaAluno = e.RowIndex
        iColunaAluno = e.ColumnIndex
    End Sub
End Class