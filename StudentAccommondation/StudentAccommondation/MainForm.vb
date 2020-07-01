
Public Class MainForm
    Private CurrentView As ViewType

    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        Dim aboutBox = New AboutBox()
        aboutBox.ShowDialog()
    End Sub

    Private Sub 宿舍ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 宿舍ToolStripMenuItem.Click
        CurrentView = ViewType.Room
        ToolStripLabel1.Text = "房间视图"
        RefreshRoomView()
    End Sub

    Private Sub RefreshRoomView()
        Dim db = New StudentDbcontext()
        Dim list = db.Rooms.Include("students").AsEnumerable().Select(Function(r) _
            New RoomView With {
                .Id = r.Id,
                .Name = r.Name,
                .Number = r.Number,
                .BuildingNo = r.BuildingNo,
                .Capacity = r.Capacity,
                .FloorNo = r.FloorNo,
                .Students = String.Join(",", r.Students.Select(Function(s) s.Name).ToArray())})

        BindingSource1.DataSource = list.ToList()
        If Not DataGridView1.Visible Then
            DataGridView1.Show()
        End If
    End Sub

    Private Sub RefreshStudentView()
        Dim db = New StudentDbcontext()
        Dim list = db.Students.Include("Room").AsEnumerable().Select(Function(r) _
            New StudentView With {
                .Id = r.Id,
                .Name = r.Name,
                .Number = r.Number,
                .AdmissionDate = r.AdmissionDate,
                .Birthday = r.Birthday,
                .Major = r.Major,
                .RoomName = r.Room?.Name})

        BindingSource1.DataSource = list.ToList()
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
        End If
        If CurrentView = ViewType.Student Then
            tb_EditRoom.Enabled = False
            tb_deleteRoom.Enabled = False
            tb_EditStudent.Enabled = flag
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
                .Name = studentAdd.RoomName,
                .Number = studentAdd.Number,
                .CreateTime = Date.Now
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
            .Name = student.Name,
            .Number = student.Number,
            .Birthday = student.Birthday,
            .AdmissionDate = student.AdmissionDate
        }
        Dim dr = StudentEdit.ShowDialog()
        If dr = DialogResult.OK Then
            student.Major = StudentEdit.Major
            student.AdmissionDate = StudentEdit.AdmissionDate
            student.Birthday = StudentEdit.Birthday
            student.Name = StudentEdit.RoomName
            student.Number = StudentEdit.Number
            db.SaveChanges()
            If CurrentView = ViewType.Student Then
                RefreshStudentView()
            End If
        End If
    End Sub
End Class
