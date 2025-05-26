Imports System.Data.OleDb

Public Class LogInForm
    ' Connection string for the database
    Dim databaseSystem As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ridhwan\Documents\UserAcc.accdb;"
    Public Shared loggedInCustomerID As Integer

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim newForm As New UserRegisterForm() ' Create an instance of the User Register form
        Me.Hide()
        newForm.ShowDialog() ' Show the register form as a modal dialog
        Me.Show() ' Show login form again after registration
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        If radAdmin.Checked Then
            ' Admin Login - Validate username and password in Admin database
            Dim username As String = txtUsername.Text
            Dim password As String = txtPassword.Text

            ' Validate credentials for admin in the Admin database
            Using conn As New OleDbConnection(databaseSystem)
                Try
                    conn.Open()

                    ' SQL query to check if the admin exists with the given username and password
                    Dim query As String = "SELECT COUNT(*) FROM AdminInfo WHERE Username = @Username AND [Password] = @Password"
                    Dim cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Dim adminExists As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If adminExists > 0 Then
                        ' Admin credentials are valid, show the Admin form
                        Dim adminForm As New PricingManagementForm()
                        Me.Hide()
                        adminForm.ShowDialog()
                    Else
                        MessageBox.Show("Invalid admin username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If conn.State = ConnectionState.Open Then conn.Close()
                End Try
            End Using
        ElseIf radUser.Checked Then
            Using conn As New OleDbConnection(databaseSystem)
                Try
                    conn.Open()

                    ' SQL query to check if the user exists and fetch their CustomerID
                    Dim query As String = "SELECT CustomerID FROM Account WHERE Username = @Username AND [Password] = @Password"
                    Dim cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        ' Store the CustomerID in the shared property
                        loggedInCustomerID = Convert.ToInt32(result)

                        ' Proceed to the user interface
                        Dim userForm As New NewParkingForm()
                        Me.Hide()
                        userForm.ShowDialog()
                    Else
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If conn.State = ConnectionState.Open Then conn.Close()
                End Try
            End Using
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLEARToolStripMenuItem.Click
        radUser.Checked = False
        radAdmin.Checked = False
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub
End Class