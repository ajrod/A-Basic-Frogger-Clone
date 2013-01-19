'The form that handles when frogger dies.
Public Class YouDie

    'Handles the try again button being clicked. Simply hide the form and continue playing.
    Private Sub TryAgain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TryAgain.Click
        Me.Hide()
    End Sub

    'Handles the quick button being clicked. This sets the quit flag to true, so that the game will exit.
    Private Sub Quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quit.Click
        quitGame = True
        Me.Hide()
    End Sub
End Class