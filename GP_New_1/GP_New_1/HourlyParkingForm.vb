Public Class HourlyParkingForm ' Make sure this is the correct label reference
    Public Shared totalHourly As Decimal ' Keep this as Decimal for accurate calculations
    Public Shared durationHourly As Integer ' This will store the number of hours entered

    Private Sub HourlyParkingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the label is initialized and valid
        If lblParkingPrice IsNot Nothing Then
            lblParkingPrice.Text = "RM " & PricingManagementForm.hourlyPrice.ToString("F2")
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

    ' Button to calculate the price
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim hours As Integer

        ' Validate input for integer duration (hours)
        If Integer.TryParse(txtDays.Text, hours) AndAlso hours > 0 Then
            ' Store the validated hours in durationHourly
            durationHourly = hours

            ' Use the shared hourly rate from PricingManagementForm
            Dim hourlyRate As Decimal = PricingManagementForm.hourlyPrice

            ' Calculate the total cost
            totalHourly = hourlyRate * hours

            ' Update the label to display the total cost
            lblTotalCost.Text = "RM " & totalHourly.ToString("F2")
        Else
            MessageBox.Show("Please enter a valid number of hours.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim newForm As New ChooseDurationForm()
        Me.Hide()
        newForm.ShowDialog()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Check if the calculation has been done and the data is available
        If totalHourly > 0 AndAlso durationHourly > 0 Then
            ' Proceed to the payment form if valid
            Dim paymentForm As New Figure12()
            Me.Hide()
            paymentForm.ShowDialog()
        Else
            ' Show error if calculation hasn't been done
            MessageBox.Show("Please calculate the total cost first.", "Calculation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDays.Text = ""
        lblTotalCost.Text = ""
    End Sub
End Class
