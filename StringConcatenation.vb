Module Module1

    Sub Main()
        Dim str1, str2, str3 As String

        str1 = ""
        str2 = ""
        str3 = ""

        Console.Write("enter first string of 2 words: ")
        str1 = Console.ReadLine

        Console.Write("enter second string of 2 words: ")
        str2 = Console.ReadLine

        str3 = Left(str1, InStr(str1, " ")) & Right(str2, Len(str2) - InStr(str2, " "))

        Console.WriteLine("the combined string is: " & str3)
        Console.ReadKey()
    End Sub

End Module
