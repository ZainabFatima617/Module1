Module Module1

    Sub Main()
        Dim Str1 As String = ""
        Dim myChar As String = ""
        Dim FinalStr As String = ""
        Dim Numbers As String = ""
        Dim Counter As Integer = 0
        Dim Letters As String = ""
        Dim Specials As String = ""

        Console.Write("Enter String Consisting of Numbers, Letters and Special Characters: ")
        Str1 = Console.ReadLine

        For Counter = 1 To Len(Str1)
            myChar = Mid(Str1, Counter, 1)
            If Asc(UCase(myChar)) >= 65 And Asc(UCase(myChar)) <= 91 Then
                Letters = Letters & myChar
            ElseIf Asc(myChar) >= 48 And Asc(myChar) <= 57 Then
                Numbers = Numbers & myChar
            Else : Specials = Specials & myChar
            End If
        Next

        Console.WriteLine("Letters in the String are: " & Letters)
        Console.WriteLine("Numbers in the String are: " & Numbers)
        Console.WriteLine("Specials in the String are: " & Specials)
        Console.ReadKey()
    End Sub

End Module
