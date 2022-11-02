Imports System.Runtime.InteropServices

<ComImport()>
<Guid("16BC804B-DB6D-440B-86BC-6CB4B59B4E87")>
Public Interface ISampleInterface
    Sub GetUserInput()
    ReadOnly Property UserInput As String
    Function GetDate() As Date
End Interface