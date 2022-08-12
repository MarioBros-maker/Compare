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
        WindowsApp.Main.Label4.Text = "我认为，a"
        WindowsApp.Main.Button1.Text = "比较"
        WindowsApp.About.Text = "关于"
        WindowsApp.About.Label1.Text = "比较程序"
        WindowsApp.About.Label2.Text = "作者：Miriao"
        WindowsApp.Help.Label1.Text = "这个程序是我花半个小时完成的，真的几乎没有一点技术含量。由于VB的特性（自己水平不足）导致"
        WindowsApp.Help.Label3.Text = "在比较小数的时候会进行四舍五入，因此会出现类似于114.5=114.6的情况......"
        WindowsApp.Help.Label2.Text = "但我已经满意了（逃"
        Me.Label2.Text = "皮肤"
        Me.RadioButton3.Text = "原版"
        WindowsApp.Material.Text = "比较程序"
        WindowsApp.Material.Label1.Text = "请输入数字："
        WindowsApp.Material.Button1.Text = "比较" '通过手工改变字符来达到切换语言的效果'
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Me.Text = "Settings"
        Button1.Text = "OK"
        Label1.Text = "Languages"
        WindowsApp.Main.Text = "Compare"
        WindowsApp.Main.Label1.Text = "Please enter numbers:"
        WindowsApp.Main.Label4.Text = "I think a"
        WindowsApp.Main.Button1.Text = "Compare!"
        WindowsApp.About.Text = "About"
        WindowsApp.About.Button1.Text = "OK"
        WindowsApp.About.Label1.Text = "Compare"
        WindowsApp.About.Label2.Text = "Author:Miriao"
        WindowsApp.Help.Label1.Text = "This program is finished in about half an hour.Because they are Integers,"
        WindowsApp.Help.Label3.Text = "so something like 114.5=114.6 can occur.But I am very satisfied with it."
        WindowsApp.Help.Label2.Text = "Really."
        Me.Label2.Text = "Skin"
        Me.RadioButton3.Text = "Original"
        WindowsApp.Material.Text = "Compare"
        WindowsApp.Material.Label1.Text = "Please enter numbers:"
        WindowsApp.Material.Button1.Text = "Compare!"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        WindowsApp.Main.Show()
        WindowsApp.Material.Hide() '切换皮肤'
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        WindowsApp.Material.Show()
        WindowsApp.Main.Hide()
    End Sub
End Class