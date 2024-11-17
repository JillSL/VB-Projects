Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ub, lb, a, b, c, dx, x, y, tru As Double
        Dim n, i As Integer
        TextBox1.Focus()
        Try
            If Not IsNumeric(TextBox1.Text) Or Not IsNumeric(TextBox2.Text) Or Not IsNumeric(TextBox3.Text) Or Not IsNumeric(TextBox4.Text) Or Not IsNumeric(TextBox5.Text) Or Not IsNumeric(TextBox6.Text) Then
                MessageBox.Show("Error! Please check if all of the input values are numeric.")
            Else
                ub = TextBox1.Text
                lb = TextBox2.Text
                a = TextBox3.Text
                b = TextBox4.Text
                c = TextBox5.Text
                n = TextBox6.Text
                dx = Math.Abs(ub - lb) / n
                x = lb
                Select Case ComboBox1.Text
                    Case "Linear Function"
                        Do Until i > n
                            If i = 0 Or i = n Then
                                y += (a * x + b) / 2
                            Else
                                y += a * x + b
                            End If
                            x += dx
                            i += 1
                        Loop
                        tru = ((a * ub ^ 2) / 2 + b * ub) - ((a * lb ^ 2) / 2 + b * lb)
                        Try
                            If a = 0 Then
                                MessageBox.Show("Error! Please input a valid value for a.")
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                        Label2.Text = ub
                        Label3.Text = lb
                        Label4.Text = ""
                        Label5.Text = "(" & a & "x + " & b & ") dx"
                        Label6.Text = ""
                    Case "Quadratic Function"
                        Do Until i > n
                            If i = 0 Or i = n Then
                                y += (a * x ^ 2 + b * x + c) / 2
                            Else
                                y += a * x ^ 2 + b * x + c
                            End If
                            x += dx
                            i += 1
                        Loop
                        tru = ((a * ub ^ 3) / 3 + (b * ub ^ 2) / 2 + c * ub) - ((a * lb ^ 3) / 3 + (b * lb ^ 2) / 2 + c * lb)
                        Try
                            If a = 0 Then
                                MessageBox.Show("Error! Please input a valid value for a.")
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                        Label2.Text = ub
                        Label3.Text = lb
                        Label4.Text = ""
                        Label5.Text = "(" & a & "x^2 + " & b & "x + " & c & ") dx"
                        Label6.Text = ""
                    Case "Power Function"
                        Do Until i > n
                            If i = 0 Or i = n Then
                                y += (a * x ^ b + c) / 2
                            Else
                                y += a * x ^ b + c
                            End If
                            x += dx
                            i += 1
                        Loop
                        tru = ((a * ub ^ (b + 1)) / (b + 1) + c * ub) - ((a * lb ^ (b + 1)) / (b + 1) + c * lb)
                        Try
                            If b = 0 Then
                                MessageBox.Show("Error! Please input a valid value for b.")
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                        Label2.Text = ub
                        Label3.Text = lb
                        Label4.Text = ""
                        Label5.Text = "(" & a & "x^" & b & " + " & c & ") dx"
                        Label6.Text = ""
                    Case "Exponential Function"
                        Do Until i > n
                            If i = 0 Or i = n Then
                                y += (a ^ (b * x) + c) / 2
                            Else
                                y += a ^ (b * x) + c
                            End If
                            x += dx
                            i += 1
                        Loop
                        tru = (a ^ (b * ub) / (Math.Log10(a ^ b) / Math.Log10(2.718281828)) + c * ub) - (a ^ (b * lb) / (Math.Log10(a ^ b) / Math.Log10(2.718281828)) + c * lb)
                        Try
                            If a = 0 Then
                                If b = 0 Then
                                    MessageBox.Show("Error! Please input valid values for a and b.")
                                Else
                                    MessageBox.Show("Error! Please input a valid value for a.")
                                End If
                            ElseIf b = 0 Then
                                MessageBox.Show("Error! Please input a valid value for b.")
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                        Label2.Text = ub
                        Label3.Text = lb
                        Label4.Text = ""
                        Label5.Text = "(" & a & "^(" & b & "x) + " & c & ") dx"
                        Label6.Text = ""
                    Case "Nth-Root Funtion"
                        Do Until i > n
                            If i = 0 Or i = n Then
                                y += ((a * x + b) ^ (1 / c)) / 2
                            Else
                                y += (a * x + b) ^ (1 / c)
                            End If
                            x += dx
                            i += 1
                        Loop
                        tru = (((a * ub + b) ^ (1 / c + 1)) / (a * (1 / c + 1))) - (((a * lb + b) ^ (1 / c + 1)) / (a * (1 / c + 1)))
                        Try
                            If a = 0 Then
                                If c = -1 Or c = 0 Then
                                    MessageBox.Show("Error! Please input valid values for a and c.")
                                Else
                                    MessageBox.Show("Error! Please input a valid value for a.")
                                End If
                            ElseIf c = -1 Or c = 0 Then
                                MessageBox.Show("Error! Please input a valid value for c.")
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                        Label2.Text = ub
                        Label3.Text = lb
                        Label4.Text = c
                        Label5.Text = "⎷" & a & "x + " & b & " dx"
                        Label6.Text = "__________"
                        If c = 2 Then
                            Label4.Text = ""
                        End If
                    Case Else
                        Try
                            If ComboBox1.Text = "" Then
                                MessageBox.Show("Error! Please select one function type.")
                            Else
                                MessageBox.Show("Error! Please select from the given function types.")
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                End Select
                TextBox7.Text = tru
                TextBox8.Text = y * dx
                If tru = y Then
                    TextBox9.Text = "0%"
                Else
                    TextBox9.Text = 100 * (Math.Abs(tru - (y * dx)) / tru) & "%"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("***Program***
Trapezoidal Rule Calculator
This program approximates
the area of the function using
the values of UB, LB, a, b, c, and n
which are inputs from the user.
It also calculates the actual
area by integration and the percent error
of the approximated from the actual value.

***Creator***
Jillian Joy C. San Luis
2015-02999
ENSC 26 CD13")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox1.Focus()
        Label2.Text = "UB"
        Label3.Text = "LB"
        Label4.Text = "c"
        Label5.Text = "⎷ax+b dx Approximator"
        Label6.Text = "_________"
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox1.Focus()
        Label2.Text = "UB"
        Label3.Text = "LB"
        Label4.Text = "c"
        Label5.Text = "⎷ax+b dx Approximator"
        Label6.Text = "_________"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
