Imports GFUDemo_VB
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class AutomobileTest

    <TestMethod()> Public Sub DefaultAutomobileIsInitializedCorrectly()
        Dim myAuto = New Automobile()
        Assert.IsTrue((myAuto.Model = "Not Specified") And (myAuto.TopSpeed = -1))
    End Sub
    <TestMethod()> Public Sub AutomobileWithModelNameCanStart()
        Dim model As String = "Contoso"
        Dim topSpeed As Integer = 199
        Dim myAuto As New Automobile(model, topSpeed)
        myAuto.Start()
        Assert.IsTrue(myAuto.IsRunning = True)
    End Sub
End Class