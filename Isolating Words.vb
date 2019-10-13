Module Module1

    Sub Main()
        Dim A1 As String = ""
        Dim A2 As String = ""
        Dim A3 As String = ""
        Dim A4 As String = ""
        Dim X As String = ""
        Dim Y As String = ""
        Dim N As Integer = 0

        Console.Write("Enter string composed of three words: ")
        A1 = Console.ReadLine

        X = InStr(A1, " ")
        A2 = Mid(A1, 1, X - 1)

        Y = InStr((InStr(A1, " ") + 1), A1, " ")
        A3 = Mid(A1, X + 1, (Y - X - 1))

        N = Len(A1)
        A4 = Mid(A1, (N - X + 2), N)

        Console.WriteLine("First Word: " & A2)
        Console.WriteLine("Second Word: " & A3)
        Console.WriteLine("Third Word: " & A4)
        Console.ReadKey()
    End Sub

End Module
