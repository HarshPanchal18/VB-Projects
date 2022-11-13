Imports System.Data.OleDb

Public Class mainHome
    Inherits System.Web.UI.Page

    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\source\repos\contactBook\My Project\contactBook.mdb")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim qry As String
            Dim field1 As String = CType(Session.Item("user"), String)

            qry = "insert into contacts(cname,cnum,ccity,created_by) values('" & tbname.Text & "'," & tbnum.Text & ",'" & tbcity.Text & "','" & field1 & "')"
            cn.Open()
            Dim cmd As New OleDbCommand(qry, cn)
            Dim res As Integer
            cmd.ExecuteNonQuery()
            GridView1.DataBind()

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Protected Sub btnUpd_Click(sender As Object, e As EventArgs) Handles btnUpd.Click
        Try
            Dim qry As String

            qry = "update [contact] set cname='" & tbname.Text & "'  and cnum='" & tbnum.Text & "' and ccity='" & tbcity.Text & "'"

            cn.Open()
            Dim cmd = New OleDbCommand(qry, cn)
            cmd.ExecuteNonQuery()
            'GridViewUser.DataBind()
            cn.Close()
            MsgBox("Updated")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Protected Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            Dim qry As String

            qry = "delete from [contact] where cname='" & tbname.Text & "'"

            cn.Open()
            Dim cmd = New OleDbCommand(qry, cn)
            cmd.ExecuteNonQuery()
            'GridViewUser.DataBind()
            cn.Close()
            MsgBox("Updated")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Protected Sub btnSrcName_Click(sender As Object, e As EventArgs) Handles btnSrcName.Click
        Try
            cn.Open()
            Dim qry As String
            qry = "select * from [contact] where cname"
        Catch ex As Exception

        End Try
    End Sub
End Class