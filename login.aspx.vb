Imports System.Data.OleDb
Imports System.Data

Public Class login
    Inherits System.Web.UI.Page

    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\source\repos\contactBook\My Project\contactBook.mdb")

    'DBConn = New OleDbConnection("PROVIDER=" _
    '& "Microsoft.Jet.OLEDB.4.0;" _
    '& "DATA SOURCE=" _
    '& Server.MapPath("LogIn.mdb;"))

    Protected Sub reset()
        tboxuser.Text = ""
        tboxpass.Text = ""
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            If tboxuser.Text = "admin" And tboxpass.Text = "admin" Then
                Response.Redirect("adminpage.aspx")

            Else
                Dim qry As String

                qry = "select * from [user] where username='" & tboxuser.Text & "' and password='" & tboxpass.Text & "'"

                cn.Open()
                Dim cmd = New OleDbCommand(qry, cn)
                Dim adp = New OleDbDataAdapter(cmd)
                Dim ds As New DataSet()
                adp.Fill(ds)

                Dim x As Integer
                x = ds.Tables(0).Rows.Count

                If x = 0 Then
                    MsgBox("Invalid credentials")
                    reset()
                Else
                    Session("user") = tboxuser.Text
                    Session("password") = tboxpass.Text
                    Response.Redirect("userpage.aspx")
                End If
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
