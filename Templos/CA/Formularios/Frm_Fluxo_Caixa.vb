
Public Class Frm_Fluxo_Caixa
    Dim strIDMovFinanceiro As String
#Region "Rotinas do programador"

    Private Sub CarregaGrid()
        Dim ds As New DataSet
        Dim Busca As New ClsDados

        Dim decTTCrdAberto As Decimal = 0
        Dim decTTDebAberto As Decimal = 0

        Dim decTTCrdBaixado As Decimal = 0
        Dim decTTDebBaixado As Decimal = 0

        Dim sSQL As String = "SELECT Tbl_Mov_Financeiros.IDFinanceiro, Tbl_Mov_Financeiros.TipoFinanceiro, " &
            " Tbl_Mov_Financeiros.DataVencimento, Tbl_Pessoas.Pessoa, Tbl_Categorias.Categoria, Tbl_Mov_Financeiros.Titulo," &
            " Tbl_Mov_Financeiros.ValorTitulo, Tbl_Mov_Financeiros.DataPagamento" &
            " FROM (Tbl_Mov_Financeiros INNER JOIN Tbl_Pessoas ON Tbl_Mov_Financeiros.IDPessoa = Tbl_Pessoas.IDPessoa)" &
            " INNER JOIN Tbl_Categorias ON Tbl_Mov_Financeiros.IDCategoria = Tbl_Categorias.IDCategoria" &
            " ORDER BY Tbl_Mov_Financeiros.DataVencimento;"

        Dim I As Integer

        ds = Busca.RetornarDataSet(sSQL)
        'preenche a dgCustoFixo
        With dgFluxo_Caixa

            .Columns.Clear()

            .DataSource = ds.Tables(0)

            .Columns(0).Name = "IDFinanceiro"
            .Columns(0).Visible = False

            .Columns(1).Name = "TipoFinanceiro"
            .Columns(1).Width = 30
            .Columns(1).HeaderText = "D/C"

            .Columns(2).Name = "DataVencimento"
            .Columns(2).Width = 90
            .Columns(2).HeaderText = "Vencimento"

            .Columns(3).Name = "Pessoa"
            .Columns(3).Width = 150
            .Columns(3).HeaderText = "Sacado"
            .Columns(3).ReadOnly = True

            .Columns(4).Name = "Categoria"
            .Columns(4).Width = 50
            .Columns(4).HeaderText = "Tipo"
            .Columns(4).ReadOnly = True

            .Columns(5).Name = "Titulo"
            .Columns(5).Width = 100
            .Columns(5).HeaderText = "Titulo"
            .Columns(5).ReadOnly = True

            .Columns(6).Name = "ValorTitulo"
            .Columns(6).Width = 100
            .Columns(6).HeaderText = "R$ Valor"
            .Columns(6).DefaultCellStyle.Format = "C2"
            .Columns(6).ReadOnly = True

            .Columns(7).Name = "DataPagamento"
            .Columns(7).Width = 90
            .Columns(7).HeaderText = "Dt. Baixa"
            .Columns(7).ReadOnly = True

            .Update()
            .Refresh()
        End With

        Dim sLinha As Int32

        For I = 0 To ds.Tables(0).Rows.Count - 1
            If (ds.Tables(0).Rows(I).Item("DataPagamento").ToString = Nothing) And ds.Tables(0).Rows(I).Item("TipoFinanceiro").ToString = "C" Then
                decTTCrdAberto += ds.Tables(0).Rows(I).Item("ValorTitulo")
            ElseIf (ds.Tables(0).Rows(I).Item("DataPagamento").ToString = Nothing) And ds.Tables(0).Rows(I).Item("TipoFinanceiro").ToString = "D" Then
                decTTDebAberto += ds.Tables(0).Rows(I).Item("ValorTitulo")
            ElseIf (ds.Tables(0).Rows(I).Item("DataPagamento").ToString <> Nothing) And ds.Tables(0).Rows(I).Item("TipoFinanceiro").ToString = "D" Then
                decTTDebBaixado += ds.Tables(0).Rows(I).Item("ValorTitulo")
                sLinha = I
            ElseIf (ds.Tables(0).Rows(I).Item("DataPagamento").ToString <> Nothing) And ds.Tables(0).Rows(I).Item("TipoFinanceiro").ToString = "C" Then
                decTTCrdBaixado += ds.Tables(0).Rows(I).Item("ValorTitulo")
                sLinha = I
            End If
        Next

        sLinha += 1

        'Formata a caixa em formato de moeda
        ctxt_Total_Credito_Aberto.Text = Format(decTTCrdAberto, "C2")
        ctxt_Total_Debito_Aberto.Text = Format(decTTDebAberto, "C2")
        ctxt_Total_Credito_Baixado.Text = Format(decTTCrdBaixado, "C2")
        ctxt_Total_Debito_Baixado.Text = Format(decTTDebBaixado, "C2")

        If (dgFluxo_Caixa.RowCount = 0) Then
            Exit Sub
        End If
        If (sLinha < dgFluxo_Caixa.Rows.Count) Then
            dgFluxo_Caixa.FirstDisplayedScrollingRowIndex = sLinha
            dgFluxo_Caixa.CurrentCell = dgFluxo_Caixa.Rows(sLinha).Cells(1)

            dgFluxo_Caixa.Rows(sLinha).Selected = True


        End If



    End Sub

