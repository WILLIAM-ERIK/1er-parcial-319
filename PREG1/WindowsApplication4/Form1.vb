Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)
        If (a > b And a > c) Then GoTo ciclo1
        If (b > a And b > c) Then GoTo ciclo2
        If (c > a And c > b) Then GoTo ciclo3
ciclo1:
        If b > c Then GoTo mayor2 Else GoTo mayor3
        GoTo final
ciclo2:
        If a > c Then GoTo proceso1 Else GoTo proceso2
        GoTo final
ciclo3:
        If a > b Then GoTo proceso3 Else GoTo proceso4
        GoTo final
mayor2:
        TextBox4.Text = a
        TextBox5.Text = b
        TextBox6.Text = c
        GoTo final
mayor3:
        TextBox4.Text = a
        TextBox5.Text = c
        TextBox6.Text = b
        GoTo final
proceso1:
        TextBox4.Text = b
        TextBox5.Text = a
        TextBox6.Text = c
        GoTo final
proceso2:
        TextBox4.Text = b
        TextBox5.Text = c
        TextBox6.Text = a
        GoTo final
proceso3:
        TextBox4.Text = c
        TextBox5.Text = a
        TextBox6.Text = b
        GoTo final
proceso4:
        TextBox4.Text = c
        TextBox5.Text = b
        TextBox6.Text = a
        GoTo final
final:
    End Sub


End Class