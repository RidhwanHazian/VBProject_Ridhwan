Imports System.Data.OleDb
Public Class ParkingDetailsHistoryForm
    Dim database As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ridhwan\Documents\UserAcc.accdb"
    Dim currentCustomerID As Integer = LogInForm.loggedInCustomerID ' Assuming logged-in customer ID is stored here
    Dim lastReferenceID As Integer ' To store the ReferenceID of the last receipt

    Private Sub ParkingDetailsHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load parking details when the form loads
        LoadLastReceipt()
    End Sub

    Private Sub LoadLastReceipt()
        Using conn As New OleDbConnection(database)
            Try
                conn.Open()

                Dim query As String = "SELECT TOP 1 ReferenceID, [ParkingFee(RM)], TotalDuration, VehiclePlate, LocationName, [DateTime] " &
                                  "FROM Receipt WHERE CustomerID = @CustomerID ORDER BY DateTime DESC"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerID", currentCustomerID)

                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        lstBoxLastReceipt.Items.Clear()

                        If reader.HasRows Then
                            While reader.Read()
                                lastReferenceID = Convert.ToInt32(reader("ReferenceID")) ' Set the last ReferenceID
                                lstBoxLastReceipt.Items.Add($"Reference ID: {reader("ReferenceID")}")
                                lstBoxLastReceipt.Items.Add($"Fee: RM{reader("ParkingFee(RM)"):F2}")
                                lstBoxLastReceipt.Items.Add($"Duration: {reader("TotalDuration")}")
                                lstBoxLastReceipt.Items.Add($"Plate: {reader("VehiclePlate")}")
                                lstBoxLastReceipt.Items.Add($"Location: {reader("LocationName")}")
                                lstBoxLastReceipt.Items.Add($"Date: {Convert.ToDateTime(reader("DateTime")).ToString("yyyy-MM-dd HH:mm:ss")}")
                            End While
                        Else
                            lstBoxLastReceipt.Items.Add("No parking details found for the current customer.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading parking details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim lastForm As New NewParkingForm()
        Me.Hide()
        lastForm.ShowDialog()
    End Sub

    Private Sub lstBoxLastReceipt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxLastReceipt.SelectedIndexChanged
        ' Handle selection of an item in the ListBox (Optional)
        If lstBoxLastReceipt.SelectedIndex <> -1 Then
            Dim selectedDetail As String = lstBoxLastReceipt.SelectedItem.ToString()
            MessageBox.Show($"Selected Parking Detail: {selectedDetail}", "Detail Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Example: Navigate to a new form with the selected detail
            Dim newForm As New NewParkingForm()
            Me.Hide()
            newForm.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub btnExtend_Click(sender As Object, e As EventArgs) Handles btnExtend.Click
        If lastReferenceID = 0 Then
            MessageBox.Show("No receipt found to extend.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim newDuration As Integer
        If Not Integer.TryParse(txtNewDuration.Text, newDuration) OrElse newDuration <= 0 Then
            MessageBox.Show("Please enter a valid duration.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim newFee As Decimal
        Dim durationDescription As String = ""
        If radHourly.Checked Then
            Dim ratePerHour As Decimal = 2D ' 2 per hour
            Dim hourlyRate As Decimal = PricingManagementForm.hourlyPrice
            newFee = newDuration * hourlyRate
            durationDescription = $"{newDuration} hour"  ' Fee is calculated, but we just show the duration in hours
        ElseIf radFullDay.Checked Then
            Dim ratePerDay As Decimal = 20D ' 20 per day
            Dim DailyRate As Decimal = PricingManagementForm.hourlyPrice
            newFee = newDuration * DailyRate
            newFee = newDuration * ratePerDay
            durationDescription = $"{newDuration} days"  ' Fee is calculated, but we just show the duration in days
        Else
            MessageBox.Show("Please select a parking type (Hourly or Full Day).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As New OleDbConnection(database)
            Try
                conn.Open()
                ' Query to update the receipt with new duration
                Dim query As String = "UPDATE Receipt SET TotalDuration = @NewDuration, [ParkingFee(RM)] = @NewFee WHERE ReferenceID = @ReferenceID"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NewDuration", durationDescription)   ' Set the new duration (either in hours or days)
                    cmd.Parameters.AddWithValue("@NewFee", newFee.ToString("F2"))              ' Set the new fee as calculated
                    cmd.Parameters.AddWithValue("@ReferenceID", lastReferenceID)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        ' Show success message with the updated duration (no "RM" or explicit fee in output)
                        MessageBox.Show($"Duration successfully updated. Duration: {durationDescription}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadLastReceipt() ' Reload receipt details after update
                    Else
                        MessageBox.Show("Failed to update the receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error updating receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class