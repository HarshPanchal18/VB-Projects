Imports System.Data.OleDb

Public Class insert
    Inherits System.Web.UI.Page

    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\studentasp.mdb")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'GridView1.Visible = False
    End Sub

    Protected Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            Dim str As String
            Dim ans As Integer

            str = "Insert into Stud values(" & tbnum.Text & ",'" & tbname.Text & "','" & tbstr.Text & "'," & tbsem.Text & "," & tbper.Text & ")"
            cn.Open()

            Dim cmd As New OleDbCommand(str, cn)
            ans = cmd.ExecuteNonQuery
            MsgBox("Inserted")
            GridView1.DataBind()
            ' GridView1.Visible = True
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Protected Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Try
            Dim str As String
            Dim ans As Integer

            str = "delete from Stud where rno=" & tbnum.Text & ""

            Dim cmd As New OleDbCommand(str, cn)
            cn.Open()
            ans = cmd.ExecuteNonQuery
            cn.Close()

            MsgBox("Deleted")
            GridView1.DataBind()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Protected Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click
        Try
            Dim str As String
            Dim ans As Integer

            str = "update Stud set sname='" & tbname.Text & "',stream='" & tbstr.Text & "',perc=" & tbper.Text & " where rno=" & tbnum.Text

            Dim cmd As New OleDbCommand(str, cn)
            cn.Open()
            ans = cmd.ExecuteNonQuery

            MsgBox("Updated")
            GridView1.DataBind()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Protected Sub btnsrch_Click(sender As Object, e As EventArgs) Handles btnsrch.Click
        Try
            cn.Open()
            Dim str As String
            str = "select * from Stud where rno=" & tbnum.Text & ""

            Dim cmd As New OleDbCommand(str, cn)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader

            While dr.Read
                tbname.Text = dr.Item(1).ToString
                tbstr.Text = dr.Item(2).ToString
                tbsem.Text = dr.Item(3).ToString
                tbper.Text = dr.Item(4).ToString
            End While

            GridView1.DataBind()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
