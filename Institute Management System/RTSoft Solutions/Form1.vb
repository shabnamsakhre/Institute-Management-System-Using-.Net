Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value <= 10 Then
            Label1.Text = "Initializing System"
        ElseIf ProgressBar1.Value <= 30 Then
            Label1.Text = "Loading All Components"
        ElseIf ProgressBar1.Value <= 50 Then
            Label1.Text = "Integrating Database"
        ElseIf ProgressBar1.Value <= 70 Then
            Label1.Text = "Please Wait"
        ElseIf ProgressBar1.Value <= 100 Then
            Label1.Text = "Welcome to RTSoft Solutions"

            If ProgressBar1.Value = 100 Then
                Timer1.Dispose()
                Me.Hide()
                Form2.ShowDialog()
                Me.Close()
            End If
        End If
    End Sub


End Class
