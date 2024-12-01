Public Class InputInfoPage
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        PatientMenuPage.Show()
        Me.Hide()
    End Sub
End Class