Imports System.Data.OleDb


Public Class Form7
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\registration.accdb")

    Private Sub clear_btn_Click(sender As Object, e As EventArgs)

        fname_txt.Clear()
        mname_txt.Clear()
        lname_txt.Clear()
        email_txt.Clear()
        branch_txt.Clear()
        contact_txt.Clear()
        add_txt.Clear()


    End Sub

    Private Sub sub_btn_Click_1(sender As Object, e As EventArgs) Handles sub_btn.Click
        mycon.Open()
        Dim mycmd As New OleDbCommand("INSERT INTO registration(fname, mname, lname, email, dob, gender, address, contact, stream, branch, admiDate) VALUES ('" & fname_txt.Text & "', '" & mname_txt.Text & "', '" & lname_txt.Text & "', '" & email_txt.Text & "', '" & dob_txt.Value & "', '" & gender_txt.Text & "', '" & add_txt.Text & "', '" & contact_txt.Text & "', '" & stream_txt.Text & "', '" & branch_txt.Text & "', '" & adate_txt.Value & "')", mycon)

        Try
            mycmd.ExecuteNonQuery()
            mycon.Close()

            MessageBox.Show("Registered Successfully")

            fname_txt.Clear()
            mname_txt.Clear()
            lname_txt.Clear()
            email_txt.Clear()
            branch_txt.Clear()
            contact_txt.Clear()
            add_txt.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class