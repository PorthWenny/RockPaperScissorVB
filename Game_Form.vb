Imports System.Reflection.Emit
Imports Npgsql

Public Class Game_Form

    Private Shared ReadOnly ConnectionString As String = "User Id=postgres;Password=l1qEYDkwXIn84Yn6;Server=db.umrbdtcblbsidpoxiqpl.supabase.co;Port=5432;Database=postgres"

    Dim rock As Bitmap = My.Resources.rock
    Dim paper As Bitmap = My.Resources.paper
    Dim scissors As Bitmap = My.Resources.scissors
    Dim rock_hand As Bitmap = My.Resources.rock_hand
    Dim paper_hand As Bitmap = My.Resources.paper_hand
    Dim scissors_hand As Bitmap = My.Resources.scissors_hand

    Dim random_picture As Bitmap
    Dim player_wins As Integer = 0, computer_wins As Integer = 0
    Dim list As ArrayList = New ArrayList()
    Dim random As Random = New Random()
    Dim highestScore As Integer = 0

    Private _currentUsername As String
    Public Property CurrentUsername() As String
        Get
            Return _currentUsername
        End Get
        Set(ByVal value As String)
            _currentUsername = value
        End Set
    End Property

    Private Sub Game_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Rock, Paper, Scissors!"
        panel_Leaderboard.Visible = False

        Me.Icon = My.Resources.rps_icon
        pictureBoxRock.Image = My.Resources.rock
        pictureBoxPaper.Image = My.Resources.paper
        pictureBoxScissors.Image = My.Resources.scissors

        list.Add(rock_hand)
        list.Add(paper_hand)
        list.Add(scissors_hand)

        ' to display stored highscore upon login
        Try
            Using connection As New NpgsqlConnection(ConnectionString)
                connection.Open()

                Dim query As String = "SELECT highscore FROM account_info WHERE username = @username"
                Using cmd As New NpgsqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", CurrentUsername)
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        highestScore = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error fetching high score: " & ex.Message)
        End Try


        label_HighestScore.Text = "Highest Score: " & highestScore.ToString()

        label_PlayingNow.Text = "Playing As: " & CurrentUsername
        Me.Refresh()

    End Sub

    Public Sub getWinner(ByVal player As Bitmap, ByVal computer As Bitmap)

        Dim playerChoice As String = GetChoiceName(player)
        Dim computerChoice As String = GetChoiceName(computer)

        If playerChoice.Equals(computerChoice) Then
            label_WinStreak.Text = "It's a Tie!"

        ElseIf playerChoice.Equals("rock") Then

            If computerChoice.Equals("scissors") Then
                player_wins += 1
                label_WinStreak.Text = player_wins.ToString()
            Else
                player_wins = 0
                label_WinStreak.Text = "You lost!"
                UpdateHighestScoreInDB()
            End If

        ElseIf playerChoice.Equals("paper") Then

            If computerChoice.Equals("rock") Then
                player_wins += 1
                label_WinStreak.Text = player_wins.ToString()
            Else
                player_wins = 0
                label_WinStreak.Text = "You lost!"
                UpdateHighestScoreInDB()
            End If

        ElseIf playerChoice.Equals("scissors") Then

            If computerChoice.Equals("paper") Then
                player_wins += 1
                label_WinStreak.Text = player_wins.ToString()
            Else
                player_wins = 0
                label_WinStreak.Text = "You lost!"
                UpdateHighestScoreInDB()
            End If

        End If

        If player_wins > highestScore Then
            highestScore = player_wins
            label_HighestScore.Text = "Highest Score: " & highestScore.ToString()
        End If
    End Sub

    Private Function GetChoiceName(ByVal bitmap As Bitmap) As String
        Dim resourceNames As New Dictionary(Of Bitmap, String) From {
        {rock, "rock"},
        {paper, "paper"},
        {scissors, "scissors"},
        {rock_hand, "rock_hand"},
        {paper_hand, "paper_hand"},
        {scissors_hand, "scissors_hand"}
    }

        Dim resourceName As String = ""
        If resourceNames.ContainsKey(bitmap) Then
            resourceName = resourceNames(bitmap)
        End If

        resourceName = resourceName.Replace("_hand", "")
        Return resourceName
    End Function

    Private Sub pictureBoxRock_Click(sender As Object, e As EventArgs) Handles pictureBoxRock.Click

        label_ChooseThrow.Visible = False
        pictureBox_player.Image = rock_hand
        random_picture = CType(list(random.[Next](list.Count)), Bitmap)
        Dim flippedImage As Bitmap = New Bitmap(random_picture)
        flippedImage.RotateFlip(RotateFlipType.RotateNoneFlipX)
        pictureBox_computer.Image = flippedImage
        getWinner(rock, random_picture)

    End Sub

    Private Sub pictureBoxPaper_Click(sender As Object, e As EventArgs) Handles pictureBoxPaper.Click

        label_ChooseThrow.Visible = False
        pictureBox_player.Image = paper_hand
        random_picture = CType(list(random.[Next](list.Count)), Bitmap)
        Dim flippedImage As Bitmap = New Bitmap(random_picture)
        flippedImage.RotateFlip(RotateFlipType.RotateNoneFlipX)
        pictureBox_computer.Image = flippedImage
        getWinner(paper, random_picture)

    End Sub

    Private Sub pictureBoxScissors_Click(sender As Object, e As EventArgs) Handles pictureBoxScissors.Click

        label_ChooseThrow.Visible = False
        pictureBox_player.Image = scissors_hand
        random_picture = CType(list(random.[Next](list.Count)), Bitmap)
        Dim flippedImage As Bitmap = New Bitmap(random_picture)
        flippedImage.RotateFlip(RotateFlipType.RotateNoneFlipX)
        pictureBox_computer.Image = flippedImage
        getWinner(scissors, random_picture)

    End Sub
    Private Sub button_Leaderboard_Click(sender As Object, e As EventArgs) Handles button_Leaderboard.Click
        If panel_Leaderboard.Visible = False Then
            pictureBox_player.Visible = False
            pictureBox_computer.Visible = False
            panel_Leaderboard.Visible = True
            panel_Leaderboard.Enabled = True
            PopulateLeaderboard()

            grid_Leaderboard.DefaultCellStyle.Font = New Font("Monocraft", 12)
            grid_Leaderboard.ColumnHeadersDefaultCellStyle.Font = New Font("A Goblin Appears!", 10, FontStyle.Bold)
            grid_Leaderboard.Columns(0).HeaderText = "Player"
            grid_Leaderboard.Columns(1).HeaderText = "High Score"

            grid_Leaderboard.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            grid_Leaderboard.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For Each column As DataGridViewColumn In grid_Leaderboard.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            grid_Leaderboard.ReadOnly = True
            grid_Leaderboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            grid_Leaderboard.AllowUserToAddRows = False
            grid_Leaderboard.AllowUserToDeleteRows = False
            grid_Leaderboard.EditMode = DataGridViewEditMode.EditProgrammatically
            grid_Leaderboard.MultiSelect = False
            grid_Leaderboard.ClearSelection()
        End If
    End Sub


    Private Sub button_ExitLeaderboard_Click(sender As Object, e As EventArgs) Handles button_ExitLeaderboard.Click
        If panel_Leaderboard.Visible = True Then
            pictureBox_player.Visible = True
            pictureBox_computer.Visible = True
            panel_Leaderboard.Visible = False
            panel_Leaderboard.Enabled = False
            grid_Leaderboard.ClearSelection()
        End If
    End Sub

    Private Sub button_Logout_Click(sender As Object, e As EventArgs) Handles button_Logout.Click
        Login_Form.Show()
        Me.Hide()
    End Sub

    ' Database connections

    Private Sub button_ChangeName_Click(sender As Object, e As EventArgs) Handles button_ChangeName.Click
        Dim newName As String = InputBox("Enter new name (maximum 15 characters only):", "Want to change name?")

        If Not String.IsNullOrEmpty(newName) Then
            If newName.Length > 15 Then
                newName = newName.Substring(0, 15)
            End If

            Try
                Using connection As New NpgsqlConnection(ConnectionString)
                    connection.Open()

                    Dim query As String = "UPDATE account_info SET username = @newName WHERE username = @oldName"
                    Using cmd As New NpgsqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@newName", newName)
                        cmd.Parameters.AddWithValue("@oldName", CurrentUsername)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                CurrentUsername = newName
                label_PlayingNow.Text = "Playing As: " & CurrentUsername

            Catch ex As Exception
                Console.WriteLine("Error updating username: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub button_Reset_Click(sender As Object, e As EventArgs) Handles button_Reset.Click
        Dim confirmReset As DialogResult = MessageBox.Show("Are you sure you want to reset your highscore?" & Environment.NewLine & "(This is irreversible, and your progress will be lost forever.)", "Highscore Reset Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmReset = DialogResult.Yes Then
            player_wins = 0
            highestScore = 0
            label_WinStreak.Text = "0"
            label_HighestScore.Text = "Highest Score: 0"
            UpdateHighestScoreInDB()
            PopulateLeaderboard()
        End If
    End Sub


    Private Sub UpdateHighestScoreInDB()
        Try
            Using connection As New NpgsqlConnection(ConnectionString)
                connection.Open()

                Dim query As String = "UPDATE account_info SET highscore = @highscore WHERE username = @username"
                Using cmd As New NpgsqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@highscore", highestScore)
                    cmd.Parameters.AddWithValue("@username", CurrentUsername)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error updating highest score: " & ex.Message)
        End Try
    End Sub

    Private Sub PopulateLeaderboard()
        Try
            Using connection As New NpgsqlConnection(ConnectionString)
                connection.Open()

                Dim query As String = "SELECT username, highscore FROM account_info WHERE highscore > 0 ORDER BY highscore DESC"
                Using cmd As New NpgsqlCommand(query, connection)
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        Dim dataTable As New DataTable()
                        dataTable.Load(reader)

                        Dim top10Rows = (From row In dataTable.AsEnumerable() Select row).Take(10).CopyToDataTable()
                        grid_Leaderboard.DataSource = top10Rows
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error retrieving leaderboard data: " & ex.Message)
        End Try
    End Sub

End Class