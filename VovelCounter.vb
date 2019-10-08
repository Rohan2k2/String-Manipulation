Module Module1

    Sub Main()
        Dim str, vovel As String
        Dim count, NoOfVovels As Integer

        str = ""
        vovel = "AEIOU"
        count = 0
        NoOfVovels = 0

        Console.Write("Enter the string to be checked: ")
        str = Console.ReadLine

        str = UCase(str)

        For count = 1 To Len(str)
            If InStr(vovel, Mid(str, count, 1)) > 0 Then
                NoOfVovels = NoOfVovels + 1
            End If
        Next

        Console.WriteLine("the no of vovels in the entered string is: " & NoOfVovels)
        Console.ReadKey()
    End Sub

End Module
