Public Class Automobile
    Sub New()
        Model = "Not Specified"
        TopSpeed = -1
        IsRunning = True
    End Sub

    Public Sub New(model As String, topSpeed As Integer)
        Me.Model = model
        Me.TopSpeed = topSpeed
    End Sub

    Public Property Model As String
    Public Property TopSpeed As Integer
    Public Property IsRunning As Boolean

    Public Sub Start()
        If Model <> "Not specified" Or TopSpeed <> -1 Then
            IsRunning = True
        Else
            IsRunning = False
        End If
    End Sub
End Class
