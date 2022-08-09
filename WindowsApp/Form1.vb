Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value = 0
        Dim a As Integer
        Dim b As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        Timer1.Start()
        ProgressBar1.Value = Timer1.Interval
        If ProgressBar1.Value = 100 Then
            If a > b Then
                Label6.Show()
                Label6.Text = ">"
            End If
            If a < b Then
                Label6.Show()
                Label6.Text = "<"
            End If
            If a = b Then
                Label6.Show()
                Label6.Text = "="
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label6.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Settings.Show()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        About.Show()
    End Sub
End Class
