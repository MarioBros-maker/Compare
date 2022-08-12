Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double   '将a,b定义为64 位双精度浮点型'
        a = TextBox1.Text
        b = TextBox2.Text   '让a,b的内容等于文本框中输入的内容'
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
