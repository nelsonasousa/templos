Public Class Frm_Classes

    Private Sub CarregaPessoas()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select IDPessoa,Pessoa From Tbl_Pessoas" &
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

        With cboIDProfessor
            .DataSource = dt
            .DisplayMember = "Pessoa"
            .ValueMember = "IDPessoa"
        End With


    End Sub
    Private Sub CarregaPessoas2()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select IDPessoa,Pessoa From Tbl_Pessoas" &
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

        With cboIDProfessor2
            .DataSource = dt
            .DisplayMember = "Pessoa"
            .ValueMember = "IDPessoa"
        End With


    End Sub
    Private Sub CarregaPessoas3()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select IDPessoa,Pessoa From Tbl_Pessoas" &
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

        With cboIDProfessor3
            .DataSource = dt
            .DisplayMember = "Pessoa"
            .ValueMember = "IDPessoa"
        End With


    End Sub
    Private Sub CarregaPessoas4()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select IDPessoa,Pessoa From Tbl_Pessoas" &
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

        With cboIDProfessor4
            .DataSource = dt
            .DisplayMember = "Pessoa"
            .ValueMember = "IDPessoa"
        End With


    End Sub


    Private Sub cmdIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIncluir.Click

        Dim incluir As New ClsClasses()

        If txtClasse.Text.Trim = Nothing Then
            MsgBox("Nome da Classe necessário", 16, strSistema)
            Exit Sub
        End If

        incluir.Classe = SmartCase(txtClasse.Text)
        incluir.DataCriacao = Format(txtDataCriacao.Value, "yyyy/MM/dd")
        incluir.IDProfessor = cboIDProfessor.SelectedValue
        incluir.IDProfessor2 = cboIDProfessor2.SelectedValue
        incluir.IDProfessor3 = cboIDProfessor3.SelectedValue
        incluir.IDProfessor4 = cboIDProfessor4.SelectedValue

        If txtEscola.Checked = True Then
            incluir.Escola = "Sim"
        Else
            incluir.Escola = "Nao"
        End If
        incluir.NomeUser = strNomeUser
        incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            'Chama a rotina de gravação da classe
            incluir.Gravar()
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao incluir um(a) Classe/Grupo ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            incluir = Nothing
        End Try

        MsgBox("Registro Cadastrado com sucesso.", 64, strSistema)

        Limpar(grpRegistro)

        txtClasse.Focus()

    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        Dim alterar As New ClsClasses()

        If txtIDClasse.Text.Trim = Nothing Then
            MsgBox("Você precisa selecionar uma classe.", 16, strSistema)
            Exit Sub
        End If
        alterar.IDClasse = txtIDClasse.Text
        alterar.Classe = txtClasse.Text
        alterar.IDProfessor = cboIDProfessor.SelectedValue
        alterar.IDProfessor2 = cboIDProfessor2.SelectedValue
        alterar.IDProfessor3 = cboIDProfessor3.SelectedValue
        alterar.IDProfessor4 = cboIDProfessor4.SelectedValue
        alterar.DataCriacao = Format(txtDataCriacao.Value, "yyyy/MM/dd")
        If txtEscola.Checked = True Then
            alterar.Escola = "Sim"
        Else
            alterar.Escola = "Nao"
        End If
        alterar.NomeUser = strNomeUser
        alterar.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        'Try
        alterar.Editar()
        'Catch ex As Exception
        'MsgBox("Ao alterar um(a) Classe/Grupo ocorreu o erro: " & ex.Message)
        'Exit Sub
        'Finally
        'alterar = Nothing
        'End Try

        MsgBox("Registro Alterado com Sucesso", 64, strSistema)

        txtClasse.Focus()

    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        Dim Excluir As New ClsClasses

        Excluir.IDClasse = txtIDClasse.Text

        Excluir.Classe = txtClasse.Text

        Dim ret As Integer

        ret = MsgBox("Deseja excluir: " & Excluir.Classe & " ?", 36, strSistema)

        If ret = vbYes Then
            Excluir.Excluir()
            MsgBox("Registro Excluído com Sucesso", 64, strSistema)
        Else
            MsgBox("Operação Cancelada", 64, strSistema)
        End If

        Limpar(grpRegistro)

        txtClasse.Focus()

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Limpar(grpRegistro)
        ParaGravar(grpBotoes)
        txtClasse.Focus()

    End Sub
    Private Sub cmdPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click
        Frm_Localizar.Text = "Pesquisa dados das Classes."

        Frm_Localizar.Tag = "Tbl_Classes" 'Aqui guardamos o nome da tabela

        Frm_Localizar.Show()

    End Sub

    Private Sub txtClasse_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClasse.GotFocus
        lblDigita.Text = "Informe o nome da classe/grupo."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtClasse.SelectionStart = 0
        Me.txtClasse.SelectionLength = Len(Me.txtClasse.Text) 'Tamanho campo
    End Sub
    Private Sub txtClasse_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClasse.Validated
        txtClasse.Text = SmartCase(txtClasse.Text)
    End Sub
    Private Sub txtClasse_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClasse.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtDataCriacao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtDataCriacao.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtDataCriacao.Focus()
        End If
    End Sub

    Private Sub txtDataCriacao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDataCriacao.GotFocus
        lblDigita.Text = "Informe a data de criação da classe/grupo."
    End Sub
    Private Sub txtDataCriacao_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDataCriacao.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000


        If KeyCode = System.Windows.Forms.Keys.Down Then
            cboIDProfessor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtClasse.Focus()
        End If
    End Sub

    Private Sub txtEscola_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEscola.GotFocus
        lblDigita.Text = "Marque o campo se a classe/grupo pertencem à escola dominical."
    End Sub
    Private Sub txtEscola_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEscola.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            If cmdIncluir.Enabled = True Then
                cmdIncluir.Focus()
            Else
                cmdAlterar.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            If cmdIncluir.Enabled = True Then
                cmdIncluir.Focus()
            Else
                cmdAlterar.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            If cmdIncluir.Enabled = True Then
                cmdIncluir.Focus()
            Else
                cmdAlterar.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.cboIDProfessor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.cboIDProfessor.Focus()
        End If
    End Sub

    Private Sub cboIDProfessor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboIDProfessor.GotFocus
        lblDigita.Text = "Informe o professor responsável pela classe/grupo."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.cboIDProfessor.SelectionStart = 0
        Me.cboIDProfessor.SelectionLength = Len(Me.cboIDProfessor.Text) 'Tamanho campo
    End Sub
    Private Sub cboIDProfessor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboIDProfessor.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            cboIDProfessor2.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            cboIDProfessor2.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtDataCriacao.Focus()
        End If
    End Sub

    Private Sub Frm_Classes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Verifica se a string com o ID a ser localizado está carregada com valor > 0(zero).
        'Se valor for = 0(zero) mostra o form vazio.
        If strIDLocaliza > 0 Then

            Dim Localiza As New ClsClasses

            Localiza.IDClasse = strIDLocaliza 'Passa o valor da string de localização para a classe.

            Localiza.Buscar() 'Chama o método de localização da classe.

            CarregaPessoas()
            CarregaPessoas2()
            CarregaPessoas3()
            CarregaPessoas4()

            'Prenche os campos do form com os dados retonados pela localização
            txtIDClasse.Text = Localiza.IDClasse
            txtClasse.Text = Localiza.Classe
            cboIDProfessor.SelectedValue = Localiza.IDProfessor

            If Localiza.IDProfessor2 = 0 Then
                cboIDProfessor2.Text = ""
            Else
                cboIDProfessor2.SelectedValue = Localiza.IDProfessor2
            End If

            If Localiza.IDProfessor3 = 0 Then
                cboIDProfessor3.Text = ""
            Else
                cboIDProfessor3.SelectedValue = Localiza.IDProfessor3
            End If

            If Localiza.IDProfessor4 = 0 Then
                cboIDProfessor4.Text = ""
            Else
                cboIDProfessor4.SelectedValue = Localiza.IDProfessor4
            End If

            If Localiza.Escola = "Sim" Then
                txtEscola.Checked = True
            Else
                txtEscola.Checked = False
            End If
            lblDigita.Text = "Última alteração feita por: " & Localiza.NomeUser & " em " & Localiza.DataDigita
            strIDLocaliza = 0 'Descarrega string de localização.
            ParaAlterar(grpBotoes)
        Else
            ParaGravar(grpBotoes)
        End If

    End Sub
    Private Sub Frm_Classes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal
        CarregaPessoas()
        CarregaPessoas2()
        CarregaPessoas3()
        CarregaPessoas4()
        cboIDProfessor.Text = String.Empty
        cboIDProfessor2.Text = String.Empty
        cboIDProfessor3.Text = String.Empty
        cboIDProfessor4.Text = String.Empty
    End Sub

    Private Sub cboIDProfessor2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboIDProfessor2.GotFocus
        lblDigita.Text = "Informe o segundo responsável pela classe/grupo."
        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.cboIDProfessor2.SelectionStart = 0
        Me.cboIDProfessor2.SelectionLength = Len(Me.cboIDProfessor2.Text) 'Tamanho campo
    End Sub
    Private Sub cboIDProfessor2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboIDProfessor2.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            cboIDProfessor3.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            cboIDProfessor3.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.cboIDProfessor.Focus()
        End If
    End Sub

    Private Sub cboIDProfessor3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboIDProfessor3.GotFocus
        lblDigita.Text = "Informe o terceiro responsável pela classe/grupo."
        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.cboIDProfessor3.SelectionStart = 0
        Me.cboIDProfessor3.SelectionLength = Len(Me.cboIDProfessor3.Text) 'Tamanho campo
    End Sub
    Private Sub cboIDProfessor3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboIDProfessor3.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            cboIDProfessor4.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            cboIDProfessor4.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.cboIDProfessor2.Focus()
        End If
    End Sub

    Private Sub cboIDProfessor4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboIDProfessor4.GotFocus
        lblDigita.Text = "Informe o quarto responsável pela classe/grupo."
        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.cboIDProfessor4.SelectionStart = 0
        Me.cboIDProfessor4.SelectionLength = Len(Me.cboIDProfessor4.Text) 'Tamanho campo
    End Sub
    Private Sub cboIDProfessor4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboIDProfessor4.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtEscola.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtEscola.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.cboIDProfessor3.Focus()
        End If
    End Sub



End Class