Public Class Frm_Pessoas_Ocorrencias

    Dim strIDOcorrencia As String
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
        With cboPessoa
            .DataSource = dt
            .DisplayMember = "Pessoa"
            .ValueMember = "IDPessoa"
        End With

        cboPessoa.Text = ""
    End Sub
    Private Sub CarregaOcorrencias()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select IDOcorrencia,Ocorrencia From Tbl_Ocorrencias" & _
                                   " order by Ocorrencia")

        dt.Columns.Add("Ocorrencia", GetType(System.String))
        dt.Columns.Add("IDOcorrencia", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Ocorrencia") = dr("Ocorrencia")
            NovaDr("IDOcorrencia") = dr("IDOcorrencia")
            dt.Rows.Add(NovaDr)
        Next

        'preenche a combobox com os nomes das Livros e seleciona o primeiro valor    
        With cboOcorrencia
            .DataSource = dt
            .DisplayMember = "Ocorrencia"
            .ValueMember = "IDOcorrencia"
        End With

        cboOcorrencia.Text = ""

    End Sub

    Private Sub CarregaGridOcorrencias()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim strFiltro As String = cboPessoa.SelectedValue
        'limpa o grid
        LimpaGridOcorrencias()


        ds = Busca.RetornarDataSet("SELECT Tbl_Ocorrencias.IDOcorrencia,Tbl_Pessoas_Ocorrencias.DataOcorrencia,Tbl_Ocorrencias.Ocorrencia" & _
                       " FROM Tbl_Pessoas_Ocorrencias INNER JOIN Tbl_Ocorrencias" & _
                       " ON Tbl_Pessoas_Ocorrencias.IDOcorrencia = Tbl_Ocorrencias.IDOcorrencia" & _
                       " WHERE (Tbl_Pessoas_Ocorrencias.IDPessoa =" & strFiltro & ")" & _
                       " ORDER BY Tbl_Pessoas_Ocorrencias.DataOcorrencia;")

        'preenche a DGProdutos
        With dg_Ocorrencias

            .DataSource = ds.Tables(0)

            .Columns(0).Name = "IDOcorrencia"
            .Columns(0).Visible = False

            .Columns(1).Name = "DataOcorrencia"
            .Columns(1).Width = 80
            .Columns(1).HeaderText = "Data"

            .Columns(2).Name = "Ocorrencia"
            .Columns(2).Width = 220
            .Columns(2).HeaderText = "Ocorrência"



        End With
    End Sub
    Private Sub LimpaGridOcorrencias()
        dg_Ocorrencias.Columns.Clear()
    End Sub

    Private Sub btInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInserir.Click

        Dim incluir As New ClsOcorrencias()


        'Carrega as variáveis da classe clsAgenda com os valores do formulário
        incluir.IDOcorrencia = cboOcorrencia.SelectedValue
        incluir.IDPessoa = cboPessoa.SelectedValue
        incluir.DataOcorrencia = Format(txtDataOcorrencia.Value, "yyyy/MM/dd")
        incluir.NomeUser = strNomeUser
        incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            'Chama a rotina de gravação da classe
            incluir.IncluirOcorrencia()
            CarregaGridOcorrencias()
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao incluir uma ocorrência ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            incluir = Nothing
        End Try

        MsgBox("Ocorrência Registrada com sucesso.", 64, strSistema)


    End Sub

    Private Sub cboOcorrencia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOcorrencia.GotFocus
        lblDigita.Text = "EScolha a ocorrência."
        cboOcorrencia.DroppedDown = True
    End Sub

    Private Sub cboPessoa_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPessoa.GotFocus
        lblDigita.Text = "Escolha o membro."
        cboPessoa.DroppedDown = True
    End Sub

    Private Sub txtDataOcorrencia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDataOcorrencia.GotFocus
        lblDigita.Text = "Informe a data da ocorrência."
    End Sub

    Private Sub Frm_Pessoas_Ocorrencias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal
        txtDataOcorrencia.Value = Date.Today
        CarregaOcorrencias()
        CarregaPessoas()

    End Sub

    Private Sub cboPessoa_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboPessoa.SelectionChangeCommitted
        CarregaGridOcorrencias()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Limpar(grpRegistro)
        LimpaGridOcorrencias()
        cboPessoa.Focus()

    End Sub

    Private Sub dg_Ocorrencias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Ocorrencias.CellDoubleClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If cboPessoa.Text = Nothing Then
            MsgBox("Você precisa escolher uma pessoa.", 64, strSistema)
            Exit Sub

        End If
        If Confirma("Confirma exclusão de ocorrência?") Then

            Dim exclui As New ClsOcorrencias
            exclui.IDOcorrencia = strIDOcorrencia
            exclui.IDPessoa = cboPessoa.SelectedValue
            exclui.Excluir()
            CarregaGridOcorrencias()
        End If

    End Sub

    Private Sub dg_Ocorrencias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Ocorrencias.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        strIDOcorrencia = dg_Ocorrencias.Rows(e.RowIndex).Cells("IDOcorrencia").Value
    End Sub
End Class