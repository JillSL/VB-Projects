Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B, C, D, X, Y As Double
        If TextBox2.Text = "0" Then
            MessageBox.Show("Error! Please input a nonzero value for A.")
            TextBox2.Clear()
            TextBox2.Focus()
        ElseIf IsNumeric(TextBox2.Text) And IsNumeric(TextBox3.Text) And IsNumeric(TextBox4.Text) Then
            A = TextBox2.Text
            B = TextBox3.Text
            C = TextBox4.Text
            D = B ^ 2 - 4 * A * C
            If D = 0 OrElse D > 0 Then
                X = (-B + Math.Sqrt(D)) / (2 * A)
                Y = (-B - Math.Sqrt(D)) / (2 * A)
                TextBox1.Text = Math.Round(X, 3)
                TextBox5.Text = Math.Round(Y, 3)
                If D = 0 Then
                    Label6.Text = "Real and Equal"
                Else
                    Label6.Text = "Real and Unequal"
                End If
            Else
                X = Math.Round(-B / (2 * A), 3)
                Y = Math.Round(Math.Sqrt(Math.Abs(D)) / (2 * A), 3)
                TextBox1.Text = X & " + " & Y & "i"
                TextBox5.Text = X & " - " & Y & "i"
                Label6.Text = "Imaginary"
            End If
        ElseIf Not IsNumeric(TextBox2.Text) Then
            If Not IsNumeric(TextBox3.Text) Then
                If Not IsNumeric(TextBox4.Text) Then
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    TextBox2.Focus()
                    MessageBox.Show("Error! Please input numerical values for A, B, and C.")
                ElseIf IsNumeric(TextBox4.Text) Then
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox2.Focus()
                    MessageBox.Show("Error! Please input a numerical value for A and B.")
                End If
            ElseIf Not IsNumeric(TextBox4.Text) Then
                TextBox2.Clear()
                TextBox4.Clear()
                TextBox2.Focus()
                MessageBox.Show("Error! Please input a numerical value for A and C.")
            ElseIf IsNumeric(TextBox3.Text) And IsNumeric(TextBox4.Text) Then
                TextBox2.Clear()
                TextBox2.Focus()
                MessageBox.Show("Error! Please input a numerical value for A.")
            End If
        ElseIf Not IsNumeric(TextBox3.Text) Then
            If Not IsNumeric(TextBox4.Text) Then
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox3.Focus()
                MessageBox.Show("Error! Please input a numerical value for B and C.")
            ElseIf IsNumeric(TextBox4.Text) Then
                TextBox3.Clear()
                TextBox3.Focus()
                MessageBox.Show("Error! Please input a numerical value for B.")
            End If
        ElseIf Not IsNumeric(TextBox4.Text) Then
            TextBox4.Clear()
            TextBox4.Focus()
            MessageBox.Show("Error! Please input a numerical value for C.")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            Close()
        ElseIf dialog = DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Clear()
        TextBox5.Clear()
        Label6.Text = “Ready. Please enter the coefficients of the equation.”
        TextBox2.Focus()
    End Sub

    Private Sub PinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem.Click
        Me.BackColor = Color.Pink
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.BackColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.BackColor = Color.LightGreen
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.BackColor = Color.White
    End Sub

    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.Empty
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Clear()
        TextBox5.Clear()
        Label6.Text = “Ready. Please enter the coefficients of the equation.”
        TextBox2.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to close the app?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub
End Class
