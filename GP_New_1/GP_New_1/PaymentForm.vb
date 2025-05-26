Public Class Figure12
    Public Shared totalFee As Decimal
    Public Shared totalDuration As String
    Private Sub Figure12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearAll()

        ' Display selected parking type
        lblOutputParking.Text = ChooseDurationForm.selectedParking.ToString()

        ' Show duration and cost based on selected parking type
        If ChooseDurationForm.selectedParking = "Full Day" Then
            lblOutputDuration.Text = FullDayParkingForm.durationFullDay.ToString() & " days"
            lblOutputCost.Text = $"RM {Decimal.Parse(FullDayParkingForm.totalFull):F2}"
        ElseIf ChooseDurationForm.selectedParking = "Hourly" Then
            lblOutputDuration.Text = HourlyParkingForm.durationHourly.ToString() & " hours"
            lblOutputCost.Text = $"RM {Decimal.Parse(HourlyParkingForm.totalHourly):F2}"
        End If
    End Sub

    Private Sub clearAll()
        lblOutputParking.Text = ""
        lblOutputDuration.Text = ""
        lblOutputCost.Text = ""
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim costText As String = lblOutputCost.Text.Replace("RM", "").Trim()
        If Decimal.TryParse(costText, totalFee) Then
            totalDuration = lblOutputDuration.Text.ToString()
            Dim finalForm As New Figure13()
            Me.Hide()
            finalForm.ShowDialog()
        Else
            MessageBox.Show("Invalid cost value. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
