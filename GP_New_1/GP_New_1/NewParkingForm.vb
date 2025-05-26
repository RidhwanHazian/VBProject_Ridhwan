Imports System.Data.OleDb

Public Class NewParkingForm
    ' Database connection string
    Private databaseSystem As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ridhwan\Documents\UserAcc.accdb"
    Public Shared selectedState As String
    Public Shared selectedPlate As String
    Dim currentCustomerID As Integer = LogInForm.loggedInCustomerID

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        Dim newLogInForm As New LogInForm()
        Me.Hide()
        newLogInForm.ShowDialog()
    End Sub

    Private Sub NewParkingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' List of states
        Dim states As String() = {"Melaka"} ' Add more as needed
        cbStates.Items.AddRange(states)

        ' Load plate numbers from the database into the ListBox
        LoadPlateNumbers()
    End Sub

    Private Sub LoadPlateNumbers()
        lstPlates.Items.Clear()
        Try
            Using conn As New OleDbConnection(databaseSystem)
                conn.Open()
                Dim query As String = "SELECT VehiclePlateNumber FROM vhPlateNumber WHERE Customer_ID = @CustomerID"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.Add("@CustomerID", OleDbType.Integer).Value = LogInForm.loggedInCustomerID
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            lstPlates.Items.Add(reader("VehiclePlateNumber").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading plate numbers: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddPlate_Click(sender As Object, e As EventArgs) Handles btnAddPlate.Click
        Dim plateNumber As String = TextBox1.Text.Trim()

        If String.IsNullOrWhiteSpace(plateNumber) Then
            MessageBox.Show("Please enter a valid vehicle plate number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check for duplicates in the database
        If IsPlateNumberExists(plateNumber) Then
            MessageBox.Show("This plate number already exists in the list.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Save the plate number to the database
        SavePlateNumber(plateNumber)

        ' Add to the ListBox
        lstPlates.Items.Add(plateNumber)
        TextBox1.Clear()
    End Sub

    Private Function IsPlateNumberExists(plateNumber As String) As Boolean
        Try
            Using conn As New OleDbConnection(databaseSystem)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM vhPlateNumber WHERE LCase(VehiclePlateNumber) = LCase(@PlateNumber)"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.Add("@PlateNumber", OleDbType.VarChar).Value = plateNumber
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error checking plate number: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub SavePlateNumber(plateNumber As String)
        Try
            Using conn As New OleDbConnection(databaseSystem)
                conn.Open()
                Dim query As String = "INSERT INTO vhPlateNumber (VehiclePlateNumber, Customer_ID) VALUES (@PlateNumber, @CustomerID)"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.Add("@PlateNumber", OleDbType.VarChar).Value = plateNumber
                    cmd.Parameters.Add("@CustomerID", OleDbType.Integer).Value = LogInForm.loggedInCustomerID
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saving plate number: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstPlates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPlates.SelectedIndexChanged
        If lstPlates.SelectedItem IsNot Nothing Then
            TextBox1.Text = lstPlates.SelectedItem.ToString()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If cbStates.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a state before proceeding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If lstPlates.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a vehicle plate number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        selectedState = cbStates.SelectedItem.ToString()
        selectedPlate = lstPlates.SelectedItem.ToString()

        Dim newParkingForm2 As New NewParkingForm2
        Me.Hide()
        newParkingForm2.ShowDialog()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstPlates.SelectedItem IsNot Nothing Then
            Dim selectedPlate As String = lstPlates.SelectedItem.ToString()

            If RemovePlateNumberFromDatabase(selectedPlate) Then
                lstPlates.Items.Remove(selectedPlate)
                MessageBox.Show("Plate number removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to remove plate number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a plate number to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function RemovePlateNumberFromDatabase(plateNumber As String) As Boolean
        Try
            Using conn As New OleDbConnection(databaseSystem)
                conn.Open()
                Dim query As String = "DELETE FROM vhPlateNumber WHERE VehiclePlateNumber = @PlateNumber"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.Add("@PlateNumber", OleDbType.VarChar).Value = plateNumber
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show($"Error removing plate number: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub RECEIPTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RECEIPTToolStripMenuItem.Click
        Dim newForm As New ParkingReceipts()
        Me.Hide()
        newForm.ShowDialog()
    End Sub

    Private Sub PARKINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PARKINGToolStripMenuItem.Click
        Dim formHistory As New ParkingDetailsHistoryForm()
        Me.Hide()
        formHistory.ShowDialog()
    End Sub
End Class
