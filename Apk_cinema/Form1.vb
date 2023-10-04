Public Class Form1
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()

    End Sub
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles loginBtn1.Click
        loginForm.Show()
    End Sub
    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        registerationForm.Show()
    End Sub
End Class
