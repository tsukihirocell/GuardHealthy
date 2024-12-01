Public Class appointment
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbl_NoteBox.Click

    End Sub

    Private Sub appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ConfirmApp_Click(sender As Object, e As EventArgs) Handles btn_ConfirmApp.Click
        AppointmentPage.Show()
        Me.Hide()
    End Sub
End Class