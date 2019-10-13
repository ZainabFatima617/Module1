Module Module1

    Sub Main()
        Dim A1 As String
        Dim X As Integer
        Dim A2 As String
        Dim Y As Integer

        A1 = ""
        X = 0
        A2 = ""
        Y = 0

        Console.Write("Enter String: ")
        A1 = Console.ReadLine

        X = InStr(A1, " ")
        Y = InStr(X + 1, A1, " ")
        A2 = Mid(A1, (X + 1), (Y - X - 1))

        Console.WriteLine("Middle word of the string: " & A2)
        Console.ReadKey()
    End Sub

End Module
