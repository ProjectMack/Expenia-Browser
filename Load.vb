Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Settings.Password = "na"
        'My.Settings.Username = "na"
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize
        Cursor.Hide()
        Label1.Text = ""
        Timer1.Start()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            If Not My.Settings.Username = "na" Then
                login.Show()
            Else
                FirstStart.Show()
                Cursor.Show()
            End If
        ElseIf ProgressBar1.Value = 50 Then
            Label1.Text = "EXPENIA OS"
        End If
    End Sub
End Class
