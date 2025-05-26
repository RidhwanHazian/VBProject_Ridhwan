Imports System.Data.OleDb

Public Class PricingManagementForm
    Public Shared hourlyPrice As Decimal = 2D ' Default hourly price
    Public Shared dailyPrice As Decimal = 20D ' Default daily price

    Dim databaseSystem As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ridhwan\Documents\UserAcc.accdb"
    Dim connection As New OleDbConnection(databaseSystem)

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub LOCATIONMANAGEMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOCATIONMANAGEMENTToolStripMenuItem.Click
        Dim newForm As New LocationManagementForm()
        Me.Hide()
        newForm.ShowDialog()
    End Sub

    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        Dim newLogInForm As New LogInForm()
        Me.Hide()
        newLogInForm.ShowDialog()
    End Sub

    Private Sub PricingManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the initial price on the label
        lblCurrentPrice.Text = "RM " & hourlyPrice.ToString("F2")
        lblCurrentPriceDaily.Text = "RM " & dailyPrice.ToString("F2")
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ' Track whether any price was successfully updated
        Dim priceUpdated As Boolean = False

        ' Validate and update the hourly price if input is provided
        If Not String.IsNullOrWhiteSpace(txtHourlyPrice.Text) Then
            Dim newHourlyPrice As Decimal
            If Decimal.TryParse(txtHourlyPrice.Text, newHourlyPrice) AndAlso newHourlyPrice >= 0 Then
                ' Update the shared hourly price
                hourlyPrice = newHourlyPrice
                lblCurrentPrice.Text = "RM " & hourlyPrice.ToString("F2")
                priceUpdated = True
            Else
                MessageBox.Show("Please enter a valid positive hourly price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        ' Validate and update the daily price if input is provided
        If Not String.IsNullOrWhiteSpace(txtDailyPrice.Text) Then
            Dim newDailyPrice As Decimal
            If Decimal.TryParse(txtDailyPrice.Text, newDailyPrice) AndAlso newDailyPrice >= 0 Then
                ' Update the shared daily price
                dailyPrice = newDailyPrice
                lblCurrentPriceDaily.Text = "RM " & dailyPrice.ToString("F2")
                priceUpdated = True
            Else
                MessageBox.Show("Please enter a valid positive daily price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        ' Provide feedback if at least one price was updated
        If priceUpdated Then
            MessageBox.Show("Prices updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionally clear the text boxes after updating
            txtHourlyPrice.Clear()
            txtDailyPrice.Clear()
        Else
            MessageBox.Show("Please enter a price to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearAll()
    End Sub

    Private Sub clearAll()
        txtDailyPrice.Text = ""
        txtHourlyPrice.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblTotalProfit.Visible = True
        Try
            connection.Open()
            Dim query As String = "SELECT SUM([ParkingFee(RM)]) FROM Receipt"
            Dim cmd As New OleDbCommand(query, connection)

            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Dim totalProfit As Decimal = Convert.ToDecimal(result)
                lblTotal.Text = "RM " & totalProfit.ToString("F2")
            Else
                lblTotal.Text = "RM 0.00"
            End If
        Catch ex As Exception
            MessageBox.Show("Error calculating total profit: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub USERMANAGEMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERMANAGEMENTToolStripMenuItem.Click
        Dim newForm As New AdminUserCheckUpForm()
        Me.Hide()
        newForm.ShowDialog()
    End Sub
End Class