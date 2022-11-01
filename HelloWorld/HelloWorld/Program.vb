Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("What is your name?")
        Dim name = Console.ReadLine()
        Dim currentDate = DateTime.Now
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}")
        Console.Write($"{Environment.NewLine}Press any key to exit...")
        Console.ReadKey(True)
    End Sub
End Module
