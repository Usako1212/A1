﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.宿舍ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.学生ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.统计分析ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Capacity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuildingNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FloorNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tb_AddRoom = New System.Windows.Forms.ToolStripButton()
        Me.tb_EditRoom = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tb_deleteRoom = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tb_AddStudent = New System.Windows.Forms.ToolStripButton()
        Me.tb_EditStudent = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TB_ChangeRoom = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tb_deleteStudent = New System.Windows.Forms.ToolStripButton()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Major = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmissionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Birthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.宿舍ToolStripMenuItem, Me.学生ToolStripMenuItem, Me.统计分析ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '宿舍ToolStripMenuItem
        '
        Me.宿舍ToolStripMenuItem.Name = "宿舍ToolStripMenuItem"
        Me.宿舍ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.宿舍ToolStripMenuItem.Text = "宿舍"
        '
        '学生ToolStripMenuItem
        '
        Me.学生ToolStripMenuItem.Name = "学生ToolStripMenuItem"
        Me.学生ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.学生ToolStripMenuItem.Text = "学生"
        '
        '统计分析ToolStripMenuItem
        '
        Me.统计分析ToolStripMenuItem.Name = "统计分析ToolStripMenuItem"
        Me.统计分析ToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.统计分析ToolStripMenuItem.Text = "统计分析"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关于ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.关于ToolStripMenuItem.Text = "关于..."
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(800, 400)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Visible = False
        '
        'BindingSource1
        '
        '
        'Number
        '
        Me.Number.DataPropertyName = "Number"
        Me.Number.HeaderText = "编号"
        Me.Number.Name = "Number"
        Me.Number.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "名称"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Capacity
        '
        Me.Capacity.DataPropertyName = "Capacity"
        Me.Capacity.HeaderText = "最大人数"
        Me.Capacity.Name = "Capacity"
        Me.Capacity.ReadOnly = True
        '
        'BuildingNoDataGridViewTextBoxColumn
        '
        Me.BuildingNoDataGridViewTextBoxColumn.DataPropertyName = "BuildingNo"
        Me.BuildingNoDataGridViewTextBoxColumn.HeaderText = "楼号"
        Me.BuildingNoDataGridViewTextBoxColumn.Name = "BuildingNoDataGridViewTextBoxColumn"
        Me.BuildingNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.BuildingNoDataGridViewTextBoxColumn.Width = 60
        '
        'FloorNoDataGridViewTextBoxColumn
        '
        Me.FloorNoDataGridViewTextBoxColumn.DataPropertyName = "FloorNo"
        Me.FloorNoDataGridViewTextBoxColumn.HeaderText = "层号"
        Me.FloorNoDataGridViewTextBoxColumn.Name = "FloorNoDataGridViewTextBoxColumn"
        Me.FloorNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FloorNoDataGridViewTextBoxColumn.Width = 60
        '
        'StudentsDataGridViewTextBoxColumn
        '
        Me.StudentsDataGridViewTextBoxColumn.DataPropertyName = "Students"
        Me.StudentsDataGridViewTextBoxColumn.HeaderText = "入住学生"
        Me.StudentsDataGridViewTextBoxColumn.Name = "StudentsDataGridViewTextBoxColumn"
        Me.StudentsDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentsDataGridViewTextBoxColumn.Width = 200
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tb_AddRoom, Me.tb_EditRoom, Me.ToolStripSeparator1, Me.tb_deleteRoom, Me.ToolStripSeparator2, Me.tb_AddStudent, Me.tb_EditStudent, Me.ToolStripSeparator4, Me.TB_ChangeRoom, Me.ToolStripSeparator3, Me.tb_deleteStudent, Me.ToolStripTextBox1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(150, 22)
        '
        'tb_AddRoom
        '
        Me.tb_AddRoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tb_AddRoom.Image = CType(resources.GetObject("tb_AddRoom.Image"), System.Drawing.Image)
        Me.tb_AddRoom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tb_AddRoom.Name = "tb_AddRoom"
        Me.tb_AddRoom.Size = New System.Drawing.Size(60, 22)
        Me.tb_AddRoom.Text = "添加房间"
        '
        'tb_EditRoom
        '
        Me.tb_EditRoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tb_EditRoom.Enabled = False
        Me.tb_EditRoom.Image = CType(resources.GetObject("tb_EditRoom.Image"), System.Drawing.Image)
        Me.tb_EditRoom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tb_EditRoom.Name = "tb_EditRoom"
        Me.tb_EditRoom.Size = New System.Drawing.Size(60, 22)
        Me.tb_EditRoom.Text = "编辑房间"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tb_deleteRoom
        '
        Me.tb_deleteRoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tb_deleteRoom.Enabled = False
        Me.tb_deleteRoom.Image = CType(resources.GetObject("tb_deleteRoom.Image"), System.Drawing.Image)
        Me.tb_deleteRoom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tb_deleteRoom.Name = "tb_deleteRoom"
        Me.tb_deleteRoom.Size = New System.Drawing.Size(60, 22)
        Me.tb_deleteRoom.Text = "删除房间"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tb_AddStudent
        '
        Me.tb_AddStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tb_AddStudent.Image = CType(resources.GetObject("tb_AddStudent.Image"), System.Drawing.Image)
        Me.tb_AddStudent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tb_AddStudent.Name = "tb_AddStudent"
        Me.tb_AddStudent.Size = New System.Drawing.Size(84, 22)
        Me.tb_AddStudent.Text = "添加学生档案"
        '
        'tb_EditStudent
        '
        Me.tb_EditStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tb_EditStudent.Enabled = False
        Me.tb_EditStudent.Image = CType(resources.GetObject("tb_EditStudent.Image"), System.Drawing.Image)
        Me.tb_EditStudent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tb_EditStudent.Name = "tb_EditStudent"
        Me.tb_EditStudent.Size = New System.Drawing.Size(84, 22)
        Me.tb_EditStudent.Text = "编辑学生档案"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'TB_ChangeRoom
        '
        Me.TB_ChangeRoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TB_ChangeRoom.Enabled = False
        Me.TB_ChangeRoom.Image = CType(resources.GetObject("TB_ChangeRoom.Image"), System.Drawing.Image)
        Me.TB_ChangeRoom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TB_ChangeRoom.Name = "TB_ChangeRoom"
        Me.TB_ChangeRoom.Size = New System.Drawing.Size(60, 22)
        Me.TB_ChangeRoom.Text = "分配房间"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tb_deleteStudent
        '
        Me.tb_deleteStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tb_deleteStudent.Enabled = False
        Me.tb_deleteStudent.Image = CType(resources.GetObject("tb_deleteStudent.Image"), System.Drawing.Image)
        Me.tb_deleteStudent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tb_deleteStudent.Name = "tb_deleteStudent"
        Me.tb_deleteStudent.Size = New System.Drawing.Size(84, 22)
        Me.tb_deleteStudent.Text = "删除学生档案"
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "姓名"
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        Me.NameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn1.Width = 80
        '
        'NumberDataGridViewTextBoxColumn
        '
        Me.NumberDataGridViewTextBoxColumn.DataPropertyName = "Number"
        Me.NumberDataGridViewTextBoxColumn.HeaderText = "学号"
        Me.NumberDataGridViewTextBoxColumn.Name = "NumberDataGridViewTextBoxColumn"
        Me.NumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumberDataGridViewTextBoxColumn.Width = 80
        '
        'Major
        '
        Me.Major.DataPropertyName = "Major"
        Me.Major.HeaderText = "专业"
        Me.Major.Name = "Major"
        Me.Major.ReadOnly = True
        '
        'AdmissionDate
        '
        Me.AdmissionDate.DataPropertyName = "AdmissionDate"
        Me.AdmissionDate.HeaderText = "入学日期"
        Me.AdmissionDate.Name = "AdmissionDate"
        Me.AdmissionDate.ReadOnly = True
        '
        'Birthday
        '
        Me.Birthday.DataPropertyName = "Birthday"
        Me.Birthday.HeaderText = "生日"
        Me.Birthday.Name = "Birthday"
        Me.Birthday.ReadOnly = True
        '
        'RoomName
        '
        Me.RoomName.DataPropertyName = "RoomName"
        Me.RoomName.HeaderText = "所在房间"
        Me.RoomName.Name = "RoomName"
        Me.RoomName.ReadOnly = True
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripTextBox1.ToolTipText = "输入要搜索的关键字"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "学生住宿管理系统v1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 宿舍ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 学生ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 统计分析ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents CreateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents tb_AddRoom As ToolStripButton
    Friend WithEvents tb_EditRoom As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tb_deleteRoom As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tb_AddStudent As ToolStripButton
    Friend WithEvents tb_EditStudent As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tb_deleteStudent As ToolStripButton
    Friend WithEvents Number As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Capacity As DataGridViewTextBoxColumn
    Friend WithEvents BuildingNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FloorNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TB_ChangeRoom As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents NameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Major As DataGridViewTextBoxColumn
    Friend WithEvents AdmissionDate As DataGridViewTextBoxColumn
    Friend WithEvents Birthday As DataGridViewTextBoxColumn
    Friend WithEvents RoomName As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
End Class
