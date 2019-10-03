Module Module1

    Sub Main()
        Dim NumEntered, InternationalNum, OmittedChar, ReplacedChar, CountryCode, FixedInternationalNum, CurrentChar As String
        Dim counter As Integer

        NumEntered = ""
        InternationalNum = ""
        FixedInternationalNum = ""
        OmittedChar = ""
        CurrentChar = ""
        ReplacedChar = ""
        CountryCode = ""
        counter = 0

        Console.Write("Enter your phone number: ")
        NumEntered = Console.ReadLine

        Console.Write("Entered the characters to be omitted in the string: ")
        OmittedChar = Console.ReadLine

        Console.Write("Enter the character to replace the omitted character: ")
        ReplacedChar = Console.ReadLine

        Console.Write("Enter your country code: ")
        CountryCode = Console.ReadLine

        InternationalNum = CountryCode & Right(NumEntered, Len(NumEntered) - InStr(NumEntered, "0"))
        For counter = 1 To Len(InternationalNum)
            CurrentChar = Mid(InternationalNum, counter, 1)
            If CurrentChar = OmittedChar Then
                CurrentChar = ReplacedChar
            End If
            FixedInternationalNum = FixedInternationalNum & CurrentChar
        Next

        Console.WriteLine("Your phone number with the country code and with the characters you requested to be replaced is: " & FixedInternationalNum)

        Console.ReadKey()

    End Sub

End Module
