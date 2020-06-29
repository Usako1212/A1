<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.宿舍ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.学生ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.统计分析ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
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
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.关于ToolStripMenuItem.Text = "关于..."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "学生住宿管理系统v1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
End Class
