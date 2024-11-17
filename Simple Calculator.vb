' SAN LUIS, Jillian Joy C.
' Project: Simple Calculator

Imports System

Module Calculator
    Sub Main()
        Dim num1 As Double
        Dim num2 As Double
        Dim op As String
        Dim result As Double
        Dim isValidInput As Boolean

        ' Loop to handle invalid inputs for first number
        Do
            Try
                Console.WriteLine("Enter the first number:")
                num1 = Convert.ToDouble(Console.ReadLine())
                isValidInput = True
            Catch ex As FormatException
                Console.WriteLine("Invalid input. Please enter a valid number.")
                isValidInput = False
            End Try
        Loop Until isValidInput

        ' Loop to handle invalid inputs for operator
        Do
            Console.WriteLine("Enter the operator (+, -, *, /):")
            op = Console.ReadLine()

            If op = "+" OrElse op = "-" OrElse op = "*" OrElse op = "/" Then
                isValidInput = True
            Else
                Console.WriteLine("Invalid operator. Please enter one of the following: +, -, *, /.")
                isValidInput = False
            End If
        Loop Until isValidInput

        ' Loop to handle invalid inputs for second number
        Do
            Try
                Console.WriteLine("Enter the second number:")
                num2 = Convert.ToDouble(Console.ReadLine())
                isValidInput = True
            Catch ex As FormatException
                Console.WriteLine("Invalid input. Please enter a valid number.")
                isValidInput = False
            End Try
        Loop Until isValidInput

        ' Perform the calculation
        Try
            Select Case op
                Case "+"
                    result = num1 + num2
                Case "-"
                    result = num1 - num2
                Case "*"
                    result = num1 * num2
                Case "/"
                    If num2 = 0 Then
                        Throw New DivideByZeroException("Cannot divide by zero.")
                    Else
                        result = num1 / num2
                    End If
                Case Else
                    Throw New InvalidOperationException("Invalid operator entered.")
            End Select

            ' Display the result
            Console.WriteLine("The result is: " & result)

        Catch ex As DivideByZeroException
            Console.WriteLine(ex.Message)
        Catch ex As InvalidOperationException
            Console.WriteLine(ex.Message)
        Catch ex As Exception
            Console.WriteLine("An unexpected error occurred: " & ex.Message)
        Finally
            ' Wait for user input before closing the application
            Console.WriteLine("Press any key to exit.")
            Console.ReadKey()
        End Try
    End Sub
End Module
