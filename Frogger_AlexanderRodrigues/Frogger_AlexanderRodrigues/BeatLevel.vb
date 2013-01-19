'The form that handles if frogger beat the level.
Public Class BeatLevel

    'Handles the quit button being clicked. Exits the game.
    Private Sub WinningQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WinningQuit.Click
        quitGame = True
        Me.Hide()
    End Sub

    'Handles the continue button being clicked. Hides the form and continues playing.
    Private Sub ContinueButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContinueButton.Click
        Me.Hide()
    End Sub
End Class