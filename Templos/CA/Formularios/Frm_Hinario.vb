
Imports System.IO

Public Class Frm_Hinario

    Private Sub bt_Abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Abrir.Click
        Dim str_Path As String = "C:\Projetos\VBNET\SGT\Hinos\"
        AbrirPPT(str_Path)

    End Sub

    Private Sub Frm_Hinario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Di As New DirectoryInfo(Application.StartupPath & "\Hinos")
        Dim Fi As FileInfo

        DataGridView1.Columns.Add("Himo", "Hino")
        For Each Fi In Di.GetFiles()
            DataGridView1.Rows.Add(Fi.Name)
        Next

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            Process.Start(Application.StartupPath & "\Hinos\" & DataGridView1.CurrentRow.Cells(0).Value)
        Catch ex As Exception

        End Try
    End Sub
End Class