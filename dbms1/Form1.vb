Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudtblDataSet.studDetail' table. You can move, or remove it, as needed.
        Me.StudDetailTableAdapter.Fill(Me.StudtblDataSet.studDetail)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudDetailBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        StudDetailBindingSource.AddNew()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        StudDetailBindingSource.MoveNext()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StudDetailBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo SaveErr

        StudDetailBindingSource.EndEdit()
        StudDetailTableAdapter.Update(StudtblDataSet.studDetail)
        MsgBox("Data Upated")

SaveErr:

    End Sub
End Class