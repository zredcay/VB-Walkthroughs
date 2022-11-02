<ComClass(MathFunctions.ClassId, MathFunctions.InterfaceId, MathFunctions.EventsId)>
Public Class MathFunctions

#Region "COM GUIDs"
    ' These  GUIDs provide the COM identity for this class 
    ' and its COM interfaces. If you change them, existing 
    ' clients will no longer be able to access the class.
    Public Const ClassId As String = "6f11e933-3d8d-4d11-a3b9-fdaec4140410"
    Public Const InterfaceId As String = "a4af79b6-ae8a-45fc-a714-b3431162199e"
    Public Const EventsId As String = "69556f6e-0b06-483d-b2ba-f03dd453c9ec"
#End Region

    ' A creatable COM class must have a Public Sub New() 
    ' with no parameters, otherwise, the class will not be 
    ' registered in the COM registry and cannot be created 
    ' via CreateObject.
    Public Sub New()
        MyBase.New()
    End Sub
    ' Local Variable to hold property value.
    Private mvarProp1 As Integer
    Public Property Prop1() As Integer
        Set(ByVal vData As Integer)
            ' Used when assigning a value to the property.
            mvarProp1 = vData

        End Set
        Get
            'Used when retrieving a property's value.
            Prop1 = mvarProp1
        End Get
    End Property
    Public Function AddNumbers(
                            ByVal SomeNumber As Integer,
                            ByVal AnotherNumber As Integer) As Integer
        AddNumbers = SomeNumber + AnotherNumber
    End Function

End Class


