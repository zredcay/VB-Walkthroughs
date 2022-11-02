Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Form1
    Const FileName As String = "..\..\SavedLoan.bin"
    Private WithEvents TestLoan As New LoanClass.Loan(10000.0, 0.075, 36, "Neil Black")

    Private Sub Form1_Load() Handles MyBase.Load
        If File.Exists(FileName) Then
            Dim TestFileStream As Stream = File.OpenRead(FileName)
            Dim Deserializer As New BinaryFormatter
            TestLoan = CType(Deserializer.Deserialize(TestFileStream), LoanClass.Loan)
            TestFileStream.Close()
        End If

        AddHandler TestLoan.PropertyChanged, AddressOf Me.CustomerPropertyChanged

        TextBox1.Text = TestLoan.LoanAmount.ToString
        TextBox2.Text = TestLoan.InterestRate.ToString
        TextBox3.Text = TestLoan.Term.ToString
        TextBox4.Text = TestLoan.Customer.ToString
    End Sub

    Public Sub CustomerPropertyChanged(
                                      ByVal sender As Object,
                                      ByVal e As System.ComponentModel.PropertyChangedEventArgs
                                      ) Handles TestLoan.PropertyChanged
        MsgBox(e.PropertyName & " has been changed.")
    End Sub

    Private Sub Form1_FormClosing() Handles MyBase.FormClosing
        TestLoan.LoanAmount = CDbl(TextBox1.Text)
        TestLoan.InterestRate = CDbl(TextBox2.Text)
        TestLoan.Term = CInt(TextBox3.Text)
        TestLoan.Customer = TextBox4.Text

        Dim TestFileStream As Stream = File.Create(FileName)
        Dim serializer As New BinaryFormatter
        serializer.Serialize(TestFileStream, TestLoan)
        TestFileStream.Close()
    End Sub
End Class
