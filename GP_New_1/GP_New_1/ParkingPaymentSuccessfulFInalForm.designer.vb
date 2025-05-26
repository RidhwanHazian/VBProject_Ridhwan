<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Figure13
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Figure13))
        Me.LabelCost = New System.Windows.Forms.Label()
        Me.LabelReference = New System.Windows.Forms.Label()
        Me.LabelFee = New System.Windows.Forms.Label()
        Me.LableReceipts = New System.Windows.Forms.Label()
        Me.Lable2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelVehicle = New System.Windows.Forms.Label()
        Me.LabelLocation = New System.Windows.Forms.Label()
        Me.LabelStart = New System.Windows.Forms.Label()
        Me.btnPplus = New System.Windows.Forms.Button()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblVehicle = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblFee = New System.Windows.Forms.Label()
        Me.lblLocationName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelCost
        '
        resources.ApplyResources(Me.LabelCost, "LabelCost")
        Me.LabelCost.Name = "LabelCost"
        '
        'LabelReference
        '
        resources.ApplyResources(Me.LabelReference, "LabelReference")
        Me.LabelReference.Name = "LabelReference"
        '
        'LabelFee
        '
        resources.ApplyResources(Me.LabelFee, "LabelFee")
        Me.LabelFee.Name = "LabelFee"
        '
        'LableReceipts
        '
        resources.ApplyResources(Me.LableReceipts, "LableReceipts")
        Me.LableReceipts.Name = "LableReceipts"
        '
        'Lable2
        '
        resources.ApplyResources(Me.Lable2, "Lable2")
        Me.Lable2.Name = "Lable2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'LabelVehicle
        '
        resources.ApplyResources(Me.LabelVehicle, "LabelVehicle")
        Me.LabelVehicle.Name = "LabelVehicle"
        '
        'LabelLocation
        '
        resources.ApplyResources(Me.LabelLocation, "LabelLocation")
        Me.LabelLocation.Name = "LabelLocation"
        '
        'LabelStart
        '
        resources.ApplyResources(Me.LabelStart, "LabelStart")
        Me.LabelStart.Name = "LabelStart"
        '
        'btnPplus
        '
        resources.ApplyResources(Me.btnPplus, "btnPplus")
        Me.btnPplus.Name = "btnPplus"
        Me.btnPplus.UseVisualStyleBackColor = True
        '
        'lblDuration
        '
        resources.ApplyResources(Me.lblDuration, "lblDuration")
        Me.lblDuration.Name = "lblDuration"
        '
        'lblLocation
        '
        resources.ApplyResources(Me.lblLocation, "lblLocation")
        Me.lblLocation.Name = "lblLocation"
        '
        'lblDateTime
        '
        resources.ApplyResources(Me.lblDateTime, "lblDateTime")
        Me.lblDateTime.Name = "lblDateTime"
        '
        'lblVehicle
        '
        resources.ApplyResources(Me.lblVehicle, "lblVehicle")
        Me.lblVehicle.Name = "lblVehicle"
        '
        'lblID
        '
        resources.ApplyResources(Me.lblID, "lblID")
        Me.lblID.Name = "lblID"
        '
        'lblFee
        '
        resources.ApplyResources(Me.lblFee, "lblFee")
        Me.lblFee.Name = "lblFee"
        '
        'lblLocationName
        '
        resources.ApplyResources(Me.lblLocationName, "lblLocationName")
        Me.lblLocationName.Name = "lblLocationName"
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.Name = "btnExit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Figure13
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblLocationName)
        Me.Controls.Add(Me.lblFee)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblVehicle)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.btnPplus)
        Me.Controls.Add(Me.LabelStart)
        Me.Controls.Add(Me.LabelLocation)
        Me.Controls.Add(Me.LabelVehicle)
        Me.Controls.Add(Me.LabelCost)
        Me.Controls.Add(Me.LabelReference)
        Me.Controls.Add(Me.LabelFee)
        Me.Controls.Add(Me.LableReceipts)
        Me.Controls.Add(Me.Lable2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Figure13"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelCost As Label
    Friend WithEvents LabelReference As Label
    Friend WithEvents LabelFee As Label
    Friend WithEvents LableReceipts As Label
    Friend WithEvents Lable2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelVehicle As Label
    Friend WithEvents LabelLocation As Label
    Friend WithEvents LabelStart As Label
    Friend WithEvents btnPplus As Button
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblVehicle As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblFee As Label
    Friend WithEvents lblLocationName As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
End Class
