Module Module1

    Sub Main()
        Dim myStr As String = ""
        Dim Length As Integer = 0
        Dim myChar As String = ""
        Dim validBinaryString As Boolean = True
        Dim Counter As Integer = 0

        Console.Write("Enter a Binary Number: ")
        myStr = Console.ReadLine

        Length = Len(myStr)
        If Length < 1 Or Length > 8 Then
            validBinaryString = False
        End If

        If validBinaryString = True Then
            For Counter = 1 To Len(myStr)
                myChar = Mid(myStr, Counter, 1)
                If myChar = "1" Or myChar = "0" Then
                    validBinaryString = True
                Else : validBinaryString = False
                End If
            Next
        End If

        If validBinaryString = True Then
            Console.WriteLine("It is a valid binary number...")
        ElseIf validBinaryString = False Then
            Console.WriteLine("Not a valid binary number...")
        End If
        Console.ReadKey()
    End Sub

End Module



