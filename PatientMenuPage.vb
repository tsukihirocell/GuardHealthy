Public Class PatientMenuPage
    Private Sub PatientMenuPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Appointment_Click(sender As Object, e As EventArgs) Handles btn_Appointment.Click
        AppointmentPage.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Records_Click(sender As Object, e As EventArgs) Handles btn_Records.Click
        PatientRecord.Show()
        Me.Hide()
    End Sub
End Class