<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Figure12
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
        Me.Lable2 = New System.Windows.Forms.Label()
        Me.Lable3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.radOnline = New System.Windows.Forms.RadioButton()
        Me.radEWallet = New System.Windows.Forms.RadioButton()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lblOutputParking = New System.Windows.Forms.Label()
        Me.lblOutputDuration = New System.Windows.Forms.Label()
        Me.lblOutputCost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PARKING TICKET"
        '
        'Lable2
        '
        Me.Lable2.AutoSize = True
        Me.Lable2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lable2.Location = New System.Drawing.Point(143, 297)
        Me.Lable2.Name = "Lable2"
        Me.Lable2.Size = New System.Drawing.Size(246, 59)
        Me.Lable2.TabIndex = 1
        Me.Lable2.Text = "SYSTEM"
        '
        'Lable3
        '
        Me.Lable3.AutoSize = True
        Me.Lable3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lable3.Location = New System.Drawing.Point(909, 122)
        Me.Lable3.Name = "Lable3"
        Me.Lable3.Size = New System.Drawing.Size(387, 46)
        Me.Lable3.TabIndex = 2
        Me.Lable3.Text = "PARKING DETAILS:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(912, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PARKING TYPE: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(912, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DURATION:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(912, 349)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TOTAL COST:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(912, 420)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(207, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "PAYMENT METHOD:"
        '
        'radOnline
        '
        Me.radOnline.AutoSize = True
        Me.radOnline.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOnline.Location = New System.Drawing.Point(1196, 421)
        Me.radOnline.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radOnline.Name = "radOnline"
        Me.radOnline.Size = New System.Drawing.Size(110, 29)
        Me.radOnline.TabIndex = 7
        Me.radOnline.TabStop = True
        Me.radOnline.Text = "ONLINE"
        Me.radOnline.UseVisualStyleBackColor = True
        '
        'radEWallet
        '
        Me.radEWallet.AutoSize = True
        Me.radEWallet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEWallet.Location = New System.Drawing.Point(1196, 454)
        Me.radEWallet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radEWallet.Name = "radEWallet"
        Me.radEWallet.Size = New System.Drawing.Size(139, 29)
        Me.radEWallet.TabIndex = 8
        Me.radEWallet.TabStop = True
        Me.radEWallet.Text = "E-WALLET"
        Me.radEWallet.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(1066, 544)
        Me.btnPay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(150, 51)
        Me.btnPay.TabIndex = 9
        Me.btnPay.Text = "PAY"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'lblOutputParking
        '
        Me.lblOutputParking.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputParking.Location = New System.Drawing.Point(1097, 220)
        Me.lblOutputParking.Name = "lblOutputParking"
        Me.lblOutputParking.Size = New System.Drawing.Size(156, 25)
        Me.lblOutputParking.TabIndex = 10
        '
        'lblOutputDuration
        '
        Me.lblOutputDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputDuration.Location = New System.Drawing.Point(1097, 278)
        Me.lblOutputDuration.Name = "lblOutputDuration"
        Me.lblOutputDuration.Size = New System.Drawing.Size(163, 25)
        Me.lblOutputDuration.TabIndex = 11
        '
        'lblOutputCost
        '
        Me.lblOutputCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputCost.Location = New System.Drawing.Point(1097, 349)
        Me.lblOutputCost.Name = "lblOutputCost"
        Me.lblOutputCost.Size = New System.Drawing.Size(145, 25)
        Me.lblOutputCost.TabIndex = 12
        '
        'Figure12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1604, 747)
        Me.Controls.Add(Me.lblOutputCost)
        Me.Controls.Add(Me.lblOutputDuration)
        Me.Controls.Add(Me.lblOutputParking)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.radEWallet)
        Me.Controls.Add(Me.radOnline)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lable3)
        Me.Controls.Add(Me.Lable2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Figure12"
        Me.Text = "PaymentForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Lable2 As Label
    Friend WithEvents Lable3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents radOnline As RadioButton
    Friend WithEvents radEWallet As RadioButton
    Friend WithEvents btnPay As Button
    Friend WithEvents lblOutputParking As Label
    Friend WithEvents lblOutputDuration As Label
    Friend WithEvents lblOutputCost As Label
End Class
