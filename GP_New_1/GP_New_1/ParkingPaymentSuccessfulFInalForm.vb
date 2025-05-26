Imports System.Data.OleDb

Public Class Figure13
    Dim dataBase As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ridhwan\Documents\UserAcc.accdb"
    Dim connection As New OleDbConnection(dataBase)
    Dim currentCustomerID As Integer = LogInForm.loggedInCustomerID
    Public Shared currentReferenceID As Integer

    Private Sub btnPplus_Click(sender As Object, e As EventArgs) Handles btnPplus.Click
        ' Redirect the user to New Parking Form (Figure 5) for another parking order
        InsertReceipt() ' Insert the data into the database
        NewParkingForm.Show()
        Me.Hide()
    End Sub

    Private Sub Figure13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFee.Text = Figure12.totalFee.ToString("F2")
        lblDuration.Text = Figure12.totalDuration.ToString()
        lblLocation.Text = $"{NewParkingForm.selectedState}, {NewParkingForm2.selectedCouncil}"
        lblLocationName.Text = NewParkingForm2.selectedLocation.ToString()
        lblVehicle.Text = NewParkingForm.selectedPlate.ToString()
        lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        ' Retrieve and display the Reference ID
        Dim lastID As Integer = GetLastInsertedReferenceID()
        lblID.Text = (lastID + 1).ToString()

        currentReferenceID = lblID.Text.ToString()
    End Sub

    Private Sub InsertReceipt()
        Using conn As New OleDbConnection(dataBase)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO Receipt ([ParkingFee(RM)], TotalDuration, VehiclePlate, LocationName, [DateTime], customer_ID) VALUES (@ParkingFeeRM, @TotalDuration, @VehiclePlate, @LocationName, @DateTime, @CustomerID )"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ParkingFeeRM", Decimal.Parse(lblFee.Text.Replace("RM", "").Trim()).ToString("F2"))
                    cmd.Parameters.AddWithValue("@TotalDuration", lblDuration.Text)
                    cmd.Parameters.AddWithValue("@VehiclePlate", lblVehicle.Text)
                    cmd.Parameters.AddWithValue("@LocationName", lblLocationName.Text)
                    cmd.Parameters.AddWithValue("@DateTime", lblDateTime.Text)
                    cmd.Parameters.AddWithValue("CustomerID", currentCustomerID)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error inserting data into the database: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function GetLastInsertedReferenceID() As Integer
        Using connection As New OleDbConnection(dataBase)
            Dim command As New OleDbCommand("SELECT TOP 1 ReferenceID FROM Receipt ORDER BY ReferenceID DESC", connection)

            Try
                connection.Open()
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Return Convert.ToInt32(result)
                Else
                    ' If no records exist, start from 0
                    Return 0
                End If
            Catch ex As Exception
                MessageBox.Show("Error retrieving last inserted ReferenceID: " & ex.Message)
                Return 0
            End Try
        End Using
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class