Imports System.CodeDom
Imports System.IO
Imports System.Transactions

Public Class Form1
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim fw As StreamWriter

        Dim ReadString As String

        If (Entry.Text = "" Or Entry.Text = "Please enter something.") Then
            Entry.Text = "Please enter something."
            Return
        End If
        Try
            ' Pass the file path and name to the StreamWriter constructor.
            ' Indicate that Append is True, so file will not be overwritten.
            fw = New StreamWriter("C:\tmp\MyDiary.txt", True)
            Dim Today As DateTime
            Today = Now
            fw.Write(CStr(Today))
            fw.Write(ControlChars.CrLf)
            ReadString = Entry.Text
            fw.WriteLine(ReadString)
        Finally
            ' Close the file.
            fw.Close()

        End Try
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Entry.Text = ""
    End Sub

    Private Sub GetEntries_Click(sender As Object, e As EventArgs) Handles GetEntries.Click
        Dim fr As StreamReader = Nothing
        Dim FileString As String
        FileString = ""
        Try
            fr = New System.IO.StreamReader("C:\tmp\MyDiary.txt")
            PickEntries.Items.Clear()
            PickEntries.Enabled = True
            Do
                FileString = fr.ReadLine
                If IsDate(FileString) Then
                    PickEntries.Items.Add(FileString)
                End If
            Loop Until (FileString Is Nothing)
        Finally
            If fr IsNot Nothing Then
                fr.Close()
            End If
        End Try
        PickEntries.Enabled = True
    End Sub

    Private Sub Display_Click(sender As Object, e As EventArgs) Handles Display.Click
        Dim fr As StreamReader
        Dim ReadString As String
        ' Make sure ReadString begins empty.
        ReadString = ""
        Dim FileString As String
        fr = New StreamReader("C:\tmp\MyDiary.txt")
        ' If no entry has been selected, show the whole file.
        If PickEntries.Enabled = False Or PickEntries.SelectedText Is Nothing Then
            Do
                ' Read a line from the file into FileString.
                FileString = fr.ReadLine
                ' Add it to ReadString
                ReadString = ReadString & ControlChars.CrLf & FileString
            Loop Until (FileString = Nothing)
        Else
            ' An entry has been selected, find the line that matches.
            Do

                FileString = fr.ReadLine
            Loop Until FileString = CStr(PickEntries.SelectedItem)
            FileString = CStr(PickEntries.SelectedItem) & ControlChars.CrLf
            ReadString = ReadString & fr.ReadLine

            ' Read from the file until EOF or another Date is found.
            Do Until ((fr.Peek < 0) Or (IsDate(fr.ReadLine)))
                ReadString = ReadString & fr.ReadLine
            Loop
        End If
        fr.Close()
        DisplayEntry.Visible = True
        DisplayEntry.Text = ReadString
        DeleteEntry.Enabled = True
        EditEntry.Enabled = True
    End Sub

    Private Sub DeleteEntry_Click(sender As Object, e As EventArgs) Handles DeleteEntry.Click
        Dim fr As StreamReader
        Dim ReadString As String
        Dim WriteString As String
        Dim ConfirmDelete As MsgBoxResult
        fr = New StreamReader("C:\tmp\MyDiary.txt")
        ReadString = fr.ReadLine
        ' Read through the text file.
        Do Until (fr.Peek < 0)
            ReadString = ReadString & vbCrLf & fr.ReadLine
        Loop
        WriteString = Replace(ReadString, DisplayEntry.Text, "")
        fr.Close()
        ' Check to make sure th euser wishes to delete the entry.
        ConfirmDelete = MsgBox("Do you really wish to delete this entry?", MsgBoxStyle.OkCancel)
        If ConfirmDelete = MsgBoxResult.Ok Then
            File.Delete("C:\tmp\MyDiary.txt")
            Dim fw As StreamWriter = File.CreateText("C:\tmp\MyDiary.txt")
            fw.WriteLine(WriteString)
            fw.Close()
            ' Reset controls on the form.
            DisplayEntry.Text = ""
            PickEntries.Text = ""
            PickEntries.Items.Clear()
            PickEntries.Enabled = False
            DeleteEntry.Enabled = False
        End If
    End Sub

    Private Sub EditEntry_Click(sender As Object, e As EventArgs) Handles EditEntry.Click
        Entry.Text = DisplayEntry.Text
        SubmitEdit.Enabled = True
    End Sub

    Private Sub SubmitEdit_Click(sender As Object, e As EventArgs) Handles SubmitEdit.Click
        Dim fr As StreamReader
        Dim ReadString As String
        Dim WriteString As String
        If Entry.Text = "" Then
            MsgBox("Use Delete to Delete an Entry")
            Return
        End If
        fr = New StreamReader("C:\tmp\MyDiary.txt")
        ReadString = fr.ReadLine
        Do Until (fr.Peek < 0)
            ReadString = ReadString & vbCrLf & fr.ReadLine
        Loop
        WriteString = Replace(ReadString, DisplayEntry.Text, Entry.Text)
        fr.Close()
        File.Delete("C:\tmp\MyDiary.txt")
        Dim fw As StreamWriter = File.CreateText("C:\tmp\MyDiary.txt")
        fw.WriteLine(WriteString)
        fw.Close()
        DisplayEntry.Text = Entry.Text
        Entry.Text = ""
        EditEntry.Enabled = False
        SubmitEdit.Enabled = False
    End Sub
End Class
