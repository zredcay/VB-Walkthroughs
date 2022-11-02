Imports System.Runtime.InteropServices
Module Module1
    Public Const MB_ICONQUESTION As Integer = &H20
    Public Const MB_YESNO As Integer = &H4
    Public Const IDYES As Integer = 6
    Public Const IDNO As Integer = 7

    Declare Auto Function MBox Lib "user32.dll" Alias "MessageBox" (
        ByVal hWnd As Integer,
        ByVal txt As String,
        ByVal caption As String,
        ByVal Typ As Integer) As Integer
    Declare Sub SetData Lib "...\LIB\UnmgdLib.dll" (
        ByVal x As Short,
        <MarshalAsAttribute(UnmanagedType.AsAny)>
        ByVal o As Object)
End Module
