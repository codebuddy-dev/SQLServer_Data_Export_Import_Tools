Public Class MenuForm


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub btnExport_Click_1(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
        ExportData.Show()
    End Sub

    Private Sub btn_Click(sender As System.Object, e As System.EventArgs) Handles btn.Click
        ExportObjects.Show()
    End Sub

    Private Sub btnImport_Click(sender As System.Object, e As System.EventArgs) Handles btnImport.Click
        DataImport.Show()
    End Sub
End Class
