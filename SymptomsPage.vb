Public Class SymptomsPage
    Private Sub SymptomsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pic_Exit_Click(sender As Object, e As EventArgs) Handles pic_Exit.Click
        AppointmentPage.Show()
        Me.Hide()
    End Sub

    Private Sub btn_FindSpecialist_Click(sender As Object, e As EventArgs) Handles btn_FindSpecialist.Click
        SpecialistPage.Show()
        Me.Hide()
    End Sub
End Class