Module Module1

    Sub Main()
        'computer science monthly test code for max repeated character'
        'this code is primarily based on the one done in the actual quesiton paper and is a more refined version of it, in comparison it is nearly the same '
        'some changes willl be highlighted'
        Dim currentchar, lastcharcount, count As Integer 'added declarations'
        Dim str1, nextchar, maxrepeatedchar, str2, fixstr As String

        currentchar = 0
        lastcharcount = 1 'changed this declaration to 1 so that strings with no repeating chars can be discarded'
        count = 0
        str1 = ""
        nextchar = ""
        maxrepeatedchar = ""
        str2 = "" 'new variable created'
        fixstr = "" 'new variable made to get rid of all spaces in a string

        Console.Write("enter a string: ")
        str1 = Console.ReadLine
        str1 = LCase(str1)

        'this next section is a seciton added to remove spaces from an entered string'

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If nextchar = " " Then
                nextchar = ""
            End If
            fixstr = fixstr & nextchar
        Next
        str1 = fixstr

        'main code starts here'
        If str1 <> "" Then 'added a statment for when no string is entered'
            For count = 1 To Len(str1)
                str2 = str1
                nextchar = Mid(str1, count, 1)
                Do Until InStr(str2, nextchar) = 0
                    currentchar = currentchar + 1
                    str2 = Left(str2, InStr(str2, nextchar) - 1) & Right(str2, Len(str2) - InStr(str2, nextchar)) 'replaced all str1s in this stement with str2, str1s did give valid outputs but i decided making a new variable was more efficient'
                Loop
                If currentchar > lastcharcount Then
                    maxrepeatedchar = nextchar
                End If
                lastcharcount = currentchar
                currentchar = 0
            Next

            If maxrepeatedchar = "" Then
                Console.WriteLine("all characters are only seen once ")
            End If
            If maxrepeatedchar <> "" Then
                Console.WriteLine("most repeated char is: " & maxrepeatedchar)
            End If
        Else
            Console.WriteLine("you have not entered a valid string")
        End If

        Console.ReadKey()
    End Sub

End Module
