Public Class Form1
    Dim intXOrigin, intYOrigin, cCounter, rCounter, tCounter, sCounter, shapenum As Integer
    Dim xShape, yShape, h, w, radius, shapelist, t As Single
    Public xCen, yCen As Double
    Dim circlelist() As Circle 'arraylist
    Dim rectlist() As Rectangle
    Dim trilist() As Triangle
    Dim semilist() As Semicircle
    Dim blnPlot As Boolean = False

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If IsNothing(circlelist) And IsNothing(rectlist) And IsNothing(trilist) And IsNothing(semilist) Then
            intXOrigin = 0
            intYOrigin = 0
            cCounter = 0
            rCounter = 0
            tCounter = 0
            sCounter = 0
            shapenum = 0
            shapelist = 0
            shade.Enabled = False
            plot.Enabled = False
            position.Enabled = False
            shapes.Focus()
        Else : reset.PerformClick()
        End If
    End Sub

    Public Sub DrawAxes(ByVal g As Graphics)
        intXOrigin = 265 'Calculates the x-origin
        intYOrigin = PicDraw.Height - 50 'Calculates the y-origin
        Dim myfont As New Font("Arial", 10, FontStyle.Regular)
        g.Clear(Color.Black)
        g.DrawLine(Pens.Red, 0, intYOrigin, PicDraw.Width, intYOrigin) 'draw x-axis
        g.DrawLine(Pens.Red, intXOrigin, 0, intXOrigin, PicDraw.Height) 'draw y-axis
        g.DrawString("(0, 0)", myfont, Brushes.Green, intXOrigin, intYOrigin) 'add label to origin
        g.DrawString("x-axis", myfont, Brushes.Green, intXOrigin + 750, intYOrigin) 'add label to x-axis
        g.DrawString("y-axis", myfont, Brushes.Green, intXOrigin + 5, 0) 'add label to y-axis
        'draws x-axis labels
        Dim xx As Integer = 0
        For i = intXOrigin + 100 To PicDraw.Width Step 100
            xx += 10
            g.DrawLine(Pens.Red, i, intYOrigin - 10, i, intYOrigin + 10)
            g.DrawString(xx, myfont, Brushes.Red, i - 10, intYOrigin + 10)
        Next

        'draws y-axis labels
        Dim yy As Integer = 0
        For i = intYOrigin - 100 To 0 Step -100
            yy += 10
            g.DrawString(yy, myfont, Brushes.Red, intXOrigin - 30, i - 10)
            g.DrawLine(Pens.Red, intXOrigin - 10, i, intXOrigin + 10, i)
        Next
    End Sub

    Public Sub btnPlot_Click(sender As System.Object, e As System.EventArgs) Handles plot.Click
        'error handling
        Try
            If x.Text = "" Then
                MsgBox("Input Error: Please put input x value", , "Centroid Calculator")
                x.Focus()
            Else
                If y.Text = "" Then
                    MsgBox("Input Error: Please put input y value", , "Centroid Calculator")
                    y.Focus()
                Else
                    If positive.Checked = False And negative.Checked = False Then : MsgBox("Please choose a shape property")
                    Else
                        xShape = x.Text '+ x origin
                        yShape = y.Text '+ y origin
                        If positive.Checked = True Then : t = 0
                        Else : t = 1
                        End If

                        'instantiating the classes and filling the lists
                        Select Case shapenum
                            Case 0 'rectangle
                                If sWidth.Text <> "" And sHeight.Text <> "" Then
                                    w = sWidth.Text
                                    h = sHeight.Text
                                    ReDim Preserve rectlist(rCounter)
                                    Dim sshape = New Rectangle(xShape, yShape, w, h, t)
                                    rectlist(rCounter) = sshape

                                    rCounter += 1
                                Else
                                    MsgBox("Input Error: Please input Height and/or Width", , "Centroid Calculator")
                                    sWidth.Focus()
                                End If
                            Case 1 'circle
                                If sRadius.Text <> "" Then
                                    radius = sRadius.Text
                                    ReDim Preserve circlelist(cCounter)
                                    Dim sshape = New Circle(xShape, yShape, radius, t)
                                    circlelist(cCounter) = sshape
                                    cCounter += 1
                                Else
                                    MsgBox("Input Error: Please input Radius", , "Centroid Calculator")
                                    sRadius.Focus()
                                End If
                            Case 2 'semicircle
                                If sRadius.Text <> "" Then
                                    'yung radius ng textbox ay diameter sa drawing
                                    radius = sRadius.Text
                                    ReDim Preserve semilist(sCounter)
                                    Dim sshape = New Semicircle(xShape, yShape, radius, t)
                                    semilist(sCounter) = sshape
                                    sCounter += 1
                                Else
                                    MsgBox("Input Error: Please input Radius", , "Centroid Calculator")
                                    sRadius.Focus()
                                End If
                            Case 3 'triangle
                                If sWidth.Text <> "" And sHeight.Text <> "" Then
                                    w = sWidth.Text
                                    h = sHeight.Text
                                    ReDim Preserve trilist(tCounter)
                                    Dim sshape = New Triangle(xShape, yShape, w, h, t)
                                    trilist(tCounter) = sshape
                                    tCounter += 1
                                Else
                                    MsgBox("Input Error: Please input Height and/or Width", , "Centroid Calculator")
                                    sWidth.Focus()
                                End If
                        End Select
                    End If

                    'put on text box
                    TextBox1.Text = "Shapes" & vbTab & "x" & vbTab & "y" & vbTab & "w" & vbTab & "h" & vbTab & "r" & vbTab & "type" & vbNewLine & vbNewLine

                    Dim type As String
                    If t = 0 Then : type = "Positive"
                    Else : type = "Negative"
                    End If

                    'pacheck kasi yung ibang labels ay malayo sa shapes tulad ng semicircle
                    'TODO : CHECK YUNG TYPE SA DRAWING AND SA DITO SA BABA
                    If IsNothing(rectlist) = False Then
                        For i As Integer = 0 To UBound(rectlist)
                            TextBox1.Text &= "R" & i & ": " & vbTab & CSng(rectlist(i).x) & vbTab & CSng(rectlist(i).y) & vbTab & CSng(rectlist(i).width) & vbTab & CSng(rectlist(i).height) & vbTab & vbTab & rectlist(i).shapeType() & vbNewLine
                        Next
                    End If
                    If IsNothing(circlelist) = False Then
                        For i As Integer = 0 To UBound(circlelist)
                            TextBox1.Text &= "C" & i & ": " & vbTab & CSng(circlelist(i).x) & vbTab & CSng(circlelist(i).y) & vbTab & vbTab & vbTab & CSng(circlelist(i).radius) & vbTab & circlelist(i).shapeType() & vbNewLine
                        Next
                    End If
                    If IsNothing(semilist) = False Then
                        For i As Integer = 0 To UBound(semilist)
                            TextBox1.Text &= "S" & i & ": " & vbTab & CSng(semilist(i).x) & vbTab & CSng(semilist(i).y) & vbTab & vbTab & vbTab & CSng(semilist(i).radius) & vbTab & semilist(i).shapeType() & vbNewLine
                        Next
                    End If
                    If IsNothing(trilist) = False Then
                        For i As Integer = 0 To UBound(trilist)
                            TextBox1.Text &= "T" & i & ": " & vbTab & CSng(trilist(i).x) & vbTab & CSng(trilist(i).y) & vbTab & CSng(trilist(i).width) & vbTab & CSng(trilist(i).height) & vbTab & vbTab & trilist(i).shapeType() & vbNewLine
                        Next
                    End If

                    'Plotting
                    blnPlot = True
                    PicDraw.Refresh()
                End If
            End If
        Catch ex As Exception
            MsgBox("Input Error: multiple dots (...) found", , "Centroid Calculator")
            x.Clear()
            y.Clear()
            sWidth.Clear()
            sHeight.Clear()
            sRadius.Clear()
            x.Focus()
        End Try

    End Sub

    '-------------------DRAWING SUB------------------------'
    Public Sub PicDraw_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles PicDraw.Paint
        Dim gPaint As Graphics = e.Graphics
        Dim myfont As New Font("Arial", 10, FontStyle.Regular)
        Dim shapespicture As New Bitmap(PicDraw.Width, PicDraw.Height)
        gPaint.FillEllipse(Brushes.Red, CInt(xCen), CInt(yCen), 5, 5)
        gPaint.DrawString("x:" & xCen, myfont, Brushes.Red, 300, 300)
        gPaint.DrawString("y:" & yCen, myfont,
                          Brushes.Red, 330, 300)
        Select Case True
            Case blnPlot
                Call DrawAxes(gPaint)

                Dim shapefont As New Font("Arial", 8, FontStyle.Bold)
                Dim multiplier As Integer = 10
                Dim xwidth As Single = x.Text
                Dim yheight As Single = y.Text

                If IsNothing(rectlist) = False Then
                    For i As Integer = 0 To UBound(rectlist)
                        xShape = CSng(rectlist(i).x * multiplier)
                        yShape = CSng(rectlist(i).y * multiplier)
                        w = CSng(rectlist(i).width * multiplier)
                        h = CSng(rectlist(i).height * multiplier)

                        If rectlist(i).type = 0 Then : gPaint.FillRectangle(Brushes.LightBlue, intXOrigin + xShape, intYOrigin - yShape - h, w, h)
                        Else : gPaint.FillRectangle(Brushes.Black, intXOrigin + xShape, intYOrigin - yShape - h, w, h)
                        End If
                        gPaint.DrawString("R" & i, shapefont, Brushes.Blue, intXOrigin + xShape, intYOrigin - yShape - h)
                    Next

                End If
                If IsNothing(circlelist) = False Then
                    For i As Integer = 0 To UBound(circlelist)
                        xShape = CSng(circlelist(i).x * multiplier)
                        yShape = CSng(circlelist(i).y * multiplier)
                        radius = CSng(circlelist(i).radius * multiplier) * 2
                        If circlelist(i).type = 0 = True Then : gPaint.FillEllipse(Brushes.LightBlue, New Drawing.Rectangle(intXOrigin + xShape - radius / 2, intYOrigin - yShape - radius / 2, radius, radius))
                        Else : gPaint.FillEllipse(Brushes.Black, New Drawing.Rectangle(intXOrigin + xShape - radius / 2, intYOrigin - yShape - radius / 2, radius, radius))
                        End If
                        gPaint.DrawString("C" & i, shapefont, Brushes.Blue, intXOrigin + xShape, intYOrigin - yShape - h)
                    Next
                End If

                If IsNothing(semilist) = False Then
                    For i As Integer = 0 To UBound(semilist)
                        xShape = CSng(semilist(i).x * multiplier)
                        yShape = CSng(semilist(i).y * multiplier)
                        'radius ay diameter recheck sa centroid calc
                        radius = CSng(semilist(i).radius * multiplier * 2)
                        If semilist(i).type = 0 Then : e.Graphics.FillPie(New SolidBrush(Color.LightBlue), New Drawing.Rectangle(intXOrigin + xShape - radius / 2, intYOrigin - yShape - radius / 2, radius, radius), 0, -180)
                        Else : e.Graphics.FillPie(New SolidBrush(Color.Black), New Drawing.Rectangle(intXOrigin + xShape - radius / 2, intYOrigin - yShape - radius / 2, radius, radius), 0, -180)
                        End If
                        gPaint.DrawString("S" & i, shapefont, Brushes.Blue, intXOrigin + xShape, intYOrigin - yShape - h)
                    Next
                End If
                If IsNothing(trilist) = False Then
                    For i As Integer = 0 To UBound(trilist)
                        xShape = CSng(trilist(i).x * multiplier)
                        yShape = CSng(trilist(i).y * multiplier)
                        w = CSng(trilist(i).width * multiplier)
                        h = CSng(trilist(i).height * multiplier)

                        Dim A As New Point(intXOrigin + xShape, intYOrigin - yShape - h)
                        Dim B As New Point(intXOrigin + xShape, intYOrigin - yShape)
                        Dim C As New Point(intXOrigin + xShape + w, intYOrigin - yShape)
                        Dim myPoints As Point() = {A, B, C}
                        If trilist(i).type = 0 Then : e.Graphics.FillPolygon(New SolidBrush(Color.LightBlue), myPoints)
                        Else : e.Graphics.FillPolygon(New SolidBrush(Color.Black), myPoints)
                        End If
                        gPaint.DrawString("T" & i, shapefont, Brushes.Blue, intXOrigin + xShape, intYOrigin - yShape - h)
                    Next
                End If

                Form2.Show()
                Call Centroid()

                'TODO: Draw a circle with Xcen and Ycen calculated in the picture box along with a label
                gPaint.FillEllipse(Brushes.Red, (intXOrigin + CInt(xCen) * multiplier - 5), intYOrigin - CInt(yCen) * multiplier - 5, 10, 10)
                gPaint.DrawString("x:" & xCen, myfont, Brushes.Red, intXOrigin + CInt(xCen) * multiplier + 10, intYOrigin - CInt(yCen) * multiplier)
                gPaint.DrawString("y:" & yCen, myfont, Brushes.Red, intXOrigin + CInt(xCen) * multiplier + 10, intYOrigin - CInt(yCen) * multiplier + 12)

            Case Else
                gPaint.Clear(Color.Black) 'clearing of all graphics
                Call DrawAxes(gPaint) 'drawing of axes
        End Select
    End Sub

    Public Sub Centroid()
        Dim sumArea, sumAX, sumAY As Double

        'for sum area
        If IsNothing(rectlist) = False Then
            For i As Integer = 0 To UBound(rectlist)
                'check if the shape is positive or negative
                If rectlist(i).type = 0 Then
                    sumArea += rectlist(i).Area
                    sumAY += rectlist(i).Area * rectlist(i).YBar
                    sumAX += rectlist(i).Area * rectlist(i).XBar
                Else
                    sumAX -= rectlist(i).Area * rectlist(i).XBar
                    sumArea -= rectlist(i).Area
                    sumAY -= rectlist(i).Area * rectlist(i).YBar
                End If
            Next
        End If
        If IsNothing(circlelist) = False Then
            For i As Integer = 0 To UBound(circlelist)
                'check if the shape is positive or negative
                If circlelist(i).type = 0 Then
                    sumArea += circlelist(i).Area
                    sumAY += circlelist(i).Area * circlelist(i).YBar
                    sumAX += circlelist(i).Area * circlelist(i).XBar
                Else
                    sumAX -= circlelist(i).Area * circlelist(i).XBar
                    sumAY -= circlelist(i).Area * circlelist(i).YBar
                    sumArea -= circlelist(i).Area
                End If
            Next
        End If
        If IsNothing(semilist) = False Then
            For i As Integer = 0 To UBound(semilist)
                'check if the shape is positive or negative
                If semilist(i).type = 0 Then
                    sumArea += semilist(i).Area
                    sumAY += semilist(i).Area * semilist(i).YBar
                    sumAX += semilist(i).Area * semilist(i).XBar
                Else
                    sumAX -= semilist(i).Area * semilist(i).XBar
                    sumAY -= semilist(i).Area * semilist(i).YBar
                    sumArea -= semilist(i).Area
                End If
            Next
        End If
        If IsNothing(trilist) = False Then
            For i As Integer = 0 To UBound(trilist)
                'check if the shape is positive or negative
                If trilist(i).type = 0 Then
                    sumArea += trilist(i).Area
                    sumAY += trilist(i).Area * trilist(i).YBar
                    sumAX += trilist(i).Area * trilist(i).XBar
                Else
                    sumAX -= trilist(i).Area * trilist(i).XBar
                    sumAY -= trilist(i).Area * trilist(i).YBar
                    sumArea -= trilist(i).Area
                End If
            Next
        End If

        xCen = Math.Round(sumAX / sumArea, 2)
        yCen = Math.Round(sumAY / sumArea, 2)

        'testing
        ' MsgBox("Sum of Area: " & sumArea)
        ' MsgBox("Sum of AY: " & sumAY)
        ' MsgBox("Sum of AX: " & sumAX)

    End Sub

    Public Sub drawcentroid(ByVal g As Graphics)
        g.DrawEllipse(Pens.Red, CInt(xCen), CInt(yCen), 1, 1)
    End Sub

    'TEXT RESTRAINTS HANDLING
    Public Sub allKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles x.KeyPress, y.KeyPress, sWidth.KeyPress, sHeight.KeyPress, sRadius.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
        Else : e.KeyChar = ""
        End If
    End Sub


    '----------------------------BUTTONS-----------------------------'
    Public Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        MsgBox("Please pick a shape", , "Centroid Calculator")
        x.Clear()
        y.Clear()
        sWidth.Clear()
        sHeight.Clear()
        sRadius.Clear()
        TextBox1.Clear()
        blnPlot = False
        shapes.Enabled = True
        position.Enabled = False
        shade.Enabled = False
        positive.Checked = False
        negative.Checked = False
        plot.Enabled = False
        PicDraw.Refresh()
        'additional to reset all drawing
        intXOrigin = 0
        intYOrigin = 0
        cCounter = 0
        rCounter = 0
        tCounter = 0
        sCounter = 0
        shapenum = 0
        shapelist = 0
        rectlist = Nothing
        circlelist = Nothing
        semilist = Nothing
        trilist = Nothing
    End Sub

    Public Sub newData()
        MsgBox("Please pick a shape", , "Centroid Calculator")
        x.Clear()
        y.Clear()
        sWidth.Clear()
        sHeight.Clear()
        sRadius.Clear()
        shapes.Enabled = True
        shade.Enabled = False
        position.Enabled = False
        positive.Checked = False
        negative.Checked = False
    End Sub

    '----------------------------CLICKING THE SHAPES-----------------------------
    Public Sub rectangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rectangle.Click
        shapenum = 0
        shade.Enabled = True
        shapes.Enabled = False
        sRadius.Enabled = False
        sRadius.Enabled = False
        sHeight.Enabled = True
        sWidth.Enabled = True
    End Sub

    Public Sub circle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles circle.Click
        shapenum = 1
        shapes.Enabled = False
        shade.Enabled = True
        sWidth.Enabled = False
        sHeight.Enabled = False
        sRadius.Enabled = True
    End Sub

    Public Sub semicircle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles semicircle.Click
        shapenum = 2
        shapes.Enabled = False
        shade.Enabled = True
        sWidth.Enabled = False
        sHeight.Enabled = False
        sRadius.Enabled = True
    End Sub

    Public Sub triangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles triangle.Click
        shapenum = 3
        shapes.Enabled = False
        shade.Enabled = True
        sRadius.Enabled = False
        sHeight.Enabled = True
        sWidth.Enabled = True
    End Sub

    Private Sub positive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles positive.MouseClick
        position.Enabled = True
        plot.Enabled = True
        x.Focus()
    End Sub

    Private Sub negative_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles negative.MouseClick
        position.Enabled = True
        plot.Enabled = True
        x.Focus()
    End Sub

