<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameOver
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GameOverTitle = New System.Windows.Forms.Label
        Me.PlayAgain = New System.Windows.Forms.Label
        Me.YesButton = New System.Windows.Forms.Button
        Me.NoButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'GameOverTitle
        '
        Me.GameOverTitle.AutoSize = True
        Me.GameOverTitle.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameOverTitle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GameOverTitle.Location = New System.Drawing.Point(53, 39)
        Me.GameOverTitle.Name = "GameOverTitle"
        Me.GameOverTitle.Size = New System.Drawing.Size(220, 36)
        Me.GameOverTitle.TabIndex = 0
        Me.GameOverTitle.Text = "GAME OVER"
        '
        'PlayAgain
        '
        Me.PlayAgain.AutoSize = True
        Me.PlayAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayAgain.ForeColor = System.Drawing.Color.Chartreuse
        Me.PlayAgain.Location = New System.Drawing.Point(44, 101)
        Me.PlayAgain.Name = "PlayAgain"
        Me.PlayAgain.Size = New System.Drawing.Size(254, 24)
        Me.PlayAgain.TabIndex = 1
        Me.PlayAgain.Text = "Would you live to play again?"
        '
        'YesButton
        '
        Me.YesButton.Location = New System.Drawing.Point(48, 151)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(81, 30)
        Me.YesButton.TabIndex = 2
        Me.YesButton.Text = "Yes"
        Me.YesButton.UseVisualStyleBackColor = True
        '
        'NoButton
        '
        Me.NoButton.Location = New System.Drawing.Point(192, 151)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(81, 30)
        Me.NoButton.TabIndex = 4
        Me.NoButton.Text = "No"
        Me.NoButton.UseVisualStyleBackColor = True
        '
        'GameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(335, 218)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.YesButton)
        Me.Controls.Add(Me.PlayAgain)
        Me.Controls.Add(Me.GameOverTitle)
        Me.Name = "GameOver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GameOver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GameOverTitle As System.Windows.Forms.Label
    Friend WithEvents PlayAgain As System.Windows.Forms.Label
    Friend WithEvents YesButton As System.Windows.Forms.Button
    Friend WithEvents NoButton As System.Windows.Forms.Button
End Class
