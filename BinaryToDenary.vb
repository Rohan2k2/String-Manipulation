Module Module1

    Sub Main()

        'program for october monthly test'
        'this program includes certain changes from the psuedocode version written on the written paper,in order to improve the program'

        '(a)'

        Dim str1, str2, NextChar, binary As String
        Dim count, NextNum, DenaryNum As Integer
        Dim validBinaryString As Boolean

        str1 = ""
        str2 = ""
        NextChar = ""
        binary = "01"
        count = 0
        NextNum = 0
        DenaryNum = 0
        validBinaryString = True

        Console.Write("Enter Binary Number: ")
        str1 = Console.ReadLine

        If Len(str1) <= 8 And Len(str1) > 0 Then
            For count = 1 To Len(str1)
                NextChar = Mid(str1, count, 1)
                If InStr(binary, NextChar) = 0 Then
                    'changed the or here to a location check to resemble pangram checker,alternatively,the or could have been fixed by replacing with an and'
                    validBinaryString = False
                End If
            Next
        Else : validBinaryString = False

        End If

        If validBinaryString = False Then
            Console.Write("not a valid binary number...")

        End If

        '(b)'

        If validBinaryString = True Then

            For count = 1 To Len(str1)
                str2 = Mid(str1, count, 1) & str2
            Next

            For count = 1 To Len(str2)
                NextChar = Mid(str2, count, 1)
                NextNum = 0     'added this line to make nextnum to 0 at start of loop'
                If NextChar = "1" Then
                    NextNum = 1
                End If

                If count = 1 Then
                    DenaryNum = DenaryNum + NextNum
                End If

                If count = 2 Then
                    DenaryNum = DenaryNum + NextNum * 2
                End If

                If count = 3 Then
                    DenaryNum = DenaryNum + NextNum * 4
                End If

                If count = 4 Then
                    DenaryNum = DenaryNum + NextNum * 8
                End If

                If count = 5 Then
                    DenaryNum = DenaryNum + NextNum * 16
                End If

                If count = 6 Then
                    DenaryNum = DenaryNum + NextNum * 32
                End If

                If count = 7 Then
                    DenaryNum = DenaryNum + NextNum * 64
                End If

                If count = 8 Then
                    DenaryNum = DenaryNum + NextNum * 128
                End If
            Next

            Console.WriteLine(str1 & " = " & DenaryNum)
        End If

        Console.ReadKey()


    End Sub

End Module
