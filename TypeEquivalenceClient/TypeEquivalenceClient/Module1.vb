Imports System.Reflection
Imports TypeEquivalenceInterface

Module Module1

    Sub Main()
        Dim sampleAssembly = Assembly.Load("TypeEquivalenceRuntime")
        Dim sampleClass As ISampleInterface = CType(
            sampleAssembly.CreateInstance("TypeEquivalenceRuntime.SampleClass"), ISampleInterface)
        sampleClass.GetUserInput()
        Console.WriteLine(sampleClass.UserInput)
        Console.WriteLine(sampleAssembly.GetName().Version)
        Console.ReadLine()
    End Sub

End Module