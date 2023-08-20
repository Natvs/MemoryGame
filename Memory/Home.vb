Public Class Home
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Dim GameForm As New Memory_Game
        GameForm.Show()
    End Sub

End Class