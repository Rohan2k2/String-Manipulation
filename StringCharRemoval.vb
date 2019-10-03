Module Module1

    Sub Main()
        Dim NumEntered, FixedNum, OmittedChar, CurrentChar As String
        Dim counter As Integer

        NumEntered = ""
        FixedNum = ""
        OmittedChar = ""
        CurrentChar = ""
        counter = 0

        Console.Write("Enter your phone number: ")
        NumEntered = Console.ReadLine

        Console.Write("Enter the character to remove: ")
        OmittedChar = Console.ReadLine

        For counter = 1 To Len(NumEntered)
            CurrentChar = Mid(NumEntered, counter, 1)
            If CurrentChar <> OmittedChar Then
                FixedNum = FixedNum & CurrentChar
            End If
        Next
        Console.WriteLine("Your phone number without any extra characters is: " & FixedNum)
        Console.ReadKey()
    End Sub

End Module
