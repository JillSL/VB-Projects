Public Class Form2
    Public button2click As Boolean

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Centroid()
        Form1.newData()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form1.Centroid()
        button2click = True
        Me.Close()
        Form1.plot.Enabled = False
        MsgBox("X Component of the Centroid: " & Math.Round((Form1.xCen), 2))
        MsgBox("Y Component of the Centroid: " & Math.Round((Form1.yCen), 2))
    End Sub

    Public Sub drawcentroid(ByVal g As Graphics)

        Form1.Centroid()
    End Sub

End Class