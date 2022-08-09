Public Class Form1
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
                Label6.Text = "大于"
            End If
            If a < b Then
                Label6.Show()
                Label6.Text = "小于"
            End If
            If a = b Then
                Label6.Show()
                Label6.Text = "等于"
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label6.Hide()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
