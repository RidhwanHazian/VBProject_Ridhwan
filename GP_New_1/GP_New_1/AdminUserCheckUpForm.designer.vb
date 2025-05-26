<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminUserCheckUpForm
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
        Me.lblAI = New System.Windows.Forms.Label()
        Me.lstBoxUserData = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOCATIONMANAGEMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRICINGMANAGEMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPTK
        '
        Me.lblPTK.AutoSize = True
        Me.lblPTK.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPTK.Location = New System.Drawing.Point(56, 277)
        Me.lblPTK.Name = "lblPTK"
        Me.lblPTK.Size = New System.Drawing.Size(573, 118)
        Me.lblPTK.TabIndex = 1
        Me.lblPTK.Text = "USER MANAGEMENT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SYSTEM"
        '
        'lblAI
        '
        Me.lblAI.AutoSize = True
        Me.lblAI.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAI.Location = New System.Drawing.Point(942, 122)
        Me.lblAI.Name = "lblAI"
        Me.lblAI.Size = New System.Drawing.Size(400, 46)
        Me.lblAI.TabIndex = 4
        Me.lblAI.Text = "ADMIN INTERFACE"
        '
        'lstBoxUserData
        '
        Me.lstBoxUserData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxUserData.FormattingEnabled = True
        Me.lstBoxUserData.ItemHeight = 25
        Me.lstBoxUserData.Location = New System.Drawing.Point(909, 213)
        Me.lstBoxUserData.Name = "lstBoxUserData"
        Me.lstBoxUserData.Size = New System.Drawing.Size(493, 304)
        Me.lstBoxUserData.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1621, 33)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXITToolStripMenuItem, Me.BACKToolStripMenuItem, Me.LOCATIONMANAGEMENTToolStripMenuItem, Me.PRICINGMANAGEMENTToolStripMenuItem})
        Me.MENUToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(82, 29)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(349, 30)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'BACKToolStripMenuItem
        '
        Me.BACKToolStripMenuItem.Name = "BACKToolStripMenuItem"
        Me.BACKToolStripMenuItem.Size = New System.Drawing.Size(349, 30)
        Me.BACKToolStripMenuItem.Text = "BACK"
        '
        'LOCATIONMANAGEMENTToolStripMenuItem
        '
        Me.LOCATIONMANAGEMENTToolStripMenuItem.Name = "LOCATIONMANAGEMENTToolStripMenuItem"
        Me.LOCATIONMANAGEMENTToolStripMenuItem.Size = New System.Drawing.Size(349, 30)
        Me.LOCATIONMANAGEMENTToolStripMenuItem.Text = "LOCATION MANAGEMENT"
        '
        'PRICINGMANAGEMENTToolStripMenuItem
        '
        Me.PRICINGMANAGEMENTToolStripMenuItem.Name = "PRICINGMANAGEMENTToolStripMenuItem"
        Me.PRICINGMANAGEMENTToolStripMenuItem.Size = New System.Drawing.Size(349, 30)
        Me.PRICINGMANAGEMENTToolStripMenuItem.Text = "PRICING MANAGEMENT"
        '
        'AdminUserCheckUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1621, 621)
        Me.Controls.Add(Me.lstBoxUserData)
        Me.Controls.Add(Me.lblAI)
        Me.Controls.Add(Me.lblPTK)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AdminUserCheckUpForm"
        Me.Text = "Form3"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPTK As Label
    Friend WithEvents lblAI As Label
    Friend WithEvents lstBoxUserData As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOCATIONMANAGEMENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRICINGMANAGEMENTToolStripMenuItem As ToolStripMenuItem
End Class
