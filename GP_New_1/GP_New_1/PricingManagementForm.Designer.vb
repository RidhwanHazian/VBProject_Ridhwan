<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PricingManagementForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PricingManagementForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHourlyPrice = New System.Windows.Forms.TextBox()
        Me.lblCurrentPrice = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDailyPrice = New System.Windows.Forms.TextBox()
        Me.lblCurrentPriceDaily = New System.Windows.Forms.Label()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOCATIONMANAGEMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERMANAGEMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalProfit = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 118)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PARKING TICKET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " SYSTEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(858, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(385, 46)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ADMIN INTERFACE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(878, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 32)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "PRICING MANAGEMENT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(893, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "HOURLY PARKING"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(893, 476)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "DAILY PARKING"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(893, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "CURRENT PRICE : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(893, 392)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "NEW PRICE :"
        '
        'txtHourlyPrice
        '
        Me.txtHourlyPrice.Location = New System.Drawing.Point(1033, 391)
        Me.txtHourlyPrice.Name = "txtHourlyPrice"
        Me.txtHourlyPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtHourlyPrice.TabIndex = 14
        '
        'lblCurrentPrice
        '
        Me.lblCurrentPrice.AutoSize = True
        Me.lblCurrentPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPrice.Location = New System.Drawing.Point(1086, 339)
        Me.lblCurrentPrice.Name = "lblCurrentPrice"
        Me.lblCurrentPrice.Size = New System.Drawing.Size(0, 25)
        Me.lblCurrentPrice.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(893, 522)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 25)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "CURRENT PRICE : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(893, 566)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 25)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "NEW PRICE :"
        '
        'txtDailyPrice
        '
        Me.txtDailyPrice.Location = New System.Drawing.Point(1033, 567)
        Me.txtDailyPrice.Name = "txtDailyPrice"
        Me.txtDailyPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtDailyPrice.TabIndex = 18
        '
        'lblCurrentPriceDaily
        '
        Me.lblCurrentPriceDaily.AutoSize = True
        Me.lblCurrentPriceDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPriceDaily.Location = New System.Drawing.Point(1086, 522)
        Me.lblCurrentPriceDaily.Name = "lblCurrentPriceDaily"
        Me.lblCurrentPriceDaily.Size = New System.Drawing.Size(0, 25)
        Me.lblCurrentPriceDaily.TabIndex = 19
        '
        'btnChange
        '
        Me.btnChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(989, 617)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(103, 42)
        Me.btnChange.TabIndex = 20
        Me.btnChange.Text = "CHANGE"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1575, 33)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BACKToolStripMenuItem, Me.EXITToolStripMenuItem, Me.LOCATIONMANAGEMENTToolStripMenuItem, Me.USERMANAGEMENTToolStripMenuItem})
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'BACKToolStripMenuItem
        '
        Me.BACKToolStripMenuItem.Name = "BACKToolStripMenuItem"
        Me.BACKToolStripMenuItem.Size = New System.Drawing.Size(306, 30)
        Me.BACKToolStripMenuItem.Text = "BACK"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(306, 30)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'LOCATIONMANAGEMENTToolStripMenuItem
        '
        Me.LOCATIONMANAGEMENTToolStripMenuItem.Name = "LOCATIONMANAGEMENTToolStripMenuItem"
        Me.LOCATIONMANAGEMENTToolStripMenuItem.Size = New System.Drawing.Size(306, 30)
        Me.LOCATIONMANAGEMENTToolStripMenuItem.Text = "LOCATION MANAGEMENT"
        '
        'USERMANAGEMENTToolStripMenuItem
        '
        Me.USERMANAGEMENTToolStripMenuItem.Name = "USERMANAGEMENTToolStripMenuItem"
        Me.USERMANAGEMENTToolStripMenuItem.Size = New System.Drawing.Size(306, 30)
        Me.USERMANAGEMENTToolStripMenuItem.Text = "USER MANAGEMENT"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1177, 617)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 42)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotalProfit
        '
        Me.lblTotalProfit.AutoSize = True
        Me.lblTotalProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProfit.Location = New System.Drawing.Point(70, 567)
        Me.lblTotalProfit.Name = "lblTotalProfit"
        Me.lblTotalProfit.Size = New System.Drawing.Size(172, 25)
        Me.lblTotalProfit.TabIndex = 23
        Me.lblTotalProfit.Text = "TOTAL PROFIT : "
        Me.lblTotalProfit.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(70, 597)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(183, 36)
        Me.lblTotal.TabIndex = 24
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(66, 507)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(204, 40)
        Me.btnCalculate.TabIndex = 25
        Me.btnCalculate.Text = "CALCULATE PROFIT"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-13, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1600, 700)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'PricingManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1575, 743)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalProfit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.lblCurrentPriceDaily)
        Me.Controls.Add(Me.txtDailyPrice)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblCurrentPrice)
        Me.Controls.Add(Me.txtHourlyPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PricingManagementForm"
        Me.Text = "AdminPricingForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtHourlyPrice As TextBox
    Friend WithEvents lblCurrentPrice As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDailyPrice As TextBox
    Friend WithEvents lblCurrentPriceDaily As Label
    Friend WithEvents btnChange As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOCATIONMANAGEMENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotalProfit As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents USERMANAGEMENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
