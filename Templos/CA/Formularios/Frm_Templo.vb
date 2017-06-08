
Public Class Frm_Templo

#Region "Rotinas do programador"

    Private Sub CarregaEstados()
        Dim ds As New DataSet
        Dim Busca As New ClsDados
        Dim dt As New DataTable

        ds = Busca.RetornarDataSet("Select Estado From Tbl_Estados order by Estado")

        dt.Columns.Add("Estado", GetType(System.String))

        Dim dr As DataRow, NovaDr As DataRow

        For Each dr In ds.Tables(0).Rows()
            NovaDr = dt.NewRow()
            NovaDr("Estado") = dr("Estado")
            dt.Rows.Add(NovaDr)
        Next

        'preenche a combobox com os nomes das entidades e seleciona o primeiro valor    
        With cboEstados
            .DataSource = dt
            .DisplayMember = "Estado"
            .ValueMember = "Estado"
        End With

    End Sub

#End Region

#Region "Código dos botões"

    Private Sub cmdIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIncluir.Click
        Dim incluir As New ClsTemplo

        If txtTemplos.Text.Trim = Nothing Then
            MsgBox("O nome do Templos é necessário.", 16, strSistema)
            Exit Sub
        End If

        incluir.Templo = txtTemplos.Text
        incluir.Endereco = txtEndereco.Text
        incluir.Bairro = txtBairro.Text
        incluir.CEP = txtCEP.Text
        incluir.Cidade = txtCidade.Text
        incluir.UF = cboEstados.Text
        incluir.Telefone = txtTelefone.Text
        incluir.Fax = txtFax.Text
        incluir.Site = txtSite.Text
        incluir.Email = txtEmail.Text
        incluir.CNPJ = txtCNPJ.Text
        incluir.IE = txtIE.Text
        incluir.Mensagem = txtMensagem.Text.Trim
        If txtBrIndividual.Checked = True Then
            incluir.BRIndividual = "Sim"
        Else
            incluir.BRIndividual = "Nao"
        End If
        incluir.LogoPath = txtLogoPath.Text
        incluir.NomeUser = strNomeUser
        incluir.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        Try
            'Chama a rotina de gravação da classe
            incluir.Gravar()
        Catch ex As Exception
            'Caso ocorra erro mostra a menssagem abaixo
            MsgBox("Ao incluir Templos ocorreu o erro: " & ex.Message)
            Exit Sub
        Finally
            'Limpa a variável incluir
            incluir = Nothing
        End Try

        MsgBox("Registro Cadastrado com sucesso.", 64, strSistema)

        'Limpa o form
        Limpar(grpRegistro)

        'Carrega a combo
        CarregaEstados()

        'Direciona o foco
        txtCNPJ.Focus()

    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        Dim alterar As New ClsTemplo

        If txtIDTemplos.Text.Trim = Nothing Then
            MsgBox("Você precisa selecionar um Templos.", 16, strSistema)
            Exit Sub
        End If
        alterar.IDTemplo = txtIDTemplos.Text
        alterar.Templo = txtTemplos.Text
        alterar.Endereco = txtEndereco.Text
        alterar.Bairro = txtBairro.Text
        alterar.CEP = txtCEP.Text
        alterar.Cidade = txtCidade.Text
        alterar.UF = cboEstados.Text
        alterar.Telefone = txtTelefone.Text
        alterar.Fax = txtFax.Text
        alterar.Site = txtSite.Text
        alterar.Email = txtEmail.Text
        alterar.CNPJ = txtCNPJ.Text
        alterar.IE = txtIE.Text
        alterar.Mensagem = txtMensagem.Text.Trim
        If txtBrIndividual.Checked = True Then
            alterar.BRIndividual = "Sim"
        Else
            alterar.BRIndividual = "Nao"
        End If
        alterar.LogoPath = txtLogoPath.Text

        alterar.NomeUser = strNomeUser
        alterar.DataDigita = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")

        'Try
        alterar.Editar()
        'Catch ex As Exception
        ' MsgBox("Ao alterar Templos ocorreu o erro: " & ex.Message)
        ' Exit Sub
        ' Finally
        ' alterar = Nothing
        ' End Try

        MsgBox("Registro Alterado com Sucesso", 64, strSistema)

        'Direciona o foco
        txtCNPJ.Focus()

    End Sub

#End Region

