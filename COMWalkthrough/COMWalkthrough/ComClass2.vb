<ComClass(ComClass2.ClassId, ComClass2.InterfaceId, ComClass2.EventsId)> _
Public Class ComClass2

#Region "COM GUIDs"
    ' These  GUIDs provide the COM identity for this class 
    ' and its COM interfaces. If you change them, existing 
    ' clients will no longer be able to access the class.
    Public Const ClassId As String = "0451425b-4529-42f1-a202-b6895fe50e6e"
    Public Const InterfaceId As String = "d78e03e4-4b98-4fff-a567-dae3a6d70790"
    Public Const EventsId As String = "97661d6c-613c-440c-a36f-59751747f952"
#End Region

    ' A creatable COM class must have a Public Sub New() 
    ' with no parameters, otherwise, the class will not be 
    ' registered in the COM registry and cannot be created 
    ' via CreateObject.
    Public Sub New()
        MyBase.New()
    End Sub

End Class


