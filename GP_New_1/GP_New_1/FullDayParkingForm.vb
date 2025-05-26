Public Class FullDayParkingForm
    Public Shared totalFull As String
    Public Shared durationFullDay As String

    Private Sub FullDayParkingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the label is initialized and valid
        If lblParkingPrice IsNot Nothing Then
            lblParkingPrice.Text = "RM " & PricingManagementForm.dailyPrice.ToString("F2")
        End If

        ' Display the selected location
        If Not String.IsNullOrEmpty(NewParkingForm2.selectedCouncil) Then
            lblCouncil.Text = NewParkingForm2.selectedCouncil
        Else
            lblCouncil.Text = "Location: Not selected"
        End If

        If Not String.IsNullOrEmpty(NewParkingForm2.selectedLocation) Then
            lblLocation.Text = NewParkingForm2.selectedLocation
        Else
            lblLocation.Text = "Location: Not selected"
        End If
    End Sub

    ' Button click event to calculate the total cost
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Variable to hold the number of days entered by the user
        Dim days As Integer

        ' Validate the user input for days
        If Integer.TryParse(txtDays.Text, days) AndAlso days > 0 Then
            ' Directly use the shared daily price from PricingManagementForm
            Dim dailyRate As Decimal = PricingManagementForm.dailyPrice

            ' Calculate the total cost
            Dim totalCost As Decimal = dailyRate * days

            ' Display the total cost
            lblTotal.Text = "RM " & totalCost.ToString("F2")

            ' Store the calculated total cost in the shared variable
            FullDayParkingForm.totalFull = totalCost.ToString("F2")
        Else
            ' Handle invalid input for days
            MessageBox.Show("Please enter a valid number of days.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Button to clear input and output fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDays.Text = ""
        lblTotal.Text = ""
    End Sub

    ' Button to go back to the previous form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim chooseDurationForm As New ChooseDurationForm()
        Me.Close()
        chooseDurationForm.ShowDialog()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Check if the calculation has been done and data is available
        If Not String.IsNullOrEmpty(totalFull) AndAlso Not String.IsNullOrEmpty(txtDays.Text) Then
            ' Assign the duration
            durationFullDay = txtDays.Text

            ' Proceed to the payment form
            Dim paymentForm As New Figure12() ' Create an instance of the payment form
            Me.Hide() ' Hide the current form
            paymentForm.ShowDialog() ' Show the payment form
        Else
            ' Show error if calculation hasn't been done
            MessageBox.Show("Please calculate the total cost first.", "Calculation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
