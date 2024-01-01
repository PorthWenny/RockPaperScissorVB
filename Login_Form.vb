Imports Npgsql

Public Class Login_Form
    Private Shared ReadOnly ConnectionString As String = "User Id=postgres;Password=l1qEYDkwXIn84Yn6;Server=db.umrbdtcblbsidpoxiqpl.supabase.co;Port=5432;Database=postgres"
    Private username As String = ""

    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.rps_icon
        pictureBoxTitle.Image = My.Resources.title
        button_Login.Enabled = False
    End Sub

    Private Sub textBox_Username_TextChanged(sender As Object, e As EventArgs) Handles textBox_Username.TextChanged
        If textBox_Username.Text.Length <= 15 Then
            username = textBox_Username.Text.Trim()
            button_Login.Enabled = Not String.IsNullOrEmpty(username)
        Else
            textBox_Username.Text = textBox_Username.Text.Substring(0, 15)
        End If
    End Sub

    Private Sub button_Login_Click(sender As Object, e As EventArgs) Handles button_Login.Click
        If Not String.IsNullOrEmpty(username) Then
            Try
                Using connection As New NpgsqlConnection(ConnectionString)
                    connection.Open()
                    Dim query As String = "SELECT COUNT(*) FROM account_info WHERE username = @username"
                    Using cmd As New NpgsqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@username", username)
                        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                        If count > 0 Then
                            Game_Form.CurrentUsername = username
                        Else
                            Dim insertQuery As String = "INSERT INTO account_info (username) VALUES (@username)"
                            Using insertCmd As New NpgsqlCommand(insertQuery, connection)
                                insertCmd.Parameters.AddWithValue("@username", username)
                                insertCmd.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                End Using

                Me.Hide()
                Dim gameForm As New Game_Form()
                gameForm.CurrentUsername = username
                gameForm.Show()

                ' in case of errors...
            Catch ex As NpgsqlException
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
End Class
