Public Class FirstStart
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Username = TextBox1.Text
        My.Settings.Password = TextBox2.Text
        My.Settings.Save()
        Me.Hide()
        Form1.Hide()
        Desktop.Show()
    End Sub
End Class