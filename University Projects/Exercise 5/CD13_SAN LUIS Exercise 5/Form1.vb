Public Class Form1
    Dim r1, c1, r2, c2 As Double
    Dim b4 As Integer = 0
    Dim array1(,), array2(,), array3(,) As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome! Please input the size (i.e., row and column) of Array 1 and Array 2.")
        Me.Size = New Size(250, 400)
        TextBox1.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Please fill in all of the input textboxes.")
        Else
            r1 = TextBox1.Text
            c1 = TextBox2.Text
            r2 = TextBox3.Text
            c2 = TextBox4.Text
            If r1 <> r2 Or c1 <> c2 Then
                MessageBox.Show("Error! The number of rows and columns must match for Arrays 1 and 2. Please change the row and column value for Array 2.")
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox3.Focus()
            Else
                IncludeScrollBar(r1, c1, 1)
                IncludeScrollBar(r2, c2, 2)
                IncludeScrollBar(r1, c1, 3)
                StoreElements(r1, c1, 1, b4)
                StoreElements(r2, c2, 2, b4)

                Me.Size = New Size(500, 400)
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                TextBox1.ReadOnly = True
                TextBox2.ReadOnly = True
                TextBox3.ReadOnly = True
                TextBox4.ReadOnly = True
                Dim str As String = ""
                ReDim array3(r1 - 1, c1 - 1)
                If DirectCast(sender, Button).Name = "Button1" Then
                    For i As Integer = 0 To r1 - 1
                        For j As Integer = 0 To c1 - 1
                            array3(i, j) = array1(i, j) + array2(i, j)
                            array3(i, j) = Math.Round(array3(i, j), 4)
                            str += CStr(array3(i, j)) & vbTab
                        Next
                        str += vbCrLf
                    Next
                    TextBox7.Text = "The result of Array 1 + Array 2 is :" & vbCrLf & vbCrLf & str
                Else
                    For i As Integer = 0 To r1 - 1
                        For j As Integer = 0 To c1 - 1
                            array3(i, j) = array1(i, j) - array2(i, j)
                            array3(i, j) = Math.Round(array3(i, j), 4)
                            str += CStr(array3(i, j)) & vbTab
                        Next
                        str += vbCrLf
                    Next
                    TextBox7.Text = "The result of Array 1 - Array 2 is :" & vbCrLf & vbCrLf & str
                End If
                b4 = 0
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Please fill in all of the input textboxes.")
        Else
            r1 = TextBox1.Text
            c1 = TextBox2.Text
            r2 = TextBox3.Text
            c2 = TextBox4.Text
            If c1 <> r2 Then
                MessageBox.Show("Error! The number of rows for Array 2 must match the number of columns for Array 1. Please change the row value for Array 2.")
                TextBox3.Clear()
                TextBox3.Focus()
            Else
                IncludeScrollBar(r1, c1, 1)
                IncludeScrollBar(r2, c2, 2)
                IncludeScrollBar(r1, c2, 3)
                StoreElements(r1, c1, 1, b4)
                StoreElements(r2, c2, 2, b4)
                Me.Size = New Size(500, 400)
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                TextBox1.Enabled = False
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                TextBox4.Enabled = False
                Dim str As String = ""
                Dim result As Double = 0
                For i As Integer = 0 To r1 - 1
                    For j As Integer = 0 To c2 - 1
                        For k As Integer = 0 To r2 - 1
                            result += array1(i, k) * array2(k, j)
                        Next
                        result = Math.Round(result, 4)
                        str += result & vbTab
                        result = 0
                    Next
                    str += vbCrLf
                Next
                TextBox7.Text = "The result of Array 1 x Array 2 is :" & vbCrLf & vbCrLf & str
                b4 = 0
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Select Case MsgBox("Do you want to use the same input array values?", MsgBoxStyle.YesNoCancel)
            Case MsgBoxResult.Yes
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()
                TextBox1.ReadOnly = True
                TextBox2.ReadOnly = True
                TextBox3.ReadOnly = True
                TextBox4.ReadOnly = True
                Button1.Enabled = True
                Button2.Enabled = True
                Button3.Enabled = True
                Me.Size = New Size(250, 400)
                Button1.Focus()
                b4 = 1
            Case MsgBoxResult.No
                TextBox1.ReadOnly = False
                TextBox2.ReadOnly = False
                TextBox3.ReadOnly = False
                TextBox4.ReadOnly = False
                Me.Size = New Size(250, 400)
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()
                TextBox1.Focus()
                Button1.Enabled = True
                Button2.Enabled = True
                Button3.Enabled = True
            Case MsgBoxResult.Cancel
                Button1.Focus()
        End Select
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("The matrix calculator lets you perform addition, subtraction, and multiplication of 2 matrices whose elements, number of rows, and number of columns are all user inputs.")
    End Sub
    Sub StoreElements(ByVal x As Integer, ByVal y As Integer, ByVal ArrayNum As Integer, ByVal btn4 As Integer)
        Dim arr(x - 1, y - 1) As Double
        Dim str As String = ""
        If btn4 = 0 Then
            Select Case ArrayNum
                Case 1
                    ReDim array1(x - 1, y - 1)
                Case 2
                    ReDim array2(x - 1, y - 1)
            End Select
            MessageBox.Show("Please input the elements of Array " & ArrayNum & " row by row, from left to right.")
            For i As Integer = 0 To x - 1
                For j As Integer = 0 To y - 1
                    Dim message As String = "The value for Array " & ArrayNum & " at index (" & i & ", " & j & ") is :"
                    Dim sngA As Single
                    Dim newarr(1), newinput As String
                    newinput = InputBox(message, "Array Elements")
                    If newinput.Contains("/") Then
                        newarr = newinput.Split("/")
                        If Not IsNumeric(newarr(0)) Or Not IsNumeric(newarr(1)) Then
                            MessageBox.Show("Error! Please input numeric values only.")
                            newinput = InputBox(message, "Array Elements")
                        Else
                            sngA = CDec(newarr(0) / newarr(1))
                            arr(i, j) = Math.Round(sngA, 4)
                        End If
                    ElseIf Not IsNumeric(newinput) Then
                        MessageBox.Show("Error! Please input numeric values only.")
                        newinput = InputBox(message, "Array Elements")
                    Else
                        arr(i, j) = Math.Round(CDbl(newinput), 4)
                    End If
                    Select Case ArrayNum
                        Case 1
                            array1(i, j) = arr(i, j)
                        Case 2
                            array2(i, j) = arr(i, j)
                    End Select
                    str += CStr(arr(i, j)) & vbTab
                Next
                str += vbCrLf
            Next
        Else
            For i As Integer = 0 To x - 1
                For j As Integer = 0 To y - 1
                    Select Case ArrayNum
                        Case 1
                            str += CStr(array1(i, j)) & vbTab
                        Case 2
                            str += CStr(array2(i, j)) & vbTab
                    End Select
                Next
                str += vbCrLf
            Next
        End If
        Select Case ArrayNum
            Case 1
                TextBox5.Text = "The elements of Array" & ArrayNum & " are :" & vbCrLf & vbCrLf & str
            Case 2
                TextBox6.Text = "The elements of Array" & ArrayNum & " are :" & vbCrLf & vbCrLf & str
        End Select
    End Sub
    Sub IncludeScrollBar(ByVal x As Integer, ByVal y As Integer, ByVal ArrayNum As Integer)
        If x >= 3 And y >= 5 Then
            Select Case ArrayNum
                Case 1
                    TextBox5.ScrollBars = ScrollBars.Both
                Case 2
                    TextBox6.ScrollBars = ScrollBars.Both
                Case 3
                    TextBox7.ScrollBars = ScrollBars.Both
            End Select
        ElseIf x >= 3 Then
            Select Case ArrayNum
                Case 1
                    TextBox5.ScrollBars = ScrollBars.Vertical
                Case 2
                    TextBox6.ScrollBars = ScrollBars.Vertical
                Case 3
                    TextBox7.ScrollBars = ScrollBars.Vertical
            End Select
        ElseIf y >= 5 Then
            Select Case ArrayNum
                Case 1
                    TextBox5.ScrollBars = ScrollBars.Horizontal
                Case 2
                    TextBox6.ScrollBars = ScrollBars.Horizontal
                Case 3
                    TextBox7.ScrollBars = ScrollBars.Horizontal
            End Select
        Else
            Select Case ArrayNum
                Case 1
                    TextBox5.ScrollBars = ScrollBars.None
                Case 2
                    TextBox6.ScrollBars = ScrollBars.None
                Case 3
                    TextBox7.ScrollBars = ScrollBars.None
            End Select
        End If
    End Sub
    Private Sub TextBoxes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
