Public Class Frm_Muda_Classe
    Dim strIDClasseAntiga As String
    Dim strMsg As String

    Private Sub CarregaAlunos()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("SELECT Tbl_Pessoas.IDPessoa, Tbl_Pessoas.Pessoa" &
                                   " FROM (Tbl_Pessoas INNER JOIN Tbl_Pessoas_Grupos" &
                                   " ON Tbl_Pessoas.IDPessoa = Tbl_Pessoas_Grupos.IDPessoa)" &
                                   " INNER JOIN Tbl_Classes ON Tbl_Pessoas_Grupos.IDClasse = Tbl_Classes.IDClasse" &
                                   " WHERE ((Tbl_Pessoas.TipoPessoa <> 'Fornecedor') AND (Tbl_Classes.Escola = 'Sim')" &
                                   " AND (DataBaixa IS NULL)) ORDER BY Tbl_Pessoas.Pessoa")

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
        With cboAluno
            .DataSource = dt
            .DisplayMember = "Pessoa"
            .ValueMember = "IDPessoa"
        End With

        cboAluno.Text = String.Empty

    End Sub
    Private Sub CarregaClasses()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select IDClasse,Classe From Tbl_Classes" &
                                   " WHERE Escola='Sim' order by Classe")

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
        With cboClasses
            .DataSource = dt
            .DisplayMember = "Classe"
            .ValueMember = "IDClasse"
        End With


    End Sub

    Private Sub btConfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirma.Click
        If Confirma("Confirma transferência do aluno?") Then
            Dim troca As New ClsClasseAlunos

            troca.IDPessoa = cboAluno.SelectedValue
            troca.IDClasse = strIDClasseAntiga
            troca.DataMatricula = Format(Date.Today, "yyyy/MM/dd")
            troca.DataBaixa = Format(Date.Today, "yyyy/MM/dd")
            troca.NomeUser = strNomeUser
            troca.DataDigita = Format(Date.Now, "yyyy/MM/dd HH:mm:ss")

            Try
                strMsg = "Ao baixar o aluno na classe ocorreu o erro: "
                troca.Baixar()
                troca.IDClasse = cboClasses.SelectedValue
                strMsg = "Ao inserir o aluno na classe ocorreu o erro: "
                troca.Gravar()
                cboAluno.Focus()
            Catch ex As Exception
                MsgBox(strMsg & ex.Message)
                Exit Sub

            End Try
        End If
    End Sub

    Private Sub Frm_Muda_Classe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal
        CarregaAlunos()
        CarregaClasses()

    End Sub


    Private Sub cboAluno_KeyUp(sender As Object, e As KeyEventArgs) Handles cboAluno.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.cboClasses.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.cboClasses.Focus()
        End If

    End Sub
    Private Sub cboAluno_GotFocus(sender As Object, e As EventArgs) Handles cboAluno.GotFocus
        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.cboAluno.SelectionStart = 0
        Me.cboAluno.SelectionLength = Len(Me.cboAluno.Text) 'Tamanho campo

        cboAluno.DroppedDown = True
    End Sub

    Private Sub cboClasses_KeyUp(sender As Object, e As KeyEventArgs) Handles cboClasses.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.btConfirma.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.btConfirma.Focus()
        End If
    End Sub

    Private Sub cboAluno_LostFocus(sender As Object, e As EventArgs) Handles cboAluno.LostFocus
        Dim localiza As New ClsMembros
        Dim classe As New ClsClasseAlunos
        localiza.IDPessoa = cboAluno.SelectedValue
        localiza.Buscar()

        classe.IDPessoa = localiza.IDPessoa
        classe.BuscaMatricula()

        lblClasse.Text = classe.NomeClasse
        strIDClasseAntiga = classe.IDClasse
        localiza = Nothing
        classe = Nothing

    End Sub
End Class