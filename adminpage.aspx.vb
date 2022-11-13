
Imports System.Data.OleDb
Imports System.Data

Imports System.Data.DataView
Imports System.Data.DataRowView
Public Class adminpage
    Inherits System.Web.UI.Page

    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\source\repos\contactBook\My Project\contactBook.mdb")
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim str = "select * from [user]"
        Dim cmd As New OleDbCommand(str, cn)
        Dim adp = New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        adp.Fill(ds)
        'GridViewUser.DataSource = ds.Tables(0)
        'GridViewUser.DataBind()

    End Sub

    Protected Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Try
            Dim qry As String
            Dim res As Integer

            qry = "delete from [user] where username='" & DropDownUser.SelectedValue & "'and password='" & tbpass.Text & "'"

            Dim cmd As New OleDbCommand(qry, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            GridViewUser.DataBind()
            MsgBox("Deleted")
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Protected Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click
        Try
            Dim qry As String

            qry = "update [user] set username='" & DropDownUser.SelectedValue & "'  and password='" & tbpass.Text & "'"

            cn.Open()
            Dim cmd = New OleDbCommand(qry, cn)
            cmd.ExecuteNonQuery()
            GridViewUser.DataBind()
            cn.Close()
            MsgBox("Updated")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Protected Sub btndel0_Click(sender As Object, e As EventArgs) Handles btndel0.Click
        Try
            Dim qry As String
            Dim res As Integer


            qry = "delete from contact where cnum=" & tbnum.Text & ""

            Dim cmd As New OleDbCommand(qry, cn)
            cn.Open()
            res = cmd.ExecuteNonQuery
            GridViewUser.DataBind()
            cn.Close()
            MsgBox("Deleted")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Protected Sub btnupd0_Click(sender As Object, e As EventArgs) Handles btnupd0.Click
        Try
            Dim qry As String
            Dim res As Integer

            qry = "update [contact] set username='" & tbnum.Text & "'and password='" & tbpass.Text & "'"

            Dim cmd As New OleDbCommand(qry, cn)
            cn.Open()
            res = cmd.ExecuteNonQuery
            GridViewUser.DataBind()
            cn.Close()
            MsgBox("Updated")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class