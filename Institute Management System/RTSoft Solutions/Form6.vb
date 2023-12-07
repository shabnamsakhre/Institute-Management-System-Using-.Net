Imports System.Data.OleDb

Public Class Form6

    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\registration.accdb")

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.Open()
        Dim StNum As Integer
        Dim myread = "SELECT COUNT(*) from registration"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(myread, mycon)
        StNum = cmd.ExecuteScalar
        stu_lbl.Text = StNum

        Dim FacNum As Integer
        Dim myfac = "SELECT COUNT(*) FROM facreg"
        Dim faccmd As OleDbCommand
        faccmd = New OleDbCommand(myfac, mycon)
        FacNum = faccmd.ExecuteScalar
        fac_lbl.Text = FacNum



        mycon.Close()



    End Sub
End Class