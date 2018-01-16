Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices

Public Class Form1
    '==================== FILL INFO ====================
    Dim onlineEnabled = False  'Set it to TRUE to use online features
    Dim phpFileURL As String = "" 'URL for the php file. example : http://exmaple.com/AudioBookSync/post.php
    '====================   ENDS   =====================

    Dim shutDownPc As Boolean = False
    Dim toUpload As String = ""
    Dim lastSave As String = ""
    Dim remoteSwitch As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setUpPlayer()
        getOnlineLocation(False)
        setupRemote()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            My.Settings.Save()
        Catch ex As Exception
        End Try
    End Sub

    '+++++++++++++++++++++++++++++++++++++++++++++++ OTHER FUNCTIONS +++++++++++++++++++++++++++++++++++++++++++++++

    '################ check if remote has be activated ############
    Private Sub setupRemote()
        Dim remoteWeb As New WebBrowser
        remoteWeb.Navigate(phpFileURL.Replace("post.php", "") + "reset.php?w=0 0")
        While (Not remoteWeb.ReadyState = WebBrowserReadyState.Complete)
            Snooze(1)
        End While
        REMOTE.Interval = 2000
        REMOTE.Enabled = True
        REMOTE.Start()
    End Sub

    '################# OPEN FILE #################
    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog
        If (ofd.ShowDialog() = DialogResult.OK) Then
            My.Settings.fileLoc = ofd.FileName
            My.Settings.Save()
            AxWindowsMediaPlayer1.URL = My.Settings.fileLoc
        Else
            MsgBox("Error, File not found or supported", MsgBoxStyle.Exclamation, "AudioBook Player")
        End If
        ofd.Dispose()
    End Sub

    '########################## UPDATES GUI AND AUTO SAVE ####################
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles GUIAUTOSAVE.Tick
        ManSaved.Text = My.Settings.lastManTime.ToString.Split(".")(0) + "s Manual Saved"
        ManSaving.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString.Split(".")(0) + "s Save"
        AutoSave.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString.Split(".")(0) + "s AUTO SAVING"
        AutoSaved.Text = My.Settings.lastAuTime.ToString.Split(".")(0) + "s Auto Saved"

        SpeedToolStripMenuItem.Text = "Speed x" + AxWindowsMediaPlayer1.settings.rate.ToString("0.00")

        If lastSave <> AxWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString Then
            lastSave = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString
            PlayToolStripMenuItem.Text = "Pause"
            PlayToolStripMenuItem.Image = My.Resources.puasePNG
        Else
            PlayToolStripMenuItem.Text = "Play"
            PlayToolStripMenuItem.Image = My.Resources.playPNG
        End If
        My.Settings.lastAuTime = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
        My.Settings.Save()
    End Sub

    '################### OPENS LAST AUDIO FILE AND LAST SAVED LOCATION ###################
    Private Sub setUpPlayer()
        AxWindowsMediaPlayer1.settings.volume = 100
        If (My.Settings.fileLoc.ToString <> "") Then
            AxWindowsMediaPlayer1.URL = My.Settings.fileLoc.ToString
            If (My.Settings.lastAuTime.ToString <> "") Then
                AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = My.Settings.lastAuTime
                If (AxWindowsMediaPlayer1.Ctlcontrols.currentPosition > 5) Then
                    AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 5
                    PlayToolStripMenuItem.Text = "Pause"
                    PlayToolStripMenuItem.Image = My.Resources.puasePNG
                End If
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If
        Else
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        End If
    End Sub

    '############### SHUTDOWN PC ###############
    Private Sub shutDown(tome As Integer, pc As Boolean)
        shutDownPc = pc
        SHUTDOWNTIMER.Interval = tome
        SHUTDOWNTIMER.Start()
    End Sub

    '############# SHUT DOWN PC TIMER ###########
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles SHUTDOWNTIMER.Tick
        If (shutDownPc) Then
            System.Diagnostics.Process.Start("shutdown", "-s -t 00")
        Else
            Me.Close()
        End If
    End Sub

    '################### SLEEP METHOD ############
    Private Sub Snooze(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    '+++++++++++++++++++++++++++++++++++++++++++++++ ONLINE BOOKMARK '+++++++++++++++++++++++++++++++++++++++++++++++

    '############### UPLOAD TO SERVER ##############
    Private Sub upload()
        If (onlineEnabled = True) Then
            Try
                If toUpload <> "" Then
                    Dim web As New WebBrowser
                    web.Navigate(phpFileURL & "?w=" & toUpload)
                    While (Not web.ReadyState = WebBrowserReadyState.Complete)
                        Snooze(1)
                    End While
                    web.Dispose()
                End If
            Catch ex As Exception
            End Try
            getOnlineLocation(False)
        End If
    End Sub

    '############### DOWNLOAD FROM SERVER ##############
    Private Sub getOnlineLocation(jump As Boolean)
        If (onlineEnabled) Then
            Try
                Dim web As New WebBrowser
                web.Navigate(phpFileURL.Replace("post.php", "") + "data.txt")
                While (Not web.ReadyState = WebBrowserReadyState.Complete)
                    Snooze(1)
                End While
                Dim loc As String = web.Document.Body.InnerText
                web.Dispose()
                OnlineSavedToolStripMenuItem.Text = loc.ToString.Split(".")(0) & " Online Saved"
                If (jump) Then
                    AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToDouble(loc.ToString)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    '############ check for remote updates #################
    Private Sub REMOTE_Tick(sender As Object, e As EventArgs) Handles REMOTE.Tick
        If onlineEnabled Then
            Try
                Dim remoteWeb As New WebBrowser
                remoteWeb.Navigate(phpFileURL.Replace("post.php", "") + "ping.txt")
                While (Not remoteWeb.ReadyState = WebBrowserReadyState.Complete)
                    Snooze(1)
                End While
                Dim loc As String() = remoteWeb.Document.Body.InnerText.Split(" ")

                If loc(1).ToString <> remoteSwitch Then
                    remoteSwitch = loc(1)
                    Select Case Int(loc(0))
                        Case 1
                            PlayToolStripMenuItem.PerformClick()
                        Case 2
                            PlayToolStripMenuItem.PerformClick()
                        Case 3
                            ManSaving.PerformClick()
                        Case 4
                            MinToolStripMenuItem2.PerformClick()
                    End Select

                End If
                remoteWeb.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            REMOTE.Stop()
        End If
    End Sub

    '+++++++++++++++++++++++++++++++++++++++++++++++ CONTROL BUTTONS +++++++++++++++++++++++++++++++++++++++++++++++

    '################# STOP BUTTON #################
    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    '################# PLAY BUTTON #################
    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        If PlayToolStripMenuItem.Text = "Play" Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            PlayToolStripMenuItem.Text = "Pause"
            PlayToolStripMenuItem.Image = My.Resources.puasePNG
        Else
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            PlayToolStripMenuItem.Text = "Play"
            PlayToolStripMenuItem.Image = My.Resources.playPNG
        End If
    End Sub

    '################# FORWARD/REWIND #################
    Private Sub SToolStripMenuItem3_Click_1(sender As Object, e As EventArgs) Handles SToolStripMenuItem.Click, SToolStripMenuItem1.Click, SToolStripMenuItem2.Click, SToolStripMenuItem6.Click, SToolStripMenuItem7.Click, MinToolStripMenuItem.Click, SToolStripMenuItem3.Click, SToolStripMenuItem4.Click, SToolStripMenuItem5.Click, SToolStripMenuItem8.Click, SToolStripMenuItem9.Click, MinToolStripMenuItem1.Click
        Dim STS As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition + Int(STS.Text.Replace("s", "").ToString)
    End Sub

    '################ SHUTDOWN PC ##############
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click, ToolStripMenuItem3.Click, ToolStripMenuItem4.Click, HourToolStripMenuItem.Click, HoursToolStripMenuItem1.Click, HoursToolStripMenuItem.Click
        Dim STS As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        shutDown(Int(STS.Text.Replace("min", "").ToString) * 60000, True)
        SleepToolStripMenuItem.BackColor = Color.Lime
    End Sub

    '################ SHUTDOWN APP ##############
    Private Sub MinToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles MinToolStripMenuItem4.Click, MinToolStripMenuItem3.Click, MinToolStripMenuItem2.Click, HourToolStripMenuItem1.Click, HourToolStripMenuItem2.Click, HoursToolStripMenuItem2.Click
        Dim STS As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        shutDown(Int(STS.Text.Replace("min", "").ToString) * 60000, False)
        SleepToolStripMenuItem.BackColor = Color.Lime
    End Sub

    '############## STOP SHUTDOWNS ##############
    Private Sub StopShutDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopShutDownToolStripMenuItem.Click
        Process.Start(Application.ExecutablePath)
        Me.Close()
    End Sub
    '################## SPEED ###################
    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click, X05ToolStripMenuItem.Click, X12ToolStripMenuItem.Click, X13ToolStripMenuItem.Click, X14ToolStripMenuItem.Click, X15ToolStripMenuItem.Click, X20ToolStripMenuItem.Click, X11ToolStripMenuItem.Click
        Dim STS As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        If AxWindowsMediaPlayer1.settings.isAvailable("Rate") Then
            If (STS.Text <> "Normal") Then
                AxWindowsMediaPlayer1.settings.rate = Convert.ToDouble(STS.Text.Replace("x", "").ToString)
            Else
                AxWindowsMediaPlayer1.settings.rate = 1
            End If
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition - 15
        End If
    End Sub

    '################# SAVE LOCATION ###########
    Private Sub SaveLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManSaving.Click
        My.Settings.lastManTime = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
        My.Settings.Save()
        toUpload = My.Settings.lastManTime
        upload()
    End Sub
    '############## JUMP TO AUTO SAVE #########
    Private Sub AutoSavedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoSaved.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = My.Settings.lastAuTime
    End Sub

    '############ JUMP TO MANUAL SAVE #########
    Private Sub ManualSavedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManSaved.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = My.Settings.lastManTime
    End Sub

    '########### JUMP TO ONLINE SAVED ########
    Private Sub OnlineSavedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlineSavedToolStripMenuItem.Click
        getOnlineLocation(True)
    End Sub
    '########## JUMP TO AUTO ALT #############
    Private Sub LastPositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LastPositionToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = My.Settings.lastAuTime
    End Sub

    '########### GET PLAY STOP KEYBOARD BUTTONS #########
    <DllImport("USER32.DLL", EntryPoint:="GetAsyncKeyState", SetLastError:=True,
    CharSet:=CharSet.Unicode, ExactSpelling:=True,
    CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function getkey(ByVal Vkey As Integer) As Boolean
    End Function

    '########### CHECK FOR PLAY FORWARD AND REWIND KEY PRESSES ##########
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles MEDIABUTTON.Tick
        If getkey(179) Then
            PlayToolStripMenuItem.PerformClick()
        End If
        If getkey(177) Then
            SToolStripMenuItem1.PerformClick()
        End If
        If getkey(176) Then
            SToolStripMenuItem4.PerformClick()
        End If
    End Sub
End Class