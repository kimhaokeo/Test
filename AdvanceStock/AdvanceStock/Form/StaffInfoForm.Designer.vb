<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffInfoForm
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.txtSalary = New DevComponents.Editors.IntegerInput()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.cboPosition = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.TblPositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PositionDataSet = New AdvanceStock.PositionDataSet()
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboGender = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Male = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtUserName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtStaffName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.TblPositionTableAdapter = New AdvanceStock.PositionDataSetTableAdapters.tblPositionTableAdapter()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnShow = New DevComponents.DotNetBar.ButtonX()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Staff"
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.AllowUserToResizeColumns = False
        Me.DataGridViewX1.AllowUserToResizeRows = False
        Me.DataGridViewX1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(22, 327)
        Me.DataGridViewX1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.RowHeadersVisible = False
        Me.DataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewX1.Size = New System.Drawing.Size(637, 279)
        Me.DataGridViewX1.TabIndex = 38
        '
        'Column7
        '
        Me.Column7.HeaderText = "ID"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "StaffName"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Gender"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Salary"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Position"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "UserName"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Password"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'LabelX7
        '
        Me.LabelX7.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(250, 50)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(181, 73)
        Me.LabelX7.TabIndex = 39
        Me.LabelX7.Text = "Staff "
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Manager"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Staff"
        '
        'txtSalary
        '
        Me.txtSalary.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtSalary.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtSalary.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSalary.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtSalary.Location = New System.Drawing.Point(155, 196)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(309, 22)
        Me.txtSalary.TabIndex = 25
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Manager"
        '
        'cboPosition
        '
        Me.cboPosition.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboPosition.DataSource = Me.TblPositionBindingSource
        Me.cboPosition.DisplayMember = "PositionName"
        Me.cboPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.ItemHeight = 14
        Me.cboPosition.Location = New System.Drawing.Point(155, 229)
        Me.cboPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(309, 20)
        Me.cboPosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboPosition.TabIndex = 27
        Me.cboPosition.ValueMember = "PositionID"
        '
        'TblPositionBindingSource
        '
        Me.TblPositionBindingSource.DataMember = "tblPosition"
        Me.TblPositionBindingSource.DataSource = Me.PositionDataSet
        '
        'PositionDataSet
        '
        Me.PositionDataSet.DataSetName = "PositionDataSet"
        Me.PositionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassword.Location = New System.Drawing.Point(155, 293)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(308, 22)
        Me.txtPassword.TabIndex = 30
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'cboGender
        '
        Me.cboGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboGender.DisplayMember = "Text"
        Me.cboGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.ItemHeight = 14
        Me.cboGender.Items.AddRange(New Object() {Me.Male, Me.ComboItem1})
        Me.cboGender.Location = New System.Drawing.Point(155, 164)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(309, 20)
        Me.cboGender.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboGender.TabIndex = 23
        '
        'Male
        '
        Me.Male.Text = "Male"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Female"
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearch.Location = New System.Drawing.Point(483, 237)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 28)
        Me.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSearch.TabIndex = 36
        Me.btnSearch.Text = "Search"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Location = New System.Drawing.Point(483, 201)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 28)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "Delete"
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Location = New System.Drawing.Point(483, 165)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 28)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 33
        Me.btnEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Location = New System.Drawing.Point(483, 130)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 28)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "Add"
        '
        'LabelX6
        '
        Me.LabelX6.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(47, 290)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(100, 28)
        Me.LabelX6.TabIndex = 37
        Me.LabelX6.Text = "Password"
        '
        'txtUserName
        '
        Me.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtUserName.Border.Class = "TextBoxBorder"
        Me.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUserName.Location = New System.Drawing.Point(155, 261)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(308, 22)
        Me.txtUserName.TabIndex = 29
        '
        'LabelX5
        '
        Me.LabelX5.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(47, 258)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(100, 28)
        Me.LabelX5.TabIndex = 34
        Me.LabelX5.Text = "UserName"
        '
        'LabelX4
        '
        Me.LabelX4.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(47, 226)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(100, 28)
        Me.LabelX4.TabIndex = 31
        Me.LabelX4.Text = "Position"
        '
        'LabelX3
        '
        Me.LabelX3.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(47, 194)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(100, 28)
        Me.LabelX3.TabIndex = 28
        Me.LabelX3.Text = "Salary"
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(47, 162)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(100, 28)
        Me.LabelX2.TabIndex = 24
        Me.LabelX2.Text = "Gender"
        '
        'txtStaffName
        '
        Me.txtStaffName.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtStaffName.Border.Class = "TextBoxBorder"
        Me.txtStaffName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtStaffName.Location = New System.Drawing.Point(155, 133)
        Me.txtStaffName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(308, 22)
        Me.txtStaffName.TabIndex = 22
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(47, 130)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(100, 28)
        Me.LabelX1.TabIndex = 21
        Me.LabelX1.Text = "StaffName"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Location = New System.Drawing.Point(559, 614)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 41
        Me.btnClose.Text = "&Close"
        '
        'TblPositionTableAdapter
        '
        Me.TblPositionTableAdapter.ClearBeforeFill = True
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(600, 165)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 29)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 42
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Visible = False
        '
        'btnShow
        '
        Me.btnShow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnShow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnShow.Location = New System.Drawing.Point(483, 273)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(100, 28)
        Me.btnShow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnShow.TabIndex = 36
        Me.btnShow.Text = "Show All"
        '
        'StaffInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 700)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.cboPosition)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.LabelX7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffInfoForm"
        Me.Text = "StaffInfoForm"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents txtSalary As DevComponents.Editors.IntegerInput
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents cboPosition As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboGender As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Male As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUserName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtStaffName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PositionDataSet As AdvanceStock.PositionDataSet
    Friend WithEvents TblPositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPositionTableAdapter As AdvanceStock.PositionDataSetTableAdapters.tblPositionTableAdapter
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnShow As DevComponents.DotNetBar.ButtonX
End Class