End Class

'----------------------------CLASSES FOR THE SHAPES-----------------------------'
Public Class Circle
    Public x, y, radius As Double   'check if Dim or Public
    Public type As Integer '0 if positive, 1 if negative

    Public Sub New(ByVal x As Double, ByVal y As Double, ByVal r As Double, ByVal t As Integer)
        Me.x = x
        Me.y = y
        Me.radius = r
        Me.type = t
    End Sub

    Function Area()
        Return Math.PI * (Me.radius ^ 2)
    End Function

    Function XBar()
        Return Me.x
    End Function

    Function YBar()
        Return Me.y
    End Function

    Function shapeType()
        If Me.type = 0 Then
            Return "Positive"
        Else
            Return "Negative"
        End If
    End Function

End Class

Public Class Rectangle
    Public x, y, width, height As Double
    Public type As Integer '0 if positive, 1 if negative

    Public Sub New(ByVal x As Double, ByVal y As Double, ByVal w As Double, ByVal h As Double, ByVal t As Integer)
        Me.x = x
        Me.y = y
        Me.width = w
        Me.height = h
        Me.type = t
    End Sub

    Function Area()
        Return Me.width * Me.height
    End Function

    Function XBar()
        Return Me.x + (Me.width / 2)
    End Function

    Function YBar()
        Return Me.y + (Me.height / 2)
    End Function

    Function shapeType()
        If Me.type = 0 Then
            Return "Positive"
        Else
            Return "Negative"
        End If
    End Function

