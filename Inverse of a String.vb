Module Module1

    Sub Main()
        Dim Str1 As String = ""
        Dim myChar As String = ""
        Dim Counter As Integer = 0
        Dim FinalStr As String = ""

        Console.Write("Enter String to inverse: ")
        Str1 = Console.ReadLine

        For Counter = Len(Str1) To 1 Step -1
            myChar = Mid(Str1, Counter, 1)
            FinalStr = FinalStr & myChar
        Next

        Console.WriteLine("Final String is: " & FinalStr)
        Console.ReadKey()
    End Sub

End Module
