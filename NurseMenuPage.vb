Public Class NurseMenuPage

    Private Sub RoundedButton1_Click_1(sender As Object, e As EventArgs) Handles btn_Records.Click
        RecordsPage.Show()
        Hide()
    End Sub

    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles btn_Prescription.Click
        PrescriptionPage.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pic_Header.Click

    End Sub
End Class
