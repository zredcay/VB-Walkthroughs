Imports Microsoft.VisualBasic.DateAndTime

Public Class Widget
    Public Event PercentDone(ByVal Percent As Single,
                         ByRef Cancel As Boolean)
    Public Sub LongTask(ByVal Duration As Single,
                        ByVal MinimumInterval As Single)
        Dim Threshold As Single
        Dim Start As Single
        Dim blnCancel As Boolean

        ' The Timer property of the DateAndTime object returns the seconds
        ' and milliseconds that have passed since midnight.
        Start = CSng(Timer)
        Threshold = MinimumInterval

        Do While CSng(Timer) < (Start + Duration)
            ' In a real application, some unit of work would
            ' be done here each time through the loop.
            If CSng(Timer) > (Start + Threshold) Then
                RaiseEvent PercentDone(
                    Threshold / Duration, blnCancel)
                ' Check to see if the operation was canceled.
                If blnCancel Then Exit Sub
                Threshold = Threshold + MinimumInterval
            End If
        Loop
    End Sub
End Class
