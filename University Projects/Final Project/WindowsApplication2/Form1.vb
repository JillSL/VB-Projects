Public Class Form1
    Dim intXOrigin, intYOrigin, cCounter, rCounter, tCounter, sCounter, qCounter, shapenum As Integer
    Dim xShape, yShape, h, w, radius As Double
    Dim circlelist() As Circle 'arraylist
    Dim rectlist() As Rectangle
    Dim trilist() As Triangle
    Dim semilist() As Semicircle
    Dim quarlist() As Quartercircle
    Dim blnPlot As Boolean = False

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'form reload
        ReDim circlelist(0)
        ReDim rectlist(0)
        ReDim trilist(0)
        ReDim semilist(0)
        ReDim quarlist(0)
        reset.PerformClick()
    End Sub

    Private Sub DrawAxes(ByVal g As Graphics)
        x.Text = PicDraw.Width
        y.Text = PicDraw.Height
        intXOrigin = 265 'Calculates the x-origin
        intYOrigin = PicDraw.Height - 50 'Claculates the y-origin
        Dim myfont As New Font("Arial", 8, FontStyle.Regular)
        g.Clear(Color.Black)
        g.DrawLine(Pens.Red, 0, intYOrigin, PicDraw.Width, intYOrigin) 'draw x-axis
        g.DrawLine(Pens.Red, intXOrigin, 0, intXOrigin, PicDraw.Height) 'draw y-axis
        g.DrawString("(0, 0)", myfont, Brushes.Green, intXOrigin, intYOrigin) 'add label to origin
        g.DrawString("x-axis", myfont, Brushes.Green, intXOrigin + 750, intYOrigin) 'add label to x-axis
        g.DrawString("y-axis", myfont, Brushes.Green, intXOrigin + 5, 0) 'add label to y-axis
    End Sub

    Private Sub btnPlot_Click(sender As System.Object, e As System.EventArgs) Handles plot.Click
        'input
        Try
            If x.Text = "" Then
                MsgBox("No input: X value", , "Centroid Calculator")
                x.Focus()
            End If
            If y.Text = "" Then
                MsgBox("No input: Y value", , "Centroid Calculator")
                y.Focus()
            End If
            If y.Text <> "" Or x.Text <> "" Then
                xShape = intXOrigin + x.Text
                yShape = intYOrigin - y.Text
            End If

            If shapenum = 0 Or shapenum = 1 Then
                If sWidth.Text = "" Then
                    MsgBox("No input: Width", , "Centroid Calculator")
                    sWidth.Focus()
                End If
                If sHeight.Text = "" Then
                    MsgBox("No input: Height", , "Centroid Calculator")
                    sHeight.Focus()
                End If
                If sHeight.Text <> "" Or sWidth.Text <> "" Then
                    h = sHeight.Text
                    w = sWidth.Text
                End If

            Else
                If sRadius.Text = "" Then
                    MsgBox("No input: Radius", , "Centroid Calculator")
                    sRadius.Focus()
                Else : radius = sRadius.Text
                End If
            End If

        Catch ex As Exception
            MsgBox("Input Error: Input must be numeric value")
            x.Clear()
            y.Clear()
            sWidth.Clear()
            sHeight.Clear()
            sRadius.Clear()
        End Try



        Call newData()
    End Sub

    'draws the function might not be necessary
    Private Sub PicDraw_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles PicDraw.Paint
        Dim gPaint As Graphics = e.Graphics 'creates the graphics object
        Select Case True
            Case blnPlot
                'Dim pic As New PictureBox 'set bounds to 1st quadrant
                'xShape = intXOrigin + x.Text
                'yShape = intYOrigin - y.Text
                'pic = rectangle
                'pic.SetBounds(xShape, yShape, w, -h)
                gPaint.FillRectangle(Brushes.LightBlue, intXOrigin, intYOrigin - 10, 60, 10)
                'Calculate the centroid

                'Draw the centroidCall DrawAxes(gPaint) 'draw axes
                
            Case Else
                gPaint.Clear(Color.Black) 'clearing of all graphics
                Call DrawAxes(gPaint) 'drawing of axes
        End Select
    End Sub


    'all the shapes have the same content
    Private Sub rectangle_Click(sender As Object, e As EventArgs) Handles rectangle.Click
        MsgBox("Set the position and dimension", , "Centroid Calculator")
        position.Enabled = True

        'put in array
        rCounter += 1
        ReDim Preserve rectlist(rCounter - 1)
        Dim rectangle As New Rectangle
        rectlist(rCounter - 1) = rectangle

        'shape identifier
        shapenum = 0
        sRadius.Enabled = False

        'focus on width textbox
        sWidth.Focus()
    End Sub

    'error handling
    Private Sub allKeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles x.KeyPress, y.KeyPress, sWidth.KeyPress, sHeight.KeyPress, sRadius.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
        Else : e.KeyChar = ""
        End If
    End Sub

    Private Sub reset_Click(sender As System.Object, e As System.EventArgs) Handles reset.Click, Button2.Click
        'MsgBox("Please pick a shape", , "Centroid Calculator")
        x.Clear()
        y.Clear()
        sWidth.Clear()
        sHeight.Clear()
        sRadius.Clear()
        blnPlot = False
        position.Enabled = False
        PicDraw.Refresh()
        'additional to reset all drawing
        intXOrigin = 0
        intYOrigin = 0
        cCounter = 0
        rCounter = 0
        tCounter = 0
        sCounter = 0
        qCounter = 0
        shapenum = 0
    End Sub

    Private Sub newData()
        MsgBox("Please pick a shape", , "Centroid Calculator")
        x.Clear()
        y.Clear()
        sWidth.Clear()
        sHeight.Clear()
        sRadius.Clear()
        position.Enabled = False
    End Sub

