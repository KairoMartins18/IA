Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.noeuser = TextBox1.Text
        My.Settings.Save()
        Form1.lbuser.Text = TextBox1.Text
        Me.Close()
    End Sub
End Class