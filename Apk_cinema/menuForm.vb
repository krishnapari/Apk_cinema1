Public Class menuForm
    Private Sub menuClose_Click(sender As Object, e As EventArgs) Handles menuClose.Click
        Me.Close()
    End Sub
    Private Sub nowShowing_Click(sender As Object, e As EventArgs) Handles nowShowing.Click
        indicator.Top = nowShowing.Top
        pages.SetPage(0)
    End Sub

    Private Sub movies_Click(sender As Object, e As EventArgs) Handles movies.Click
        indicator.Top = movies.Top
        pages.SetPage(1)
    End Sub
    Private Sub collection_Click(sender As Object, e As EventArgs) Handles collection.Click
        indicator.Top = collection.Top
        pages.SetPage(2)
    End Sub
    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        pages.SetPage(3)
    End Sub

End Class