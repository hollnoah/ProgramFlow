Option Explicit On
Option Strict On
Option Compare Text
Imports System.Runtime.InteropServices

Module ProgramFlow
    Sub Main()
        Dim myNumber As Integer
        Dim userInput As String


        ''assign 5 to my number (raccoon)
        'myNumber = 5

        ''test is raccoon greater than 6
        ''display the result on the console
        'If myNumber > 6 Then
        '    Console.WriteLine(myNumber > 6)
        'End If

        'If myNumber > 3 Then
        '    Console.WriteLine(myNumber > 3)
        'End If

        'If myNumber > 4 Then
        '    Console.WriteLine(myNumber > 4)
        'End If

        ''only evaluates to see if one of the statements is true. if so, it doesn't read anything else
        'If myNumber > 6 Then
        '    Console.WriteLine(myNumber > 6)
        'ElseIf myNumber > 3 Then
        '    Console.WriteLine(myNumber > 3)
        'ElseIf myNumber > 4 Then
        '    Console.WriteLine(myNumber > 4)
        'End If


        'myNumber -= 3
        ''if no conditions are true, console will read else condition
        'If myNumber > 6 Then
        '    Console.WriteLine($"{myNumber} is a big number!")
        'ElseIf myNumber > 3 Then
        '    Console.WriteLine($"Sorry not tall enough...")
        'ElseIf myNumber > 4 Then
        '    Console.WriteLine($"who cares")
        'Else
        '    Console.WriteLine($"Not sure what happened")
        'End If


        'Do 'sets beginning of loop
        '    Console.WriteLine("Please enter your age:")
        '    userInput = Console.ReadLine()
        '    Try
        '        myNumber = CInt(userInput)
        '        Select Case myNumber
        '            Case 0 To 3
        '                Console.WriteLine("Where are your parents?")
        '            Case 4 To 10
        '                Console.WriteLine("Where are your parents?")
        '            Case 11 To 64
        '                Console.WriteLine("Enjoy the ride!")
        '            Case 65 To 99
        '                Console.WriteLine("Where are your kids?")
        '            Case > 100
        '                Console.WriteLine("Oh so you and Walt Disney went to school together?")
        '            Case Else
        '                Console.WriteLine("Well this is awkward")
        '        End Select
        '    Catch ex As Exception
        '        Console.WriteLine($"You entered {userInput}")
        '    End Try
        'Loop Until userInput = "Q" 'pressing q ends the loop
        'Console.WriteLine("Have a nice day")

        'userInput = "5"

        'Do
        '    'Console.WriteLine("Type something and press enter:")
        '    'userInput = Console.ReadLine()
        '    Console.WriteLine($"In the Do, Loop until: ")
        '    userInput = "q"
        'Loop Until userInput = "Q"

        Do Until userInput = "Q"
            Console.WriteLine("Type something and press enter:")
            userInput = Console.ReadLine()
            Console.WriteLine($"In the Do Until, Loop: ")
        Loop

    End Sub

End Module
