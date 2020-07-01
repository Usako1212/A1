Imports System
Imports System.Collections.Generic

Partial Public Class Student
    Public Property Id As Integer

    ''' <summary>
    ''' 学号
    ''' </summary>
    ''' <returns></returns>
    Public Property Number As String
    ''' <summary>
    ''' 姓名
    ''' </summary>
    ''' <returns></returns>
    Public Property Name As String
    ''' <summary>
    ''' 专业
    ''' </summary>
    ''' <returns></returns>
    Public Property Major As String
    ''' <summary>
    ''' 入学时间
    ''' </summary>
    ''' <returns></returns>
    Public Property AdmissionDate As Date
    ''' <summary>
    ''' 生日
    ''' </summary>
    ''' <returns></returns>
    Public Property Birthday As Date
    ''' <summary>
    ''' 创建时间
    ''' </summary>
    ''' <returns></returns>
    Public Property CreateTime As Date
    'Public Property RoomId As Integer
    Public Overridable Property Room As Room

End Class
