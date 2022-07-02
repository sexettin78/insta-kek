Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hesap As String
        hesap = TextBox1.Text
        Label1.Text = ("şifre denemesi 1 başarısız")
        Label2.Text = (" ")
        Label3.Text = ("şifre denemesi 2 başarısız")
        Label4.Text = ("şifre denemesi 3 başarısız")
        Label5.Text = ("şifre denemesi 4 başarısız")
        Label6.Text = ("şifre denemesi 5 başarısız")
        Label7.Text = ("şifre denemesi 6 başarısız")
        MsgBox(hesap & " adlı kullanıcının hesabı hackleniyor...", MsgBoxStyle.Information, "Hesap hackleniyor")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
