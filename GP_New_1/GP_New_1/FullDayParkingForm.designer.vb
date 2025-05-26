<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FullDayParkingForm
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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblCouncil = New System.Windows.Forms.Label()
        Me.lbPL = New System.Windows.Forms.Label()
        Me.lblPF = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblParkingType = New System.Windows.Forms.Label()
        Me.lblParkingPrice = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblTC = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.AutoSize = True
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(1030, 568)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(134, 35)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(793, 568)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(215, 35)
        Me.btnCalculate.TabIndex = 15
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(656, 568)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(122, 35)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblCouncil
        '
        Me.lblCouncil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCouncil.Location = New System.Drawing.Point(825, 149)
        Me.lblCouncil.Name = "lblCouncil"
        Me.lblCouncil.Size = New System.Drawing.Size(326, 29)
        Me.lblCouncil.TabIndex = 13
        '
        'lbPL
        '
        Me.lbPL.AutoSize = True
        Me.lbPL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPL.Location = New System.Drawing.Point(692, 188)
        Me.lbPL.Name = "lbPL"
        Me.lbPL.Size = New System.Drawing.Size(132, 25)
        Me.lbPL.TabIndex = 12
        Me.lbPL.Text = "LOCATION : "
        '
        'lblPF
        '
        Me.lblPF.AutoSize = True
        Me.lblPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPF.Location = New System.Drawing.Point(758, 83)
        Me.lblPF.Name = "lblPF"
        Me.lblPF.Size = New System.Drawing.Size(327, 46)
        Me.lblPF.TabIndex = 10
        Me.lblPF.Text = "PARKING FEES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 118)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "PARKING TICKET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " SYSTEM"
        '
        'lblParkingType
        '
        Me.lblParkingType.Location = New System.Drawing.Point(10, 21)
        Me.lblParkingType.Name = "lblParkingType"
        Me.lblParkingType.Size = New System.Drawing.Size(132, 29)
        Me.lblParkingType.TabIndex = 0
        Me.lblParkingType.Text = "Full Day Parking"
        '
        'lblParkingPrice
        '
        Me.lblParkingPrice.Location = New System.Drawing.Point(10, 48)
        Me.lblParkingPrice.Name = "lblParkingPrice"
        Me.lblParkingPrice.Size = New System.Drawing.Size(146, 29)
        Me.lblParkingPrice.TabIndex = 1
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Location = New System.Drawing.Point(19, 100)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(69, 25)
        Me.lblD.TabIndex = 2
        Me.lblD.Text = "DAY : "
        '
        'lblTC
        '
        Me.lblTC.AutoSize = True
        Me.lblTC.Location = New System.Drawing.Point(17, 162)
        Me.lblTC.Name = "lblTC"
        Me.lblTC.Size = New System.Drawing.Size(158, 25)
        Me.lblTC.TabIndex = 3
        Me.lblTC.Text = "TOTAL COST : "
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(181, 100)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(110, 30)
        Me.txtDays.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.txtDays)
        Me.GroupBox1.Controls.Add(Me.lblTC)
        Me.GroupBox1.Controls.Add(Me.lblD)
        Me.GroupBox1.Controls.Add(Me.lblParkingPrice)
        Me.GroupBox1.Controls.Add(Me.lblParkingType)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(675, 233)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(466, 300)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(181, 162)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(137, 25)
        Me.lblTotal.TabIndex = 20
        '
        'btnBack
        '
        Me.btnBack.AutoSize = True
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(37, 526)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 35)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblLocation
        '
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(825, 188)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(326, 29)
        Me.lblLocation.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(692, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "COUNCIL    : "
        '
        'FullDayParkingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1565, 741)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblCouncil)
        Me.Controls.Add(Me.lbPL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblPF)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FullDayParkingForm"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblCouncil As Label
    Friend WithEvents lbPL As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblPF As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_location As Label
    Friend WithEvents lblParkingType As Label
    Friend WithEvents lblParkingPrice As Label
    Friend WithEvents lblD As Label
    Friend WithEvents lblTC As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblLocation As Label
    Friend WithEvents Label2 As Label
End Class
