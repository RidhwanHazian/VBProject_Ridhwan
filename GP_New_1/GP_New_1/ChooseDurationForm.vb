Public Class ChooseDurationForm
    ' Property to store the selected location
    Public Shared selectedParking As String

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Check which radio button is selected and navigate accordingly
        If btn_hourly.Checked Then
            Dim hourlyForm As New HourlyParkingForm()
            Me.Hide()
            hourlyForm.Show()
            selectedParking = "Hourly"

        ElseIf btn_fullday.Checked Then
            ' Navigate to the FullDay UI and pass the selected location
            Dim fullDayForm As New FullDayParkingForm()
            Me.Hide()
            fullDayForm.Show()
            selectedParking = "Full Day"
        Else
            ' If neither radio button is selected, show an error message
            MessageBox.Show("Please select a parking type (Hourly or Full Day).", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim newForm As New NewParkingForm2()
        Me.Hide()
        newForm.ShowDialog()
    End Sub
End Class
