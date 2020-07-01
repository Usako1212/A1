Imports System
Imports System.Collections.Generic

Partial Public Class Room
    Public Property Id As Integer
    Public Property Name As String
    Public Property Number As String
    Public Property BuildingNo As String
    Public Property FloorNo As String
    Public Property Capacity As Short
    Public Overridable Property Students As ICollection(Of Student) = New HashSet(Of Student)
End Class
