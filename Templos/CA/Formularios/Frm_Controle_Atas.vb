Imports System.IO
Imports Word = Microsoft.Office.Interop.Word

Public Class Frm_Controle_Atas

    Dim booNovo As Boolean
    Dim sIDAta As String
    Private Sub CarregaClasses()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select IDClasse,Classe From Tbl_Classes" & _
                                   " order by Classe")

        dt.Columns.Add("Classe", GetType(System.String))
        dt.Columns.Add("IDClasse", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Classe") = dr("Classe")
            NovaDr("IDClasse") = dr("IDClasse")
            dt.Rows.Add(NovaDr)
        Next

        'preenche a combobox com os nomes das Classes e seleciona o primeiro valor    
        With cbo_IDClasse
            .DataSource = dt
            .DisplayMember = "Classe"
            .ValueMember = "IDClasse"
        End With


    End Sub
    Private Sub Carrega_Grid_Localiza()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim Busca As New ClsDados
        Dim sSQL As String = "SELECT Tbl_Atas.IDAta,Tbl_Atas.Nome_Doc FROM Tbl_Atas ORDER BY Tbl_Atas.Nome_DOC;"

        'limpa o grid
        Limpa_Grid_Atas()

        If cbo_IDClasse.Text = Nothing And txt_Filtro.Text <> Nothing Then

            sSQL = "SELECT Tbl_Atas.IDAta,Tbl_Atas.Nome_Doc FROM Tbl_Atas" & _
                " WHERE Tbl_Atas.Palavras_Chave LIKE '*" & txt_Filtro.Text & "*' ORDER BY Tbl_Atas.Nome_DOC;"

        ElseIf cbo_IDClasse.Text <> Nothing And txt_Filtro.Text = Nothing Then

            sSQL = "SELECT Tbl_Atas.IDAta,Tbl_Atas.Nome_Doc FROM Tbl_Atas" & _
                " WHERE Tbl_Atas.ID_Classe=" & cbo_IDClasse.SelectedValue & " ORDER BY Tbl_Atas.Nome_DOC;"

        ElseIf cbo_IDClasse.Text <> Nothing And txt_Filtro.Text <> Nothing Then

            sSQL = "SELECT Tbl_Atas.IDAta,Tbl_Atas.Nome_Doc FROM Tbl_Atas" & _
                " WHERE Tbl_Atas.ID_Classe=" & cbo_IDClasse.SelectedValue & " AND " & _
                " Tbl_Atas.Palavras_Chave LIKE '*" & txt_Filtro.Text & "*' ORDER BY Tbl_Atas.Nome_DOC;"
        End If

        ds = Busca.RetornarDataSet(sSQL)
        ' dt = Busca.RetornarDataTAble(sSQL)
        'preenche a DGProdutos
        With dg_Localiza

            '.DataSource = dt
            .DataSource = ds.Tables(0)

            .Columns(0).Visible = False
            .Columns(0).Name = "IDAta"

            .Columns(1).Name = "Nome_Doc"
            .Columns(1).Width = 150
            .Columns(1).HeaderText = "Ata"
            .Columns(1).ReadOnly = True

        End With
        ntxt_Cadastros.Text = dg_Localiza.RowCount

    End Sub
    Private Sub Limpa_Grid_Atas()
        dg_Localiza.Columns.Clear()
    End Sub
    Private Sub GeraDocumentoWord()
        Dim wd As Word.Application = New Word.Application
        Dim doc As Word.Document = wd.Documents.Add
        Dim rng As Word.Range = doc.Range(0, 0)
        Dim sNovo As String = txt_Pasta.Text & txt_Nome_Doc.Text & ".docx"

        Try
            doc.SaveAs(sNovo)

            wd.Documents.Open(sNovo)
            wd.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Mostra_Registro()

        booNovo = False
        Dim registro As New ClsAtas

        registro.IDAta = sIDAta

        registro.Buscar()

        txt_IDAta.Text = sIDAta
        cbo_IDClasse.SelectedValue = registro.ID_Classe
        txt_Data_Ata.Value = CDate(registro.Data_Ata)
        txt_Livro.Text = ZerosEsquerda(CInt(registro.Livro), 3)
        txt_Folha.Text = ZerosEsquerda(CInt(registro.Folha), 3)
        txt_Qtde_Paginas.Text = registro.Qtde_Paginas
        txt_Palavras_Chave.Text = registro.Palavras_Chave
        txt_Resumo.Text = registro.Resumo_Ata
        txt_Pasta.Text = registro.Pasta
        txt_Nome_Doc.Text = registro.Nome_Doc

    End Sub
    Private Sub Frm_Controle_Atas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MdiParent = Frm_Principal
        booNovo = True
        CarregaClasses()
        cbo_IDClasse.Text = Nothing
        Carrega_Grid_Localiza()

    End Sub

    Private Sub bt_Salvar_Click(sender As Object, e As EventArgs) Handles bt_Salvar.Click


        If cbo_IDClasse.Text.Trim = Nothing Then
            MsgBox("Nome da Classe necessário", 48, strSistema)
            cbo_IDClasse.Focus()
            Exit Sub
        End If
        If txt_Palavras_Chave.Text.Trim = Nothing Then
            MsgBox("Informe o campo de palavras chave.", 48, strSistema)
            txt_Palavras_Chave.Focus()
            Exit Sub
        End If
        If txt_Livro.Text.Trim = Nothing Or CInt(txt_Livro.Text) = 0 Then
            MsgBox("Informe o número do livro.", 48, strSistema)
            txt_Livro.Focus()
            Exit Sub
        End If
        If txt_Folha.Text.Trim = Nothing Or CInt(txt_Folha.Text) = 0 Then
            MsgBox("Informe o número da folha.", 48, strSistema)
            txt_Folha.Focus()
            Exit Sub
        End If
        If txt_Qtde_Paginas.Text.Trim = Nothing Or CInt(txt_Qtde_Paginas.Text) = 0 Then
            MsgBox("Informe a quantidade de páginas do documento.", 48, strSistema)
            txt_Qtde_Paginas.Focus()
            Exit Sub
        End If


        Dim registro As New ClsAtas


        registro.ID_Classe = cbo_IDClasse.SelectedValue
        registro.Codigo_Ata = txt_Nome_Doc.Text
        registro.Data_Ata = Format(txt_Data_Ata.Value, "yyy/MM/dd")
        registro.Palavras_Chave = txt_Palavras_Chave.Text
        registro.Resumo_Ata = txt_Resumo.Text
        registro.Livro = txt_Livro.Text
        registro.Folha = txt_Folha.Text
        registro.Pasta = txt_Pasta.Text
        registro.Nome_Doc = txt_Nome_Doc.Text
        registro.Qtde_Paginas = txt_Qtde_Paginas.Text
        registro.Nome_User = strNomeUser
        registro.Data_Digita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            'Chama a rotina de gravação da classe
            If booNovo = True Then
                registro.Gravar()
                GeraDocumentoWord()
            Else
                registro.IDAta = txt_IDAta.Text
                registro.Editar()
            End If

            MsgBox("Registro salvo com sucesso.", 64, strSistema)
            Carrega_Grid_Localiza()

        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao salvar a Ata ocorreu o erro: " & ex.Message, 16, strSistema)
            Exit Sub
        Finally
            'Limpa a variável incluir
            registro = Nothing
        End Try


    End Sub

    Private Sub cbo_IDClasse_Validated(sender As Object, e As EventArgs) Handles cbo_IDClasse.Validated

        If cbo_IDClasse.Text = Nothing Then
            Exit Sub
        End If


        Dim busca As New ClsDados
        Dim registro As New ClsAtas

        registro.ID_Classe = cbo_IDClasse.SelectedValue.ToString()
        registro.Busca_Ultima_Ata()

        If registro.Livro = Nothing Then
            txt_Livro.Text = ZerosEsquerda(1, 3)
        Else
            txt_Livro.Text = ZerosEsquerda(CInt(registro.Livro), 3)

        End If

        If registro.Folha = Nothing Then
            txt_Folha.Text = ZerosEsquerda(1, 3)
        Else

            txt_Folha.Text = ZerosEsquerda(CInt(registro.Folha) + CInt(registro.Qtde_Paginas), 3)
        End If

        txt_Pasta.Text = "C:\Methodus\Templos\Atas\" & RemoveAcentos(cbo_IDClasse.Text).ToUpper() & "\"
        txt_Nome_Doc.Text = "Ata_" & ZerosEsquerda(CInt(txt_Livro.Text), 3) & "_" & ZerosEsquerda(CInt(txt_Folha.Text), 3) & "_" & RemoveAcentos(cbo_IDClasse.Text).ToUpper()
        txt_Qtde_Paginas.Text = "1"

        If Not DBExists(txt_Pasta.Text) Then
            Directory.CreateDirectory(txt_Pasta.Text)
        End If

        Carrega_Grid_Localiza()

    End Sub

    Private Sub txt_Filtro_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_Filtro.KeyUp
        Carrega_Grid_Localiza()
    End Sub

    Private Sub dg_Localiza_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Localiza.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        sIDAta = dg_Localiza.Rows(e.RowIndex).Cells("IDAta").Value
        Mostra_Registro()
    End Sub


    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        txt_IDAta.Text = Nothing
        cbo_IDClasse.SelectedValue = 0
        txt_Data_Ata.Value = Date.Today
        txt_Livro.Text = Nothing
        txt_Folha.Text = Nothing
        txt_Qtde_Paginas.Text = Nothing
        txt_Palavras_Chave.Text = Nothing
        txt_Resumo.Text = Nothing
        txt_Pasta.Text = Nothing
        txt_Nome_Doc.Text = Nothing
        txt_Filtro.Text = Nothing
        Carrega_Grid_Localiza()
        booNovo = True

    End Sub

    Private Sub bt_Abre_Doc_Click(sender As Object, e As EventArgs) Handles bt_Abre_Doc.Click
        Dim docWord As New Word.Application
        Dim docDoc As Word.Document = docWord.Documents.Open(txt_Pasta.Text & txt_Nome_Doc.Text & ".docx")
        docWord.Visible = True

    End Sub

    Private Sub txt_Qtde_Paginas_Validated(sender As Object, e As EventArgs) Handles txt_Qtde_Paginas.Validated
        txt_Nome_Doc.Text = "Ata_" & ZerosEsquerda(CInt(txt_Livro.Text), 3) & "_" & ZerosEsquerda(CInt(txt_Folha.Text), 3) & "_" & RemoveAcentos(cbo_IDClasse.Text).ToUpper()
    End Sub

    Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click

        If txt_IDAta.Text.Trim = Nothing Then
            MsgBox("É necessário escolher uma ata.", 48, strSistema)
            Exit Sub
        End If

        Dim registro As New ClsAtas


        registro.IDAta = txt_IDAta.Text

        Try
            registro.Excluir()

            MsgBox("Registro excluído com sucesso.", 64, strSistema)
            Carrega_Grid_Localiza()

        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao excluir a Ata ocorreu o erro: " & ex.Message, 16, strSistema)
            Exit Sub
        Finally
            'Limpa a variável incluir
            registro = Nothing
        End Try



    End Sub
End Class