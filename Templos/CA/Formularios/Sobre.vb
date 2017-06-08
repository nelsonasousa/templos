
Public NotInheritable Class Sobre

    Private Sub Sobre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Sobre o {0}", ApplicationTitle)
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Versão {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description & vbCrLf & " Toda sugestão para melhoria deste programa, bem como o relato de erros encontrados, serão bem vindos, e, podem ser enviados para nelsonasousa@yahoo.com.br" & vbCrLf & "Um abraço a todos." & vbCrLf & _
             vbCrLf & "Na verdade, na verdade vos digo que quem OUVE a minha palavra, e CRÊ naquele que me enviou, TEM a vida eterna, e NÃO ENTRARÁ em condenação, mas PASSOU da morte para a vida. João 5:24"
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
