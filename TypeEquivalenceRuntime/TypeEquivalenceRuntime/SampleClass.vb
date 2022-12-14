Imports TypeEquivalenceInterface

Public Class SampleClass
    Implements ISampleInterface

    Private p_UserInput As String
    Public ReadOnly Property UserInput() As String Implements ISampleInterface.UserInput
        Get
            Return p_UserInput
        End Get
    End Property

    Public Sub GetUserInput() Implements ISampleInterface.GetUserInput
        Console.WriteLine("Please enter a value:")
        p_UserInput = Console.ReadLine()
    End Sub
    Public Function GetDate() As DateTime Implements ISampleInterface.GetDate
        Return Now
    End Function
End Class