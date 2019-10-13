Module Module1

    Sub Main()
        Dim A1 As String
        Dim A2 As String
        Dim A3 As String
        Dim X As Integer
        Dim FN As String
        Dim LN As String

        A1 = ""
        A2 = ""
        A3 = ""
        X = 0
        FN = ""
        LN = ""

        Console.Write("Enter the First Name: ")
        A1 = Console.ReadLine()

        Console.Write("Enter the Second Name: ")
        A2 = Console.ReadLine()

        X = InStr(A1, " ")
        FN = Left(A1, (X - 1))

        X = InStr(A2, " ")
        LN = Right(A2, Len(A2) - X)

        A3 = FN + " " + LN

        Console.WriteLine("Final String is: " & A3)
        Console.ReadKey()


    End Sub

End Module
