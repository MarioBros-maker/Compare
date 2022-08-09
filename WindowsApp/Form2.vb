Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        WindowsApp.Main.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.Text = "设置"
        Button1.Text = "完成"
        Label1.Text = "语言"
        WindowsApp.Main.Text = "比较程序"
        WindowsApp.Main.Label1.Text = "请输入数字："
        WindowsApp.Main.Label4.Text = "经鉴定，a"
        WindowsApp.Main.Button1.Text = "比较"
        WindowsApp.About.Text = "关于"
        WindowsApp.About.Label1.Text = "比较程序"
        WindowsApp.About.Label2.Text = "作者：Miriao"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Me.Text = "Settings"
        Button1.Text = "OK"
        Label1.Text = "Languages"
        WindowsApp.Main.Text = "Compare"
        WindowsApp.Main.Label1.Text = "Please enter numbers:"
        WindowsApp.Main.Label4.Text = "I think a"
        WindowsApp.Main.Button1.Text = "Compare"
        WindowsApp.About.Text = "About"
        WindowsApp.About.Button1.Text = "OK"
        WindowsApp.About.Label1.Text = "Compare"
        WindowsApp.About.Label2.Text = "Author:Miriao"
    End Sub
End Class