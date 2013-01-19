<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YouDie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YouDie))
        Me.TryAgain = New System.Windows.Forms.Button
        Me.Quit = New System.Windows.Forms.Button
        Me.SplatteredFrog = New System.Windows.Forms.PictureBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DrownedFrog = New System.Windows.Forms.PictureBox
        CType(Me.SplatteredFrog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrownedFrog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TryAgain
        '
        Me.TryAgain.Location = New System.Drawing.Point(23, 182)
        Me.TryAgain.Name = "TryAgain"
        Me.TryAgain.Size = New System.Drawing.Size(106, 51)
        Me.TryAgain.TabIndex = 0
        Me.TryAgain.Text = "Try Again"
        Me.TryAgain.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Location = New System.Drawing.Point(154, 182)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(106, 51)
        Me.Quit.TabIndex = 1
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'SplatteredFrog
        '
        Me.SplatteredFrog.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.SplatteredFrog.Image = CType(resources.GetObject("SplatteredFrog.Image"), System.Drawing.Image)
        Me.SplatteredFrog.Location = New System.Drawing.Point(67, 70)
        Me.SplatteredFrog.Name = "SplatteredFrog"
        Me.SplatteredFrog.Size = New System.Drawing.Size(138, 92)
        Me.SplatteredFrog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SplatteredFrog.TabIndex = 2
        Me.SplatteredFrog.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Lime
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox1.Location = New System.Drawing.Point(67, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(138, 33)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "You Died"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DrownedFrog
        '
        Me.DrownedFrog.Image = CType(resources.GetObject("DrownedFrog.Image"), System.Drawing.Image)
        Me.DrownedFrog.Location = New System.Drawing.Point(67, 70)
        Me.DrownedFrog.Name = "DrownedFrog"
        Me.DrownedFrog.Size = New System.Drawing.Size(138, 92)
        Me.DrownedFrog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DrownedFrog.TabIndex = 4
        Me.DrownedFrog.TabStop = False
        Me.DrownedFrog.Visible = False
        '
        'YouDie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.DrownedFrog)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SplatteredFrog)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.TryAgain)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "YouDie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frogger Died!"
        CType(Me.SplatteredFrog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrownedFrog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TryAgain As System.Windows.Forms.Button
    Friend WithEvents Quit As System.Windows.Forms.Button
    Friend WithEvents SplatteredFrog As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DrownedFrog As System.Windows.Forms.PictureBox
End Class
