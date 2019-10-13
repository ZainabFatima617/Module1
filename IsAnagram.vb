Module Module1

    Sub Main()
        Dim Str1 As String = ""
        Dim Str2 As String = ""
        Dim Counter1 As Integer = 0
        Dim Counter2 As Integer = 0
        Dim Char1 As String = ""
        Dim myChar As String = ""
        Dim IsAnagram As Boolean = True
        Dim NewStr2 As String = ""

        Console.Write("Enter String 1 to check Anagram: ")
        Str1 = Console.ReadLine

        Console.Write("Enter String 2 to check Anagram: ")
        Str2 = Console.ReadLine

        If Len(Str1) <> Len(Str2) Then
            Console.WriteLine("It is not an Anagram ")
            Console.ReadLine()
        Else
        End If

        NewStr2 = UCase(Str2)
        IsAnagram = True
        For Counter1 = 1 To Len(Str1)
            Char1 = Mid(Str1, Counter1, 1)
            myChar = InStr(NewStr2, UCase(Char1))
            If myChar > 0 Then
                IsAnagram = True
            Else
                IsAnagram = False
                Exit For
            End If
        Next

        If IsAnagram = True Then
            Console.WriteLine("The strings are Anagram.")
            Console.ReadLine()
        Else : Console.WriteLine("The Strings are not Anagram.")
        End If

        Console.ReadKey()
    End Sub

End Module