#Region "Eventos dos campos"

    'Evento ao entrar no formulário
    Private Sub Frm_Templo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal

        Dim Localiza As New ClsTemplo
        CarregaEstados()
        txtIDTemplos.Text = Localiza.BuscarId() 'Chama o método de localização da classe.
        If txtIDTemplos.Text < 1 Then
            cmdIncluir.Visible = True
            cmdAlterar.Visible = False
        Else
            cmdIncluir.Visible = False
            cmdAlterar.Visible = True
            Localiza.IDTemplo = txtIDTemplos.Text
            Localiza.Buscar()
            'Prenche os campos do form com os dados retonados pela localização
            txtIDTemplos.Text = Localiza.IDTemplo
            txtTemplos.Text = Localiza.Templo
            txtEndereco.Text = Localiza.Endereco
            txtBairro.Text = Localiza.Bairro
            txtCEP.Text = Localiza.CEP
            txtCidade.Text = Localiza.Cidade
            cboEstados.Text = Localiza.UF
            txtTelefone.Text = Localiza.Telefone
            txtFax.Text = Localiza.Fax
            txtSite.Text = Localiza.Site
            txtEmail.Text = Localiza.Email
            txtCNPJ.Text = Localiza.CNPJ
            txtIE.Text = Localiza.IE
            txtLogoPath.Text = Localiza.LogoPath

            If Localiza.BRIndividual = "Sim" Then
                txtBrIndividual.Checked = True
            Else
                txtBrIndividual.Checked = False
            End If

            txtMensagem.Text = Localiza.Mensagem
            lblDigita.Text = "Última alteração feita por: " & Localiza.NomeUser & " em " & Localiza.DataDigita
        End If

    End Sub

    'Evento ao entrar no campo
    Private Sub txtCNPJ_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNPJ.GotFocus
        lblDigita.Text = "Informe o CNPJ do Templos."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtCNPJ.SelectionStart = 0
        Me.txtCNPJ.SelectionLength = Len(Me.txtCNPJ.Text) 'Tamanho campo

    End Sub
    Private Sub txtIE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIE.GotFocus
        lblDigita.Text = "Informe a inscrição estadual do Templos."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtIE.SelectionStart = 0
        Me.txtIE.SelectionLength = Len(Me.txtIE.Text) 'Tamanho campo

    End Sub
    Private Sub txtTemplos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTemplos.GotFocus
        lblDigita.Text = "Informe o nome do Templos."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtTemplos.SelectionStart = 0
        Me.txtTemplos.SelectionLength = Len(Me.txtTemplos.Text) 'Tamanho campo

    End Sub
    Private Sub txtEndereco_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEndereco.GotFocus
        lblDigita.Text = "Informe o endereço do Templos."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtEndereco.SelectionStart = 0
        Me.txtEndereco.SelectionLength = Len(Me.txtEndereco.Text) 'Tamanho campo

    End Sub
    Private Sub txtBairro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBairro.GotFocus
        lblDigita.Text = "Informe o bairro do Templos."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtBairro.SelectionStart = 0
        Me.txtBairro.SelectionLength = Len(Me.txtBairro.Text) 'Tamanho campo

    End Sub
    Private Sub txtCEP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCEP.GotFocus
        lblDigita.Text = "Informe CEP do Templos."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtCEP.SelectionStart = 0
        Me.txtCEP.SelectionLength = Len(Me.txtCEP.Text) 'Tamanho campo

    End Sub
    Private Sub txtCidade_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCidade.GotFocus
        lblDigita.Text = "Informe a cidade do Templos."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtCidade.SelectionStart = 0
        Me.txtCidade.SelectionLength = Len(Me.txtCidade.Text) 'Tamanho campo

    End Sub
    Private Sub cboEstados_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEstados.GotFocus
        lblDigita.Text = "Informe a unidade da federação onde se encontra a Templos."

    End Sub
    Private Sub txtTelefone_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelefone.GotFocus
        lblDigita.Text = "Informe o telefone do Templos."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtTelefone.SelectionStart = 0
        Me.txtTelefone.SelectionLength = Len(Me.txtTelefone.Text) 'Tamanho campo

    End Sub
    Private Sub txtFax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFax.GotFocus
        lblDigita.Text = "Informe o fax do Templos."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtFax.SelectionStart = 0
        Me.txtFax.SelectionLength = Len(Me.txtFax.Text) 'Tamanho campo

    End Sub
    Private Sub txtSite_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSite.GotFocus
        lblDigita.Text = "Informe o site do Templos."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtSite.SelectionStart = 0
        Me.txtSite.SelectionLength = Len(Me.txtSite.Text) 'Tamanho campo

    End Sub
    Private Sub txtEmail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.GotFocus
        lblDigita.Text = "Informe o e-mail do Templos."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.SelectionLength = Len(Me.txtEmail.Text) 'Tamanho campo

    End Sub
    Private Sub txtMensagem_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMensagem.GotFocus
        lblDigita.Text = "Informe uma mensagem padrão para o rodapé dos relatórios."

        'Preenche a caixa com uma tarja azul do tamanho da digitação
        Me.txtMensagem.SelectionStart = 0
        Me.txtMensagem.SelectionStart = Len(Me.txtMensagem.Text) 'Tamanho campo

    End Sub
    Private Sub txtBrIndividual_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBrIndividual.GotFocus
        lblDigita.Text = "Marque para controlar bíblias e revistas individualmente, e, desmarque para controle por classe."

    End Sub

    'Evento do teclado
    Private Sub txtCNPJ_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCNPJ.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtIE.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtIE.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtIE.Focus()
        End If

    End Sub
    Private Sub txtIE_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIE.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtTemplos.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtTemplos.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtTemplos.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtCNPJ.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtCNPJ.Focus()
        End If

    End Sub
    Private Sub txtTemplos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTemplos.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtEndereco.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtEndereco.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtEndereco.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtIE.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtIE.Focus()
        End If

    End Sub
    Private Sub txtEndereco_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEndereco.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtBairro.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtBairro.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtBairro.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtTemplos.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtTemplos.Focus()
        End If

    End Sub
    Private Sub txtBairro_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBairro.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtCEP.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtCEP.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtCEP.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtEndereco.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtEndereco.Focus()
        End If

    End Sub
    Private Sub txtCEP_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCEP.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtCidade.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtCidade.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtCidade.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtBairro.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtBairro.Focus()
        End If

    End Sub
    Private Sub txtCidade_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCidade.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            cboEstados.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            cboEstados.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            cboEstados.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtCEP.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtCEP.Focus()
        End If

    End Sub
    Private Sub cboEstados_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboEstados.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtTelefone.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtTelefone.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtCidade.Focus()
        End If

    End Sub
    Private Sub txtTelefone_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTelefone.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtFax.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtFax.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtFax.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.cboEstados.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.cboEstados.Focus()
        End If

    End Sub
    Private Sub txtFax_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFax.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtSite.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtSite.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtSite.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtTelefone.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtTelefone.Focus()
        End If

    End Sub
    Private Sub txtSite_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSite.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtEmail.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtEmail.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtEmail.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtFax.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtFax.Focus()
        End If

    End Sub
    Private Sub txtEmail_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyUp
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 13 Then
            txtMensagem.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
            txtMensagem.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
            txtMensagem.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
            Me.txtSite.Focus()
        ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
            Me.txtSite.Focus()
        End If

    End Sub
    Private Sub txtMensagem_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMensagem.KeyUp
        'Procedimento para ativar as teclas Enter, Right, Left, Down, Up.
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If cmdIncluir.Enabled = True Then
            If KeyCode = 13 Then
                Me.cmdIncluir.Focus()
            ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
                Me.cmdIncluir.Focus()
            ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
                Me.txtEmail.Focus()
            ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
                Me.cmdIncluir.Focus()
            ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
                Me.txtEmail.Focus()
            End If

        ElseIf cmdAlterar.Enabled = True Then
            If KeyCode = 13 Then
                Me.cmdAlterar.Focus()
            ElseIf KeyCode = System.Windows.Forms.Keys.Right Then
                Me.cmdAlterar.Focus()
            ElseIf KeyCode = System.Windows.Forms.Keys.Left Then
                Me.txtEmail.Focus()
            ElseIf KeyCode = System.Windows.Forms.Keys.Down Then
                Me.cmdAlterar.Focus()
            ElseIf KeyCode = System.Windows.Forms.Keys.Up Then
                Me.txtEmail.Focus()
            End If

        End If

    End Sub

#End Region

    Private Sub btLocalizaLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLocalizaLogo.Click
        'Define as propriedades do controle FolderBrowserDialog

        FBDialog.Description = "Localiza a pasta do arquivo Logo.jpg"
        FBDialog.RootFolder = Environment.SpecialFolder.MyComputer
        FBDialog.ShowNewFolderButton = True

        'Exibe a caixa de diálogo
        If FBDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then


            Try
                'Exibe a pasta selecionada
                txtLogoPath.Text = FBDialog.SelectedPath & "\Logo.jpg"
                picLogo.Image = Image.FromFile(txtLogoPath.Text)

            Catch ex As Exception

                picLogo.Image = Nothing


            End Try
        End If


    End Sub
End Class