Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value = 0
        Dim a As Integer
        Dim b As Integer   '将a,b定义为无符号整数，因此在输入小数的时候会四舍五入'
        a = TextBox1.Text
        b = TextBox2.Text   '让a,b的内容等于文本框中输入的内容'
        Timer1.Start()
        ProgressBar1.Value = Timer1.Interval
        If ProgressBar1.Value = 100 Then   '做了一个没啥用的进度条'
            If a > b Then
                Label6.Show()
                Label6.Text = ">"   '如果a>b显示大于号，以下同理'
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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Help.Show()
    End Sub
End Class
