Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Activity tracing information
        My.Application.Log.WriteEntry("Entering Button1_Click", TraceEventType.Start)

        ' Tracing information
        My.Application.Log.WriteEntry("In Button1_Click", TraceEventType.Information)

        ' Create an exception to log.
        Dim ex As New ApplicationException
        ' Exception Information
        My.Application.Log.WriteException(ex)

        ' Activity tracing information
        My.Application.Log.WriteEntry("Leaving Button1_Click", TraceEventType.Stop)

        Dim sL As New SimpleListener
        sL.DisplaySimpleListenerStrongName()
    End Sub
End Class