End Class

Public Class Circle
    Dim x, y, radius As Double

    Function Area(ByVal r As Double)
        Return Math.PI * (r ^ 2)
    End Function

    Function XBar(ByVal x As Double)
        Return x
    End Function

    Function YBar(ByVal y As Double)
        Return y
    End Function

End Class

Public Class Rectangle
    Dim x, y, width, height As Double

    Function Area(ByVal w As Double, ByVal h As Double)
        Return w * h
    End Function

    Function XBar(ByVal x As Double, ByVal w As Double)
        Return x + (w / 2)
    End Function

    Function YBar(ByVal y As Double, ByVal h As Double)
        Return y + (h / 2)
    End Function

    Sub Rotate()

    End Sub

End Class

Public Class Triangle
    Dim x, y, width, height As Double
    Dim fh, fv, rc, rcc As Boolean

    Function Area(ByVal w As Double, ByVal h As Double)
        Return (1 / 2) * w * h
    End Function

    Function XBar(ByVal x As Double, ByVal w As Double)
        Return x + (w / 3)
    End Function

    Function YBar(ByVal y As Double, ByVal h As Double)
        Return y + (h / 3)
    End Function

    Sub FlipHorizontal()

    End Sub

    Sub FlipVertical()

    End Sub

    Sub RotateClockwise()

    End Sub

    Sub RotateCClockwise()

    End Sub
End Class

Public Class Semicircle
    Dim x, y, radius As Double
    Dim fh, fv, rc, rcc As Boolean

    Function Area(ByVal r As Double)
        Return Math.PI * (r ^ 2) / 2
    End Function

    Function XBar(ByVal x As Double)
        Return x
    End Function

    Function YBar(ByVal y As Double, ByVal r As Double)
        Return y + (4 * r) / (Math.PI * 3)
    End Function

    Sub RotateClockwise()

    End Sub

    Sub RotateCClockwise()

    End Sub
End Class

Public Class Quartercircle
    Dim x, y, radius As Double
    Dim fh, fv, rc, rcc As Boolean

    Function Area(ByVal r As Double)
        Return Math.PI * (r ^ 2) / 4
    End Function

    Function XBar(ByVal x As Double, ByVal r As Double)
        Return x + (4 * r) / (Math.PI * 3)
    End Function

    Function YBar(ByVal y As Double, ByVal r As Double)
        Return y + (4 * r) / (Math.PI * 3)
    End Function

    Sub RotateClockwise()

    End Sub

    Sub RotateCClockwise()

    End Sub
End Class
