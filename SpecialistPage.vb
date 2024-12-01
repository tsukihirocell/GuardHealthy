Public Class SpecialistPage

    Dim navbar As String = "Close"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If navbar = "Open" Then
            pnl_Header.Height = 25
            If pnl_Header.Height >= 100 Then
                navbar = "Close"
                Timer1.Stop()
            End If
        Else
            pnl_Header.Height = 25
            If pnl_Header.Height <= 50 Then
                navbar = "Open"
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub pic_Menu_Click(sender As Object, e As EventArgs) Handles pic_Menu.Click
        Timer1.Start()
    End Sub

    Private Sub pic_Exit_Click(sender As Object, e As EventArgs) Handles pic_Exit.Click
        Me.Hide()
        SymptomsPage.Show()
    End Sub

    Private Sub btn_BookAppointment_Click(sender As Object, e As EventArgs) Handles btn_BookAppointment.Click
        Me.Hide()
        AppointmentPage.Show()
    End Sub
End Class