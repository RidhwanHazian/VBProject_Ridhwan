<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChooseDurationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_hourly = New System.Windows.Forms.RadioButton()
        Me.btn_fullday = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 118)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PARKING TICKET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " SYSTEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(856, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(413, 46)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "CHOOSE DURATION"
        '
        'btn_hourly
        '
        Me.btn_hourly.AutoSize = True
        Me.btn_hourly.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hourly.Location = New System.Drawing.Point(971, 241)
        Me.btn_hourly.Name = "btn_hourly"
        Me.btn_hourly.Size = New System.Drawing.Size(122, 36)
        Me.btn_hourly.TabIndex = 13
        Me.btn_hourly.TabStop = True
        Me.btn_hourly.Text = "Hourly"
        Me.btn_hourly.UseVisualStyleBackColor = True
        '
        'btn_fullday
        '
        Me.btn_fullday.AutoSize = True
        Me.btn_fullday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fullday.Location = New System.Drawing.Point(971, 327)
        Me.btn_fullday.Name = "btn_fullday"
        Me.btn_fullday.Size = New System.Drawing.Size(133, 36)
        Me.btn_fullday.TabIndex = 14
        Me.btn_fullday.TabStop = True
        Me.btn_fullday.Text = "Fullday"
        Me.btn_fullday.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.AutoSize = True
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(971, 401)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(145, 41)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "CONFIRM"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.AutoSize = True
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(57, 525)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(145, 41)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ChooseDurationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1569, 737)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btn_fullday)
        Me.Controls.Add(Me.btn_hourly)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ChooseDurationForm"
        Me.Text = "LocationsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_hourly As RadioButton
    Friend WithEvents btn_fullday As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
End Class
