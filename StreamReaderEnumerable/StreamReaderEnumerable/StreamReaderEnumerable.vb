Public Class StreamReaderEnumerable
    Implements IEnumerable(Of String)
    Private _filePath As String
    Public Sub New(ByVal filePath As String)
        _filePath = filePath
    End Sub
    Public Function GetEnumerator() As IEnumerator(Of String) _
    Implements IEnumerable(Of String).GetEnumerator

        Return New StreamReaderEnumerator(_filePath)
    End Function
    Private Function GetEnumerator1() As IEnumerator _
    Implements IEnumerable.GetEnumerator

        Return Me.GetEnumerator()
    End Function

End Class
