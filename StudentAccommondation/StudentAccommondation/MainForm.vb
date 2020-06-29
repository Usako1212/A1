Public Class MainForm
    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        Dim aboutBox = New AboutBox()
        aboutBox.ShowDialog()
    End Sub
End Class
