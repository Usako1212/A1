Public Class SetRoom
    Public Property StudentName As String
        Get
            Return Label1.Text
        End Get
        Set(ByVal value As String)
            Label1.Text = value
        End Set
    End Property

    Public Property Rooms() As List(Of Room)
        Get
            Return TryCast(RoomBindingSource.DataSource, List(Of Room))
        End Get
        Set(ByVal value As List(Of Room))
            RoomBindingSource.DataSource = value
        End Set
    End Property

    Public Property SelectedRoom() As Room
        Get
            Return RoomBindingSource.Current
        End Get
        Set(ByVal value As Room)
            Dim index = Rooms.IndexOf(value)
            RoomBindingSource.Position = index
        End Set
    End Property

End Class