<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BeatLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BeatLevel))
        Me.WinningLabel = New System.Windows.Forms.Label
        Me.WinningFrog = New System.Windows.Forms.PictureBox
        Me.ContinueButton = New System.Windows.Forms.Button
        Me.WinningQuit = New System.Windows.Forms.Button
        CType(Me.WinningFrog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WinningLabel
        '
        Me.WinningLabel.AutoSize = True
        Me.WinningLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinningLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.WinningLabel.Location = New System.Drawing.Point(73, 18)
        Me.WinningLabel.Name = "WinningLabel"
        Me.WinningLabel.Size = New System.Drawing.Size(132, 33)
        Me.WinningLabel.TabIndex = 0
        Me.WinningLabel.Text = "You Win"
        '
        'WinningFrog
        '
        Me.WinningFrog.Image = CType(resources.GetObject("WinningFrog.Image"), System.Drawing.Image)
        Me.WinningFrog.Location = New System.Drawing.Point(59, 64)
        Me.WinningFrog.Name = "WinningFrog"
        Me.WinningFrog.Size = New System.Drawing.Size(157, 107)
        Me.WinningFrog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WinningFrog.TabIndex = 1
        Me.WinningFrog.TabStop = False
        '
        'ContinueButton
        '
        Me.ContinueButton.Location = New System.Drawing.Point(28, 188)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(93, 39)
        Me.ContinueButton.TabIndex = 2
        Me.ContinueButton.Text = "Continue"
        Me.ContinueButton.UseVisualStyleBackColor = True
        '
        'WinningQuit
        '
        Me.WinningQuit.Location = New System.Drawing.Point(157, 188)
        Me.WinningQuit.Name = "WinningQuit"
        Me.WinningQuit.Size = New System.Drawing.Size(93, 39)
        Me.WinningQuit.TabIndex = 3
        Me.WinningQuit.Text = "Quit"
        Me.WinningQuit.UseVisualStyleBackColor = True
        '
        'BeatLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.WinningQuit)
        Me.Controls.Add(Me.ContinueButton)
        Me.Controls.Add(Me.WinningFrog)
        Me.Controls.Add(Me.WinningLabel)
        Me.Name = "BeatLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Beat Level"
        CType(Me.WinningFrog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WinningLabel As System.Windows.Forms.Label
    Friend WithEvents WinningFrog As System.Windows.Forms.PictureBox
    Friend WithEvents ContinueButton As System.Windows.Forms.Button
    Friend WithEvents WinningQuit As System.Windows.Forms.Button
End Class
