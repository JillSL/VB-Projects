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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Temperature__KLabel As System.Windows.Forms.Label
        Dim Specific_Enthalpy__kJ_kgLabel As System.Windows.Forms.Label
        Dim Reduced_PressureLabel As System.Windows.Forms.Label
        Dim Specific_Internal_Energy__kJ_kgLabel As System.Windows.Forms.Label
        Dim Reduced_VolumeLabel As System.Windows.Forms.Label
        Dim Specific_Entropy__Ideal__kJ_kg_KLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Database1DataSet = New CD13_SAN_LUIS_Exercise_6.Database1DataSet()
        Me.AirTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AirTableTableAdapter = New CD13_SAN_LUIS_Exercise_6.Database1DataSetTableAdapters.AirTableTableAdapter()
        Me.TableAdapterManager = New CD13_SAN_LUIS_Exercise_6.Database1DataSetTableAdapters.TableAdapterManager()
        Me.AirTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.AirTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Temperature__KLabel = New System.Windows.Forms.Label()
        Specific_Enthalpy__kJ_kgLabel = New System.Windows.Forms.Label()
        Reduced_PressureLabel = New System.Windows.Forms.Label()
        Specific_Internal_Energy__kJ_kgLabel = New System.Windows.Forms.Label()
        Reduced_VolumeLabel = New System.Windows.Forms.Label()
        Specific_Entropy__Ideal__kJ_kg_KLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AirTableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FileToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(929, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.FileToolStripMenuItem1.Text = "&Help"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 57)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Specific_Entropy__Ideal__kJ_kg_KLabel)
        Me.GroupBox2.Controls.Add(Reduced_VolumeLabel)
        Me.GroupBox2.Controls.Add(Specific_Internal_Energy__kJ_kgLabel)
        Me.GroupBox2.Controls.Add(Reduced_PressureLabel)
        Me.GroupBox2.Controls.Add(Specific_Enthalpy__kJ_kgLabel)
        Me.GroupBox2.Controls.Add(Temperature__KLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 189)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Compute"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(117, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(222, 91)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "&Show Data >>>>"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(198, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(186, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AirTableBindingSource
        '
        Me.AirTableBindingSource.DataMember = "AirTable"
        Me.AirTableBindingSource.DataSource = Me.Database1DataSet
        '
        'AirTableTableAdapter
        '
        Me.AirTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AirTableTableAdapter = Me.AirTableTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = CD13_SAN_LUIS_Exercise_6.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AirTableBindingNavigator
        '
        Me.AirTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AirTableBindingNavigator.BindingSource = Me.AirTableBindingSource
        Me.AirTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AirTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AirTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AirTableBindingNavigatorSaveItem})
        Me.AirTableBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.AirTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AirTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AirTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AirTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AirTableBindingNavigator.Name = "AirTableBindingNavigator"
        Me.AirTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AirTableBindingNavigator.Size = New System.Drawing.Size(929, 25)
        Me.AirTableBindingNavigator.TabIndex = 5
        Me.AirTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'AirTableBindingNavigatorSaveItem
        '
        Me.AirTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AirTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("AirTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AirTableBindingNavigatorSaveItem.Name = "AirTableBindingNavigatorSaveItem"
        Me.AirTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.AirTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Temperature__KLabel
        '
        Temperature__KLabel.AutoSize = True
        Temperature__KLabel.Location = New System.Drawing.Point(12, 22)
        Temperature__KLabel.Name = "Temperature__KLabel"
        Temperature__KLabel.Size = New System.Drawing.Size(83, 13)
        Temperature__KLabel.TabIndex = 0
        Temperature__KLabel.Text = "Temperature, K:"
        '
        'Specific_Enthalpy__kJ_kgLabel
        '
        Specific_Enthalpy__kJ_kgLabel.AutoSize = True
        Specific_Enthalpy__kJ_kgLabel.Location = New System.Drawing.Point(12, 48)
        Specific_Enthalpy__kJ_kgLabel.Name = "Specific_Enthalpy__kJ_kgLabel"
        Specific_Enthalpy__kJ_kgLabel.Size = New System.Drawing.Size(129, 13)
        Specific_Enthalpy__kJ_kgLabel.TabIndex = 2
        Specific_Enthalpy__kJ_kgLabel.Text = "Specific Enthalpy, k J/kg:"
        '
        'Reduced_PressureLabel
        '
        Reduced_PressureLabel.AutoSize = True
        Reduced_PressureLabel.Location = New System.Drawing.Point(12, 74)
        Reduced_PressureLabel.Name = "Reduced_PressureLabel"
        Reduced_PressureLabel.Size = New System.Drawing.Size(98, 13)
        Reduced_PressureLabel.TabIndex = 4
        Reduced_PressureLabel.Text = "Reduced Pressure:"
        '
        'Specific_Internal_Energy__kJ_kgLabel
        '
        Specific_Internal_Energy__kJ_kgLabel.AutoSize = True
        Specific_Internal_Energy__kJ_kgLabel.Location = New System.Drawing.Point(12, 100)
        Specific_Internal_Energy__kJ_kgLabel.Name = "Specific_Internal_Energy__kJ_kgLabel"
        Specific_Internal_Energy__kJ_kgLabel.Size = New System.Drawing.Size(159, 13)
        Specific_Internal_Energy__kJ_kgLabel.TabIndex = 6
        Specific_Internal_Energy__kJ_kgLabel.Text = "Specific Internal Energy, k J/kg:"
        '
        'Reduced_VolumeLabel
        '
        Reduced_VolumeLabel.AutoSize = True
        Reduced_VolumeLabel.Location = New System.Drawing.Point(12, 126)
        Reduced_VolumeLabel.Name = "Reduced_VolumeLabel"
        Reduced_VolumeLabel.Size = New System.Drawing.Size(92, 13)
        Reduced_VolumeLabel.TabIndex = 8
        Reduced_VolumeLabel.Text = "Reduced Volume:"
        '
        'Specific_Entropy__Ideal__kJ_kg_KLabel
        '
        Specific_Entropy__Ideal__kJ_kg_KLabel.AutoSize = True
        Specific_Entropy__Ideal__kJ_kg_KLabel.Location = New System.Drawing.Point(12, 152)
        Specific_Entropy__Ideal__kJ_kg_KLabel.Name = "Specific_Entropy__Ideal__kJ_kg_KLabel"
        Specific_Entropy__Ideal__kJ_kg_KLabel.Size = New System.Drawing.Size(163, 13)
        Specific_Entropy__Ideal__kJ_kg_KLabel.TabIndex = 10
        Specific_Entropy__Ideal__kJ_kg_KLabel.Text = "Specific Entropy (Ideal),k J/kg-K:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(184, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(184, 45)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(184, 71)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(184, 97)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(184, 123)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 15
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(184, 149)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 329)
        Me.Controls.Add(Me.AirTableBindingNavigator)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Air Property Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AirTableBindingNavigator.ResumeLayout(False)
        Me.AirTableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents AirTableBindingSource As BindingSource
    Friend WithEvents AirTableTableAdapter As Database1DataSetTableAdapters.AirTableTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AirTableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AirTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
