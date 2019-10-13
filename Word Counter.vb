Module Module1

    Sub Main()
        Dim CharCount, Counter, WCount As Integer
        Dim myStr, myChar As String
        Const Character1 As String = " "
        Const Character2 As String = "."

        CharCount = 0
        myChar = ""
        Counter = 0
        WCount = 0
        myStr = ""

        Console.Write("Enter sentence to count words:")
        myStr = Console.ReadLine()

        For Counter = 1 To Len(myStr)
            myChar = Mid(myStr, Counter, 1)
            If myChar = Character1 Then
                CharCount = CharCount + 1
                If myChar = Character2 Then
                    CharCount = CharCount + 1
                End If
            End If
        Next

        WCount = CharCount + 1


        Console.WriteLine("Number of words in the above sentence: " & WCount)
        Console.ReadKey()

    End Sub

End Module
