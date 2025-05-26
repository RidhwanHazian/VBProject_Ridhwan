<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HourlyParkingForm
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
        Me.lblPTK = New System.Windows.Forms.Label()
        Me.lblPF = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.lblTC = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblParkingPrice = New System.Windows.Forms.Label()
        Me.lblParkingType = New System.Windows.Forms.Label()
        Me.lbPL = New System.Windows.Forms.Label()
        Me.lblCouncil = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPTK
        '
        Me.lblPTK.AutoSize = True
        Me.lblPTK.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPTK.Location = New System.Drawing.Point(37, 293)
        Me.lblPTK.Name = "lblPTK"
        Me.lblPTK.Size = New System.Drawing.Size(489, 118)
        Me.lblPTK.TabIndex = 0
        Me.lblPTK.Text = "PARKING TICKET " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       SYSTEM"
        '
        'lblPF
        '
        Me.lblPF.AutoSize = True
        Me.lblPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPF.Location = New System.Drawing.Point(915, 91)
        Me.lblPF.Name = "lblPF"
        Me.lblPF.Size = New System.Drawing.Size(339, 46)
        Me.lblPF.TabIndex = 1
        Me.lblPF.Text = "PARKING FEES "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalCost)
        Me.GroupBox1.Controls.Add(Me.txtDays)
        Me.GroupBox1.Controls.Add(Me.lblTC)
        Me.GroupBox1.Controls.Add(Me.lblD)
        Me.GroupBox1.Controls.Add(Me.lblParkingPrice)
        Me.GroupBox1.Controls.Add(Me.lblParkingType)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(830, 239)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(466, 300)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Location = New System.Drawing.Point(181, 162)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(146, 29)
        Me.lblTotalCost.TabIndex = 15
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(170, 97)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(110, 30)
        Me.txtDays.TabIndex = 13
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
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Location = New System.Drawing.Point(19, 100)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(131, 25)
        Me.lblD.TabIndex = 2
        Me.lblD.Text = "DURATION : "
        '
        'lblParkingPrice
        '
        Me.lblParkingPrice.Location = New System.Drawing.Point(10, 48)
        Me.lblParkingPrice.Name = "lblParkingPrice"
        Me.lblParkingPrice.Size = New System.Drawing.Size(146, 29)
        Me.lblParkingPrice.TabIndex = 1
        '
        'lblParkingType
        '
        Me.lblParkingType.Location = New System.Drawing.Point(10, 21)
        Me.lblParkingType.Name = "lblParkingType"
        Me.lblParkingType.Size = New System.Drawing.Size(128, 29)
        Me.lblParkingType.TabIndex = 0
        Me.lblParkingType.Text = "Hourly Parking"
        '
        'lbPL
        '
        Me.lbPL.AutoSize = True
        Me.lbPL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPL.Location = New System.Drawing.Point(832, 191)
        Me.lbPL.Name = "lbPL"
        Me.lbPL.Size = New System.Drawing.Size(132, 25)
        Me.lbPL.TabIndex = 3
        Me.lbPL.Text = "LOCATION : "
        '
        'lblCouncil
        '
        Me.lblCouncil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCouncil.Location = New System.Drawing.Point(970, 147)
        Me.lblCouncil.Name = "lblCouncil"
        Me.lblCouncil.Size = New System.Drawing.Size(326, 29)
        Me.lblCouncil.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(808, 575)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(119, 35)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(951, 575)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(206, 35)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.AutoSize = True
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(1187, 575)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(123, 35)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1576, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnBack
        '
        Me.btnBack.AutoSize = True
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(47, 523)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 35)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblLocation
        '
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(970, 187)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(326, 29)
        Me.lblLocation.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(832, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "COUNCIL    : "
        '
        'HourlyParkingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1576, 743)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblCouncil)
        Me.Controls.Add(Me.lbPL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblPF)
        Me.Controls.Add(Me.lblPTK)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HourlyParkingForm"
        Me.Text = "HourlyParkingForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPTK As Label
    Friend WithEvents lblPF As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTC As Label
    Friend WithEvents lblD As Label
    Friend WithEvents lblParkingPrice As Label
    Friend WithEvents lblParkingType As Label
    Friend WithEvents lbPL As Label
    Friend WithEvents lblCouncil As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtDays As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents Label2 As Label
End Class
