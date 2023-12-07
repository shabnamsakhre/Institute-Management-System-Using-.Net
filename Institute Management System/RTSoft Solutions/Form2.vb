Imports System.Data.OleDb

Public Class Form2

    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\account.accdb")


    Private Sub signup_btn_Click(sender As Object, e As EventArgs) Handles signup_btn.Click
        Me.Hide()
        Form3.ShowDialog()


    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        mycon.Open()

        If user_txt.Text = Nothing Or pass_txt.Text = Nothing Then
            MessageBox.Show("Please Enter Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim mycmd As New OleDbCommand("SELECT * FROM account WHERE uname = '" & user_txt.Text & "' AND pass = '" & pass_txt.Text & "'", mycon)
        Dim myread As OleDbDataReader = mycmd.ExecuteReader

        If myread.Read Then
            Me.Hide()
            Form4.ShowDialog()


        Else
            MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        mycon.Close()

        user_txt.Clear()
        pass_txt.Clear()


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class