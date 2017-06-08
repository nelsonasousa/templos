Public Class Frm_Dizimos
    Private Sub CarregaAno()
        Dim strData As Integer

        strData = Today.Year

        For I = 0 To 4
            cboAno.Items.Add(strData + I)
        Next


    End Sub

    Private Sub Frm_Dizimos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        MdiParent = Frm_Principal

        CarregaAno()

    End Sub
End Class