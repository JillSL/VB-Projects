Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.AirTable' table. You can move, or remove it, as needed.
        Me.AirTableTableAdapter.Fill(Me.Database1DataSet.AirTable)

    End Sub

    Private Sub AirTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AirTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AirTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub
End Class
