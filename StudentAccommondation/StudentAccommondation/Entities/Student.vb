Imports System
Imports System.Collections.Generic

Partial Public Class Student
    Public Property Id As Integer

    ''' <summary>
    ''' ѧ��
    ''' </summary>
    ''' <returns></returns>
    Public Property Number As String
    ''' <summary>
    ''' ����
    ''' </summary>
    ''' <returns></returns>
    Public Property Name As String
    ''' <summary>
    ''' רҵ
    ''' </summary>
    ''' <returns></returns>
    Public Property Major As String
    ''' <summary>
    ''' ��ѧʱ��
    ''' </summary>
    ''' <returns></returns>
    Public Property AdmissionDate As Date
    ''' <summary>
    ''' ����
    ''' </summary>
    ''' <returns></returns>
    Public Property Birthday As Date
    ''' <summary>
    ''' ����ʱ��
    ''' </summary>
    ''' <returns></returns>
    Public Property CreateTime As Date
    'Public Property RoomId As Integer
    Public Overridable Property Room As Room

End Class
