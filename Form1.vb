Imports System.Data.SqlClient
Imports System.Drawing.Text

Public Class Form1
    Dim Con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If (UsernameTb.Text = "") Then
            Label2.Visible = True
            UsernameTb.Focus()
            Exit Sub

        End If
        If (PasswordTb).Text = ("") Then
            Label3.Visible = True
            Label2.Visible = False
            PasswordTb.Focus()
            Exit Sub
        End If
        Try
            Con = New SqlConnection("Data Source=DESKTOP-9ERDDO0\SQLEXPRESS;Initial Catalog=airline;Integrated Security=True")
            Con.Open()
            cmd = New SqlCommand("select * From LoginTbl where username='" & UsernameTb.Text & "' and password='" & PasswordTb.Text & "'")
            cmd.Connection = Con
            rdr = cmd.ExecuteReader()
            If (rdr.Read()) Then
                MsgBox("Login Successful")
                Form2.Show()
                Me.Hide()
            Else
                Label2.Visible = False
                Label3.Visible = False
                Label6.Visible = True
                UsernameTb.Text = ""
                PasswordTb.Text = ""
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class
