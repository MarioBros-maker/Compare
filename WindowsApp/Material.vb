Imports MaterialSkin
Public Class Material
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Hide()
        Dim a As Double
        Dim b As Double
        a = TextBox1.Text
        b = TextBox2.Text
        If a > b Then
            Label4.Show()
            Label4.Text = ">"
        End If
        If a < b Then
            Label4.Show()
            Label4.Text = "<"
        End If
        If a = b Then
            Label4.Show()
            Label4.Text = "="
        End If
    End Sub
End Class