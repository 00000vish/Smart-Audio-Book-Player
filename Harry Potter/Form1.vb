Imports System.IO
Imports System.Net
Imports System.Security.Principal

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (principal.IsInRole(WindowsBuiltInRole.Administrator)) Then
            SleepToolStripMenuItem.BackColor = Color.Yellow
        End If

        Try
            setUpPlayer()
            setUpAdmin()
            getLocation(True)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub setUpAdmin()
        If (principal.IsInRole(WindowsBuiltInRole.Administrator)) Then
            ShutDownPcToolStripMenuItem.Enabled = True
        Else
            ShutDownPcToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub setUpPlayer()
        If (My.Settings.fileLoc.ToString <> "") Then
            AxWindowsMediaPlayer1.URL = My.Settings.fileLoc.ToString
            If (My.Settings.lastAuTime.ToString <> "") Then
                AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = My.Settings.lastAuTime
                If (AxWindowsMediaPlayer1.Ctlcontrols.currentPosition > 5) Then
                    AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 5
                    PlayToolStripMenuItem.Text = "Pause"
                    PlayToolStripMenuItem.Image = My.Resources._1454111120_pause_circle_fill
                End If
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                AxWindowsMediaPlayer1.settings.volume = 100
            End If
        Else
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        End If
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        If PlayToolStripMenuItem.Text = "Play" Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            PlayToolStripMenuItem.Text = "Pause"
            PlayToolStripMenuItem.Image = My.Resources._1454111120_pause_circle_fill
        Else
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            PlayToolStripMenuItem.Text = "Play"
            PlayToolStripMenuItem.Image = My.Resources._1454111105_play_circle_fill
        End If
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        If (OpenFileDialog1.FileName <> "") Then
            My.Settings.fileLoc = OpenFileDialog1.FileName
            My.Settings.Save()
            AxWindowsMediaPlayer1.URL = My.Settings.fileLoc
        Else
            MsgBox("Error, File not found or supported", MsgBoxStyle.Exclamation, "AudioBook Player")
        End If
    End Sub

    Private Sub LastPositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LastPositionToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = My.Settings.lastAuTime - 5
    End Sub
    Dim Last As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ManSaved.Text = My.Settings.lastManTime.ToString.Split(".")(0) + "s Manual Saved"
        ManSaving.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString.Split(".")(0) + "s Save"
        AutoSave.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString.Split(".")(0) + "s AUTO SAVING"
        AutoSaved.Text = My.Settings.lastAuTime.ToString.Split(".")(0) + "s Auto Saved"

        SpeedToolStripMenuItem.Text = "Speed x" + AxWindowsMediaPlayer1.settings.rate.ToString("0.00")

        If Last <> AxWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString Then
            Last = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString
            PlayToolStripMenuItem.Text = "Pause"
            PlayToolStripMenuItem.Image = My.Resources._1454111120_pause_circle_fill
        Else
            PlayToolStripMenuItem.Text = "Play"
            PlayToolStripMenuItem.Image = My.Resources._1454111105_play_circle_fill
        End If

        My.Settings.lastAuTime = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
        My.Settings.Save()
    End Sub

    Private Sub AutoSavedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoSaved.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = My.Settings.lastAuTime
    End Sub

    Private Sub ManualSavedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManSaved.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = My.Settings.lastManTime
    End Sub

    Private Sub SaveLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManSaving.Click
        My.Settings.lastManTime = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
        My.Settings.Save()
        okDone = My.Settings.lastManTime
        upload()
    End Sub


    Dim identity = WindowsIdentity.GetCurrent()
    Dim principal = New WindowsPrincipal(identity)

    Private Sub shutDown(tome As Integer)
        If (principal.IsInRole(WindowsBuiltInRole.Administrator)) Then
            Timer2.Interval = tome
            Timer2.Start()
        Else
            MsgBox("Please run this program as admin to get Shut Down Pc In working", MsgBoxStyle.Information, "Audio Book Player")
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        upload()
        SleepToolStripMenuItem.BackColor = Color.LimeGreen
        System.Diagnostics.Process.Start("shutdown", "-s -t 00")
    End Sub

    Private Sub SleepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SleepToolStripMenuItem.Click
        If (principal.IsInRole(WindowsBuiltInRole.Administrator)) Then
            SleepToolStripMenuItem.BackColor = Color.LimeGreen
        End If
    End Sub

    Private Sub SToolStripMenuItem3_Click_1(sender As Object, e As EventArgs) Handles SToolStripMenuItem3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition + 5
    End Sub

    Private Sub SToolStripMenuItem4_Click_1(sender As Object, e As EventArgs) Handles SToolStripMenuItem4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition + 10
    End Sub

    Private Sub SToolStripMenuItem5_Click_1(sender As Object, e As EventArgs) Handles SToolStripMenuItem5.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition + 15
    End Sub

    Private Sub SToolStripMenuItem8_Click_1(sender As Object, e As EventArgs) Handles SToolStripMenuItem8.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition + 20
    End Sub

    Private Sub SToolStripMenuItem9_Click_1(sender As Object, e As EventArgs) Handles SToolStripMenuItem9.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition + 30
    End Sub

    Private Sub SToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 5
    End Sub

    Private Sub SToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles SToolStripMenuItem1.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 10
    End Sub

    Private Sub SToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles SToolStripMenuItem2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 15
    End Sub

    Private Sub SToolStripMenuItem6_Click_1(sender As Object, e As EventArgs) Handles SToolStripMenuItem6.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 20
    End Sub

    Private Sub SToolStripMenuItem7_Click_1(sender As Object, e As EventArgs) Handles SToolStripMenuItem7.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 30
    End Sub
    Private Sub X05ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X05ToolStripMenuItem.Click
        If AxWindowsMediaPlayer1.settings.isAvailable("Rate") Then
            AxWindowsMediaPlayer1.settings.rate = 0.5
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 15
        End If
    End Sub

    Private Sub X12ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X12ToolStripMenuItem.Click
        If AxWindowsMediaPlayer1.settings.isAvailable("Rate") Then
            AxWindowsMediaPlayer1.settings.rate = 1.2
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 15
        End If
    End Sub

    Private Sub X13ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X13ToolStripMenuItem.Click
        If AxWindowsMediaPlayer1.settings.isAvailable("Rate") Then
            AxWindowsMediaPlayer1.settings.rate = 1.3
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 15
        End If
    End Sub

    Private Sub X14ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X14ToolStripMenuItem.Click
        If AxWindowsMediaPlayer1.settings.isAvailable("Rate") Then
            AxWindowsMediaPlayer1.settings.rate = 1.4
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 15
        End If
    End Sub

    Private Sub X15ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X15ToolStripMenuItem.Click
        If AxWindowsMediaPlayer1.settings.isAvailable("Rate") Then
            AxWindowsMediaPlayer1.settings.rate = 1.5
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 15
        End If
    End Sub

    Private Sub X20ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X20ToolStripMenuItem.Click
        If AxWindowsMediaPlayer1.settings.isAvailable("Rate") Then
            AxWindowsMediaPlayer1.settings.rate = 2.0
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 15
        End If
    End Sub

    Private Sub MinToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MinToolStripMenuItem1.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition + 60
    End Sub

    Private Sub MinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 60
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        If AxWindowsMediaPlayer1.settings.isAvailable("Rate") Then
            AxWindowsMediaPlayer1.settings.rate = 1.0
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 15
        End If
    End Sub

    Private Sub X11ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X11ToolStripMenuItem.Click
        If AxWindowsMediaPlayer1.settings.isAvailable("Rate") Then
            AxWindowsMediaPlayer1.settings.rate = 1.1
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 15
        End If
    End Sub

    Private Sub StopShutDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopShutDownToolStripMenuItem.Click
        Process.Start(Application.ExecutablePath)
        Me.Close()
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub OnlineSavedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlineSavedToolStripMenuItem.Click
        getLocation(False)
    End Sub

    Private Sub MinToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub shutDownApp(tome As Integer)
        Timer3.Interval = tome
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        My.Settings.Save()
        Me.Close()
    End Sub

    Dim okDone As String
    Private Sub upload()
        Try
            If okDone <> "" Then
                Dim request As WebRequest = WebRequest.Create("http://datadump.net16.net/post.php?w=" & "<html><body>" & okDone & "</body></html>")
                request.GetResponse()
            End If

        Catch ex As Exception

        End Try
        getLocation(True)
    End Sub

    Private Sub getLocation(locate As Boolean)
        Try
            Dim address As String = "http://datadump.net16.net/data.html"
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            Dim loc As String = reader.ReadToEnd

            Dim spiltOne As String() = New String() {"</body>"}
            Dim spiltTwo As String() = New String() {"<body>"}
            Dim shit As Integer = loc.Split(spiltOne, False)(0).Split(spiltTwo, False)(1)

            OnlineSavedToolStripMenuItem.Text = Convert.ToInt32(shit) & " Online Saved"
            If (locate) Then
            Else
                AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToInt32(shit)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        upload()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        shutDown(900000)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        shutDown(1200000.0)
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        shutDown(1800000.0)
    End Sub

    Private Sub HourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HourToolStripMenuItem.Click
        shutDown(3600000.0)
    End Sub

    Private Sub HoursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoursToolStripMenuItem.Click
        shutDown(7200000.0)
    End Sub

    Private Sub HoursToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HoursToolStripMenuItem1.Click
        shutDown(10800000.0)
    End Sub

    Private Sub MinToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles MinToolStripMenuItem4.Click
        shutDownApp(900000)
    End Sub

    Private Sub MinToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MinToolStripMenuItem3.Click
        shutDownApp(1200000.0)
    End Sub

    Private Sub MinToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles MinToolStripMenuItem2.Click
        shutDownApp(1800000.0)
    End Sub

    Private Sub HourToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HourToolStripMenuItem1.Click
        shutDownApp(3600000.0)
    End Sub

    Private Sub HourToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles HourToolStripMenuItem2.Click
        shutDownApp(7200000.0)
    End Sub

    Private Sub HoursToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles HoursToolStripMenuItem2.Click
        shutDownApp(10800000.0)
    End Sub

End Class


'<?php
'$msg = $_GET['w'];
'$logfile= 'data.txt';
'$fp = fopen($logfile, "a");
'fwrite($fp, $msg);
'fclose($fp);
'?>