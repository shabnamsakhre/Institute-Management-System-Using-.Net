Public Class Form15



    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0

        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 0

        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.BorderSize = 0

        Button4.FlatStyle = FlatStyle.Flat
        Button4.FlatAppearance.BorderSize = 0

        Button5.FlatStyle = FlatStyle.Flat
        Button5.FlatAppearance.BorderSize = 0

        Button8.FlatStyle = FlatStyle.Flat
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatAppearance.MouseOverBackColor = Color.Transparent


    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel4.Controls.Clear()

        Dim frm As Form6
        frm = New Form6()
        frm.TopLevel = False
        frm.TopMost = True

        Panel4.Controls.Add(frm)

        frm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel4.Controls.Clear()

        Dim frm As Form16
        frm = New Form16()
        frm.TopLevel = False
        frm.TopMost = True

        Panel4.Controls.Add(frm)

        frm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel4.Controls.Clear()

        Dim frm As Form17
        frm = New Form17()
        frm.TopLevel = False
        frm.TopMost = True

        Panel4.Controls.Add(frm)

        frm.Show()
    End Sub
End Class