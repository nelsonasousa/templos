
Public Class Frm_Tarefas_User
    Dim strIDTarefaR As String, strIDTarefaE As String
    Dim booNovo As Boolean

    Private Sub CarregaVendedores()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable
        Dim strSQL As String = "Select IDPessoa,Entidade From Tbl_Pessoas " & _
                                " where TipoEntidade='" & "Funcionario" & "' order by Entidade"

        ds = Busca.RetornarDataSet(strSQL)

        dt.Columns.Add("Entidade", GetType(System.String))
        dt.Columns.Add("IDPessoa", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Entidade") = dr("Entidade")
            NovaDr("IDPessoa") = dr("IDPessoa")
            dt.Rows.Add(NovaDr)
        Next
        'define o estilo da combobox
        cboIDPessoa.DropDownStyle = ComboBoxStyle.DropDownList

        'preenche a combobox com os nomes dos vendedores 
        With cboIDPessoa
            .DataSource = dt
            .DisplayMember = "Entidade"
            .ValueMember = "IDPessoa"
        End With
    End Sub
    Private Sub CarregaRecadosR()
        Dim ds As New DataSet
        Dim Busca As New ClsDados

        'limpa o grid
        LimpaGridR()

        ds = Busca.RetornarDataSet("SELECT Tbl_Tarefas.IDTarefa,Tbl_Tarefas.DataTarefa,Tbl_Pessoas.Entidade, " & _
                                   " Tbl_Tarefas.DataCumprir,Tbl_Tarefas.Tarefa FROM Tbl_Tarefas INNER JOIN Tbl_Pessoas " & _
                                   " ON Tbl_Tarefas.IDEnvia=Tbl_Pessoas.IDPessoa " & _
                                   " WHERE Tbl_Tarefas.IDPessoa=" & strIDUser & " AND DataExecucao IS NULL")

        'preenche a DGProdutos
        With DGRecadosRecebidos

            .DataSource = ds.Tables(0)

            .Columns(0).Visible = False
            .Columns(0).Name = "IDTarefa"

            .Columns(1).Name = "DataTarefa"
            .Columns(1).Width = 70
            .Columns(1).HeaderText = "Enviada"
            .Columns(1).ReadOnly = True

            .Columns(2).Name = "Entidade"
            .Columns(2).Width = 100
            .Columns(2).HeaderText = "Por"
            .Columns(2).ReadOnly = True

            .Columns(3).Name = "DataCumprir"
            .Columns(3).Width = 70
            .Columns(3).HeaderText = "Cumprir até"

            .Columns(4).Name = "Tarefa"
            .Columns(4).Visible = False

        End With


    End Sub
    Private Sub LimpaGridR()
        DGRecadosRecebidos.Columns.Clear()
    End Sub
    Private Sub CarregaRecadosE()
        Dim ds As New DataSet
        Dim Busca As New ClsDados

        'limpa o grid
        LimpaGridE()

        ds = Busca.RetornarDataSet("SELECT Tbl_Tarefas.IDTarefa,Tbl_Tarefas.IDPessoa,Tbl_Tarefas.DataTarefa,Tbl_Pessoas.Entidade, " & _
                                   " Tbl_Tarefas.DataCumprir,Tbl_Tarefas.Tarefa FROM Tbl_Tarefas INNER JOIN Tbl_Pessoas " & _
                                   " ON Tbl_Tarefas.IDPessoa=Tbl_Pessoas.IDPessoa " & _
                                   " WHERE Tbl_Tarefas.IDEnvia=" & strIDUser & " AND DataExecucao IS NULL")

        'preenche a DGProdutos
        With DGRecadosEnviados

            .DataSource = ds.Tables(0)

            .Columns(0).Visible = False
            .Columns(0).Name = "IDTarefa"

            .Columns(1).Visible = False
            .Columns(1).Name = "IDPessoa"

            .Columns(2).Name = "DataTarefa"
            .Columns(2).Width = 70
            .Columns(2).HeaderText = "Enviada"
            .Columns(2).ReadOnly = True

            .Columns(3).Name = "Entidade"
            .Columns(3).Width = 100
            .Columns(3).HeaderText = "Para"
            .Columns(3).ReadOnly = True

            .Columns(4).Name = "DataCumprir"
            .Columns(4).Width = 70
            .Columns(4).HeaderText = "Cumprir até"

            .Columns(5).Name = "Tarefa"
            .Columns(5).Visible = False

        End With


    End Sub
    Private Sub LimpaGridE()
        DGRecadosEnviados.Columns.Clear()
    End Sub



    Private Sub Frm_Tarefas_User_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CarregaVendedores()
        CarregaRecadosE()
        CarregaRecadosR()
        booNovo = True

    End Sub

    Private Sub DGRecadosEnviados_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGRecadosEnviados.RowEnter
        If Not DGRecadosEnviados.Rows(e.RowIndex).Cells(0).Value Is DBNull.Value Then
            strIDTarefaE = DGRecadosEnviados.Rows(e.RowIndex).Cells(0).Value
            txtRecado.Text = DGRecadosEnviados.Rows(e.RowIndex).Cells(5).Value
            txtCumprirAte.Value = DGRecadosEnviados.Rows(e.RowIndex).Cells(4).Value
            cboIDPessoa.SelectedItem = DGRecadosEnviados.Rows(e.RowIndex).Cells(1).Value
        End If
    End Sub

    Private Sub DGRecadosRecebidos_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGRecadosRecebidos.RowEnter
        If Not DGRecadosRecebidos.Rows(e.RowIndex).Cells(0).Value Is DBNull.Value Then
            strIDTarefaR = DGRecadosRecebidos.Rows(e.RowIndex).Cells(0).Value
            lblRecado.Text = DGRecadosRecebidos.Rows(e.RowIndex).Cells(4).Value
            booNovo = False
        End If
    End Sub

    Private Sub btMarcarUm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMarcarUm.Click

        Dim marcaum As New ClsTarefas
        Try
            marcaum.IDTarefa = strIDTarefaR
            marcaum.DataExecucao = Format(DateTime.Now, "yyyy/MM/dd")
            marcaum.NomeUser = strNomeUser
            marcaum.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")
            marcaum.Executar()
            CarregaRecadosR()
        Catch ex As Exception
            MsgBox("Ocorreu o erro: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub btMarcarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMarcarTodos.Click
        Dim marcatodos As New ClsTarefas
        Try
            marcatodos.IDPessoa = strIDUser
            marcatodos.DataExecucao = Format(DateTime.Now, "yyyy/MM/dd")
            marcatodos.NomeUser = strNomeUser
            marcatodos.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")
            marcatodos.ExecutarTodos()
            CarregaRecadosR()
        Catch ex As Exception
            MsgBox("Ocorreu o erro: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviar.Click
        Dim incluir As New ClsTarefas()

        If txtRecado.Text.Trim = Nothing Then
            MsgBox("Descrição da tarefa é necessária", 16, strSistema)
            Exit Sub
        End If

        incluir.IDPessoa = cboIDPessoa.SelectedValue
        incluir.IDEnvia = strIDUser
        incluir.DataTarefa = Format(DateTime.Now, "yyyy/MM/dd")
        incluir.Tarefa = txtRecado.Text
        incluir.DataCumprir = Convert.ToString(Format(txtCumprirAte.Value, "yyyy/MM/dd"))
        incluir.NomeUser = strNomeUser
        incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")


        Try

            If booNovo = True Then
                incluir.Gravar()
                CarregaRecadosE()
            Else
                incluir.IDTarefa = strIDTarefaE
                incluir.Editar()
                CarregaRecadosE()
            End If
        Catch ex As Exception
            MsgBox("Ocorreu o erro: " & ex.Message)
            Exit Sub

        End Try

        MsgBox("Registro Salvo.", 64, "Sucesso")

    End Sub

End Class