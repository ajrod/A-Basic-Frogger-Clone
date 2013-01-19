<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.GamePanel = New System.Windows.Forms.Panel()
        Me.Slot0 = New System.Windows.Forms.PictureBox()
        Me.Slot1 = New System.Windows.Forms.PictureBox()
        Me.Slot3 = New System.Windows.Forms.PictureBox()
        Me.Slot2 = New System.Windows.Forms.PictureBox()
        Me.Slot4 = New System.Windows.Forms.PictureBox()
        Me.Frogger = New System.Windows.Forms.PictureBox()
        Me.Log1 = New System.Windows.Forms.PictureBox()
        Me.Log5 = New System.Windows.Forms.PictureBox()
        Me.Log2 = New System.Windows.Forms.PictureBox()
        Me.Log4 = New System.Windows.Forms.PictureBox()
        Me.Log3 = New System.Windows.Forms.PictureBox()
        Me.Log0 = New System.Windows.Forms.PictureBox()
        Me.Truck8 = New System.Windows.Forms.PictureBox()
        Me.Truck7 = New System.Windows.Forms.PictureBox()
        Me.Truck6 = New System.Windows.Forms.PictureBox()
        Me.Truck5 = New System.Windows.Forms.PictureBox()
        Me.Truck2 = New System.Windows.Forms.PictureBox()
        Me.Truck3 = New System.Windows.Forms.PictureBox()
        Me.Truck1 = New System.Windows.Forms.PictureBox()
        Me.Truck4 = New System.Windows.Forms.PictureBox()
        Me.Truck0 = New System.Windows.Forms.PictureBox()
        Me.PlatformPic = New System.Windows.Forms.PictureBox()
        Me.WaterPic = New System.Windows.Forms.PictureBox()
        Me.RoadPic = New System.Windows.Forms.PictureBox()
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.frog0 = New System.Windows.Forms.PictureBox()
        Me.frog1 = New System.Windows.Forms.PictureBox()
        Me.frog2 = New System.Windows.Forms.PictureBox()
        Me.frog3 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.Lives = New System.Windows.Forms.Label()
        Me.GamePanel.SuspendLayout()
        CType(Me.Slot0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slot4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Frogger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Log1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Log5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Log2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Log4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Log3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Log0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Truck8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Truck7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Truck6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Truck5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Truck2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Truck3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Truck1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Truck4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Truck0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlatformPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaterPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoadPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frog0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frog1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frog2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frog3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GamePanel
        '
        Me.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GamePanel.Controls.Add(Me.Slot0)
        Me.GamePanel.Controls.Add(Me.Slot1)
        Me.GamePanel.Controls.Add(Me.Slot3)
        Me.GamePanel.Controls.Add(Me.Slot2)
        Me.GamePanel.Controls.Add(Me.Slot4)
        Me.GamePanel.Controls.Add(Me.Frogger)
        Me.GamePanel.Controls.Add(Me.Log1)
        Me.GamePanel.Controls.Add(Me.Log5)
        Me.GamePanel.Controls.Add(Me.Log2)
        Me.GamePanel.Controls.Add(Me.Log4)
        Me.GamePanel.Controls.Add(Me.Log3)
        Me.GamePanel.Controls.Add(Me.Log0)
        Me.GamePanel.Controls.Add(Me.Truck8)
        Me.GamePanel.Controls.Add(Me.Truck7)
        Me.GamePanel.Controls.Add(Me.Truck6)
        Me.GamePanel.Controls.Add(Me.Truck5)
        Me.GamePanel.Controls.Add(Me.Truck2)
        Me.GamePanel.Controls.Add(Me.Truck3)
        Me.GamePanel.Controls.Add(Me.Truck1)
        Me.GamePanel.Controls.Add(Me.Truck4)
        Me.GamePanel.Controls.Add(Me.Truck0)
        Me.GamePanel.Controls.Add(Me.PlatformPic)
        Me.GamePanel.Controls.Add(Me.WaterPic)
        Me.GamePanel.Controls.Add(Me.RoadPic)
        Me.GamePanel.Location = New System.Drawing.Point(44, 42)
        Me.GamePanel.Name = "GamePanel"
        Me.GamePanel.Size = New System.Drawing.Size(800, 600)
        Me.GamePanel.TabIndex = 0
        '
        'Slot0
        '
        Me.Slot0.Image = CType(resources.GetObject("Slot0.Image"), System.Drawing.Image)
        Me.Slot0.Location = New System.Drawing.Point(26, 10)
        Me.Slot0.Name = "Slot0"
        Me.Slot0.Size = New System.Drawing.Size(32, 32)
        Me.Slot0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Slot0.TabIndex = 23
        Me.Slot0.TabStop = False
        Me.Slot0.Visible = False
        '
        'Slot1
        '
        Me.Slot1.Image = CType(resources.GetObject("Slot1.Image"), System.Drawing.Image)
        Me.Slot1.Location = New System.Drawing.Point(206, 10)
        Me.Slot1.Name = "Slot1"
        Me.Slot1.Size = New System.Drawing.Size(32, 32)
        Me.Slot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Slot1.TabIndex = 22
        Me.Slot1.TabStop = False
        Me.Slot1.Visible = False
        '
        'Slot3
        '
        Me.Slot3.Image = CType(resources.GetObject("Slot3.Image"), System.Drawing.Image)
        Me.Slot3.Location = New System.Drawing.Point(569, 10)
        Me.Slot3.Name = "Slot3"
        Me.Slot3.Size = New System.Drawing.Size(32, 32)
        Me.Slot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Slot3.TabIndex = 21
        Me.Slot3.TabStop = False
        Me.Slot3.Visible = False
        '
        'Slot2
        '
        Me.Slot2.Image = CType(resources.GetObject("Slot2.Image"), System.Drawing.Image)
        Me.Slot2.Location = New System.Drawing.Point(390, 10)
        Me.Slot2.Name = "Slot2"
        Me.Slot2.Size = New System.Drawing.Size(32, 32)
        Me.Slot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Slot2.TabIndex = 20
        Me.Slot2.TabStop = False
        Me.Slot2.Visible = False
        '
        'Slot4
        '
        Me.Slot4.Image = CType(resources.GetObject("Slot4.Image"), System.Drawing.Image)
        Me.Slot4.Location = New System.Drawing.Point(745, 10)
        Me.Slot4.Name = "Slot4"
        Me.Slot4.Size = New System.Drawing.Size(32, 32)
        Me.Slot4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Slot4.TabIndex = 19
        Me.Slot4.TabStop = False
        Me.Slot4.Visible = False
        '
        'Frogger
        '
        Me.Frogger.Image = CType(resources.GetObject("Frogger.Image"), System.Drawing.Image)
        Me.Frogger.Location = New System.Drawing.Point(354, 561)
        Me.Frogger.Name = "Frogger"
        Me.Frogger.Size = New System.Drawing.Size(32, 32)
        Me.Frogger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Frogger.TabIndex = 0
        Me.Frogger.TabStop = False
        '
        'Log1
        '
        Me.Log1.Image = CType(resources.GetObject("Log1.Image"), System.Drawing.Image)
        Me.Log1.Location = New System.Drawing.Point(527, 54)
        Me.Log1.Name = "Log1"
        Me.Log1.Size = New System.Drawing.Size(182, 55)
        Me.Log1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Log1.TabIndex = 18
        Me.Log1.TabStop = False
        '
        'Log5
        '
        Me.Log5.Image = CType(resources.GetObject("Log5.Image"), System.Drawing.Image)
        Me.Log5.Location = New System.Drawing.Point(586, 179)
        Me.Log5.Name = "Log5"
        Me.Log5.Size = New System.Drawing.Size(182, 55)
        Me.Log5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Log5.TabIndex = 17
        Me.Log5.TabStop = False
        '
        'Log2
        '
        Me.Log2.Image = CType(resources.GetObject("Log2.Image"), System.Drawing.Image)
        Me.Log2.Location = New System.Drawing.Point(181, 115)
        Me.Log2.Name = "Log2"
        Me.Log2.Size = New System.Drawing.Size(182, 55)
        Me.Log2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Log2.TabIndex = 16
        Me.Log2.TabStop = False
        '
        'Log4
        '
        Me.Log4.Image = CType(resources.GetObject("Log4.Image"), System.Drawing.Image)
        Me.Log4.Location = New System.Drawing.Point(26, 176)
        Me.Log4.Name = "Log4"
        Me.Log4.Size = New System.Drawing.Size(182, 55)
        Me.Log4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Log4.TabIndex = 15
        Me.Log4.TabStop = False
        '
        'Log3
        '
        Me.Log3.Image = CType(resources.GetObject("Log3.Image"), System.Drawing.Image)
        Me.Log3.Location = New System.Drawing.Point(449, 115)
        Me.Log3.Name = "Log3"
        Me.Log3.Size = New System.Drawing.Size(182, 55)
        Me.Log3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Log3.TabIndex = 14
        Me.Log3.TabStop = False
        '
        'Log0
        '
        Me.Log0.Image = CType(resources.GetObject("Log0.Image"), System.Drawing.Image)
        Me.Log0.Location = New System.Drawing.Point(72, 54)
        Me.Log0.Name = "Log0"
        Me.Log0.Size = New System.Drawing.Size(182, 55)
        Me.Log0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Log0.TabIndex = 13
        Me.Log0.TabStop = False
        '
        'Truck8
        '
        Me.Truck8.Image = CType(resources.GetObject("Truck8.Image"), System.Drawing.Image)
        Me.Truck8.Location = New System.Drawing.Point(10, 453)
        Me.Truck8.Name = "Truck8"
        Me.Truck8.Size = New System.Drawing.Size(59, 32)
        Me.Truck8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Truck8.TabIndex = 12
        Me.Truck8.TabStop = False
        '
        'Truck7
        '
        Me.Truck7.Image = CType(resources.GetObject("Truck7.Image"), System.Drawing.Image)
        Me.Truck7.Location = New System.Drawing.Point(413, 504)
        Me.Truck7.Name = "Truck7"
        Me.Truck7.Size = New System.Drawing.Size(152, 44)
        Me.Truck7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Truck7.TabIndex = 11
        Me.Truck7.TabStop = False
        '
        'Truck6
        '
        Me.Truck6.Image = CType(resources.GetObject("Truck6.Image"), System.Drawing.Image)
        Me.Truck6.Location = New System.Drawing.Point(496, 347)
        Me.Truck6.Name = "Truck6"
        Me.Truck6.Size = New System.Drawing.Size(115, 35)
        Me.Truck6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Truck6.TabIndex = 10
        Me.Truck6.TabStop = False
        '
        'Truck5
        '
        Me.Truck5.Image = CType(resources.GetObject("Truck5.Image"), System.Drawing.Image)
        Me.Truck5.Location = New System.Drawing.Point(365, 452)
        Me.Truck5.Name = "Truck5"
        Me.Truck5.Size = New System.Drawing.Size(77, 33)
        Me.Truck5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Truck5.TabIndex = 9
        Me.Truck5.TabStop = False
        '
        'Truck2
        '
        Me.Truck2.Image = CType(resources.GetObject("Truck2.Image"), System.Drawing.Image)
        Me.Truck2.Location = New System.Drawing.Point(72, 504)
        Me.Truck2.Name = "Truck2"
        Me.Truck2.Size = New System.Drawing.Size(145, 35)
        Me.Truck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Truck2.TabIndex = 8
        Me.Truck2.TabStop = False
        '
        'Truck3
        '
        Me.Truck3.Image = CType(resources.GetObject("Truck3.Image"), System.Drawing.Image)
        Me.Truck3.Location = New System.Drawing.Point(569, 452)
        Me.Truck3.Name = "Truck3"
        Me.Truck3.Size = New System.Drawing.Size(140, 46)
        Me.Truck3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Truck3.TabIndex = 7
        Me.Truck3.TabStop = False
        '
        'Truck1
        '
        Me.Truck1.Image = CType(resources.GetObject("Truck1.Image"), System.Drawing.Image)
        Me.Truck1.Location = New System.Drawing.Point(365, 299)
        Me.Truck1.Name = "Truck1"
        Me.Truck1.Size = New System.Drawing.Size(57, 32)
        Me.Truck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Truck1.TabIndex = 6
        Me.Truck1.TabStop = False
        '
        'Truck4
        '
        Me.Truck4.Image = CType(resources.GetObject("Truck4.Image"), System.Drawing.Image)
        Me.Truck4.Location = New System.Drawing.Point(197, 347)
        Me.Truck4.Name = "Truck4"
        Me.Truck4.Size = New System.Drawing.Size(62, 31)
        Me.Truck4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Truck4.TabIndex = 5
        Me.Truck4.TabStop = False
        '
        'Truck0
        '
        Me.Truck0.Image = CType(resources.GetObject("Truck0.Image"), System.Drawing.Image)
        Me.Truck0.Location = New System.Drawing.Point(93, 295)
        Me.Truck0.Name = "Truck0"
        Me.Truck0.Size = New System.Drawing.Size(60, 36)
        Me.Truck0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Truck0.TabIndex = 4
        Me.Truck0.TabStop = False
        '
        'PlatformPic
        '
        Me.PlatformPic.Image = CType(resources.GetObject("PlatformPic.Image"), System.Drawing.Image)
        Me.PlatformPic.Location = New System.Drawing.Point(0, 0)
        Me.PlatformPic.Name = "PlatformPic"
        Me.PlatformPic.Size = New System.Drawing.Size(800, 48)
        Me.PlatformPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PlatformPic.TabIndex = 3
        Me.PlatformPic.TabStop = False
        '
        'WaterPic
        '
        Me.WaterPic.Image = CType(resources.GetObject("WaterPic.Image"), System.Drawing.Image)
        Me.WaterPic.Location = New System.Drawing.Point(0, 40)
        Me.WaterPic.Name = "WaterPic"
        Me.WaterPic.Size = New System.Drawing.Size(800, 200)
        Me.WaterPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.WaterPic.TabIndex = 2
        Me.WaterPic.TabStop = False
        '
        'RoadPic
        '
        Me.RoadPic.Image = CType(resources.GetObject("RoadPic.Image"), System.Drawing.Image)
        Me.RoadPic.Location = New System.Drawing.Point(0, 240)
        Me.RoadPic.Name = "RoadPic"
        Me.RoadPic.Size = New System.Drawing.Size(800, 413)
        Me.RoadPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.RoadPic.TabIndex = 1
        Me.RoadPic.TabStop = False
        '
        'Timer1
        '
        Me.GameTimer.Interval = 25
        '
        'frog0
        '
        Me.frog0.Image = CType(resources.GetObject("frog0.Image"), System.Drawing.Image)
        Me.frog0.Location = New System.Drawing.Point(693, 648)
        Me.frog0.Name = "frog0"
        Me.frog0.Size = New System.Drawing.Size(32, 32)
        Me.frog0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.frog0.TabIndex = 24
        Me.frog0.TabStop = False
        '
        'frog1
        '
        Me.frog1.Image = CType(resources.GetObject("frog1.Image"), System.Drawing.Image)
        Me.frog1.Location = New System.Drawing.Point(731, 648)
        Me.frog1.Name = "frog1"
        Me.frog1.Size = New System.Drawing.Size(32, 32)
        Me.frog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.frog1.TabIndex = 25
        Me.frog1.TabStop = False
        '
        'frog2
        '
        Me.frog2.Image = CType(resources.GetObject("frog2.Image"), System.Drawing.Image)
        Me.frog2.Location = New System.Drawing.Point(769, 648)
        Me.frog2.Name = "frog2"
        Me.frog2.Size = New System.Drawing.Size(32, 32)
        Me.frog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.frog2.TabIndex = 26
        Me.frog2.TabStop = False
        '
        'frog3
        '
        Me.frog3.Image = CType(resources.GetObject("frog3.Image"), System.Drawing.Image)
        Me.frog3.Location = New System.Drawing.Point(812, 648)
        Me.frog3.Name = "frog3"
        Me.frog3.Size = New System.Drawing.Size(32, 32)
        Me.frog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.frog3.TabIndex = 27
        Me.frog3.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Title.Location = New System.Drawing.Point(367, -4)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(160, 39)
        Me.Title.TabIndex = 28
        Me.Title.Text = "FROGGER"
        '
        'Lives
        '
        Me.Lives.AutoSize = True
        Me.Lives.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lives.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lives.Location = New System.Drawing.Point(627, 650)
        Me.Lives.Name = "Lives"
        Me.Lives.Size = New System.Drawing.Size(60, 24)
        Me.Lives.TabIndex = 29
        Me.Lives.Text = "Lives:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(890, 683)
        Me.Controls.Add(Me.Lives)
        Me.Controls.Add(Me.frog3)
        Me.Controls.Add(Me.GamePanel)
        Me.Controls.Add(Me.frog2)
        Me.Controls.Add(Me.frog0)
        Me.Controls.Add(Me.frog1)
        Me.Controls.Add(Me.Title)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frogger"
        Me.GamePanel.ResumeLayout(False)
        Me.GamePanel.PerformLayout()
        CType(Me.Slot0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slot4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Frogger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Log1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Log5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Log2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Log4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Log3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Log0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Truck8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Truck7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Truck6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Truck5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Truck2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Truck3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Truck1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Truck4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Truck0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlatformPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaterPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoadPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frog0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frog1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frog2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frog3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GamePanel As System.Windows.Forms.Panel
    Friend WithEvents Frogger As System.Windows.Forms.PictureBox
    Friend WithEvents RoadPic As System.Windows.Forms.PictureBox
    Friend WithEvents PlatformPic As System.Windows.Forms.PictureBox
    Friend WithEvents WaterPic As System.Windows.Forms.PictureBox
    Friend WithEvents Truck2 As System.Windows.Forms.PictureBox
    Friend WithEvents Truck3 As System.Windows.Forms.PictureBox
    Friend WithEvents Truck1 As System.Windows.Forms.PictureBox
    Friend WithEvents Truck4 As System.Windows.Forms.PictureBox
    Friend WithEvents Truck0 As System.Windows.Forms.PictureBox
    Friend WithEvents Truck7 As System.Windows.Forms.PictureBox
    Friend WithEvents Truck6 As System.Windows.Forms.PictureBox
    Friend WithEvents Truck5 As System.Windows.Forms.PictureBox
    Friend WithEvents Truck8 As System.Windows.Forms.PictureBox
    Friend WithEvents GameTimer As System.Windows.Forms.Timer
    Friend WithEvents Log0 As System.Windows.Forms.PictureBox
    Friend WithEvents Log1 As System.Windows.Forms.PictureBox
    Friend WithEvents Log5 As System.Windows.Forms.PictureBox
    Friend WithEvents Log2 As System.Windows.Forms.PictureBox
    Friend WithEvents Log4 As System.Windows.Forms.PictureBox
    Friend WithEvents Log3 As System.Windows.Forms.PictureBox
    Friend WithEvents Slot0 As System.Windows.Forms.PictureBox
    Friend WithEvents Slot1 As System.Windows.Forms.PictureBox
    Friend WithEvents Slot3 As System.Windows.Forms.PictureBox
    Friend WithEvents Slot2 As System.Windows.Forms.PictureBox
    Friend WithEvents Slot4 As System.Windows.Forms.PictureBox
    Friend WithEvents frog0 As System.Windows.Forms.PictureBox
    Friend WithEvents frog1 As System.Windows.Forms.PictureBox
    Friend WithEvents frog2 As System.Windows.Forms.PictureBox
    Friend WithEvents frog3 As System.Windows.Forms.PictureBox
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Lives As System.Windows.Forms.Label

End Class
