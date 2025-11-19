
Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.Text = "Wisdom Player"
        Me.MaximizeBox = False
    End Sub

    Private Sub btnBrowse_Click_1(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Title = "Selecting File to play..."
        OpenFileDialog1.InitialDirectory = System.Environment.SpecialFolder.Desktop
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnPlay_Click_1(sender As Object, e As EventArgs) Handles btnPlay.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub btnPause_Click_1(sender As Object, e As EventArgs) Handles btnPause.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub btnStop_Click_1(sender As Object, e As EventArgs) Handles btnStop.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub btnFastForward_Click_1(sender As Object, e As EventArgs) Handles btnFastForward.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastForward()
    End Sub

    Private Sub btnFastReverse_Click(sender As Object, e As EventArgs) Handles btnFastReverse.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastReverse()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Try
            If OpenFileDialog1.FileName <> Nothing Or OpenFileDialog1.FileName <> "" Then
                TextBox1.Text = (OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1, (OpenFileDialog1.FileName.IndexOf(".", 0) - (OpenFileDialog1.FileName.LastIndexOf("\") + 1))))
            End If
        Catch ex As Exception
            TextBox1.Text = "UnKnown Title"
        End Try
    End Sub

    
End Class
