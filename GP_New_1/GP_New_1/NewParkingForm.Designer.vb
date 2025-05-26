<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewParkingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewParkingForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RECEIPTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PARKINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbStates = New System.Windows.Forms.ComboBox()
        Me.lstPlates = New System.Windows.Forms.ListBox()
        Me.btnAddPlate = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 118)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PARKING TICKET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " SYSTEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(917, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(304, 46)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "NEW PARKING"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1019, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "STATES:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(934, 433)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "VEHICLE PLATE NUMBER:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(914, 593)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(296, 26)
        Me.TextBox1.TabIndex = 12
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(1165, 639)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(103, 42)
        Me.btnNext.TabIndex = 19
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1572, 33)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RECEIPTToolStripMenuItem, Me.PARKINGToolStripMenuItem, Me.BACKToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'RECEIPTToolStripMenuItem
        '
        Me.RECEIPTToolStripMenuItem.Name = "RECEIPTToolStripMenuItem"
        Me.RECEIPTToolStripMenuItem.Size = New System.Drawing.Size(168, 30)
        Me.RECEIPTToolStripMenuItem.Text = "RECEIPT"
        '
        'PARKINGToolStripMenuItem
        '
        Me.PARKINGToolStripMenuItem.Name = "PARKINGToolStripMenuItem"
        Me.PARKINGToolStripMenuItem.Size = New System.Drawing.Size(168, 30)
        Me.PARKINGToolStripMenuItem.Text = "PARKING"
        '
        'BACKToolStripMenuItem
        '
        Me.BACKToolStripMenuItem.Name = "BACKToolStripMenuItem"
        Me.BACKToolStripMenuItem.Size = New System.Drawing.Size(168, 30)
        Me.BACKToolStripMenuItem.Text = "BACK"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(168, 30)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'cbStates
        '
        Me.cbStates.FormattingEnabled = True
        Me.cbStates.Location = New System.Drawing.Point(925, 340)
        Me.cbStates.Name = "cbStates"
        Me.cbStates.Size = New System.Drawing.Size(296, 28)
        Me.cbStates.TabIndex = 23
        '
        'lstPlates
        '
        Me.lstPlates.FormattingEnabled = True
        Me.lstPlates.ItemHeight = 20
        Me.lstPlates.Location = New System.Drawing.Point(988, 472)
        Me.lstPlates.Name = "lstPlates"
        Me.lstPlates.Size = New System.Drawing.Size(156, 104)
        Me.lstPlates.TabIndex = 24
        '
        'btnAddPlate
        '
        Me.btnAddPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPlate.Location = New System.Drawing.Point(892, 639)
        Me.btnAddPlate.Name = "btnAddPlate"
        Me.btnAddPlate.Size = New System.Drawing.Size(103, 42)
        Me.btnAddPlate.TabIndex = 25
        Me.btnAddPlate.Text = "ADD"
        Me.btnAddPlate.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(1024, 639)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(103, 42)
        Me.btnRemove.TabIndex = 26
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-14, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1600, 700)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'NewParkingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1572, 741)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAddPlate)
        Me.Controls.Add(Me.lstPlates)
        Me.Controls.Add(Me.cbStates)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "NewParkingForm"
        Me.Text = "ParkingTicketForm1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RECEIPTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PARKINGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbStates As ComboBox
    Friend WithEvents lstPlates As ListBox
    Friend WithEvents btnAddPlate As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
