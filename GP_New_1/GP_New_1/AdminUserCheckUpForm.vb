Imports System.Data.OleDb

Public Class AdminUserCheckUpForm
    ' Global database connection string
    Dim database As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ridhwan\Documents\UserAcc.accdb"

    Private Sub LoadUserData()
        ' Clear any previous items in the ListBox
        lstBoxUserData.Items.Clear()

        ' Query to get all users from the Account table
        Dim query As String = "SELECT * FROM Account"

        ' Open the database connection and fetch the data
        Using conn As New OleDbConnection(database)
            Try
                conn.Open()

                ' Execute the query to fetch all records from the Account table
                Using cmd As New OleDbCommand(query, conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        ' Check if there are any rows
                        If reader.HasRows Then
                            ' Loop through all rows
                            While reader.Read()
                                ' Get each user's data (handle null values as needed)
                                Dim userID As Integer = Convert.ToInt32(reader("CustomerID"))
                                Dim userName As String = If(reader("Username") IsNot DBNull.Value, reader("Username").ToString(), "N/A")
                                Dim userEmail As String = If(reader("Email") IsNot DBNull.Value, reader("Email").ToString(), "N/A")
                                Dim userPhoneNum As String = If(reader("PhoneNumber") IsNot DBNull.Value, reader("PhoneNumber").ToString(), "N/A")
                                ' Masking password for security purposes
                                Dim userPassword As String = "*****" ' You can choose not to display this at all or mask it

                                ' Add formatted data to the ListBox with space between each user
                                lstBoxUserData.Items.Add($"User ID: {userID}")
                                lstBoxUserData.Items.Add($"Name: {userName}")
                                lstBoxUserData.Items.Add($"Email: {userEmail}")
                                lstBoxUserData.Items.Add($"Phone Number: {userPhoneNum}")
                                lstBoxUserData.Items.Add($"Password: {userPassword}") ' Or skip this line if you don't want to show password
                                lstBoxUserData.Items.Add("") ' Add an empty line for spacing
                            End While
                        Else
                            ' Handle case where no users are found
                            lstBoxUserData.Items.Add("No users found.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error fetching user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub AdminUserCheckUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the user data when the form loads
        LoadUserData()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        Dim newForm As New LogInForm()
        Me.Hide()
        newForm.ShowDialog()
    End Sub

    Private Sub LOCATIONMANAGEMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOCATIONMANAGEMENTToolStripMenuItem.Click
        Dim newForm As New LocationManagementForm()
        Me.Hide()
        newForm.ShowDialog()
    End Sub

    Private Sub PRICINGMANAGEMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRICINGMANAGEMENTToolStripMenuItem.Click
        Dim newform As New PricingManagementForm()
        Me.Hide()
        newform.ShowDialog()
    End Sub
End Class
