<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomEditor
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim BuildingNoLabel1 As System.Windows.Forms.Label
        Dim CapacityLabel As System.Windows.Forms.Label
        Dim FloorNoLabel As System.Windows.Forms.Label
        Dim NameLabel1 As System.Windows.Forms.Label
        Dim NumberLabel1 As System.Windows.Forms.Label
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuildingNoTextBox1 = New System.Windows.Forms.TextBox()
        Me.FloorNoTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.NumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        BuildingNoLabel1 = New System.Windows.Forms.Label()
        CapacityLabel = New System.Windows.Forms.Label()
        FloorNoLabel = New System.Windows.Forms.Label()
        NameLabel1 = New System.Windows.Forms.Label()
        NumberLabel1 = New System.Windows.Forms.Label()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuildingNoLabel1
        '
        BuildingNoLabel1.AutoSize = True
        BuildingNoLabel1.Location = New System.Drawing.Point(20, 124)
        BuildingNoLabel1.Name = "BuildingNoLabel1"
        BuildingNoLabel1.Size = New System.Drawing.Size(35, 12)
        BuildingNoLabel1.TabIndex = 7
        BuildingNoLabel1.Text = "楼号:"
        '
        'CapacityLabel
        '
        CapacityLabel.AutoSize = True
        CapacityLabel.ForeColor = System.Drawing.Color.Navy
        CapacityLabel.Location = New System.Drawing.Point(20, 97)
        CapacityLabel.Name = "CapacityLabel"
        CapacityLabel.Size = New System.Drawing.Size(65, 12)
        CapacityLabel.TabIndex = 9
        CapacityLabel.Text = "*容纳人数:"
        '
        'FloorNoLabel
        '
        FloorNoLabel.AutoSize = True
        FloorNoLabel.Location = New System.Drawing.Point(20, 151)
        FloorNoLabel.Name = "FloorNoLabel"
        FloorNoLabel.Size = New System.Drawing.Size(35, 12)
        FloorNoLabel.TabIndex = 11
        FloorNoLabel.Text = "层号:"
        '
        'NameLabel1
        '
        NameLabel1.AutoSize = True
        NameLabel1.ForeColor = System.Drawing.Color.Navy
        NameLabel1.Location = New System.Drawing.Point(20, 70)
        NameLabel1.Name = "NameLabel1"
        NameLabel1.Size = New System.Drawing.Size(65, 12)
        NameLabel1.TabIndex = 15
        NameLabel1.Text = "*房间名称:"
        '
        'NumberLabel1
        '
        NumberLabel1.AutoSize = True
        NumberLabel1.ForeColor = System.Drawing.Color.Navy
        NumberLabel1.Location = New System.Drawing.Point(20, 43)
        NumberLabel1.Name = "NumberLabel1"
        NumberLabel1.Size = New System.Drawing.Size(53, 12)
        NumberLabel1.TabIndex = 17
        NumberLabel1.Text = "*房间号:"
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataSource = GetType(StudentAccommondation.Student)
        '
        'BuildingNoTextBox1
        '
        Me.BuildingNoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Room.BuildingNo", True))
        Me.BuildingNoTextBox1.Location = New System.Drawing.Point(103, 121)
        Me.BuildingNoTextBox1.Name = "BuildingNoTextBox1"
        Me.BuildingNoTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.BuildingNoTextBox1.TabIndex = 8
        '
        'FloorNoTextBox
        '
        Me.FloorNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Room.FloorNo", True))
        Me.FloorNoTextBox.Location = New System.Drawing.Point(103, 148)
        Me.FloorNoTextBox.Name = "FloorNoTextBox"
        Me.FloorNoTextBox.Size = New System.Drawing.Size(100, 21)
        Me.FloorNoTextBox.TabIndex = 12
        '
        'NameTextBox1
        '
        Me.NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Room.Name", True))
        Me.NameTextBox1.Location = New System.Drawing.Point(103, 67)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.NameTextBox1.TabIndex = 16
        '
        'NumberTextBox1
        '
        Me.NumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Room.Number", True))
        Me.NumberTextBox1.Location = New System.Drawing.Point(103, 40)
        Me.NumberTextBox1.Name = "NumberTextBox1"
        Me.NumberTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.NumberTextBox1.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(BuildingNoLabel1)
        Me.GroupBox1.Controls.Add(Me.BuildingNoTextBox1)
        Me.GroupBox1.Controls.Add(CapacityLabel)
        Me.GroupBox1.Controls.Add(FloorNoLabel)
        Me.GroupBox1.Controls.Add(Me.FloorNoTextBox)
        Me.GroupBox1.Controls.Add(NameLabel1)
        Me.GroupBox1.Controls.Add(Me.NameTextBox1)
        Me.GroupBox1.Controls.Add(NumberLabel1)
        Me.GroupBox1.Controls.Add(Me.NumberTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 196)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "房间属性"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(134, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(215, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(103, 94)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(58, 21)
        Me.NumericUpDown1.TabIndex = 19
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "人"
        '
        'RoomEditor
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(314, 267)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RoomEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RoomEditor"
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents BuildingNoTextBox1 As TextBox
    Friend WithEvents FloorNoTextBox As TextBox
    Friend WithEvents NameTextBox1 As TextBox
    Friend WithEvents NumberTextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
