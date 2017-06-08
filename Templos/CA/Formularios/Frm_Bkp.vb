Imports Ionic.Utils
Imports System.Windows


Public Class Frm_Bkp

    Dim strNomeArq As String = "SGT_BKP"
    Dim strPasta As String = "E:\"
    Private Sub MudaLocal()
        If CBData.Checked = True And CBHora.Checked = True Then
            Me.txtLocal.Text = strPasta & strNomeArq & "_" & Date.Today.Day & "_" & Date.Today.Month & "_" & Date.Today.Year & "_" & Date.Now.Hour & Date.Now.Minute & ".zip"
        ElseIf CBData.Checked = False And CBHora.Checked = True Then
            Me.txtLocal.Text = strPasta & strNomeArq & "_" & Date.Now.Hour & Date.Now.Minute & ".zip"
        ElseIf CBData.Checked = True And CBHora.Checked = False Then
            Me.txtLocal.Text = strPasta & strNomeArq & "_" & Date.Today.Day & "_" & Date.Today.Month & "_" & Date.Today.Year & ".zip"
        ElseIf CBData.Checked = False And CBHora.Checked = False Then
            Me.txtLocal.Text = strPasta & strNomeArq & ".zip"
        End If
    End Sub
    Private Sub btBkp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBkp.Click

        Using zip As New Zip.ZipFile(txtLocal.Text)

            'adicionando um arquivo 

            zip.AddFile(strLocalBase)
            'zip.AddFile("c:\temp\Setup.ini")

            'adicionando um diretório
            'zip.AddDirectory("c:\temp\temp2")
            Try
                zip.Save()
                MsgBox("Backup Realizado com sucesso", 64, strSistema)
                End
            Catch ex As Exception
                'Caso ocorra erro mostra a menssagem abaixo
                MsgBox("Ao fazer o Backup ocorreu o erro: " & ex.Message, 16, strSistema)
                Exit Sub
            End Try

        End Using

    End Sub

    Private Sub Frm_Bkp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = Frm_Principal
        Me.txtLocal.Text = strPasta & strNomeArq & "_" & Date.Today.Day & "_" & Date.Today.Month & "_" & Date.Today.Year & ".zip"
    End Sub

    Private Sub CBData_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBData.CheckedChanged
        MudaLocal()
    End Sub

    Private Sub btLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLocal.Click
        'Define as propriedades do controle FolderBrowserDialog

        FDialogBkp.Description = "Localize a pasta destino"
        FDialogBkp.RootFolder = Environment.SpecialFolder.MyComputer
        FDialogBkp.ShowNewFolderButton = False


        'Exibe a caixa de diálogo
        If FDialogBkp.ShowDialog = System.Windows.Forms.DialogResult.OK Then

            'Exibe a pasta selecionada
            strPasta = FDialogBkp.SelectedPath & "\"
            MudaLocal()
        End If
    End Sub

    Private Sub CBHora_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBHora.CheckedChanged
        MudaLocal()
    End Sub
End Class