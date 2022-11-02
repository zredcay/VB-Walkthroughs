Public Class MathClass
    Inherits MathFunctions
    ' This method overloads the method AddNumbers from the base class.
    Public Overloads Function AddNumbers(
                                 ByVal SomeNumber As Integer,
                                 ByVal AnotherNumber As Integer) As Integer

        Return SomeNumber + AnotherNumber
    End Function
    Public Function SubtractNumbers(
                            ByVal SomeNumber As Integer,
                            ByVal AnotherNumber As Integer) As Integer
        Return AnotherNumber - SomeNumber
    End Function
End Class
