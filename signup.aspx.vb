Imports System.Data.OleDb

Public Class signup
    Inherits System.Web.UI.Page
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\source\repos\contactBook\My Project\contactBook.mdb")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        tbuser.Text = ""
        tbpass1.Text = ""
        tbpass2.Text = ""
    End Sub

    Protected Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Try
            Dim res As Integer
            Dim qry = "insert into [user] ([username],[password]) values(@NAME,@PWD);"

            'Dim qry = "insert into [user] ([username],[password]) values('" & tbuser.Text & "','" & tbpass1.Text & "');"

            cn.Open()
            Dim cmd As New OleDbCommand(qry, cn)

            cmd.Parameters.AddWithValue("@NAME", tbuser.Text)
            cmd.Parameters.AddWithValue("@PWD", tbpass1.Text)

            res = cmd.ExecuteNonQuery()
            MsgBox(res.ToString)
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
