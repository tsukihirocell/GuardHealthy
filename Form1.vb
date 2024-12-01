Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles btn_Patient.Click
        LoginPage.Show()
        Me.Hide()
    End Sub

    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles btn_Nurse.Click
        LoginPage.Show()
        Me.Hide()
    End Sub

    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles btn_Doctor.Click
        LoginPage.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_Register.LinkClicked
        RegisterPage.Show()
        Me.Hide()

    End Sub
End Class
