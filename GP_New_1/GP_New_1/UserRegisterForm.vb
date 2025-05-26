Imports System.Data.OleDb
Public Class UserRegisterForm
    Dim userDatabase As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ridhwan\Documents\UserAcc.accdb;"
    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validate that all fields are filled
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
       String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
       String.IsNullOrWhiteSpace(txtPhoneNum.Text) OrElse
       String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
       String.IsNullOrWhiteSpace(txtPasswordCon.Text) Then

            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate password confirmation
        If txtPassword.Text <> txtPasswordCon.Text Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim conn As New OleDbConnection(userDatabase)
        Try
            conn.Open()

            ' Check if the password already exists in the database
            Dim checkPasswordQuery As String = "SELECT COUNT(*) FROM Account WHERE [Password] = @Password"
            Dim checkCmd As New OleDbCommand(checkPasswordQuery, conn)
            checkCmd.Parameters.AddWithValue("@Password", txtPassword.Text)

            Dim passwordExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
            If passwordExists > 0 Then
                MessageBox.Show("The password is already in use. Please choose a different password.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Proceed with the registration if the password is unique
            Dim query As String = "INSERT INTO Account (Username, Email, PhoneNumber, [Password]) VALUES (@Username, @Email, @PhoneNum, @Password)"
            Dim mycmd As New OleDbCommand(query, conn)

            mycmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            mycmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            mycmd.Parameters.AddWithValue("@PhoneNum", txtPhoneNum.Text)
            mycmd.Parameters.AddWithValue("@Password", txtPassword.Text)

            Dim rowsAffected As Integer = mycmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                Dim newLogInForm As New LogInForm()
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearAll()
                Me.Hide()
                newLogInForm.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub ClearAll()
        txtUsername.Text = " "
        txtEmail.Text = " "
        txtPhoneNum.Text = " "
        txtPassword.Text = " "
        txtPasswordCon.Text = " "
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearAll()
    End Sub

    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        Dim newForm As New LogInForm()
        Me.Hide()
        newForm.ShowDialog()
    End Sub
End Class