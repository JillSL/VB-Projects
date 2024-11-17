<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PicDraw = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.plot = New System.Windows.Forms.Button()
        Me.position = New System.Windows.Forms.GroupBox()
        Me.saas = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.y = New System.Windows.Forms.TextBox()
        Me.sRadius = New System.Windows.Forms.TextBox()
        Me.sHeight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sWidth = New System.Windows.Forms.TextBox()
        Me.x = New System.Windows.Forms.TextBox()
        Me.shapes = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rectangle = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PicDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.position.SuspendLayout()
        Me.shapes.SuspendLayout()
        CType(Me.rectangle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.PicDraw)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 636)
        Me.Panel1.TabIndex = 0
        '
        'PicDraw
        '
        Me.PicDraw.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PicDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicDraw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicDraw.Location = New System.Drawing.Point(0, 0)
        Me.PicDraw.Name = "PicDraw"
        Me.PicDraw.Size = New System.Drawing.Size(1061, 636)
        Me.PicDraw.TabIndex = 0
        Me.PicDraw.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.edit)
        Me.Panel2.Controls.Add(Me.reset)
        Me.Panel2.Controls.Add(Me.plot)
        Me.Panel2.Controls.Add(Me.position)
        Me.Panel2.Controls.Add(Me.shapes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(226, 636)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 421)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Shape List"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 437)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(198, 119)
        Me.TextBox1.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(114, 601)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "&Delete Shape"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(12, 601)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(96, 23)
        Me.edit.TabIndex = 7
        Me.edit.Text = "&Edit Shape"
        Me.edit.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(114, 574)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(97, 23)
        Me.reset.TabIndex = 8
        Me.reset.Text = "&Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'plot
        '
        Me.plot.Location = New System.Drawing.Point(12, 574)
        Me.plot.Name = "plot"
        Me.plot.Size = New System.Drawing.Size(96, 23)
        Me.plot.TabIndex = 7
        Me.plot.Text = "Plot"
        Me.plot.UseVisualStyleBackColor = True
        '
        'position
        '
        Me.position.Controls.Add(Me.saas)
        Me.position.Controls.Add(Me.Label6)
        Me.position.Controls.Add(Me.Label4)
        Me.position.Controls.Add(Me.Label5)
        Me.position.Controls.Add(Me.y)
        Me.position.Controls.Add(Me.sRadius)
        Me.position.Controls.Add(Me.sHeight)
        Me.position.Controls.Add(Me.Label3)
        Me.position.Controls.Add(Me.sWidth)
        Me.position.Controls.Add(Me.x)
        Me.position.Location = New System.Drawing.Point(12, 303)
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(199, 115)
        Me.position.TabIndex = 1
        Me.position.TabStop = False
        Me.position.Text = "Dimensions"
        '
        'saas
        '
        Me.saas.AutoSize = True
        Me.saas.Location = New System.Drawing.Point(85, 82)
        Me.saas.Name = "saas"
        Me.saas.Size = New System.Drawing.Size(43, 13)
        Me.saas.TabIndex = 1
        Me.saas.Text = "Radius:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Height:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Y:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Width:"
        '
        'y
        '
        Me.y.Location = New System.Drawing.Point(33, 53)
        Me.y.Name = "y"
        Me.y.Size = New System.Drawing.Size(46, 20)
        Me.y.TabIndex = 3
        '
        'sRadius
        '
        Me.sRadius.Location = New System.Drawing.Point(132, 79)
        Me.sRadius.Name = "sRadius"
        Me.sRadius.Size = New System.Drawing.Size(51, 20)
        Me.sRadius.TabIndex = 6
        '
        'sHeight
        '
        Me.sHeight.Location = New System.Drawing.Point(132, 53)
        Me.sHeight.Name = "sHeight"
        Me.sHeight.Size = New System.Drawing.Size(51, 20)
        Me.sHeight.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "X:"
        '
        'sWidth
        '
        Me.sWidth.Location = New System.Drawing.Point(132, 27)
        Me.sWidth.Name = "sWidth"
        Me.sWidth.Size = New System.Drawing.Size(51, 20)
        Me.sWidth.TabIndex = 4
        '
        'x
        '
        Me.x.Location = New System.Drawing.Point(33, 27)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(46, 20)
        Me.x.TabIndex = 2
        '
        'shapes
        '
        Me.shapes.Controls.Add(Me.Label1)
        Me.shapes.Controls.Add(Me.rectangle)
        Me.shapes.Location = New System.Drawing.Point(12, 9)
        Me.shapes.Name = "shapes"
        Me.shapes.Size = New System.Drawing.Size(199, 210)
        Me.shapes.TabIndex = 1
        Me.shapes.TabStop = False
        Me.shapes.Text = "Shapes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rectangle"
        '
        'rectangle
        '
        Me.rectangle.Image = CType(resources.GetObject("rectangle.Image"), System.Drawing.Image)
        Me.rectangle.Location = New System.Drawing.Point(17, 34)
        Me.rectangle.Name = "rectangle"
        Me.rectangle.Size = New System.Drawing.Size(79, 36)
        Me.rectangle.TabIndex = 0
        Me.rectangle.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.plot
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 636)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Centroid Calculator: Composite Shapes"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PicDraw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.position.ResumeLayout(False)
        Me.position.PerformLayout()
        Me.shapes.ResumeLayout(False)
        Me.shapes.PerformLayout()
        CType(Me.rectangle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents shapes As System.Windows.Forms.GroupBox
    Friend WithEvents PicDraw As System.Windows.Forms.PictureBox
    Friend WithEvents position As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents y As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents x As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents sHeight As System.Windows.Forms.TextBox
    Friend WithEvents sWidth As System.Windows.Forms.TextBox
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents plot As System.Windows.Forms.Button
    Friend WithEvents saas As System.Windows.Forms.Label
    Friend WithEvents sRadius As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rectangle As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
