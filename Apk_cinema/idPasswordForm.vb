Public Class idPasswordForm
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Close()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
        Me.Close()
        registerationForm.Close()

    End Sub
End Class