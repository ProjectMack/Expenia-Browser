Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.Username = TextBox1.Text And My.Settings.Password = TextBox2.Text Then
            MsgBox("Loading...")
            Desktop.Show()
            Me.Close()
            Form1.Hide()
        Else
            MsgBox("Sorry, either your username or password is incorrect.")
            TextBox2.Text = ""
            ' FIX THIS THING RETURNING FALSE EVERY TIME...
        End If
    End Sub
End Class



'read username and password from text file