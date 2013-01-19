'The form that handles game over.
Public Class GameOver

    'Handles if the no button is clicked. (In response to trying again) This will quit the game.
    Private Sub NoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoButton.Click
        Me.Hide()
        quitGame = True
    End Sub
    'Handles if the yes button is clicked. Simply hide the form and continue playing.
    Private Sub YesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesButton.Click
        Me.Hide()
    End Sub
End Class