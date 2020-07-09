
Imports System.Data.Entity
Imports System.Data.Entity.Core.Common.CommandTrees
Imports System.Data.Entity.Validation

Public Class MainForm
    Private CurrentView As ViewType

    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        Dim aboutBox = New AboutBox()
        aboutBox.ShowDialog()
    End Sub

    Private Sub 宿舍ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 宿舍ToolStripMenuItem.Click
        CurrentView = ViewType.Room
        ToolStripLabel1.Text = "房间视图"
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Number, NameDataGridViewTextBoxColumn, Capacity, BuildingNoDataGridViewTextBoxColumn, FloorNoDataGridViewTextBoxColumn, StudentsDataGridViewTextBoxColumn})
        ToolStripTextBox1.Text = ""
        RefreshRoomView()
    End Sub

    Private Sub RefreshRoomView(Optional keyword As String = "")
        Dim db = New StudentDbcontext()
        Dim list = db.Rooms.Include("students")
        If Not String.IsNullOrWhiteSpace(keyword) Then
            list = list.Where(Function(r) r.Number.Contains(keyword) Or r.Name.Contains(keyword) Or r.BuildingNo.Contains(keyword) Or r.FloorNo.Contains(keyword))
        End If
        Dim viewList = list.AsEnumerable().Select(Function(r) _
            New RoomView With {
                .Id = r.Id,
                .Name = r.Name,
                .Number = r.Number,
                .BuildingNo = r.BuildingNo,
                .Capacity = r.Capacity,
                .FloorNo = r.FloorNo,
                .Students = String.Join(",", r.Students.Select(Function(s) s.Name).ToArray())})

        BindingSource1.DataSource = viewList.ToList()
        If Not DataGridView1.Visible Then
            DataGridView1.Show()
        End If
    End Sub

    Private Sub RefreshStudentView(Optional keyword As String = "")
        Dim db = New StudentDbcontext()
        Dim list = db.Students.Include(Function(s) s.Room)
        If Not String.IsNullOrWhiteSpace(keyword) Then
            list = list.Where(Function(r) r.Number.Contains(keyword) Or r.Name.Contains(keyword) Or r.Major.Contains(keyword) Or r.Room.Name.Contains(keyword) Or r.Room.Number.Contains(keyword))
        End If
        Dim viewList = list.ToList().Select(Function(s) _
            New StudentView With {
                .Id = s.Id,
                .Name = s.Name,
                .Number = s.Number,
                .AdmissionDate = s.AdmissionDate,
                .Birthday = s.Birthday,
                .Major = s.Major,
                .RoomName = If(s.Room?.Name, "")
            }).ToList()

        BindingSource1.DataSource = viewList.ToList()
        If Not DataGridView1.Visible Then
            DataGridView1.Show()
        End If
    End Sub


    Private Sub tb_AddRoom_Click(sender As Object, e As EventArgs) Handles tb_AddRoom.Click
        Dim RoomAdd As RoomEditor = New RoomEditor With {
            .Text = "创建房间"
        }
        Dim dr = RoomAdd.ShowDialog()
        If dr = DialogResult.OK Then
            Dim db = New StudentDbcontext()
            db.Rooms.Add(New Room With {
                .BuildingNo = RoomAdd.BuildingNo,
                .Capacity = RoomAdd.Capacity,
                .FloorNo = RoomAdd.FloorNo,
                .Name = RoomAdd.RoomName,
                .Number = RoomAdd.Number
                         })
            db.SaveChanges()
            If CurrentView = ViewType.Room Then
                RefreshRoomView()
            End If
        End If
    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged
        Dim flag As Boolean = Not IsNothing(BindingSource1.Current)
        If CurrentView = ViewType.Room Then
            tb_EditRoom.Enabled = flag
            tb_deleteRoom.Enabled = flag
            tb_EditStudent.Enabled = False
            tb_deleteStudent.Enabled = False
            TB_ChangeRoom.Enabled = False
        End If
        If CurrentView = ViewType.Student Then
            tb_EditRoom.Enabled = False
            tb_deleteRoom.Enabled = False
            tb_EditStudent.Enabled = flag
            TB_ChangeRoom.Enabled = flag
            tb_deleteStudent.Enabled = flag
        End If
    End Sub

    Private Sub tb_EditRoom_Click(sender As Object, e As EventArgs) Handles tb_EditRoom.Click
        Dim roomview = TryCast(BindingSource1.Current, RoomView)
        Dim db = New StudentDbcontext()
        Dim room = db.Rooms.Find(roomview.Id)

        Dim RoomEdit As RoomEditor = New RoomEditor With {
            .Text = "编辑房间",
            .RoomName = room.Name,
            .Number = room.Number,
            .Capacity = room.Capacity,
            .BuildingNo = room.BuildingNo,
            .FloorNo = room.FloorNo
        }
        Dim dr = RoomEdit.ShowDialog()
        If dr = DialogResult.OK Then
            room.BuildingNo = RoomEdit.BuildingNo
            room.Capacity = RoomEdit.Capacity
            room.FloorNo = RoomEdit.FloorNo
            room.Name = RoomEdit.RoomName
            room.Number = RoomEdit.Number
            db.SaveChanges()
            If CurrentView = ViewType.Room Then
                RefreshRoomView()
            End If
        End If
    End Sub

    Private Sub tb_deleteRoom_Click(sender As Object, e As EventArgs) Handles tb_deleteRoom.Click
        Dim db = New StudentDbcontext()
        Dim room = db.Rooms.Find(TryCast(BindingSource1.Current, RoomView).Id)
        Dim r = MsgBox($"确认要删除当前房间{room.Name}吗?", MsgBoxStyle.OkCancel, "请确认")
        If r = MsgBoxResult.Ok Then
            db.Rooms.Remove(room)
            db.SaveChanges()
            If CurrentView = ViewType.Room Then
                RefreshRoomView()
            End If
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrentView = ViewType.NoView
    End Sub

    Private Sub 学生ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 学生ToolStripMenuItem.Click
        CurrentView = ViewType.Student
        ToolStripLabel1.Text = "学生视图"
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {NameDataGridViewTextBoxColumn1, NumberDataGridViewTextBoxColumn, Major, AdmissionDate, Birthday, RoomName})
        ToolStripTextBox1.Text = ""
        RefreshStudentView()
    End Sub

    Private Sub tb_deleteStudent_Click(sender As Object, e As EventArgs) Handles tb_deleteStudent.Click
        Dim db = New StudentDbcontext()
        Dim student = db.Students.Find(TryCast(BindingSource1.Current, StudentView).Id)
        Dim r = MsgBox($"确认要删除{student.Name}吗?", MsgBoxStyle.OkCancel, "请确认")
        If r = MsgBoxResult.Ok Then
            db.Students.Remove(student)
            db.SaveChanges()
            If CurrentView = ViewType.Student Then
                RefreshStudentView()
            End If
        End If
    End Sub

    Private Sub tb_AddStudent_Click(sender As Object, e As EventArgs) Handles tb_AddStudent.Click
        Dim studentAdd As StudentEditor = New StudentEditor With {
           .Text = "创建学生档案"
       }
        Dim dr = studentAdd.ShowDialog()
        If dr = DialogResult.OK Then
            Dim db = New StudentDbcontext()
            db.Students.Add(New Student With {
                .Birthday = studentAdd.Birthday,
                .AdmissionDate = studentAdd.AdmissionDate,
                .Major = studentAdd.Major,
                .Name = studentAdd.StudentName,
                .Number = studentAdd.Number,
                .CreateTime = Date.Now,
                .Room = Nothing
                         })
            db.SaveChanges()
            If CurrentView = ViewType.Student Then
                RefreshStudentView()
            End If
        End If
    End Sub

    Private Sub tb_EditStudent_Click(sender As Object, e As EventArgs) Handles tb_EditStudent.Click
        Dim studentView = TryCast(BindingSource1.Current, StudentView)
        Dim db = New StudentDbcontext()
        Dim student = db.Students.Find(studentView.Id)

        Dim StudentEdit As StudentEditor = New StudentEditor With {
            .Text = "编辑学生档案",
            .Major = student.Major,
            .StudentName = student.Name,
            .Number = student.Number,
            .Birthday = student.Birthday,
            .AdmissionDate = student.AdmissionDate
        }
        Dim dr = StudentEdit.ShowDialog()
        If dr = DialogResult.OK Then
            student.Major = StudentEdit.Major
            student.AdmissionDate = StudentEdit.AdmissionDate
            student.Birthday = StudentEdit.Birthday
            student.Name = StudentEdit.StudentName
            student.Number = StudentEdit.Number
            db.SaveChanges()
            If CurrentView = ViewType.Student Then
                RefreshStudentView()
            End If
        End If
    End Sub

    Private Sub TB_ChangeRoom_Click(sender As Object, e As EventArgs) Handles TB_ChangeRoom.Click
        Dim studentView = TryCast(BindingSource1.Current, StudentView)
        Using db As New StudentDbcontext()
            db.Configuration.ProxyCreationEnabled = False
            Dim student = db.Students.Include(Function(s) s.Room).Single(Function(s) s.Id = studentView.Id)
            Dim roomlist = db.Rooms.Include(Function(r) r.Students).Where(Function(r) r.Students.Count < r.Capacity).ToList()
            Dim RoomChanger = New SetRoom With {
                .StudentName = studentView.Name,
                .Rooms = roomlist,
                .SelectedRoom = student.Room
            }
            Dim dr = RoomChanger.ShowDialog()
            If dr = DialogResult.OK Then
                '更新学生的房间数据
                student.Room = Nothing
                db.SaveChanges()
                student.Room = RoomChanger.SelectedRoom
                db.SaveChanges()
            ElseIf dr = DialogResult.Yes Then
                student.Room = Nothing
                db.SaveChanges()
            End If
            If Not dr = DialogResult.Cancel And CurrentView = ViewType.Student Then
                RefreshStudentView()
            End If
        End Using
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        If CurrentView = ViewType.Room Then
            RefreshRoomView(ToolStripTextBox1.Text)
        Else
            RefreshStudentView(ToolStripTextBox1.Text)
        End If
    End Sub
End Class
