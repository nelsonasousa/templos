Public Class Frm_Status

    Private Sub cmdIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIncluir.Click

        Dim incluir As New ClsStatus()

        If txtStatus.Text.Trim = Nothing Then
            MsgBox("Nome do status necessário", 16, strSistema)
            Exit Sub
        End If

        'Carrega as variáveis da classe clsAgenda com os valores do formulário
        incluir.Status = txtStatus.Text
        incluir.Mostra = chk_Mostra.Checked
        incluir.NomeUser = strNomeUser
        incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            'Chama a rotina de gravação da classe
            incluir.Gravar()
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao incluir status de membro ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            incluir = Nothing
        End Try

        MsgBox("Registro Cadastrado com sucesso.", 64, strSistema)

        Limpar(grpRegistro)

        txtStatus.Focus()

    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        Dim alterar As New ClsStatus()

        If txtIDStatus.Text.Trim = Nothing Then
            MsgBox("Você precisa selecionar um status.", 16, strSistema)
            Exit Sub
        End If
        alterar.IDStatus = txtIDStatus.Text
        alterar.Status = txtStatus.Text
        alterar.Mostra = chk_Mostra.Checked
        alterar.NomeUser = strNomeUser
        alterar.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            alterar.Editar()
        Catch ex As Exception
            MsgBox("Ao alterar status ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            alterar = Nothing
        End Try

        MsgBox("Registro Alterado com Sucesso", 64, strSistema)

        txtStatus.Focus()

    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        Dim Excluir As New ClsStatus

        Excluir.IDStatus = txtIDStatus.Text

        Excluir.Status = txtStatus.Text

        Dim ret As Integer

        ret = MsgBox("Deseja excluir: " & Excluir.Status & " ?", 36, strSistema)

        If ret = vbYes Then
            Excluir.Excluir()
            MsgBox("Registro Excluído com Sucesso", 64, strSistema)
        Else
            MsgBox("Operação Cancelada", 64, strSistema)
        End If

        Limpar(grpRegistro)

        txtStatus.Focus()

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Limpar(grpRegistro)
        ParaGravar(grpBotoes)
        txtStatus.Focus()

    End Sub
    Private Sub cmdPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click
        Frm_Localizar.Text = "Pesquisa dados dos Status."

        Frm_Localizar.Tag = "Tbl_Status" 'Aqui guardamos o Status da tabela

        Frm_Localizar.Show()

    End Sub


    Private Sub Frm_Status_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Verifica se a string com o ID a ser localizado está carregada com valor > 0(zero).
        'Se valor for = 0(zero) mostra o form vazio.
        If strIDLocaliza > 0 Then

            Dim Localiza As New ClsStatus

            Localiza.IDStatus = strIDLocaliza 'Passa o valor da string de localização para a classe.

            Localiza.Buscar() 'Chama o método de localização da classe.

            'Prenche os campos do form com os dados retonados pela localização
            txtIDStatus.Text = Localiza.IDStatus
            txtStatus.Text = Localiza.Status
            chk_Mostra.Checked = Localiza.Mostra
            lblDigita.Text = "Última alteração feita por: " & Localiza.NomeUser & " em " & Localiza.DataDigita
            strIDLocaliza = 0 'Descarrega string de localização.
            ParaAlterar(grpBotoes)
        Else
            ParaGravar(grpBotoes)
        End If

    End Sub
    Private Sub Frm_Status_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal
        txtStatus.Focus()
        strIDLocaliza = 0
    End Sub
    Private Sub txtStatus_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStatus.GotFocus
        lblDigita.Text = "Informe o tipo/status para classificar o membro."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtStatus.SelectionStart = 0
        Me.txtStatus.SelectionLength = Len(Me.txtStatus.Text) 'Tamanho campo

    End Sub
    Private Sub txtStatus_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStatus.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            If cmdIncluir.Enabled = True Then
                cmdIncluir.Focus()
            Else
                Me.cmdAlterar.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            If cmdIncluir.Enabled = True Then
                cmdIncluir.Focus()
            Else
                Me.cmdAlterar.Focus()
            End If
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            If cmdIncluir.Enabled = True Then
                cmdIncluir.Focus()
            Else
                Me.cmdAlterar.Focus()
            End If
        End If
    End Sub

End Class