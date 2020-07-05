Imports System.Collections.ObjectModel

Namespace My
    ' 以下事件可用于 MyApplication: 
    ' Startup:应用程序启动时在创建启动窗体之前引发。
    ' Shutdown:在关闭所有应用程序窗体后引发。如果应用程序非正常终止，则不会引发此事件。
    ' UnhandledException:在应用程序遇到未经处理的异常时引发。
    ' StartupNextInstance:在启动单实例应用程序且应用程序已处于活动状态时引发。 
    ' NetworkAvailabilityChanged:在连接或断开网络连接时引发。
    Partial Friend Class MyApplication
        Protected Overrides Function OnInitialize(commandLineArgs As ReadOnlyCollection(Of String)) As Boolean
            Dim login = New Login()
            Dim veritied = False
            For index = 1 To 3
                Dim dr = login.ShowDialog()
                If dr = DialogResult.Cancel Then
                    Return False
                End If
                If dr = DialogResult.OK Then
                    Dim db = New StudentDbcontext()
                    If Not (login.UseName = "admin" And login.Password = "123qwe") Then
                        login.Password = ""
                        Continue For
                    Else
                        veritied = True
                        Exit For
                    End If
                End If
            Next
            If veritied Then
                Return MyBase.OnInitialize(commandLineArgs)
            End If
        End Function
    End Class
End Namespace
