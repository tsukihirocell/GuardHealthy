Public Class ConsentPage
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles rtb_ToS.TextChanged

    End Sub

    Private Sub btn_Understand_Click(sender As Object, e As EventArgs) Handles btn_Understand.Click
        InputInfoPage.Show()
        Me.Hide()
    End Sub
End Class