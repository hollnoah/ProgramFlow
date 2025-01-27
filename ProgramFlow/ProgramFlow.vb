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


        raccoon -= 3
        'if no conditions are true, console will read else condition
        If raccoon > 6 Then
            Console.WriteLine($"{raccoon} is a big number!")
        ElseIf raccoon > 3 Then
            Console.WriteLine($"Sorry not tall enough...")
        ElseIf raccoon > 4 Then
            Console.WriteLine($"who cares")
        Else
            Console.WriteLine($"Not sure what happened")
        End If


    End Sub

End Module
