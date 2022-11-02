Imports System.ComponentModel

<Serializable()>
Public Class Loan
    Implements System.ComponentModel.INotifyPropertyChanged

    Public Property LoanAmount As Double
    Public Property InterestRate As Double
    Public Property Term As Integer

    Private p_Customer As String
    Public Property Customer As String
        Get
            Return p_Customer
        End Get
        Set(value As String)
            p_Customer = value
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("Customer"))
        End Set
    End Property

    <NonSerialized()>
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub New(ByVal LoanAmount As Double,
                   ByVal interestRate As Double,
                   ByVal term As Integer,
                   ByVal customer As String)
        Me.LoanAmount = LoanAmount
        Me.InterestRate = interestRate
        Me.Term = term
        p_Customer = customer
    End Sub
End Class
