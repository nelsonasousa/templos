Public Class Frm_Ocorrencias
#Region "Código dos botões"

    Private Sub cmdIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIncluir.Click

        Dim incluir As New ClsOcorrencias()

        If txtOcorrencia.Text.Trim = Nothing Then
            MsgBox("Nome de ocorrência é necessário", 16, strSistema)
            Exit Sub
        End If

        'Carrega as variáveis da classe clsOcorrencias com os valores do formulário
        incluir.Ocorrencia = SmartCase(txtOcorrencia.Text)
        incluir.NomeUser = strNomeUser
        incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            'Chama a rotina de gravação da classe
            incluir.Gravar()
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao incluir na Ocorrencias ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            incluir = Nothing
        End Try

        MsgBox("Registro Cadastrado com sucesso.", 64, strSistema)

        Limpar(grpRegistro)

        txtOcorrencia.Focus()

    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        Dim alterar As New ClsOcorrencias()

        If txtIDOcorrencia.Text.Trim = Nothing Then
            MsgBox("Você precisa selecionar uma ocorrência.", 16, strSistema)
            Exit Sub
        End If

        If txtIDOcorrencia.Text = 1 Then
            MsgBox("A primeira ocorrência é de uso exclusivo do sistema.", 16, strSistema)
            Exit Sub
        End If

        If txtOcorrencia.Text.Trim = Nothing Then
            MsgBox("Nome de ocorrência é necessário", 16, strSistema)
            Exit Sub
        End If

        alterar.IDOcorrencia = txtIDOcorrencia.Text
        alterar.Ocorrencia = SmartCase(txtOcorrencia.Text)
        alterar.NomeUser = strNomeUser
        alterar.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            alterar.Editar()
        Catch ex As Exception
            MsgBox("Ao alterar na Ocorrencias ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            alterar = Nothing
        End Try

        MsgBox("Registro Alterado com Sucesso", 64, strSistema)

        txtOcorrencia.Focus()

    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        Dim Excluir As New ClsOcorrencias

        If txtIDOcorrencia.Text = 1 Then
            MsgBox("A primeira ocorrência é de uso exclusivo do sistema.", 16, strSistema)
            Exit Sub
        End If

        Excluir.IDOcorrencia = txtIDOcorrencia.Text

        Excluir.Ocorrencia = txtOcorrencia.Text

        Dim ret As Integer

        ret = MsgBox("Deseja excluir: " & Excluir.Ocorrencia & " ?", 36, strSistema)

        If ret = vbYes Then
            Excluir.Excluir()
            MsgBox("Registro Excluído com Sucesso", 64, strSistema)
        Else
            MsgBox("Operação Cancelada", 64, strSistema)
        End If

        Limpar(grpRegistro)

        txtOcorrencia.Focus()

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Limpar(grpRegistro)
        ParaGravar(grpBotoes)
        txtOcorrencia.Focus()

    End Sub
    Private Sub cmdPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click
        Frm_Localizar.Text = "Pesquisa dados da Ocorrencias."

        Frm_Localizar.Tag = "Tbl_Ocorrencias" 'Aqui guardamos o nome da tabela

        Frm_Localizar.Show()

    End Sub

    Private Sub Frm_Ocorrencia_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Verifica se a string com o ID a ser localizado está carregada com valor > 0(zero).
        'Se valor for = 0(zero) mostra o form vazio.
        If strIDLocaliza > 0 Then

            Dim Localiza As New ClsOcorrencias

            Localiza.IDOcorrencia = strIDLocaliza 'Passa o valor da string de localização para a classe.

            Localiza.Buscar() 'Chama o método de localização da classe.

            'Prenche os campos do form com os dados retonados pela localização
            txtIDOcorrencia.Text = Localiza.IDOcorrencia
            txtOcorrencia.Text = Localiza.Ocorrencia
            lblDigita.Text = "Última alteração feita por: " & Localiza.NomeUser & " em " & Localiza.DataDigita
            strIDLocaliza = 0 'Descarrega string de localização.
            ParaAlterar(grpBotoes)
        Else
            ParaGravar(grpBotoes)
        End If

    End Sub
    Private Sub Frm_Ocorrencia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal

        txtOcorrencia.Focus()

    End Sub

    'Evento ao entrar no campo
    Private Sub txtOcorrencia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOcorrencia.GotFocus
        lblDigita.Text = "Informe a descrição da ocorrência."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtOcorrencia.SelectionStart = 0
        Me.txtOcorrencia.SelectionLength = Len(Me.txtOcorrencia.Text) 'Tamanho campo

    End Sub

    'Evento do teclado
    Private Sub txtOcorrencia_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOcorrencia.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If cmdIncluir.Enabled = True Then
            If KeyCode = 13 Then
                Me.cmdIncluir.Focus()
            ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
                Me.cmdIncluir.Focus()
            End If
        ElseIf cmdAlterar.Enabled = True Then
            If KeyCode = 13 Then
                Me.cmdAlterar.Focus()
            ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
                Me.cmdAlterar.Focus()
            End If
        End If
    End Sub
    Private Sub txtOcorrencia_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOcorrencia.Validated
        txtOcorrencia.Text = SmartCase(txtOcorrencia.Text)
    End Sub
#End Region

End Class