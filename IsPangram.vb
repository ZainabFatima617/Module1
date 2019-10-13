Module Module1

    Sub Main()
        Dim Str1 As String
        Dim myAlpha As String
        Dim isPangram As Boolean
        Dim myChar As String

        Str1 = ""
        myAlpha = ""
        isPangram = True
        myChar = ""

        Console.Write("Enter String to check whether it is a pangram or not: ")
        Str1 = Console.ReadLine

        isPangram = True
        Str1 = UCase(Str1)
        For ASCII = 65 To 90
            myAlpha = Chr(ASCII)
            myChar = InStr(Str1, myAlpha)
            If myChar >= 1 Then
                isPangram = True
            Else
                isPangram = False
                Exit For
            End If
        Next

        If isPangram = True Then
            Console.WriteLine("The string is pangram.")
            Console.ReadLine()
        Else : Console.WriteLine("The string is not pangram.")
        End If

        Console.ReadKey()
    End Sub

End Module
