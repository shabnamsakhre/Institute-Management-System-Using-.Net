Imports System.Data.OleDb

Public Class Form11

    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\registration.accdb")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        mycon.Open()
        Dim mycmd As New OleDbCommand("INSERT INTO facreg([fname], [mname], [lname], [email], [add], [con], [dob], [gen], [edu]) VALUES ('" & fname_txt.Text & "', '" & mname_txt.Text & "', '" & lname_txt.Text & "', '" & email_txt.Text & "', '" & add_txt.Text & "', '" & con_txt.Text & "', '" & date_pkr.Value & "', '" & gen_comb.Text & "', '" & edu_txt.Text & "')", mycon)

        Try
            mycmd.ExecuteNonQuery()
            mycon.Close()

            MessageBox.Show("Registered Successfully")

            fname_txt.Clear()
            mname_txt.Clear()
            lname_txt.Clear()
            email_txt.Clear()
            add_txt.Clear()
            con_txt.Clear()
            edu_txt.Clear()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        fname_txt.Clear()
        mname_txt.Clear()
        lname_txt.Clear()
        email_txt.Clear()
        add_txt.Clear()
        con_txt.Clear()
        edu_txt.Clear()
    End Sub
End Class