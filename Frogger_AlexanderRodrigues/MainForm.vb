
'The mainform that the game is contained in.
Public Class MainForm

    'The number of trucks in the game
    Const NUM_TRUCKS As Integer = 8
    'The number of pixels frogger hops at a time.
    Const HOP_LENGTH As Integer = 53
    'The number of logs in the game.
    Const NUM_LOGS As Integer = 5
    'The number of goal slots in the game.
    Const NUM_SLOTS As Integer = 4
    'The number of lives Frogger has.
    Const NUM_LIVES As Integer = 3
    'The array containing the trucks pictureboxes
    Dim Trucks(NUM_TRUCKS) As PictureBox
    'The speeds for each truck.
    Dim TruckSpeed(NUM_TRUCKS) As Integer
    'The array containing the logs pictureboxes
    Dim Logs(NUM_LOGS) As PictureBox
    'The speeds for each log.
    Dim LogSpeed(NUM_LOGS) As Integer
    'The the area for each slot.
    Dim Slots(NUM_SLOTS) As PictureBox
    'True iff Frogger is riding a log
    Dim onLog As Boolean
    'The number of goal slots that Frogger has filled.
    Dim numSlotsFilled As Integer
    'The number of times Frogger has died.
    Dim deathCount As Integer
    'The array of pictureboxes displayed in the bottom right corner of the game.
    Dim FrogLives(NUM_LIVES) As PictureBox
    'True iff the game is paused.
    Dim paused As Boolean
    'True iff music is allowed to play.
    Dim Music As Boolean
    'The form that handles Froggers death.
    Public Shared YouDieForm As New YouDie
    'The form that handles Frogger winning.
    Public Shared BeatLevelForm As New BeatLevel
    'The form that handles Frogger losing (running out of lives).
    Public Shared GameOverForm As New GameOver

    'Handle user input from the keyboard such as moving Frogger around with the arrow keys.
    Private Sub MainForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'Move Frogger up
        If e.KeyCode = Keys.Up Then
            If Frogger.Top - HOP_LENGTH > 0 Then
                Frogger.Top -= HOP_LENGTH
            Else
                Frogger.Top = 0
            End If
            'Move Frogger Down
        ElseIf e.KeyCode = Keys.Down Then
            If Frogger.Bottom + HOP_LENGTH < GamePanel.Height Then
                Frogger.Top += HOP_LENGTH
            Else
                Frogger.Top = GamePanel.Height - Frogger.Height
            End If
            'Move Frogger Right
        ElseIf e.KeyCode = Keys.Right Then
            If Frogger.Right + HOP_LENGTH < GamePanel.Width Then
                Frogger.Left += HOP_LENGTH
            Else
                Frogger.Left = GamePanel.Width - Frogger.Width
            End If
            'Move Frogger Left
        ElseIf e.KeyCode = Keys.Left Then
            If Frogger.Left > HOP_LENGTH Then
                Frogger.Left -= HOP_LENGTH
            Else
                Frogger.Left = 0
            End If
            'Toggle pausing the game
        ElseIf e.KeyCode = Keys.P Then
            If paused Then
                ToggleAudio()
                paused = False
            Else
                paused = True
                ToggleAudio(True)

            End If
            'Toggle the background music
        ElseIf e.KeyCode = Keys.S Then
            Call ToggleAudio()
        End If
        'Update Frogger's animation since he may have changed direction or moved positions
        Call AnimateFrogger(e.KeyCode)
    End Sub

    'Load the game content.
    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        quitGame = False
        paused = False
        ToggleAudio()
        numSlotsFilled = NUM_SLOTS
        deathCount = 0
        FrogLives(0) = frog3
        FrogLives(1) = frog2
        FrogLives(2) = frog1
        FrogLives(3) = frog0

        Call ResetLevel()
        GameTimer.Start()

    End Sub

    'The update engine of the game. Moves logs, trucks, checks for winning or losing, etc...
    Private Sub GameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameTimer.Tick
        Dim index As Integer

        If quitGame = True Then
            Me.Close()
        End If

        If paused = True Then Return
        onLog = False

        'Move all the trucks
        For index = 0 To NUM_TRUCKS
            Call MoveTruck(index)
            If Touching(Frogger, Trucks(index)) = True Then
                Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\froggersplat.bmp")
                Call KillFrogger()
            End If
        Next

        'Move all the logs
        For index = 0 To NUM_LOGS
            MoveLog(index)
            If Touching(Frogger, Logs(index)) = True Then
                onLog = True
                RideLog(index)
            End If
        Next

        'Check if Frogger is in a goal slot
        Call CheckSlots()

        'Check if frogger is drowning
        If Frogger.Top < 240 And onLog = False Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\froggerdrown.BMP")
            YouDieForm.DrownedFrog.Visible = True
            Call KillFrogger()
            YouDieForm.DrownedFrog.Visible = False
        End If

    End Sub

    'Move the truck by the trucks speed.
    Private Sub MoveTruck(ByVal index As Integer)

        If Trucks(index).Left > GamePanel.Width Then 'car going right
            Trucks(index).Left = -200
        ElseIf Trucks(index).Left < -200 Then 'car going left
            Trucks(index).Left = GamePanel.Width
        Else
            Trucks(index).Left += TruckSpeed(index) + GetSpeedIncrease() * GetSign(TruckSpeed(index))
        End If
    End Sub

    'Return true if the pictures boxes are colliding.
    Private Function Touching(ByVal object1 As PictureBox, ByVal object2 As PictureBox)
        If object1.Left < object2.Right And object1.Right > object2.Left Then
            If object1.Bottom > object2.Top And object1.Top < object2.Bottom Then
                Return True
            End If
        End If
        Return False
    End Function

    'Reset the level.
    Private Sub ResetLevel()
        Call FroggerSet()
        Call TruckSet()
        Call LogSet()
        Call SlotSet()
    End Sub

    'Initialize Frogger's starting position and image.
    Private Sub FroggerSet()
        Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2grassup.bmp")
        Frogger.Left = 400
        Frogger.Top = 561
    End Sub

    'Initialize the truck array and and the truck speeds.
    Private Sub TruckSet()
        Trucks(0) = Truck0
        Trucks(1) = Truck1
        Trucks(2) = Truck2
        Trucks(3) = Truck3
        Trucks(4) = Truck4
        Trucks(5) = Truck5
        Trucks(6) = Truck6
        Trucks(7) = Truck7
        Trucks(8) = Truck8
        TruckSpeed(0) = 5
        TruckSpeed(1) = 5
        TruckSpeed(2) = -5
        TruckSpeed(3) = 5
        TruckSpeed(4) = -5
        TruckSpeed(5) = 5
        TruckSpeed(6) = -5
        TruckSpeed(7) = -5
        TruckSpeed(8) = 5
    End Sub

    'Initialize all the logs.
    Private Sub LogSet()
        Logs(0) = Log0
        Logs(1) = Log1
        Logs(2) = Log2
        Logs(3) = Log3
        Logs(4) = Log4
        Logs(5) = Log5
        LogSpeed(0) = 5
        LogSpeed(1) = 5
        LogSpeed(2) = -5
        LogSpeed(3) = -5
        LogSpeed(4) = 5
        LogSpeed(5) = 5

    End Sub

    'Move the log by the logs speed.'
    Private Sub MoveLog(ByVal index As Integer)
        If Logs(index).Left > GamePanel.Width Then 'Log going right
            Logs(index).Left = -200
        ElseIf Logs(index).Left < -200 Then 'car going left
            Logs(index).Left = GamePanel.Width
        Else
            Logs(index).Left += LogSpeed(index) + GetSpeedIncrease() * GetSign(LogSpeed(index))
        End If
    End Sub

    'Kill Frogger and display the dialog box for dying.
    Private Sub KillFrogger()
        Dim index As Integer
        GameTimer.Stop()
        If deathCount < NUM_LIVES Then
            YouDieForm.ShowDialog()
            FrogLives(deathCount).Visible = False
            deathCount += 1
            Call ResetLevel()
        Else
            GameOverForm.ShowDialog()
            deathCount = 0
            Call ResetLevel()
            For index = 0 To NUM_LIVES
                FrogLives(index).Visible = True
            Next
            For index = 0 To NUM_SLOTS
                Slots(index).Visible = False
            Next
            numSlotsFilled = 0
        End If
        GameTimer.Start()
    End Sub

    'Moves Frogger with the log.
    Private Sub RideLog(ByVal index As Integer)
        Frogger.Left += LogSpeed(index) + GetSpeedIncrease() * GetSign(LogSpeed(index))
        Frogger.Top = Logs(index).Top + 15
    End Sub

    'Initialize the goal slots.
    Private Sub SlotSet()
        Slots(0) = Slot0
        Slots(1) = Slot1
        Slots(2) = Slot2
        Slots(3) = Slot3
        Slots(4) = Slot4
    End Sub

    'Return the sign of a number. Returns -1 if the number was negative, 1 if the number was positive and 0 otherwise.
    Function GetSign(ByVal number As Integer)
        If number = 0 Then
            Return 0
        End If
        Return Math.Abs(number) / number
    End Function
    'Get the amount of speed increased for trucks and logs as frogger progresses
    Function GetSpeedIncrease()
        Return numSlotsFilled * 1.5
    End Function
    'Check if Frogger has reached a goal slot.
    Private Sub CheckSlots()
        Dim index As Integer
        Dim SlotIndex As Integer
        numSlotsFilled = 0
        'check if frogger is touching and goal slot
        For index = 0 To NUM_SLOTS
            If Touching(Frogger, Slots(index)) = True And Slots(index).Visible = False Then
                Slots(index).Visible = True
                ResetLevel()
            End If
        Next

        'count the number of slots filled
        For index = 0 To NUM_SLOTS
            If Slots(index).Visible Then
                numSlotsFilled += 1
            End If
        Next

        'check if frogger filled all the slots
        If numSlotsFilled = NUM_SLOTS + 1 Then
            GameTimer.Stop()
            BeatLevelForm.ShowDialog()
            For SlotIndex = 0 To NUM_SLOTS
                Slots(SlotIndex).Visible = False
            Next
            GameTimer.Start()
        End If


    End Sub

    'Animates Frogger based on his facing direction when he is on grass.
    Private Sub AnimateFroggerOnGrass(ByVal Direction As Integer)

        If Direction = Keys.Up Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2grassup.bmp")
        ElseIf Direction = Keys.Down Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2grassdown.bmp")
        ElseIf Direction = Keys.Right Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2grassright.bmp")
        ElseIf Direction = Keys.Left Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2grassleft.bmp")
        End If
    End Sub

    'Animates Frogger based on his facing direction when he is on a road.
    Private Sub AnimateFroggerOnRoad(ByVal Direction As Integer)
        If Direction = Keys.Up Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2roadup.bmp")
        ElseIf Direction = Keys.Down Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2roaddown.bmp")
        ElseIf Direction = Keys.Right Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2roadright.bmp")
        ElseIf Direction = Keys.Left Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2roadleft.bmp")
        End If
    End Sub

    'Animates Frogger based on his facing direction when he is on a log.
    Private Sub AnimateFroggerOnLog(ByVal Direction As Integer)
        If Direction = Keys.Up Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2logup.bmp")
        ElseIf Direction = Keys.Down Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2logdown.bmp")
        ElseIf Direction = Keys.Right Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2logright.bmp")
        ElseIf Direction = Keys.Left Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2logleft.bmp")
        End If
    End Sub

    'Animates Frogger based on his facing direction and the background that he is standing on.
    Private Sub AnimateFrogger(ByVal Direction As Integer)
        If Frogger.Top > 550 Then
            Call AnimateFroggerOnGrass(Direction)
        ElseIf Frogger.Top > 450 Then
            Call AnimateFroggerOnRoad(Direction)
        ElseIf Frogger.Top > 370 Then
            Call AnimateFroggerOnGrass(Direction)
        ElseIf Frogger.Top > 250 Then
            Call AnimateFroggerOnRoad(Direction)
        ElseIf Frogger.Top > 225 Then
            Call AnimateFroggerOnGrass(Direction)
        ElseIf Frogger.Top > 50 Then
            Call AnimateFroggerOnLog(Direction)
        End If
    End Sub

    'Toggles the background music
    Private Sub ToggleAudio(Optional ByVal turnOff As Boolean = False)
        Music = Not Music And Not turnOff
        If Music Then
            My.Computer.Audio.Play(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\sounds\Happy Alley.wav", AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub
End Class
