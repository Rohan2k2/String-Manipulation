Module Module1

    Sub Main()
        Dim alph, str1 As String
        Dim count As Integer
        Dim ispangram As Boolean

        alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        str1 = ""
        count = 0
        ispangram = False

        Console.WriteLine("╦ ╦┌─┐┬  ┌─┐┌─┐┌┬┐┌─┐  ┌┬┐┌─┐  ╔═╗┌─┐┌┐┌┌─┐┬─┐┌─┐┌┬┐  ┌─┐┬ ┬┌─┐┌─┐┬┌─┌─┐┬─┐  ")
        Console.WriteLine("║║║├┤ │  │  │ ││││├┤    │ │ │  ╠═╝├─┤││││ ┬├┬┘├─┤│││  │  ├─┤├┤ │  ├┴┐├┤ ├┬┘  ")
        Console.WriteLine("╚╩╝└─┘┴─┘└─┘└─┘┴ ┴└─┘   ┴ └─┘  ╩  ┴ ┴┘└┘└─┘┴└─┴ ┴┴ ┴  └─┘┴ ┴└─┘└─┘┴ ┴└─┘┴└─  ")

        Console.WriteLine("please enter a suspected pangram")
        str1 = Console.ReadLine
        str1 = UCase(str1)
        If Len(str1) >= 26 Then
            ispangram = True
            For count = 1 To 26
                If InStr(str1, Mid(alph, count, 1)) = 0 Then
                    ispangram = False
                End If
            Next
        End If
        If ispangram = True Then
            Console.WriteLine("the entered string is a pangram")
        Else
            Console.WriteLine("the entered string is not a pangram")
        End If
        Console.ReadKey()
    End Sub

End Module
