Imports System.Windows.Forms

Public Class Login
    Public Property UseName As String
        Get
            Return TextBox1.Text
        End Get
        Set(ByVal value As String)
            TextBox1.Text = value
        End Set
    End Property
    Public Property Password As String
        Get
            Return TextBox2.Text
        End Get
        Set(ByVal value As String)
            TextBox2.Text = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

End Class
