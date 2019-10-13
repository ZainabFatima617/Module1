Module Module1

    Sub Main()
        Dim myStr As String = ""
        Dim Counter As Integer = 0
        Dim NextChar As String = ""
        Dim Character As String = ""
        Dim FinalStr As String = ""

        Console.Write("Enter String to remove characters: ")
        myStr = Console.ReadLine

        Console.Write("Enter Character to remove: ")
        Character = Console.ReadLine

        For Counter = 1 To Len(myStr)
            NextChar = Mid(myStr, Counter, 1)
            If NextChar <> Character Then
                FinalStr = FinalStr & NextChar
            End If
        Next

        Console.WriteLine("Final String is: " & FinalStr)
        Console.ReadKey()
    End Sub

End Module
