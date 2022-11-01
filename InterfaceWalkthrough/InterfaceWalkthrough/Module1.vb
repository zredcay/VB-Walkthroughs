Imports System.Runtime.InteropServices

Module Module1
    Interface TestInterface
        Property Prop1() As Integer
        Sub Method1(ByVal X As Integer)
        Event Event1()
    End Interface
    Class ImplementationClass
        Implements TestInterface

        Private pval As Integer

        Public Property Prop1 As Integer Implements TestInterface.Prop1
            Get
                Return pval
            End Get
            Set(value As Integer)
                pval = value
            End Set
        End Property

        Public Event Event1() Implements TestInterface.Event1

        Public Sub Method1(X As Integer) Implements TestInterface.Method1
            MsgBox("The X parameter for Method1 is " & X)
            RaiseEvent Event1()
        End Sub
    End Class
End Module