End Class

Public Class Triangle
    Public x, y, width, height As Double
    Dim fh, fv, rc, rcc As Boolean
    Public type As Integer '0 if positive, 1 if negative

    Public Sub New(ByVal x As Double, ByVal y As Double, ByVal w As Double, ByVal h As Double, ByVal t As Integer)
        Me.x = x
        Me.y = y
        Me.width = w
        Me.height = h
        Me.type = t
    End Sub
    Function Area()
        Return (1 / 2) * Me.width * Me.height
    End Function

    Function XBar()
        Return Me.x + (Me.width / 3)
    End Function

    Function YBar()
        Return Me.y + (Me.height / 3)
    End Function

    Function shapeType()
        If Me.type = 0 Then
            Return "Positive"
        Else
            Return "Negative"
        End If
    End Function
End Class

Public Class Semicircle
    Public x, y, radius As Double
    Dim fh, fv, rc, rcc As Boolean
    Public type As Integer '0 if positive, 1 if negative

    Public Sub New(ByVal x As Double, ByVal y As Double, ByVal r As Double, ByVal t As Integer)
        Me.x = x
        Me.y = y
        Me.radius = r
        Me.type = t
    End Sub

    Function Area()
        Return Math.PI * (Me.radius ^ 2) / 2
    End Function

    Function XBar()
        Return Me.x
    End Function

    Function YBar()
        Return y + (4 * Me.radius) / (Math.PI * 3)
    End Function

    Function shapeType()
        If Me.type = 0 Then
            Return "Positive"
        Else
            Return "Negative"
        End If
    End Function
End Class
