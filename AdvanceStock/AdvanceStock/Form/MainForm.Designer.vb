<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.btnStaffControl = New DevComponents.DotNetBar.ButtonItem()
        Me.btnStaffInfo = New DevComponents.DotNetBar.ButtonItem()
        Me.btnPosition = New DevComponents.DotNetBar.ButtonItem()
        Me.btnClose = New DevComponents.DotNetBar.ButtonItem()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.btnProductControl = New DevComponents.DotNetBar.ButtonItem()
        Me.btnProductInfo = New DevComponents.DotNetBar.ButtonItem()
        Me.btnCreatePackage = New DevComponents.DotNetBar.ButtonItem()
        Me.DockSite7.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins)
        Me.DotNetBarManager1.BottomDockSite = Me.DockSite4
        Me.DotNetBarManager1.EnableFullSizeDock = False
        Me.DotNetBarManager1.LeftDockSite = Me.DockSite1
        Me.DotNetBarManager1.ParentForm = Me
        Me.DotNetBarManager1.RightDockSite = Me.DockSite2
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.DotNetBarManager1.ToolbarBottomDockSite = Me.DockSite8
        Me.DotNetBarManager1.ToolbarLeftDockSite = Me.DockSite5
        Me.DotNetBarManager1.ToolbarRightDockSite = Me.DockSite6
        Me.DotNetBarManager1.ToolbarTopDockSite = Me.DockSite7
        Me.DotNetBarManager1.TopDockSite = Me.DockSite3
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite4.Location = New System.Drawing.Point(0, 900)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(900, 0)
        Me.DockSite4.TabIndex = 3
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(0, 128)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 772)
        Me.DockSite1.TabIndex = 0
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(900, 128)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 772)
        Me.DockSite2.TabIndex = 1
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 900)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(900, 0)
        Me.DockSite8.TabIndex = 7
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 128)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 772)
        Me.DockSite5.TabIndex = 4
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(900, 128)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 772)
        Me.DockSite6.TabIndex = 5
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Controls.Add(Me.Bar1)
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(900, 128)
        Me.DockSite7.TabIndex = 6
        Me.DockSite7.TabStop = False
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Bar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.Bar1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnStaffControl, Me.btnProductControl, Me.btnClose})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.MenuBar = True
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(900, 127)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.Bar1.TabIndex = 0
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'btnStaffControl
        '
        Me.btnStaffControl.AutoCollapseOnClick = False
        Me.btnStaffControl.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnStaffControl.Image = CType(resources.GetObject("btnStaffControl.Image"), System.Drawing.Image)
        Me.btnStaffControl.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnStaffControl.Name = "btnStaffControl"
        Me.btnStaffControl.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.btnStaffControl.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnStaffInfo, Me.btnPosition})
        Me.btnStaffControl.Text = "Staff Control"
        '
        'btnStaffInfo
        '
        Me.btnStaffInfo.Image = CType(resources.GetObject("btnStaffInfo.Image"), System.Drawing.Image)
        Me.btnStaffInfo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnStaffInfo.Name = "btnStaffInfo"
        Me.btnStaffInfo.Text = "Staff Infomation"
        '
        'btnPosition
        '
        Me.btnPosition.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnPosition.Image = CType(resources.GetObject("btnPosition.Image"), System.Drawing.Image)
        Me.btnPosition.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnPosition.Name = "btnPosition"
        Me.btnPosition.Text = "Position"
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnClose.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Text = "Exit"
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(0, 128)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(900, 0)
        Me.DockSite3.TabIndex = 2
        Me.DockSite3.TabStop = False
        '
        'btnProductControl
        '
        Me.btnProductControl.Image = CType(resources.GetObject("btnProductControl.Image"), System.Drawing.Image)
        Me.btnProductControl.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnProductControl.Name = "btnProductControl"
        Me.btnProductControl.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnProductInfo, Me.btnCreatePackage})
        Me.btnProductControl.Text = "Product Control"
        '
        'btnProductInfo
        '
        Me.btnProductInfo.Image = CType(resources.GetObject("btnProductInfo.Image"), System.Drawing.Image)
        Me.btnProductInfo.Name = "btnProductInfo"
        Me.btnProductInfo.Text = "Products Info"
        '
        'btnCreatePackage
        '
        Me.btnCreatePackage.Name = "btnCreatePackage"
        Me.btnCreatePackage.Text = "Package Info"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 900)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.DockSite7.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents btnStaffControl As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnStaffInfo As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents btnPosition As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnProductControl As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnProductInfo As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnCreatePackage As DevComponents.DotNetBar.ButtonItem

End Class
