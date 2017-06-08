
Public Class Frm_Localizar
    Dim tipoCampo As System.Type

    Private Sub Frm_Localizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DataSet
        Dim Busca As New ClsDados

        '       If Me.Tag = "VwBarrasCupom" Then
        ' MdiParent = Frm_Venda_Balcao
        ' Else
        MdiParent = Frm_Principal

        'End If
        Me.AutoSize = False


        ds = Busca.RetornarDataSet("Select * From " & Me.Tag)
        cmbCampo.Items.Clear()
        Dim i As Integer

        For i = 0 To ds.Tables(0).Columns.Count - 1
            cmbCampo.Items.Add(ds.Tables(0).Columns(i).ColumnName.ToString)
        Next i

        Me.Dgv1.AutoGenerateColumns = True
        Me.Dgv1.DataSource = ds.Tables(0)


    End Sub

    Private Sub cmbCampo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCampo.SelectedIndexChanged
        Dim ds As New DataSet

        tipoCampo = Me.Dgv1.Columns(cmbCampo.SelectedIndex).ValueType

        If tipoCampo.ToString = "System.Int32" Or tipoCampo.ToString = "System.Int64" Then
            cmbParam.Items.Clear()
            cmbParam.Items.Add("=")
            cmbParam.Items.Add(">")
            cmbParam.Items.Add(">=")
            cmbParam.Items.Add("<")
            cmbParam.Items.Add("<=")
            cmbParam.Items.Add("<>")
        End If

        If tipoCampo.ToString = "System.String" Then
            cmbParam.Items.Clear()
            cmbParam.Items.Add("=")
            cmbParam.Items.Add("Começa com")
            cmbParam.Items.Add("Termina em")
            cmbParam.Items.Add("Tem a palavra")
        End If

    End Sub
    Private Sub Dgv1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv1.DoubleClick
        Me.Close()
    End Sub
    Private Sub Dgv1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv1.RowEnter
        If Not Dgv1.Rows(e.RowIndex).Cells(0).Value Is DBNull.Value Then
            strIDLocaliza = Dgv1.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub
    Private Sub cmdFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFiltrar.Click
        Dim campo As String = cmbCampo.Text
        Dim parametro As String = cmbParam.Text
        Dim valor As String = txtBusca.Text
        Dim tipo As String = tipoCampo.ToString
        Dim ds As New DataSet
        'Verificar formulário origem pelo TAG do Frm_Localiza

        'Ps: Não há a necessidade de fazer 
        'tratamento para os campos numéricos
        '-------------------

        'Para tipos String
        If tipo = "System.String" Then
            If parametro = "Tem a palavra" Then
                parametro = "Like "
                valor = "'%" & valor & "%'"
            End If

            If parametro = "=" Then
                valor = "'" & valor & "'"
            End If

            If parametro = "Começa com" Then
                parametro = "Like "
                valor = "'" & valor & "%'"
            End If

            If parametro = "Termina em" Then
                parametro = "Like "
                valor = "'%" & valor & "'"
            End If

        End If

        Select Case Me.Tag

            Case "VwLocalizaAgenda"
                Dim Localizar As New clsAgenda
                ds = Localizar.Pesquisar(campo, parametro, valor, tipo)
            Case "VwLocalizaUndFornecimento"
                Dim Localizar As New ClsFornecimentos
                ds = Localizar.Pesquisar(campo, parametro, valor, tipo)
            Case "VwLocalizaTitulos"
                Dim Localizar As New ClsFinanceiro
                ds = Localizar.Pesquisar(campo, parametro, valor, tipo)
            Case "Tbl_Templo"
                Dim Localizar As New ClsTemplo
                ds = Localizar.Pesquisar(campo, parametro, valor, tipo)
            Case "VwLocalizaProduto"
                Dim Localizar As New ClsProdutos
                ds = Localizar.Pesquisar(campo, parametro, valor, tipo)
            Case "VwLocalizaBanco"
                Dim Localizar As New ClsBanco
                ds = Localizar.Pesquisar(campo, parametro, valor, tipo)
            Case "VwLocalizaFornecedor"
                Dim Localizar As New ClsFornecedores
                ds = Localizar.Pesquisar(campo, parametro, valor, tipo)
            Case "VwLocalizaMembros"
                Dim Localizar As New ClsMembros
                ds = Localizar.Pesquisar(campo, parametro, valor)
            Case "VwLocalizaPatrimonio"
                Dim Localizar As New ClsPatrimonio
                ds = Localizar.Pesquisar(campo, parametro, valor, tipo)
            Case "VwLivros"
                Dim Localizar As New ClsLivros
                ds = Localizar.Pesquisar(campo, parametro, valor, tipo)
        End Select

        Me.Dgv1.AutoGenerateColumns = True
        Me.Dgv1.DataSource = ds.Tables(0)

    End Sub

    'Evento ao entrar no campo
    Private Sub txtBusca_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBusca.GotFocus
        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtBusca.SelectionStart = 0
        Me.txtBusca.SelectionLength = Len(Me.txtBusca.Text) 'Tamanho campo

    End Sub

    'Evento do teclado
    Private Sub cmbCampo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCampo.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.cmbParam.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.cmbParam.Focus()
        End If

    End Sub
    Private Sub cmbParam_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbParam.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.txtBusca.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.txtBusca.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.cmbCampo.Focus()
        End If

    End Sub
    Private Sub txtBusca_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusca.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            Me.cmdFiltrar.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            Me.cmdFiltrar.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            Me.cmdFiltrar.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.cmbParam.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.cmbParam.Focus()
        End If

    End Sub

    'Evento ao clicar do mouse
    Private Sub cmbCampo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCampo.SelectedValueChanged
        cmbParam.Focus()

    End Sub
    Private Sub cmbParam_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbParam.SelectedValueChanged
        txtBusca.Focus()

    End Sub

End Class