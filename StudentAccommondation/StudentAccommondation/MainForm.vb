
Public Class MainForm
    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        Dim aboutBox = New AboutBox()
        aboutBox.ShowDialog()
    End Sub

    Private Sub 宿舍ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 宿舍ToolStripMenuItem.Click
        Dim db = New StudentDbcontext()
        Dim list = From r In db.Rooms
                   Select New RoomView() With {
                       .Id = r.Id,
                       .Name = r.Name,
                       .BuildingNo = r.BuildingNo,
                       .FloorNo = r.FloorNo,
                       .Students = ""
                   }

        BindingSource1.DataSource = list.ToList()
    End Sub
End Class
