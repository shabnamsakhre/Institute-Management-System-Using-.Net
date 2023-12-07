Imports System.Data.OleDb


Public Class Form3

    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\account.accdb")
    Private Sub signup_btn_Click(sender As Object, e As EventArgs) Handles signup_btn.Click
        If signup_name.Text = Nothing Or signup_uname.Text = Nothing Or signup_pass.Text = Nothing Then
            MessageBox.Show("Please Enter Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        mycon.Open()
        Dim mycmd As New OleDbCommand("INSERT INTO account(name, uname, pass) VALUES ('" & signup_name.Text & "', '" & signup_uname.Text & "', '" & signup_pass.Text & "')", mycon)

        Try
            mycmd.ExecuteNonQuery()
            mycon.Close()

            MessageBox.Show("Account Created Successfully")

            signup_name.Clear()
            signup_uname.Clear()
            signup_pass.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class