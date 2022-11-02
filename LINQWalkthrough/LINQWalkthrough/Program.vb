Imports System

Module Program
    Sub Main()
        ' Create a list of students.
        Dim students = GetStudents()
        ' Display the names in the list.
        DisplayList(students)
        Console.WriteLine()
        Dim studentQuery = From currentStudent In students
                           Where currentStudent.Rank <= 10
                           Order By currentStudent.Last Ascending, currentStudent.First Ascending
                           Select currentStudent
        For Each studentRecord In studentQuery
            Console.WriteLine(studentRecord.Last & ", " & studentRecord.First)
        Next
        Console.WriteLine()
        Dim studentQuery2 = From currentStudent In students
                            Let name = currentStudent.Last & ", " & currentStudent.First
                            Where currentStudent.Year = "Senior" And currentStudent.Rank <= 10
                            Order By name Ascending
                            Select currentStudent
        For Each studentRecord In studentQuery2
            Console.WriteLine(studentRecord.Last & ", " & studentRecord.First)
        Next
        Console.WriteLine()
        Dim studentQuery3 = From currentStudent In students
                            Where currentStudent.Last = "Garcia"
                            Select currentStudent.First

        ' If you see too many results, comment out the previous
        ' For Each loops.
        For Each studentRecord In studentQuery3
            Console.WriteLine(studentRecord)
        Next
        Console.WriteLine()
        Dim studentQuery4 =
                From currentStudent In students
                Where currentStudent.Year = "Senior" And currentStudent.Rank <= 10
                Order By currentStudent.Rank Ascending
                Select currentStudent.First, currentStudent.Last, currentStudent.Rank

        ' If you see too many results, comment out the previous
        ' For Each loops.
        For Each studentRecord In studentQuery4
            Console.WriteLine(studentRecord.Last & ", " & studentRecord.First &
                      ":  " & studentRecord.Rank)
        Next
        Console.WriteLine()

        ' Find all students who are seniors.
        Dim q1 = From currentStudent In students
                 Where currentStudent.Year = "Senior"
                 Select currentStudent

        ' Write a For Each loop to execute the query.
        For Each q In q1
            Console.WriteLine(q.First & " " & q.Last)
        Next
        Console.WriteLine()

        ' Find all students with a first name beginning with "C".
        Dim q2 = From currentStudent In students
                 Where currentStudent.First.StartsWith("C")
                 Select currentStudent
        Console.WriteLine()

        ' Find all top ranked seniors (rank < 40).
        Dim q3 = From currentStudent In students
                 Where currentStudent.Rank < 40 And currentStudent.Year = "Senior"
                 Select currentStudent
        Console.WriteLine()

        ' Find all seniors with a lower rank than a student who 
        ' is not a senior.
        Dim q4 = From student1 In students, student2 In students
                 Where student1.Year = "Senior" And student2.Year <> "Senior" And
               student1.Rank > student2.Rank
                 Select student1
                 Distinct
        Console.WriteLine()

        ' Retrieve the full names of all students, sorted by last name.
        Dim q5 = From currentStudent In students
                 Order By currentStudent.Last
                 Select Name = currentStudent.First & " " & currentStudent.Last
        Console.WriteLine()

        ' Determine how many students are ranked in the top 20.
        Dim q6 = Aggregate currentStudent In students
         Where currentStudent.Rank <= 20
         Into Count()
        Console.WriteLine()

        ' Count the number of different last names in the group of students.
        Dim q7 = Aggregate currentStudent In students
         Select currentStudent.Last
         Distinct
         Into Count()
        Console.WriteLine()

        ' Create a list box to show the last names of students.
        Dim lb As New System.Windows.Forms.ListBox
        Dim q8 = From currentStudent In students
                 Order By currentStudent.Last
                 Select currentStudent.Last Distinct

        For Each nextName As String In q8
            lb.Items.Add(nextName)
        Next
        Console.WriteLine()

        ' Find every process that has a lowercase "h", "l", or "d" in its name.
        Dim letters() As String = {"h", "l", "d"}
        Dim q9 = From proc In System.Diagnostics.Process.GetProcesses,
         letter In letters
                 Where proc.ProcessName.Contains(letter)
                 Select proc

        For Each proc In q9
            Console.WriteLine(proc.ProcessName & ", " & proc.WorkingSet64)
        Next
        Console.WriteLine()

        Console.ReadLine()
    End Sub

    ' Call DisplayList to see the names of the names of the students in the list.
    ' You can expand this method to see other student properties.
    Sub DisplayList(ByVal studentCol As IEnumerable(Of Student))
        For Each st As Student In studentCol
            Console.WriteLine("First Name " & st.First)
            Console.WriteLine(" Last Name " & st.Last)
            Console.WriteLine()
        Next
    End Sub

    ' Function GetStudents returns a list of Student objects.
    Function GetStudents() As IEnumerable(Of Student)
        Return New List(Of Student) From
            {
             New Student("Michael", "Tucker", "Junior", 10),
             New Student("Svetlana", "Omelchenko", "Senior", 2),
             New Student("Michiko", "Osada", "Senior", 7),
             New Student("Sven", "Mortensen", "Freshman", 53),
             New Student("Hugo", "Garcia", "Junior", 16),
             New Student("Cesar", "Garcia", "Freshman", 4),
             New Student("Fadi", "Fakhouri", "Senior", 72),
             New Student("Hanying", "Feng", "Senior", 11),
             New Student("Debra", "Garcia", "Junior", 41),
             New Student("Lance", "Tucker", "Junior", 60),
             New Student("Terry", "Adams", "Senior", 6),
             New Student("Zach", "Redcay", "Senior", 18)
            }
    End Function

    ' Each student has a first name, a last name, a class year, and 
    ' a rank that indicates academic ranking in the student body.
    Public Class Student
        Public Property First As String
        Public Property Last As String
        Public Property Year As String
        Public Property Rank As Integer
        Public Sub New()

        End Sub
        Public Sub New(ByVal firstName As String,
                       ByVal lastName As String,
                       ByVal studentYear As String,
                       ByVal studentRank As Integer)
            First = firstName
            Last = lastName
            Year = studentYear
            Rank = studentRank
        End Sub
    End Class
End Module
