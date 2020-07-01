Public Class RoomEditor

    Public Property RoomName As String
        Get
            Return NameTextBox1.Text
        End Get
        Set(value As String)
            NameTextBox1.Text = value
        End Set
    End Property

    Public Property Number As String
        Get
            Return NumberTextBox1.Text
        End Get
        Set(ByVal value As String)
            NumberTextBox1.Text = value
        End Set
    End Property

    Public Property BuildingNo As String
        Get
            Return BuildingNoTextBox1.Text
        End Get
        Set(ByVal value As String)
            BuildingNoTextBox1.Text = value
        End Set
    End Property

    Public Property FloorNo As String
        Get
            Return FloorNoTextBox.Text
        End Get
        Set(ByVal value As String)
            FloorNoTextBox.Text = value
        End Set
    End Property

    Public Property Capacity As Decimal
        Get
            Return NumericUpDown1.Value
        End Get
        Set(ByVal value As Decimal)
            NumericUpDown1.Value = value
        End Set
    End Property

End Class