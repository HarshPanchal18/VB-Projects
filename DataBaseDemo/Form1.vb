Imports System.Data.OleDb

Public Class Form1
    Dim cn As New OleDbConnection
    Dim ds As New DataSet
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As New OleDbDataAdapter

    Public Sub display()
        ds.Clear()
        Dim qry As String
        qry = "select * from stud"
        adp = New OleDbDataAdapter(qry, cn)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP\source\repos\DataBaseDemo\DataBaseDemo\Database3.mdb"
        cn.Open()
        display()
        cn.Close()
    End Sub

    Private Sub InsBtn_Click(sender As Object, e As EventArgs) Handles InsBtn.Click
        Try
            cn.Open()
            Dim qry As String
            qry = "insert into stud values(" & TBoxNo.Text & "," & "'" & TBoxNm.Text & "'," & "'" & TBoxCity.Text & "'," & TBoxSem.Text & ")"
            cmd = New OleDbCommand(qry, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Inserted")
            display()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        cn.Close()
    End Sub

    Private Sub SrchBtn_Click(sender As Object, e As EventArgs) Handles SrchBtn.Click
        Try
            cn.Open()
            Dim qry As String
            qry = "select * from stud where stud_id =" & TBoxNo.Text
            cmd = New OleDbCommand(qry, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                TBoxNm.Text = dr.Item(1)
                TBoxCity.Text = dr.Item(2)
                TBoxSem.Text = dr.Item(3)
            End While

        Catch ex As Exception
            MsgBox("Error")
        End Try
        cn.Close()
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        Try
            cn.Open()
            Dim qry As String
            qry = "delete from stud where stud_id =" & TBoxNo.Text
            cmd = New OleDbCommand(qry, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted")
            display()
        Catch ex As Exception
            MsgBox("Erro")
        End Try
        cn.Close()
    End Sub

    Private Sub SrchNm_Click(sender As Object, e As EventArgs) Handles SrchNm.Click
        Try
            cn.Open()
            Dim qry As String
            qry = "select * from stud where  name ='" & TBoxNm.Text & "'"
            cmd = New OleDbCommand(qry, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                TBoxNo.Text = dr.Item(0)
                TBoxCity.Text = dr.Item(2)
                TBoxSem.Text = dr.Item(3)
            End While

        Catch ex As Exception
            MsgBox("Error")
        End Try
        cn.Close()
    End Sub

    Private Sub UpdBtn_Click(sender As Object, e As EventArgs) Handles UpdBtn.Click
        Try
            cn.Open()
            Dim qry As String
            qry = "update stud set name ='" & TBoxNm.Text & "' where stud_id = " & TBoxNo.Text
            cmd = New OleDbCommand(qry, cn)
            dr = cmd.ExecuteReader()
            MsgBox("Updated")
            display()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        cn.Close()
    End Sub
End Class