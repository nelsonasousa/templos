Public NotInheritable Class Splash



    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Application title
        'If My.Application.Info.Title <> "" Then
        ' ApplicationTitle.Text = My.Application.Info.Title
        'Else
        'If the application title is missing, use the application name, without the extension
        ApplicationTitle.Text = "Templos"
        ' End If

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright

        'MarcaDataInstala()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

        Frm_Login.Show()
        ' Me.Visible = False


    End Sub
End Class
