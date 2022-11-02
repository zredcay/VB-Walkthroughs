Public Class StreamReaderEnumerator
    Implements IEnumerator(Of String)

    Private disposedValue As Boolean
    Private _sr As IO.StreamReader
    Private _current As String
    Public Sub New(ByVal filePath As String)
        _sr = New IO.StreamReader(filePath)
    End Sub
    Public ReadOnly Property Current As String Implements IEnumerator(Of String).Current
        Get
            If _sr Is Nothing OrElse _current Is Nothing Then
                Throw New InvalidOperationException()
            End If

            Return _current
        End Get
    End Property
    Private ReadOnly Property Current1() As Object _
    Implements IEnumerator.Current

        Get
            Return Me.Current
        End Get
    End Property

    Public Sub Reset() Implements IEnumerator.Reset

        _sr.DiscardBufferedData()
        _sr.BaseStream.Seek(0, IO.SeekOrigin.Begin)
        _current = Nothing
    End Sub

    Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext

        _current = _sr.ReadLine()
        If _current Is Nothing Then Return False
        Return True
    End Function

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' Dispose of managed resources
            End If
            _current = Nothing
            _sr.Close()
            _sr.Dispose()
        End If

        Me.disposedValue = True
    End Sub

    Protected Overrides Sub Finalize()
        Dispose(False)
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub
End Class
