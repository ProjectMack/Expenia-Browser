Public Class Desktop
    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize
        If My.Settings.BKG = "na" Then

        ElseIf Not My.Settings.BKG = "na" Then
            Me.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.BKG)
        Else
            MsgBox("Could not load Desktop Background.")
        End If
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Expenia_OS.Form1.Show()
        Form1.MdiParent = Me
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Discord.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form1.Show()
        login.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog1.InitialDirectory = "C:\WINDOWS"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        My.Settings.BKG = OpenFileDialog1.FileName.ToString
        If Not (strm Is Nothing) Then
            'insert code to read file data
            strm.Close()
        End If
        Me.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.BKG)
        '' Add Expenia browser by: Project>add exsisting thingmabob
    End Sub
End Class