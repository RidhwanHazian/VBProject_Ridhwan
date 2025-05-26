Imports System.Data.OleDb
Public Class ParkingReceipts
    Private database As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ridhwan\Documents\UserAcc.accdb"
    Dim currentCustomerID As Integer = LogInForm.loggedInCustomerID ' Assuming this is set during login

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim newForm As New NewParkingForm()
        Me.Hide()
        newForm.ShowDialog()
    End Sub

    Private Sub LoadReceiptDetails()
        Using conn As New OleDbConnection(database)
            Try
                conn.Open()
                ' SQL query to fetch receipt details for the current customer
                Dim query As String = "SELECT ReferenceID, [ParkingFee(RM)], TotalDuration, VehiclePlate, LocationName, [DateTime] " &
                                      "FROM Receipt WHERE customer_ID = @CustomerID"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerID", currentCustomerID)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        lstReceipts.Items.Clear()

                        ' Check if there are records
                        If reader.HasRows Then
                            While reader.Read()
                                ' Add receipt details in vertical format
                                lstReceipts.Items.Add($"Reference ID: {reader("ReferenceID")}")
                                lstReceipts.Items.Add($"Parking Fee: RM{reader("ParkingFee(RM)").ToString()}")
                                lstReceipts.Items.Add($"Total Duration: {reader("TotalDuration")} hrs")
                                lstReceipts.Items.Add($"Vehicle Plate: {reader("VehiclePlate")}")
                                lstReceipts.Items.Add($"Location: {reader("LocationName")}")
                                lstReceipts.Items.Add($"Date/Time: {Convert.ToDateTime(reader("DateTime")).ToString("yyyy-MM-dd HH:mm:ss")}")

                                ' Add an empty line for separation
                                lstReceipts.Items.Add(String.Empty)
                            End While
                        Else
                            lstReceipts.Items.Add("No receipts found for this customer.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading receipt details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ParkingReceipts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReceiptDetails()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim vehiclePlate As String = txtVehiclePlate.Text.Trim()
        Dim searchDate As String = txtDate.Text.Trim()

        ' Validate the date format
        If Not String.IsNullOrEmpty(searchDate) AndAlso Not IsDate(searchDate) Then
            MessageBox.Show("Please enter a valid date in the format YYYY-MM-DD.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        SearchReceipts(vehiclePlate, searchDate)
    End Sub

    Private Sub SearchReceipts(vehiclePlate As String, searchDate As String)
        Using conn As New OleDbConnection(database)
            Try
                conn.Open()

                ' Base query
                Dim query As String = "SELECT ReferenceID, [ParkingFee(RM)], TotalDuration, VehiclePlate, LocationName, [DateTime] " &
                                  "FROM Receipt WHERE CustomerID = @CustomerID"

                ' Add filters dynamically
                If Not String.IsNullOrEmpty(vehiclePlate) Then
                    query &= " AND VehiclePlate LIKE @VehiclePlate"
                End If

                If Not String.IsNullOrEmpty(searchDate) Then
                    query &= " AND FORMAT([DateTime], 'yyyy-MM-dd') = @SearchDate"
                End If

                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerID", currentCustomerID)

                    ' Add parameters for filters if they exist
                    If Not String.IsNullOrEmpty(vehiclePlate) Then
                        cmd.Parameters.AddWithValue("@VehiclePlate", "%" & vehiclePlate & "%")
                    End If

                    If Not String.IsNullOrEmpty(searchDate) Then
                        cmd.Parameters.AddWithValue("@SearchDate", searchDate)
                    End If

                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        lstReceipts.Items.Clear()

                        If reader.HasRows Then
                            While reader.Read()
                                ' Display receipt details in vertical format
                                lstReceipts.Items.Add($"Reference ID: {reader("ReferenceID")}")
                                lstReceipts.Items.Add($"Parking Fee: RM{reader("ParkingFee(RM)").ToString()}")
                                lstReceipts.Items.Add($"Total Duration: {reader("TotalDuration")} hrs")
                                lstReceipts.Items.Add($"Vehicle Plate: {reader("VehiclePlate")}")
                                lstReceipts.Items.Add($"Location: {reader("LocationName")}")
                                lstReceipts.Items.Add($"Date/Time: {Convert.ToDateTime(reader("DateTime")).ToString("yyyy-MM-dd HH:mm:ss")}")
                                lstReceipts.Items.Add(String.Empty)
                            End While
                        Else
                            lstReceipts.Items.Add("No matching receipts found.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error searching receipts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class