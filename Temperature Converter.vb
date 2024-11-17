' SAN LUIS, Jillian Joy C.
' Project: Temperature Converter

Module TemperatureConverter

    Sub Main()
        Dim value As Double
        Dim fromUnit As String
        Dim toUnit As String
        Dim result As Double
        Dim userResponse As String

        Do
            Try
                Console.WriteLine("Enter the temperature value:")
                value = Convert.ToDouble(Console.ReadLine())

                Console.WriteLine("Enter the current unit (Celsius, Fahrenheit, Kelvin, Rankine):")
                fromUnit = Console.ReadLine().ToLower() ' Converts to lowercase for case-insensitive comparison

                Console.WriteLine("Enter the unit to convert to (Celsius, Fahrenheit, Kelvin, Rankine):")
                toUnit = Console.ReadLine().ToLower() ' Converts to lowercase for case-insensitive comparison

                result = ConvertTemperature(value, fromUnit, toUnit)

                Console.WriteLine(value & " " & fromUnit & " is equal to " & result & " " & toUnit & ".")

                ' Ask if user wants to try again
                Do
                    Console.WriteLine("Do you want to try again? (yes/no)")
                    userResponse = Console.ReadLine().ToLower() ' Converts to lowercase for case-insensitive comparison

                    If userResponse = "yes" OrElse userResponse = "yes." Then
                        Exit Do
                    ElseIf userResponse = "no" OrElse userResponse = "no." Then
                        Console.WriteLine("Goodbye!")
                        Exit Sub
                    Else
                        Console.WriteLine("ERROR! Invalid response. Please type 'yes' or 'no'.")
                    End If
                Loop

            Catch ex As Exception
                Console.WriteLine("ERROR: " & ex.Message)

                ' Handle invalid input and ask if the user wants to try again
                Do
                    Console.WriteLine("Do you want to try again? (yes/no)")
                    userResponse = Console.ReadLine().ToLower() ' Converts to lowercase for case-insensitive comparison

                    If userResponse = "yes" OrElse userResponse = "yes." Then
                        Exit Do
                    ElseIf userResponse = "no" OrElse userResponse = "no." Then
                        Console.WriteLine("Goodbye!")
                        Exit Sub
                    Else
                        Console.WriteLine("ERROR! Invalid response. Please type 'yes' or 'no'.")
                    End If
                Loop
            End Try
        Loop
    End Sub

    Function ConvertTemperature(value As Double, fromUnit As String, toUnit As String) As Double
        If fromUnit = toUnit Then
            Return value
        End If

        Select Case fromUnit
            Case "celsius"
                Select Case toUnit
                    Case "fahrenheit"
                        Return (value * 9 / 5) + 32
                    Case "kelvin"
                        Return value + 273.15
                    Case "rankine"
                        Return (value + 273.15) * 9 / 5
                End Select

            Case "fahrenheit"
                Select Case toUnit
                    Case "celsius"
                        Return (value - 32) * 5 / 9
                    Case "kelvin"
                        Return (value - 32) * 5 / 9 + 273.15
                    Case "rankine"
                        Return value + 459.67
                End Select

            Case "kelvin"
                Select Case toUnit
                    Case "celsius"
                        Return value - 273.15
                    Case "fahrenheit"
                        Return (value - 273.15) * 9 / 5 + 32
                    Case "rankine"
                        Return value * 9 / 5
                End Select

            Case "rankine"
                Select Case toUnit
                    Case "celsius"
                        Return (value - 491.67) * 5 / 9
                    Case "fahrenheit"
                        Return value - 459.67
                    Case "kelvin"
                        Return value * 5 / 9
                End Select

            Case Else
                Throw New ArgumentException("Invalid unit entered. Please enter a valid unit: Celsius, Fahrenheit, Kelvin, or Rankine.")
        End Select
    End Function

End Module
