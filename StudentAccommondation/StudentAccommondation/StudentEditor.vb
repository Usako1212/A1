Public Class StudentEditor

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

    Public Property Major As String
        Get
            Return MajorTextBox.Text
        End Get
        Set(ByVal value As String)
            MajorTextBox.Text = value
        End Set
    End Property

    Public Property Birthday As Date
        Get
            Return BirthdayDateTimePicker.Text
        End Get
        Set(ByVal value As Date)
            BirthdayDateTimePicker.Text = value
        End Set
    End Property

    Public Property AdmissionDate As Date
        Get
            Return AdmissionDateDateTimePicker.Value
        End Get
        Set(ByVal value As Date)
            AdmissionDateDateTimePicker.Value = value
        End Set
    End Property

End Class