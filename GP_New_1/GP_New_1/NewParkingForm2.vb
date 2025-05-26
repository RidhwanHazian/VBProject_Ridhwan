Imports System.Data.OleDb

Public Class NewParkingForm2
    Dim databaseSystem As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ridhwan\Documents\UserAcc.accdb"
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim reader As OleDbDataReader
    Public Shared selectedCouncil As String
    Public Shared selectedLocation As String

    Private Sub NewParkingForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add council names to ComboBox (column names from the table)
        cbCouncils.Items.Add("Majlis Bandaraya Melaka Bersejarah(MBMB)")
        cbCouncils.Items.Add("Majlis Perbandaran Hang Tuah Jaya(MPHTJ)")
        cbCouncils.Items.Add("Majlis Perbandaran Jasin(MPJ)")
        cbCouncils.Items.Add("Majlis Perbandaran Alor Gajah(MPAG)")
        cbCouncils.SelectedIndex = -1 ' Reset selection
    End Sub

    Private Sub cbCouncils_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCouncils.SelectedIndexChanged
        cbLocation.Items.Clear() ' Clear previous locations

        ' Check if a council is selected
        If cbCouncils.SelectedItem IsNot Nothing Then
            selectedCouncil = cbCouncils.SelectedItem.ToString()

            ' SQL query to retrieve locations for the selected council
            Dim query As String = "SELECT [" & selectedCouncil & "] FROM Location"

            ' Connect to the database and fetch the locations
            Using conn As New OleDbConnection(databaseSystem)
                Try
                    conn.Open()
                    Using cmd As New OleDbCommand(query, conn)
                        cmd.Parameters.AddWithValue("@CouncilName", selectedCouncil)
                        Using reader As OleDbDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                ' Add each location to the ComboBox
                                If Not IsDBNull(reader(selectedCouncil)) Then
                                    cbLocation.Items.Add(reader(selectedCouncil).ToString())
                                End If
                            End While
                        End Using
                    End Using

                    ' Handle case when no locations are found
                    If cbLocation.Items.Count = 0 Then
                        MessageBox.Show("No locations found for the selected council.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If

        ' Reset location ComboBox selection
        cbLocation.SelectedIndex = -1
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim newForm As New NewParkingForm()
        Me.Hide()
        newForm.ShowDialog()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Validate that the user has selected both council and location
        If cbCouncils.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a council before proceeding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cbLocation.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a location before proceeding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        selectedLocation = cbLocation.SelectedItem.ToString()
        selectedCouncil = cbCouncils.SelectedItem.ToString()
        ' Hide the current form and show ChooseDurationForm
        Me.Hide()
        chooseDurationForm.ShowDialog()
    End Sub
End Class
