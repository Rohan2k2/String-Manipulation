Module Module1

    Sub Main()
        Dim retstr, Hstr, Mstr, Starttime As String
        Dim hrs, mins, totalmins, duration As Integer

        Console.WriteLine("enter a time")
        Starttime = Console.ReadLine
        Console.WriteLine("enter duration")
        duration = Console.ReadLine


        hrs = Integer.Parse(Left(Starttime, 2))
        mins = Integer.Parse(Right(Starttime, 2))
        totalmins = mins + duration

        If totalmins >= 60 And totalmins < 120 Then
            totalmins = totalmins - 60
            hrs = hrs + 1
        ElseIf totalmins >= 120 Then
            totalmins = totalmins - 120
            hrs = hrs + 2
        End If

        Hstr = String.Format(hrs)
        Mstr = String.Format(totalmins)

        If Len(Hstr) = 1 Then Hstr = "0" & Hstr
        If Len(Mstr) = 1 Then Mstr = "0" & Mstr
        retstr = Hstr & ":" & Mstr
        Console.WriteLine(retstr)

        Console.ReadKey()

    End Sub

End Module
