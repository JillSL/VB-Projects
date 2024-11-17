Public Class Form1
    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Z, a, b, c, n, j, diff, num, den, denom As Double
        Dim ans, final As String
        If Not RadioButton1.Checked And Not RadioButton2.Checked And Not RadioButton3.Checked And Not RadioButton4.Checked Then
            MessageBox.Show("Error! Please select one from the variable choices.")
        ElseIf Not IsNumeric(TextBox1.Text) Then
            If Not IsNumeric(TextBox2.Text) Then
                If Not IsNumeric(TextBox3.Text) Then
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox1.Focus()
                    MessageBox.Show("Error! Please input numerical values for a, b, and n.")
                ElseIf IsNumeric(TextBox3.Text) Then
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox1.Focus()
                    MessageBox.Show("Error! Please input a numerical value for a and b.")
                End If
            ElseIf Not IsNumeric(TextBox3.Text) Then
                TextBox1.Clear()
                TextBox3.Clear()
                TextBox1.Focus()
                MessageBox.Show("Error! Please input a numerical value for a and n.")
            ElseIf IsNumeric(TextBox2.Text) And IsNumeric(TextBox3.Text) Then
                TextBox1.Clear()
                TextBox1.Focus()
                MessageBox.Show("Error! Please input a numerical value for a.")
            End If
        ElseIf Not IsNumeric(TextBox2.Text) Then
            If Not IsNumeric(TextBox3.Text) Then
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox2.Focus()
                MessageBox.Show("Error! Please input a numerical value for b and n.")
            ElseIf IsNumeric(TextBox3.Text) Then
                TextBox2.Clear()
                TextBox2.Focus()
                MessageBox.Show("Error! Please input a numerical value for b.")
            End If
        ElseIf Not IsNumeric(TextBox3.Text) Then
            TextBox3.Clear()
            TextBox3.Focus()
            MessageBox.Show("Error! Please input a numerical value for n.")
        Else
            a = TextBox1.Text
            b = TextBox2.Text
            j = TextBox3.Text
            Select Case Z
                Case Z = RadioButton1.Checked
                    n = Math.Abs(j)
                    ans = (a + b) ^ n
                    If j = 0 Then
                        final = "The binomial expression" & vbCrLf & "(" & a & " + " & b & ")^" & n & vbCrLf & vbCrLf & "is expanded to" & vbCrLf & 1 & "."
                    ElseIf j < 0 Then
                        If ans = 1 Then
                            final = "The binomial expression" & vbCrLf & "(" & a & " + " & b & ")^" & n & vbCrLf & vbCrLf & "is expanded to" & vbCrLf & 1 & "."
                        Else
                            final = "The binomial expression" & vbCrLf & "(" & a & " + " & b & ")^" & n & vbCrLf & vbCrLf & "is expanded to" & vbCrLf & "1 / (" & ans & ")."
                        End If
                    Else
                        final = "The binomial expression" & vbCrLf & "(" & a & " + " & b & ")^" & n & vbCrLf & vbCrLf & "is expanded to" & vbCrLf & ans & "."
                    End If
                    TextBox4.Text = final
                Case Z = RadioButton2.Checked
                    n = Math.Abs(j)
                    num = 1
                    ans = ""
                    For i = 1 To n
                        num = num * i
                    Next
                    For k As Integer = n To 0 Step -1
                        den = 1
                        denom = 1
                        diff = n - k
                        If diff = 0 Or diff = 1 Then
                            den = den
                        Else
                            For i = 1 To diff Step 1
                                den = den * i
                            Next
                        End If
                        If k = 0 Or k = 1 Then
                            denom = denom
                        Else
                            For i = k To 1 Step -1
                                denom = denom * i
                            Next
                        End If
                        c = (num / (den * denom)) * a ^ (n - k) * b ^ k
                        If k = n Then
                            ans = ans & c
                        ElseIf n - k = 1 Then
                            ans = c & "x" & " + " & ans
                        ElseIf k = 0 Then
                            ans = c & "x^" & (n - k) & " + " & ans
                        Else
                            ans = c & "x^" & (n - k) & " + " & ans
                        End If
                    Next
                    If j = 0 Then
                        final = "The binomial expression" & vbCrLf & "(" & a & " + " & b & ")^" & n & vbCrLf & vbCrLf & "is expanded to" & vbCrLf & 1 & "."
                    ElseIf j < 0 Then
                        final = "The binomial expression" & vbCrLf & "(" & a & "x + " & b & ")^" & n & vbCrLf & vbCrLf & "is expanded to" & vbCrLf & "1 / (" & ans & ")."
                    Else
                        final = "The binomial expression" & vbCrLf & "(" & a & "x + " & b & ")^" & n & vbCrLf & vbCrLf & "is expanded to" & vbCrLf & ans & "."
                    End If
                    TextBox4.Text = final
                Case Z = RadioButton3.Checked
                    n = Math.Abs(j)
                    num = 1
                    ans = ""
                    For i = 1 To n
                        num = num * i
                    Next
                    For k As Integer = n To 0 Step -1
                        den = 1
                        denom = 1
                        diff = n - k
                        If diff = 0 Or diff = 1 Then
                            den = den
                        Else
                            For i = 1 To diff Step 1
                                den = den * i
                            Next
                        End If
                        If k = 0 Or k = 1 Then
                            denom = denom
                        Else
                            For i = k To 1 Step -1
                                denom = denom * i
                            Next
                        End If
                        c = (num / (den * denom)) * a ^ k * b ^ (n - k)
                        If k = n Then
                            ans = ans & c
                        ElseIf n - k = 1 Then
                            ans = c & "y" & " + " & ans
                        ElseIf k = 0 Then
                            ans = c & "y^" & (n - k) & " + " & ans
                        Else
                            ans = c & "y^" & (n - k) & " + " & ans
                        End If
                    Next
                    If j = 0 Then
                        final = "The binomial expression" & vbCrLf & "(" & a & " + " & b & "y)^" & n & vbCrLf & vbCrLf & "is expanded to" & vbCrLf & 1 & "."
                    ElseIf j < 0 Then
                        final = "The binomial expression" & vbCrLf & "(" & a & " + " & b & "y)^" & n & vbCrLf & vbCrLf & "is expanded to" & vbCrLf & "1 / (" & ans & ")."
                    Else
                        final = "The binomial expression" & vbCrLf & "(" & a & " + " & b & "y)^" & n & vbCrLf & vbCrLf & "is expanded to" & vbCrLf & ans & "."
                    End If
                    TextBox4.Text = final
                Case Z = RadioButton4.Checked
                    n = Math.Abs(j)
                    num = 1
                    ans = ""
                    For i = 1 To n
                        num = num * i
                    Next
                    For k As Integer = n To 0 Step -1
                        den = 1
                        denom = 1
                        diff = n - k
                        If diff = 0 Or diff = 1 Then
                            den = den
                        Else
                            For i = 1 To diff Step 1
                                den = den * i
                            Next
                        End If
                        If k = 0 Or k = 1 Then
                            denom = denom
                        Else
                            For i = k To 1 Step -1
                                denom = denom * i
                            Next
                        End If
                        c = (num / (den * denom)) * a ^ k * b ^ (n - k)
                        If k = n Then
                            ans = c & "(x^" & n & ") + " & ans
                        ElseIf k = 1 Then
                            ans = ans & " + " & c & "(x)(y^" & (n - k) & ")"
                        ElseIf k = n - 1 Then
                            ans = ans & " + " & c & "(x^" & k & ")(y)"
                        ElseIf k = 0 Then
                            ans = ans & " + " & c & "(y^" & n & ")"
                        Else
                            ans = ans & " + " & c & "(x^" & k & ")(y^" & (n - k) & ")"
                        End If
                    Next
                    If j = 0 Then
                        final = "The binomial expression" & vbCrLf & "(" & a & "x + " & b & "y)^" & n & vbCrLf & vbCrLf & "is expanded to" & vbCrLf & 1 & "."
                    ElseIf j < 0 Then
                        final = "The binomial expression" & vbCrLf & "(" & a & "x + " & b & "y)^" & n & vbCrLf & vbCrLf & "is expanded to" & vbCrLf & "1 / (" & ans & ")."
                    Else
                        final = "The binomial expression" & vbCrLf & "(" & a & "x + " & b & "y)^" & n & vbCrLf & vbCrLf & "is expanded to" & vbCrLf & ans & "."
                    End If
                    TextBox4.Text = final
            End Select
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Text = “Status: awaiting expression input…”
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Text = “Status: awaiting expression input…”
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        TextBox1.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("***Program***" & vbCrLf & "Quadratic Equation Discriminant Calculator" & vbCrLf & "This program expands a binomial using the values of a, b, and n which are inputs from the user." & vbCrLf & "***Creator***" & vbCrLf & "Jillian Joy C. San Luis" & vbCrLf & "2015-02999" & vbCrLf & "ENSC 26 CD13")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
