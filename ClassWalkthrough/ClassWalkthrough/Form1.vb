Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create an instance of the class.
        Dim user As New UserNameInfo("Moore, Bobby")
        ' Capitalize the value of the property.
        user.Capitalize()
        ' Display the value of the property.
        MsgBox("The original UserName is: " & user.UserName)
        ' Change the value of the property.
        user.UserName = "Worden, Joe"
        ' Redisplay the value of the property.
        MsgBox("The new UserName is: " & user.UserName)
    End Sub
End Class
