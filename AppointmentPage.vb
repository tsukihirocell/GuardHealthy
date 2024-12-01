Public Class AppointmentPage
    Private Sub btn_NewAppoint_Click(sender As Object, e As EventArgs) Handles btn_NewAppoint.Click
        SymptomsPage.Show()
        Me.Hide()
    End Sub

    Private Sub btn_SchedAppoint_Click(sender As Object, e As EventArgs) Handles btn_SchedAppoint.Click
        appointment.Show()
        Me.Hide()
    End Sub
End Class