#End Region

#Region "Código dos botões"

    Private Sub cmdIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIncluir.Click
        Frm_Financeiro.Tag = "Dialogo"
        Frm_Financeiro.ShowDialog()

        Dim saldoanterior As New ClsFluxoCaixa
        saldoanterior.BuscaSaldo()
        CarregaGrid()
    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        strIDLocaliza = strIDMovFinanceiro
        If strIDLocaliza = 0 Then
            MsgBox("Você precisa selecionar uma conta.", 64, strSistema)
            Exit Sub
        End If
        Frm_Financeiro.Tag = "Dialogo"
        Frm_Financeiro.ShowDialog()

        Dim saldoanterior As New ClsFluxoCaixa
        saldoanterior.BuscaSaldo()
        CarregaGrid()

        strIDLocaliza = 0
    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        If strIDMovFinanceiro = 0 Then
            MsgBox("Você precisa selecionar uma conta.", 64, strSistema)
            Exit Sub
        End If

        Dim Excluir As New ClsFinanceiro

        Excluir.IDMovFinanceiro = strIDMovFinanceiro
        Excluir.Buscar()

        Dim ret As Integer

        ret = MsgBox("Deseja excluir o título: " & Excluir.Titulo & " ?", 36, strSistema)

        If ret = vbYes Then
            Excluir.Excluir()
            MsgBox("Registro Excluído com Sucesso", 64, strSistema)

            Dim saldoanterior As New ClsFluxoCaixa
            saldoanterior.BuscaSaldo()
            CarregaGrid()
        Else
            MsgBox("Operação Cancelada", 64, strSistema)
        End If

    End Sub
    Private Sub cmdBaixar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBaixar.Click
        If strIDMovFinanceiro = 0 Then
            MsgBox("Você precisa selecionar uma conta.", 64, strSistema)
            Exit Sub
        End If

        Dim baixar As New ClsFinanceiro

        baixar.IDMovFinanceiro = strIDMovFinanceiro
        baixar.Buscar()
        baixar.DataPagamento = Format(Date.Today, "yyyy/MM/dd")
        baixar.NomeUser = strNomeUser
        baixar.DataDigita = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")

        Dim ret As Integer

        ret = MsgBox("Deseja baixar o título: " & baixar.Titulo & " ?", 36, strSistema)

        If ret = vbYes Then
            baixar.Pagar()
            Dim saldoanterior As New ClsFluxoCaixa
            saldoanterior.BuscaSaldo()
            CarregaGrid()
        End If
    End Sub

#End Region

#Region "Eventos dos campos"

    'Evento ao entrar no formulário
    Private Sub Frm_Fluxo_Caixa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal

        CarregaGrid()
    End Sub

    'Evento do Grid
    Private Sub dgFluxo_Caixa_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFluxo_Caixa.RowEnter
        If Not dgFluxo_Caixa.Rows(e.RowIndex).Cells(0).Value Is DBNull.Value Then
            strIDMovFinanceiro = dgFluxo_Caixa.Rows(e.RowIndex).Cells("IDFinanceiro").Value
            If Not dgFluxo_Caixa.Rows(e.RowIndex).Cells("DataPagamento").Value Is DBNull.Value Then
                cmdIncluir.Focus()
                cmdAlterar.Enabled = False
                cmdExcluir.Enabled = False
                cmdBaixar.Enabled = False
            Else
                cmdAlterar.Enabled = True
                cmdExcluir.Enabled = True
                cmdBaixar.Enabled = True
            End If

        End If
    End Sub


    Private Sub dgFluxo_Caixa_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgFluxo_Caixa.CellFormatting

        If e.RowIndex <= 0 Then
            Exit Sub
        End If

        If (dgFluxo_Caixa.Rows(e.RowIndex).Cells("TipoFinanceiro").Value = "D") Then
            dgFluxo_Caixa.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
        End If

    End Sub


#End Region

End Class