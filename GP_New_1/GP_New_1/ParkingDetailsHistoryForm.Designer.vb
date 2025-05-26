<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParkingDetailsHistoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParkingDetailsHistoryForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstBoxLastReceipt = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewDuration = New System.Windows.Forms.TextBox()
        Me.btnExtend = New System.Windows.Forms.Button()
        Me.radHourly = New System.Windows.Forms.RadioButton()
        Me.radFullDay = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 118)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PARKING TICKET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " SYSTEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(794, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(376, 46)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "PARKING DETAILS"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(62, 547)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(121, 43)
        Me.btnBack.TabIndex = 22
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lstBoxLastReceipt
        '
        Me.lstBoxLastReceipt.FormattingEnabled = True
        Me.lstBoxLastReceipt.ItemHeight = 20
        Me.lstBoxLastReceipt.Items.AddRange(New Object() {"Location :"})
        Me.lstBoxLastReceipt.Location = New System.Drawing.Point(754, 223)
        Me.lstBoxLastReceipt.Name = "lstBoxLastReceipt"
        Me.lstBoxLastReceipt.Size = New System.Drawing.Size(464, 324)
        Me.lstBoxLastReceipt.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(782, 579)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Enter New Duration :"
        '
        'txtNewDuration
        '
        Me.txtNewDuration.Location = New System.Drawing.Point(1056, 579)
        Me.txtNewDuration.Name = "txtNewDuration"
        Me.txtNewDuration.Size = New System.Drawing.Size(147, 26)
        Me.txtNewDuration.TabIndex = 25
        '
        'btnExtend
        '
        Me.btnExtend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtend.Location = New System.Drawing.Point(1092, 239)
        Me.btnExtend.Name = "btnExtend"
        Me.btnExtend.Size = New System.Drawing.Size(111, 43)
        Me.btnExtend.TabIndex = 26
        Me.btnExtend.Text = "EXTEND"
        Me.btnExtend.UseVisualStyleBackColor = True
        '
        'radHourly
        '
        Me.radHourly.AutoSize = True
        Me.radHourly.Location = New System.Drawing.Point(866, 633)
        Me.radHourly.Name = "radHourly"
        Me.radHourly.Size = New System.Drawing.Size(79, 24)
        Me.radHourly.TabIndex = 27
        Me.radHourly.TabStop = True
        Me.radHourly.Text = "Hourly"
        Me.radHourly.UseVisualStyleBackColor = True
        '
        'radFullDay
        '
        Me.radFullDay.AutoSize = True
        Me.radFullDay.Location = New System.Drawing.Point(866, 677)
        Me.radFullDay.Name = "radFullDay"
        Me.radFullDay.Size = New System.Drawing.Size(91, 24)
        Me.radFullDay.TabIndex = 28
        Me.radFullDay.TabStop = True
        Me.radFullDay.Text = "Full Day"
        Me.radFullDay.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-18, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1600, 700)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'ParkingDetailsHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1565, 742)
        Me.Controls.Add(Me.radFullDay)
        Me.Controls.Add(Me.radHourly)
        Me.Controls.Add(Me.btnExtend)
        Me.Controls.Add(Me.txtNewDuration)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstBoxLastReceipt)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ParkingDetailsHistoryForm"
        Me.Text = "ParkingDetailsHistoryForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lstBoxLastReceipt As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNewDuration As TextBox
    Friend WithEvents btnExtend As Button
    Friend WithEvents radHourly As RadioButton
    Friend WithEvents radFullDay As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
