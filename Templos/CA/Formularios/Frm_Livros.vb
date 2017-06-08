Public Class Frm_Livros

    Private Sub cmdIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIncluir.Click

        Dim incluir As New ClsLivros()

        If txtTitulo.Text.Trim = Nothing Then
            MsgBox("Título do livro necessário", 16, strSistema)
            Exit Sub
        End If

        'Carrega as variáveis da classe com os valores do formulário
        incluir.Titulo = SmartCase(txtTitulo.Text)
        incluir.Autor = SmartCase(txtAutor.Text)
        incluir.Sinopse = txtSinopse.Text
        incluir.Obs = txtObs.Text
        incluir.DataCompra = Format(txtDataCompra.Value, "yyyy/MM/dd")
        incluir.Disponivel = "Sim"
        incluir.NomeUser = strNomeUser
        incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            'Chama a rotina de gravação da classe
            incluir.Gravar()
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao incluir um livro ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            incluir = Nothing
        End Try

        MsgBox("Registro Cadastrado com sucesso.", 64, strSistema)

        Limpar(grpRegistro)

        txtTitulo.Focus()

    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        Dim alterar As New ClsLivros()

        If txtIDLivro.Text.Trim = Nothing Then
            MsgBox("Você precisa selecionar uma pessoa.", 16, strSistema)
            Exit Sub
        End If
        alterar.IDLivro = txtIDLivro.Text
        'Carrega as variáveis da classe com os valores do formulário
        alterar.Titulo = SmartCase(txtTitulo.Text)
        alterar.Autor = SmartCase(txtAutor.Text)
        alterar.Sinopse = txtSinopse.Text
        alterar.Obs = txtObs.Text
        alterar.DataCompra = Format(txtDataCompra.Value, "yyyy/MM/dd")
        alterar.NomeUser = strNomeUser
        alterar.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            alterar.Editar()
        Catch ex As Exception
            MsgBox("Ao alterar um livro ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            alterar = Nothing
        End Try

        MsgBox("Registro Alterado com Sucesso", 64, strSistema)

        txtTitulo.Focus()

    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        Dim Excluir As New ClsClasses

        Excluir.IDClasse = txtIDLivro.Text

        Excluir.Classe = txtTitulo.Text

        Dim ret As Integer

        ret = MsgBox("Deseja excluir: " & Excluir.Classe & " ?", 36, strSistema)

        If ret = vbYes Then
            Excluir.Excluir()
            MsgBox("Registro Excluído com Sucesso", 64, strSistema)
        Else
            MsgBox("Operação Cancelada", 64, strSistema)
        End If

        Limpar(grpRegistro)

        txtTitulo.Focus()

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Limpar(grpRegistro)
        ParaGravar(grpBotoes)
        txtTitulo.Focus()

    End Sub
    Private Sub cmdPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click
        Frm_Localizar.Text = "Pesquisa dados dos Livros."

        Frm_Localizar.Tag = "VwLivros" 'Aqui guardamos o nome da tabela

        Frm_Localizar.Show()

    End Sub

    Private Sub txtAutor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAutor.GotFocus
        lblDigita.Text = "Informe o nome do autor do livro."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtAutor.SelectionStart = 0
        Me.txtAutor.SelectionLength = Len(Me.txtAutor.Text) 'Tamanho campo
    End Sub
    Private Sub txtDataCompra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDataCompra.GotFocus
        lblDigita.Text = "Informe a data da compra do livro."

    End Sub
    Private Sub txtObs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObs.GotFocus
        lblDigita.Text = "Informe as observações para o livro."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtObs.SelectionStart = 0
        Me.txtObs.SelectionLength = Len(Me.txtObs.Text) 'Tamanho campo
    End Sub
    Private Sub txtSinopse_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSinopse.GotFocus
        lblDigita.Text = "Informe a sinopse do livro."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtSinopse.SelectionStart = 0
        Me.txtSinopse.SelectionLength = Len(Me.txtSinopse.Text) 'Tamanho campo
    End Sub
    Private Sub txtTitulo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTitulo.GotFocus
        lblDigita.Text = "Informe o título do livro."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtTitulo.SelectionStart = 0
        Me.txtTitulo.SelectionLength = Len(Me.txtTitulo.Text) 'Tamanho campo
    End Sub

    Private Sub txtAutor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAutor.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtSinopse.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtSinopse.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtSinopse.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtTitulo.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtTitulo.Focus()
        End If
    End Sub
    Private Sub txtDataCompra_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDataCompra.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtObs.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtObs.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtObs.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtSinopse.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtSinopse.Focus()
        End If
    End Sub
    Private Sub txtObs_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObs.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            If cmdAlterar.Enabled = True Then
                cmdAlterar.Focus()
            Else
                cmdIncluir.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            If cmdAlterar.Enabled = True Then
                cmdAlterar.Focus()
            Else
                cmdIncluir.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            If cmdAlterar.Enabled = True Then
                cmdAlterar.Focus()
            Else
                cmdIncluir.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtDataCompra.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtDataCompra.Focus()
        End If
    End Sub
    Private Sub txtSinopse_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSinopse.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtDataCompra.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtDataCompra.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtDataCompra.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtAutor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtAutor.Focus()
        End If
    End Sub
    Private Sub txtTitulo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTitulo.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtAutor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtAutor.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtAutor.Focus()
        End If
    End Sub

    Private Sub Frm_Livros_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Verifica se a string com o ID a ser localizado está carregada com valor > 0(zero).
        'Se valor for = 0(zero) mostra o form vazio.
        If strIDLocaliza > 0 Then

            Dim Localiza As New ClsLivros

            Localiza.IDLivro = strIDLocaliza 'Passa o valor da string de localização para a classe.

            Localiza.Buscar() 'Chama o método de localização da classe.

            'Prenche os campos do form com os dados retonados pela localização
            txtIDLivro.Text = Localiza.IDLivro
            txtTitulo.Text = Localiza.Titulo
            txtAutor.Text = Localiza.Autor
            txtSinopse.Text = Localiza.Sinopse
            txtDataCompra.Value = Localiza.DataCompra
            txtObs.Text = Localiza.Obs
            
            lblDigita.Text = "Última alteração feita por: " & Localiza.NomeUser & " em " & Localiza.DataDigita
            strIDLocaliza = 0 'Descarrega string de localização.
            ParaAlterar(grpBotoes)
        Else
            ParaGravar(grpBotoes)
        End If
    End Sub
    Private Sub Frm_Livros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal
    End Sub

    Private Sub txtAutor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAutor.Validated
        txtAutor.Text = SmartCase(txtAutor.Text)
    End Sub
    Private Sub txtTitulo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTitulo.Validated
        txtTitulo.Text = SmartCase(txtTitulo.Text)
    End Sub
End Class