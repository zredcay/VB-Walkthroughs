Public Class SimpleListener
    Inherits System.Diagnostics.TraceListener

    <Security.Permissions.HostProtection(Synchronization:=True)>
    Public Overloads Overrides Sub Write(ByVal message As String)
        MsgBox("Write: " & message)
    End Sub

    <Security.Permissions.HostProtection(Synchronization:=True)>
    Public Overloads Overrides Sub WriteLine(ByVal message As String)
        MsgBox("WriteLine: " & message)
    End Sub
    Public Sub DisplaySimpleListenerStrongName()
        Dim t As Type = GetType(SimpleListener)
        MsgBox(t.FullName & ", " & t.Assembly.FullName)
    End Sub
End Class
