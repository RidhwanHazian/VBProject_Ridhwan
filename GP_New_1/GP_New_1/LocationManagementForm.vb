Imports System.Data.OleDb
Public Class LocationManagementForm
    Dim databaseSystem As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ridhwan\Documents\UserAcc.accdb"
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim reader As OleDbDataReader

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub

    Private Sub PRICINGMANAGEMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRICINGMANAGEMENTToolStripMenuItem.Click
        Dim newForm As New PricingManagementForm()
        Me.Hide()
        newForm.ShowDialog()
    End Sub

    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        Dim newLogInForm As New LogInForm()
        Me.Hide()
        newLogInForm.ShowDialog()
    End Sub

    Private Sub LocationManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This line of code loads data into the 'UserAccDataSet.Location' table. We can move, or remove it, as needed.
        Using conn As New OleDbConnection(databaseSystem)
            Try
                conn.Open()

                ' Add council names to ComboBox (column names from the table in database)
                cbCouncils.Items.Add("Majlis Bandaraya Melaka Bersejarah(MBMB)")
                cbCouncils.Items.Add("Majlis Perbandaran Hang Tuah Jaya(MPHTJ)")
                cbCouncils.Items.Add("Majlis Perbandaran Jasin(MPJ)")
                cbCouncils.Items.Add("Majlis Perbandaran Alor Gajah(MPAG)")

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cbCouncils.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a council.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ensure the location is not empty
        If String.IsNullOrWhiteSpace(txtNewLocation.Text) Then
            MessageBox.Show("Please enter a location name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get the selected council and new location
        Dim selectedCouncil As String = cbCouncils.SelectedItem.ToString()
        Dim newLocation As String = txtNewLocation.Text.Trim()

        ' Add the location to the database
        If AddLocationToDatabase(selectedCouncil, newLocation) Then
            ' Refresh the ListBox
            lstLocations.Items.Add(newLocation)
            MessageBox.Show("Location added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionally clear the TextBox after adding
            txtNewLocation.Clear()
        End If
    End Sub

    Private Sub cbCouncils_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCouncils.SelectedIndexChanged
        lstLocations.Items.Clear()

        ' Get the selected council (the full name including the abbreviation)
        Dim selectedCouncil As String = cbCouncils.SelectedItem.ToString()

        ' Fetch locations under the selected council column
        Using conn As New OleDbConnection(databaseSystem)
            Try
                conn.Open()

                Dim query As String = "SELECT [" & selectedCouncil & "] FROM Location"
                Dim cmd As New OleDbCommand(query, conn)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        lstLocations.Items.Add(reader(0).ToString())
                    End If
                End While

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstLocations.SelectedItem IsNot Nothing Then
            ' Get the selected council and location
            Dim selectedCouncil As String = cbCouncils.SelectedItem.ToString()
            Dim selectedLocation As String = lstLocations.SelectedItem.ToString()

            ' Remove the location from the ListBox
            lstLocations.Items.Remove(selectedLocation)

            ' Remove the location from the database
            If RemoveLocationFromDatabase(selectedCouncil, selectedLocation) Then
                MessageBox.Show("Location removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to remove location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a location to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Function to add location into the database
    Private Function AddLocationToDatabase(council As String, location As String) As Boolean
        Dim query As String = "INSERT INTO Location ([" & council & "]) VALUES (@Location)"

        ' Use 'Using' statement to ensure connection is properly closed
        Using conn As New OleDbConnection(databaseSystem)
            Try
                conn.Open()

                cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@Location", location)

                cmd.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    ' Function to remove location from the database
    Private Function RemoveLocationFromDatabase(council As String, location As String) As Boolean
        Dim query As String = "UPDATE Location SET [" & council & "] = NULL WHERE [" & council & "] = @Location"

        ' Use 'Using' statement to ensure connection is properly closed
        Using conn As New OleDbConnection(databaseSystem)
            Try
                conn.Open()

                cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@Location", location)

                cmd.ExecuteNonQuery()
                Return True  ' Indicating success
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False  ' Indicating failure
            End Try
        End Using
    End Function

    Private Sub USERMANAGEMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERMANAGEMENTToolStripMenuItem.Click
        Dim newForm As New AdminUserCheckUpForm()
        Me.Hide()
        newForm.ShowDialog()
    End Sub
End Class