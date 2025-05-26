<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LocationManagementForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LocationManagementForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRICINGMANAGEMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERMANAGEMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNewLocation = New System.Windows.Forms.TextBox()
        Me.lstLocations = New System.Windows.Forms.ListBox()
        Me.cbCouncils = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.UserAccDataSet = New GP_New_1.UserAccDataSet()
        Me.LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationTableAdapter = New GP_New_1.UserAccDataSetTableAdapters.LocationTableAdapter()
        Me.TableAdapterManager = New GP_New_1.UserAccDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.UserAccDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 118)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PARKING TICKET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " SYSTEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(890, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(385, 46)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ADMIN INTERFACE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(850, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "LOCATION MANAGEMENT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(861, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "List of All Location : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(851, 513)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "ADD LOCATION : "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1584, 33)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BACKToolStripMenuItem, Me.EXITToolStripMenuItem, Me.PRICINGMANAGEMENTToolStripMenuItem, Me.USERMANAGEMENTToolStripMenuItem})
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'BACKToolStripMenuItem
        '
        Me.BACKToolStripMenuItem.Name = "BACKToolStripMenuItem"
        Me.BACKToolStripMenuItem.Size = New System.Drawing.Size(289, 30)
        Me.BACKToolStripMenuItem.Text = "BACK"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(289, 30)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'PRICINGMANAGEMENTToolStripMenuItem
        '
        Me.PRICINGMANAGEMENTToolStripMenuItem.Name = "PRICINGMANAGEMENTToolStripMenuItem"
        Me.PRICINGMANAGEMENTToolStripMenuItem.Size = New System.Drawing.Size(289, 30)
        Me.PRICINGMANAGEMENTToolStripMenuItem.Text = "PRICING MANAGEMENT"
        '
        'USERMANAGEMENTToolStripMenuItem
        '
        Me.USERMANAGEMENTToolStripMenuItem.Name = "USERMANAGEMENTToolStripMenuItem"
        Me.USERMANAGEMENTToolStripMenuItem.Size = New System.Drawing.Size(289, 30)
        Me.USERMANAGEMENTToolStripMenuItem.Text = "USER MANAGEMENT"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(824, 599)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(143, 42)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1303, 599)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(164, 42)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(878, 551)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Location : "
        '
        'txtNewLocation
        '
        Me.txtNewLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewLocation.Location = New System.Drawing.Point(975, 546)
        Me.txtNewLocation.Name = "txtNewLocation"
        Me.txtNewLocation.Size = New System.Drawing.Size(270, 30)
        Me.txtNewLocation.TabIndex = 24
        '
        'lstLocations
        '
        Me.lstLocations.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLocations.FormattingEnabled = True
        Me.lstLocations.ItemHeight = 25
        Me.lstLocations.Location = New System.Drawing.Point(883, 342)
        Me.lstLocations.Name = "lstLocations"
        Me.lstLocations.Size = New System.Drawing.Size(451, 154)
        Me.lstLocations.TabIndex = 25
        '
        'cbCouncils
        '
        Me.cbCouncils.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCouncils.FormattingEnabled = True
        Me.cbCouncils.Location = New System.Drawing.Point(1052, 271)
        Me.cbCouncils.Name = "cbCouncils"
        Me.cbCouncils.Size = New System.Drawing.Size(415, 33)
        Me.cbCouncils.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(861, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 25)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Select a council : "
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(1061, 599)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(165, 42)
        Me.btnRemove.TabIndex = 28
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'UserAccDataSet
        '
        Me.UserAccDataSet.DataSetName = "UserAccDataSet"
        Me.UserAccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocationBindingSource
        '
        Me.LocationBindingSource.DataMember = "Location"
        Me.LocationBindingSource.DataSource = Me.UserAccDataSet
        '
        'LocationTableAdapter
        '
        Me.LocationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountTableAdapter = Nothing
        Me.TableAdapterManager.AdminInfoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LocationTableAdapter = Me.LocationTableAdapter
        Me.TableAdapterManager.UpdateOrder = GP_New_1.UserAccDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vhPlateNumberTableAdapter = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-16, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1600, 700)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'LocationManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 739)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbCouncils)
        Me.Controls.Add(Me.lstLocations)
        Me.Controls.Add(Me.txtNewLocation)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LocationManagementForm"
        Me.Text = "PricingManagementForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.UserAccDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRICINGMANAGEMENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNewLocation As TextBox
    Friend WithEvents lstLocations As ListBox
    Friend WithEvents cbCouncils As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents UserAccDataSet As UserAccDataSet
    Friend WithEvents LocationBindingSource As BindingSource
    Friend WithEvents LocationTableAdapter As UserAccDataSetTableAdapters.LocationTableAdapter
    Friend WithEvents TableAdapterManager As UserAccDataSetTableAdapters.TableAdapterManager
    Friend WithEvents USERMANAGEMENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
