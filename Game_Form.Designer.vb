<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.label_WinStreak = New System.Windows.Forms.Label()
        Me.label_HighestScore = New System.Windows.Forms.Label()
        Me.button_Leaderboard = New System.Windows.Forms.Button()
        Me.label_ChooseThrow = New System.Windows.Forms.Label()
        Me.label_PlayingNow = New System.Windows.Forms.Label()
        Me.button_ChangeName = New System.Windows.Forms.Button()
        Me.button_ExitLeaderboard = New System.Windows.Forms.Button()
        Me.grid_Leaderboard = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_Leaderboard = New System.Windows.Forms.Panel()
        Me.button_Reset = New System.Windows.Forms.Button()
        Me.button_Logout = New System.Windows.Forms.Button()
        Me.pictureBoxScissors = New System.Windows.Forms.PictureBox()
        Me.pictureBoxPaper = New System.Windows.Forms.PictureBox()
        Me.pictureBoxRock = New System.Windows.Forms.PictureBox()
        Me.pictureBox_player = New System.Windows.Forms.PictureBox()
        Me.pictureBox_computer = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.grid_Leaderboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Leaderboard.SuspendLayout()
        CType(Me.pictureBoxScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox_player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox_computer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_WinStreak
        '
        Me.label_WinStreak.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_WinStreak.Enabled = False
        Me.label_WinStreak.Font = New System.Drawing.Font("A Goblin Appears!", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_WinStreak.ForeColor = System.Drawing.Color.Black
        Me.label_WinStreak.Location = New System.Drawing.Point(327, 102)
        Me.label_WinStreak.Name = "label_WinStreak"
        Me.label_WinStreak.Size = New System.Drawing.Size(213, 84)
        Me.label_WinStreak.TabIndex = 13
        Me.label_WinStreak.Text = "GAME" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ON!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.label_WinStreak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_HighestScore
        '
        Me.label_HighestScore.AutoSize = True
        Me.label_HighestScore.BackColor = System.Drawing.Color.Transparent
        Me.label_HighestScore.Font = New System.Drawing.Font("A Goblin Appears!", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_HighestScore.ForeColor = System.Drawing.Color.Black
        Me.label_HighestScore.Location = New System.Drawing.Point(346, 216)
        Me.label_HighestScore.Name = "label_HighestScore"
        Me.label_HighestScore.Size = New System.Drawing.Size(180, 12)
        Me.label_HighestScore.TabIndex = 16
        Me.label_HighestScore.Text = "Highest Score: 0"
        '
        'button_Leaderboard
        '
        Me.button_Leaderboard.BackColor = System.Drawing.Color.Orange
        Me.button_Leaderboard.Font = New System.Drawing.Font("Monocraft", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Leaderboard.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.button_Leaderboard.Location = New System.Drawing.Point(12, 380)
        Me.button_Leaderboard.Name = "button_Leaderboard"
        Me.button_Leaderboard.Size = New System.Drawing.Size(96, 35)
        Me.button_Leaderboard.TabIndex = 18
        Me.button_Leaderboard.Text = "Leaderboard"
        Me.button_Leaderboard.UseVisualStyleBackColor = False
        '
        'label_ChooseThrow
        '
        Me.label_ChooseThrow.AutoSize = True
        Me.label_ChooseThrow.BackColor = System.Drawing.Color.Transparent
        Me.label_ChooseThrow.Font = New System.Drawing.Font("A Goblin Appears!", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_ChooseThrow.ForeColor = System.Drawing.Color.DimGray
        Me.label_ChooseThrow.Location = New System.Drawing.Point(312, 280)
        Me.label_ChooseThrow.Name = "label_ChooseThrow"
        Me.label_ChooseThrow.Size = New System.Drawing.Size(246, 12)
        Me.label_ChooseThrow.TabIndex = 19
        Me.label_ChooseThrow.Text = "Choose what to throw:"
        '
        'label_PlayingNow
        '
        Me.label_PlayingNow.AllowDrop = True
        Me.label_PlayingNow.AutoEllipsis = True
        Me.label_PlayingNow.BackColor = System.Drawing.Color.Transparent
        Me.label_PlayingNow.Font = New System.Drawing.Font("A Goblin Appears!", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_PlayingNow.ForeColor = System.Drawing.Color.Black
        Me.label_PlayingNow.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite
        Me.label_PlayingNow.Location = New System.Drawing.Point(517, 18)
        Me.label_PlayingNow.Name = "label_PlayingNow"
        Me.label_PlayingNow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label_PlayingNow.Size = New System.Drawing.Size(337, 12)
        Me.label_PlayingNow.TabIndex = 20
        Me.label_PlayingNow.Text = "Playing as: "
        Me.label_PlayingNow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.label_PlayingNow.UseCompatibleTextRendering = True
        '
        'button_ChangeName
        '
        Me.button_ChangeName.Font = New System.Drawing.Font("Monocraft", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_ChangeName.Location = New System.Drawing.Point(757, 33)
        Me.button_ChangeName.Name = "button_ChangeName"
        Me.button_ChangeName.Size = New System.Drawing.Size(97, 23)
        Me.button_ChangeName.TabIndex = 21
        Me.button_ChangeName.Text = "Change Name"
        Me.button_ChangeName.UseVisualStyleBackColor = True
        '
        'button_ExitLeaderboard
        '
        Me.button_ExitLeaderboard.BackColor = System.Drawing.Color.IndianRed
        Me.button_ExitLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button_ExitLeaderboard.ForeColor = System.Drawing.SystemColors.Control
        Me.button_ExitLeaderboard.Location = New System.Drawing.Point(3, 3)
        Me.button_ExitLeaderboard.Name = "button_ExitLeaderboard"
        Me.button_ExitLeaderboard.Size = New System.Drawing.Size(40, 37)
        Me.button_ExitLeaderboard.TabIndex = 0
        Me.button_ExitLeaderboard.Text = " <<"
        Me.button_ExitLeaderboard.UseVisualStyleBackColor = False
        '
        'grid_Leaderboard
        '
        Me.grid_Leaderboard.AllowUserToAddRows = False
        Me.grid_Leaderboard.AllowUserToDeleteRows = False
        Me.grid_Leaderboard.AllowUserToResizeColumns = False
        Me.grid_Leaderboard.AllowUserToResizeRows = False
        Me.grid_Leaderboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_Leaderboard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid_Leaderboard.BackgroundColor = System.Drawing.SystemColors.Info
        Me.grid_Leaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Leaderboard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grid_Leaderboard.Enabled = False
        Me.grid_Leaderboard.GridColor = System.Drawing.Color.Beige
        Me.grid_Leaderboard.Location = New System.Drawing.Point(102, 113)
        Me.grid_Leaderboard.MultiSelect = False
        Me.grid_Leaderboard.Name = "grid_Leaderboard"
        Me.grid_Leaderboard.ReadOnly = True
        Me.grid_Leaderboard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.grid_Leaderboard.ShowCellErrors = False
        Me.grid_Leaderboard.ShowCellToolTips = False
        Me.grid_Leaderboard.ShowEditingIcon = False
        Me.grid_Leaderboard.ShowRowErrors = False
        Me.grid_Leaderboard.Size = New System.Drawing.Size(629, 290)
        Me.grid_Leaderboard.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("A Goblin Appears!", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(175, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(491, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LEADERBOARD"
        '
        'panel_Leaderboard
        '
        Me.panel_Leaderboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.panel_Leaderboard.Controls.Add(Me.Label2)
        Me.panel_Leaderboard.Controls.Add(Me.button_Reset)
        Me.panel_Leaderboard.Controls.Add(Me.Label1)
        Me.panel_Leaderboard.Controls.Add(Me.grid_Leaderboard)
        Me.panel_Leaderboard.Controls.Add(Me.button_ExitLeaderboard)
        Me.panel_Leaderboard.Location = New System.Drawing.Point(12, 12)
        Me.panel_Leaderboard.Name = "panel_Leaderboard"
        Me.panel_Leaderboard.Size = New System.Drawing.Size(842, 446)
        Me.panel_Leaderboard.TabIndex = 17
        Me.panel_Leaderboard.Visible = False
        '
        'button_Reset
        '
        Me.button_Reset.BackColor = System.Drawing.Color.MistyRose
        Me.button_Reset.Font = New System.Drawing.Font("A Goblin Appears!", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Reset.ForeColor = System.Drawing.Color.IndianRed
        Me.button_Reset.Location = New System.Drawing.Point(767, 416)
        Me.button_Reset.Name = "button_Reset"
        Me.button_Reset.Size = New System.Drawing.Size(62, 23)
        Me.button_Reset.TabIndex = 3
        Me.button_Reset.Text = "Reset"
        Me.button_Reset.UseVisualStyleBackColor = False
        '
        'button_Logout
        '
        Me.button_Logout.BackColor = System.Drawing.Color.IndianRed
        Me.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button_Logout.Font = New System.Drawing.Font("Monocraft", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Logout.ForeColor = System.Drawing.SystemColors.Control
        Me.button_Logout.Location = New System.Drawing.Point(12, 421)
        Me.button_Logout.Name = "button_Logout"
        Me.button_Logout.Size = New System.Drawing.Size(75, 37)
        Me.button_Logout.TabIndex = 3
        Me.button_Logout.Text = "LOGOUT"
        Me.button_Logout.UseVisualStyleBackColor = False
        '
        'pictureBoxScissors
        '
        Me.pictureBoxScissors.BackColor = System.Drawing.Color.Transparent
        Me.pictureBoxScissors.Location = New System.Drawing.Point(517, 295)
        Me.pictureBoxScissors.Name = "pictureBoxScissors"
        Me.pictureBoxScissors.Size = New System.Drawing.Size(125, 123)
        Me.pictureBoxScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxScissors.TabIndex = 12
        Me.pictureBoxScissors.TabStop = False
        '
        'pictureBoxPaper
        '
        Me.pictureBoxPaper.BackColor = System.Drawing.Color.Transparent
        Me.pictureBoxPaper.Location = New System.Drawing.Point(375, 295)
        Me.pictureBoxPaper.Name = "pictureBoxPaper"
        Me.pictureBoxPaper.Size = New System.Drawing.Size(125, 123)
        Me.pictureBoxPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxPaper.TabIndex = 11
        Me.pictureBoxPaper.TabStop = False
        '
        'pictureBoxRock
        '
        Me.pictureBoxRock.BackColor = System.Drawing.Color.Transparent
        Me.pictureBoxRock.Location = New System.Drawing.Point(233, 295)
        Me.pictureBoxRock.Name = "pictureBoxRock"
        Me.pictureBoxRock.Size = New System.Drawing.Size(125, 123)
        Me.pictureBoxRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxRock.TabIndex = 10
        Me.pictureBoxRock.TabStop = False
        '
        'pictureBox_player
        '
        Me.pictureBox_player.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox_player.Location = New System.Drawing.Point(-65, -31)
        Me.pictureBox_player.Name = "pictureBox_player"
        Me.pictureBox_player.Size = New System.Drawing.Size(423, 449)
        Me.pictureBox_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox_player.TabIndex = 8
        Me.pictureBox_player.TabStop = False
        '
        'pictureBox_computer
        '
        Me.pictureBox_computer.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox_computer.Location = New System.Drawing.Point(517, -31)
        Me.pictureBox_computer.Name = "pictureBox_computer"
        Me.pictureBox_computer.Size = New System.Drawing.Size(393, 449)
        Me.pictureBox_computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox_computer.TabIndex = 9
        Me.pictureBox_computer.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("A Goblin Appears!", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(157, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(536, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "The Top 10 Champions of the Game!"
        '
        'Game_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(866, 470)
        Me.Controls.Add(Me.panel_Leaderboard)
        Me.Controls.Add(Me.label_HighestScore)
        Me.Controls.Add(Me.label_WinStreak)
        Me.Controls.Add(Me.pictureBoxScissors)
        Me.Controls.Add(Me.pictureBoxPaper)
        Me.Controls.Add(Me.pictureBoxRock)
        Me.Controls.Add(Me.button_Leaderboard)
        Me.Controls.Add(Me.button_Logout)
        Me.Controls.Add(Me.button_ChangeName)
        Me.Controls.Add(Me.label_PlayingNow)
        Me.Controls.Add(Me.label_ChooseThrow)
        Me.Controls.Add(Me.pictureBox_player)
        Me.Controls.Add(Me.pictureBox_computer)
        Me.Name = "Game_Form"
        Me.Text = "Rock, Paper, Scissors!"
        CType(Me.grid_Leaderboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Leaderboard.ResumeLayout(False)
        Me.panel_Leaderboard.PerformLayout()
        CType(Me.pictureBoxScissors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox_player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox_computer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_WinStreak As System.Windows.Forms.Label
    Friend WithEvents pictureBoxScissors As System.Windows.Forms.PictureBox
    Friend WithEvents pictureBoxPaper As System.Windows.Forms.PictureBox
    Friend WithEvents pictureBoxRock As System.Windows.Forms.PictureBox
    Friend WithEvents pictureBox_computer As System.Windows.Forms.PictureBox
    Friend WithEvents pictureBox_player As System.Windows.Forms.PictureBox
    Friend WithEvents label_HighestScore As Label
    Friend WithEvents button_Leaderboard As Button
    Friend WithEvents label_ChooseThrow As Label
    Friend WithEvents button_ChangeName As Button
    Friend WithEvents button_ExitLeaderboard As Button
    Friend WithEvents grid_Leaderboard As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents panel_Leaderboard As Panel
    Friend WithEvents button_Logout As Button
    Friend WithEvents button_Reset As Button
    Private WithEvents label_PlayingNow As Label
    Friend WithEvents Label2 As Label
End Class
