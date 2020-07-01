<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentEditor
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
        Dim NameLabel1 As System.Windows.Forms.Label
        Dim NumberLabel1 As System.Windows.Forms.Label
        Dim MajorLabel As System.Windows.Forms.Label
        Dim BirthdayLabel As System.Windows.Forms.Label
        Dim AdmissionDateLabel As System.Windows.Forms.Label
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.NumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MajorTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AdmissionDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        NameLabel1 = New System.Windows.Forms.Label()
        NumberLabel1 = New System.Windows.Forms.Label()
        MajorLabel = New System.Windows.Forms.Label()
        BirthdayLabel = New System.Windows.Forms.Label()
        AdmissionDateLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel1
        '
        NameLabel1.AutoSize = True
        NameLabel1.ForeColor = System.Drawing.Color.Navy
        NameLabel1.Location = New System.Drawing.Point(45, 73)
        NameLabel1.Name = "NameLabel1"
        NameLabel1.Size = New System.Drawing.Size(41, 12)
        NameLabel1.TabIndex = 15
        NameLabel1.Text = "*姓名:"
        '
        'NumberLabel1
        '
        NumberLabel1.AutoSize = True
        NumberLabel1.ForeColor = System.Drawing.Color.Navy
        NumberLabel1.Location = New System.Drawing.Point(45, 46)
        NumberLabel1.Name = "NumberLabel1"
        NumberLabel1.Size = New System.Drawing.Size(41, 12)
        NumberLabel1.TabIndex = 17
        NumberLabel1.Text = "*学号:"
        '
        'NameTextBox1
        '
        Me.NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Room.Name", True))
        Me.NameTextBox1.Location = New System.Drawing.Point(101, 70)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.NameTextBox1.TabIndex = 1
        '
        'NumberTextBox1
        '
        Me.NumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Room.Number", True))
        Me.NumberTextBox1.Location = New System.Drawing.Point(101, 43)
        Me.NumberTextBox1.Name = "NumberTextBox1"
        Me.NumberTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.NumberTextBox1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(AdmissionDateLabel)
        Me.GroupBox1.Controls.Add(Me.AdmissionDateDateTimePicker)
        Me.GroupBox1.Controls.Add(BirthdayLabel)
        Me.GroupBox1.Controls.Add(Me.BirthdayDateTimePicker)
        Me.GroupBox1.Controls.Add(MajorLabel)
        Me.GroupBox1.Controls.Add(Me.MajorTextBox)
        Me.GroupBox1.Controls.Add(NameLabel1)
        Me.GroupBox1.Controls.Add(Me.NameTextBox1)
        Me.GroupBox1.Controls.Add(NumberLabel1)
        Me.GroupBox1.Controls.Add(Me.NumberTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 227)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "学生属性"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(134, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(215, 263)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MajorLabel
        '
        MajorLabel.AutoSize = True
        MajorLabel.Location = New System.Drawing.Point(51, 100)
        MajorLabel.Name = "MajorLabel"
        MajorLabel.Size = New System.Drawing.Size(35, 12)
        MajorLabel.TabIndex = 18
        MajorLabel.Text = "专业:"
        '
        'MajorTextBox
        '
        Me.MajorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Major", True))
        Me.MajorTextBox.Location = New System.Drawing.Point(101, 97)
        Me.MajorTextBox.Name = "MajorTextBox"
        Me.MajorTextBox.Size = New System.Drawing.Size(100, 21)
        Me.MajorTextBox.TabIndex = 2
        '
        'BirthdayLabel
        '
        BirthdayLabel.AutoSize = True
        BirthdayLabel.Location = New System.Drawing.Point(51, 132)
        BirthdayLabel.Name = "BirthdayLabel"
        BirthdayLabel.Size = New System.Drawing.Size(35, 12)
        BirthdayLabel.TabIndex = 19
        BirthdayLabel.Text = "生日:"
        '
        'BirthdayDateTimePicker
        '
        Me.BirthdayDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentBindingSource, "Birthday", True))
        Me.BirthdayDateTimePicker.Location = New System.Drawing.Point(101, 126)
        Me.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker"
        Me.BirthdayDateTimePicker.Size = New System.Drawing.Size(140, 21)
        Me.BirthdayDateTimePicker.TabIndex = 3
        '
        'AdmissionDateLabel
        '
        AdmissionDateLabel.AutoSize = True
        AdmissionDateLabel.Location = New System.Drawing.Point(27, 159)
        AdmissionDateLabel.Name = "AdmissionDateLabel"
        AdmissionDateLabel.Size = New System.Drawing.Size(59, 12)
        AdmissionDateLabel.TabIndex = 20
        AdmissionDateLabel.Text = "入学时间:"
        '
        'AdmissionDateDateTimePicker
        '
        Me.AdmissionDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentBindingSource, "AdmissionDate", True))
        Me.AdmissionDateDateTimePicker.Location = New System.Drawing.Point(101, 155)
        Me.AdmissionDateDateTimePicker.Name = "AdmissionDateDateTimePicker"
        Me.AdmissionDateDateTimePicker.Size = New System.Drawing.Size(140, 21)
        Me.AdmissionDateDateTimePicker.TabIndex = 4
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataSource = GetType(StudentAccommondation.Student)
        '
        'StudentEditor
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(314, 298)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudentEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentEditor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents NameTextBox1 As TextBox
    Friend WithEvents NumberTextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents AdmissionDateDateTimePicker As DateTimePicker
    Friend WithEvents BirthdayDateTimePicker As DateTimePicker
    Friend WithEvents MajorTextBox As TextBox
End Class
