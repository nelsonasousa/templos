
Public Class Frm_Principal


    Private Sub Frm_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = strSistema & " - Sistema Gratuíto - Não pode ser vendido."
        PreencheBarraStatus()
    End Sub

    Private Sub PreencheBarraStatus()
        Dim empresa As New ClsTemplo
        empresa.IDTemplo = empresa.BuscarId
        empresa.Buscar()
        TStatusData.Text = "Data Sistema: " & Date.Today
        TStatusUser.Text = strNomeUser

        'Verifica se o usuário tem tarefas cadastradas
        'Dim tarefa As New ClsTarefas
        'tarefa.IDPessoa = strIDUser
        'If tarefa.VerificaTarefa Then
        ' tStatusRecados.Visible = True
        ' Else
        ' tStatusRecados.Visible = False
        ' End If


        tStatusEmpresa.Text = empresa.Templo
        tStatusMsg.Text = empresa.Mensagem
        tStatusNelson.Text = strNelson

        empresa = Nothing
        'tarefa = Nothing

    End Sub

    Private Sub tStatusRecados_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ValidaUser("Frm_Tarefas_User") Then
            Frm_Tarefas_User.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub FinanceiroToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ValidaUser("Frm_Financeiro") Then
            Frm_Financeiro.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub
    Private Sub MembrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MembrosToolStripMenuItem.Click
        If ValidaUser("Frm_Membros") Then
            Frm_Membros.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub
    Private Sub TiposMembrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ValidaUser("Frm_Status") Then
            Frm_Status.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub
    Private Sub TemplosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemplosToolStripMenuItem.Click
        If ValidaUser("Frm_Templo") Then
            Frm_Templo.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub
    Private Sub GruposCalssesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposCalssesToolStripMenuItem.Click
        If ValidaUser("Frm_Classes") Then
            Frm_Classes.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub
    Private Sub FornecedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedoresToolStripMenuItem.Click
        If ValidaUser("Frm_Fornecedores") Then
            Frm_Fornecedores.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub
    Private Sub LivrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LivrosToolStripMenuItem.Click
        If ValidaUser("Frm_Livros") Then
            Frm_Livros.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub
    Private Sub AgendaTelefonesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgendaTelefonesToolStripMenuItem.Click
        If ValidaUser("Frm_Agenda") Then
            Frm_Agenda.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub
    Private Sub EscolaDominicalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EscolaDominicalToolStripMenuItem.Click
        If ValidaUser("Frm_Escola_Dominical") Then
            Frm_Escola_Dominical.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub EmprestarLivroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmprestarLivroToolStripMenuItem.Click
        If ValidaUser("Frm_Empresta_Livro") Then
            Frm_Empresta_Livro.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub PagarReceberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagarReceberToolStripMenuItem.Click
        If ValidaUser("Frm_Fluxo_Caixa") Then
            Frm_Fluxo_Caixa.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub
    Private Sub UsuáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuáriosToolStripMenuItem.Click
        If ValidaUser("Frm_Usuarios") Then
            Frm_Usuarios.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub
    Private Sub PermissõesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissõesToolStripMenuItem1.Click
        If ValidaUser("Frm_Permissoes") Then
            Frm_Permissoes.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub SobreToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem1.Click
        Sobre.Show()
    End Sub

    Private Sub btFornecedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFornecedores.Click
        If ValidaUser("Frm_Fornecedores") Then
            Frm_Fornecedores.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If ValidaUser("Frm_Membros") Then
            Frm_Membros.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBLivros.Click
        If ValidaUser("Frm_Livros") Then
            Frm_Livros.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBEscolaDominical.Click
        If ValidaUser("Frm_Escola_Dominical") Then
            Frm_Escola_Dominical.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBEmprestaLivro.Click
        If ValidaUser("Frm_Empresta_Livro") Then
            Frm_Empresta_Livro.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        If ValidaUser("Frm_Fluxo_Caixa") Then
            Frm_Fluxo_Caixa.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        If ValidaUser("Frm_Permissoes") Then
            Frm_Permissoes.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub AgendaEventosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgendaEventosToolStripMenuItem.Click
        If ValidaUser("Frm_Eventos") Then
            Frm_Eventos.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub RealocarAlunoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealocarAlunoToolStripMenuItem.Click
        If ValidaUser("Frm_Muda_Classe") Then
            Frm_Muda_Classe.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub AniversariantesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AniversariantesToolStripMenuItem.Click
        If ValidaUser("Frm_Aniversariantes") Then
            Frm_Aniversariantes.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub OcorrênciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OcorrênciasToolStripMenuItem.Click
        If ValidaUser("Frm_Ocorrencias") Then
            Frm_Ocorrencias.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub OcorrênciasMembrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OcorrênciasMembrosToolStripMenuItem.Click
        If ValidaUser("Frm_Pessoas_Ocorrencias") Then
            Frm_Pessoas_Ocorrencias.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub FluxoCaixaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FluxoCaixaToolStripMenuItem.Click
        If ValidaUser("Frm_Lista_Fluxo_Caixa") Then
            Frm_Lista_Fluxo_Caixa.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

   
    Private Sub LivrosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LivrosToolStripMenuItem1.Click
        MsgBox("Rotina em desenvolvimento", 64, strSistema)
    End Sub

    Private Sub CaixaRealizadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaixaRealizadoToolStripMenuItem.Click
        MsgBox("Rotina em desenvolvimento", 64, strSistema)
    End Sub

    Private Sub MembrosAtivosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MembrosAtivosToolStripMenuItem.Click
        If ValidaUser("Frm_Lista_Membros") Then
            Frm_Lista_Membros.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub EventosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventosToolStripMenuItem.Click
        MsgBox("Rotina em desenvolvimento", 64, strSistema)
    End Sub

    Private Sub SemBackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemBackupToolStripMenuItem.Click
        End
    End Sub

    Private Sub ComBackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComBackupToolStripMenuItem.Click
        Frm_Bkp.Show()
    End Sub

    Private Sub ListasDePresençasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListasDePresençasToolStripMenuItem.Click
        Frm_Lista_Presencas.Show()
    End Sub

    Private Sub ControleDeAtasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControleDeAtasToolStripMenuItem.Click
        If ValidaUser("Frm_Controle_Atas") Then
            Frm_Controle_Atas.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub

    Private Sub ResumoAnualEscolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumoAnualEscolaToolStripMenuItem.Click
        If ValidaUser("Frm_Rlt_Anual") Then
            Frm_Rlt_Anual.Show()
        Else
            MsgBox("Você não tem permissão de acesso a esta rotina.", 16, strSistema)
        End If
    End Sub
End Class