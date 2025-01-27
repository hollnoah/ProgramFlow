Option Explicit On
Option Strict On

Module ProgramFlow
    Sub Main()
        Dim raccoon As Integer

        'assign 5 to my number (raccoon)
        raccoon = 5

        'test is raccoon greater than 6
        'display the result on the console
        If raccoon > 6 Then
            Console.WriteLine(raccoon > 6)
        End If

        If raccoon > 3 Then
            Console.WriteLine(raccoon > 3)
        End If

        If raccoon > 4 Then
            Console.WriteLine(raccoon > 4)
        End If

        'only evaluates to see if one of the statements is true. if so, it doesn't read anything else
        If raccoon > 6 Then
            Console.WriteLine(raccoon > 6)
        ElseIf raccoon > 3 Then
            Console.WriteLine(raccoon > 3)
        ElseIf raccoon > 4 Then
        Console.WriteLine(raccoon > 4)
        End If


    End Sub

End Module
