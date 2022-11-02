Imports System.Runtime.InteropServices
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Stores the return value.
        Dim RetVal As Integer
        RetVal = MBox(0, "Declare DLL Test", "Windows API MessageBox", MB_ICONQUESTION Or MB_YESNO)

        ' Check the return value.
        If RetVal = IDYES Then
            MsgBox("You chose Yes")
        Else
            MsgBox("You chose No")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim RetVal As Boolean = MoveFile(":c\tmp\Test.txt", "c:\Test.txt")
        If RetVal = True Then
            MsgBox("The file was moved successfully.")
        Else
            MsgBox("The file could not be moved.")
        End If
    End Sub

    <DllImport("KERNEL32.DLL", EntryPoint:="MoveFileW", SetLastError:=True,
    CharSet:=CharSet.Unicode, ExactSpelling:=True,
    CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function MoveFile(
    ByVal src As String,
    ByVal dst As String) As Boolean
        ' Leave the body of the function empty.
    End Function
End Class


