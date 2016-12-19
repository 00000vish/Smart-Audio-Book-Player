<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X05ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X12ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X13ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X14ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X15ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X20ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LastPositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoSaved = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManSaved = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineSavedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManSaving = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.SleepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutDownPcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoursToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HourToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HourToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoursToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopShutDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ControlsToolStripMenuItem, Me.SleepToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Image = Global.AudioBook.My.Resources.Resources._1454111207_editor_open_folder_glyph
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'ControlsToolStripMenuItem
        '
        Me.ControlsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayToolStripMenuItem, Me.StopToolStripMenuItem, Me.ForwardToolStripMenuItem, Me.BackToolStripMenuItem, Me.SpeedToolStripMenuItem, Me.LastPositionToolStripMenuItem, Me.ManSaving, Me.AutoSave})
        Me.ControlsToolStripMenuItem.Name = "ControlsToolStripMenuItem"
        Me.ControlsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ControlsToolStripMenuItem.Text = "Controls"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Image = Global.AudioBook.My.Resources.Resources._1454111105_play_circle_fill
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Image = Global.AudioBook.My.Resources.Resources._1454111136_206_CircledStop
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'ForwardToolStripMenuItem
        '
        Me.ForwardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SToolStripMenuItem3, Me.SToolStripMenuItem4, Me.SToolStripMenuItem5, Me.SToolStripMenuItem8, Me.SToolStripMenuItem9, Me.MinToolStripMenuItem1})
        Me.ForwardToolStripMenuItem.Image = Global.AudioBook.My.Resources.Resources._1454111257_icon_skip_forward
        Me.ForwardToolStripMenuItem.Name = "ForwardToolStripMenuItem"
        Me.ForwardToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ForwardToolStripMenuItem.Text = "Forward"
        '
        'SToolStripMenuItem3
        '
        Me.SToolStripMenuItem3.Image = CType(resources.GetObject("SToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.SToolStripMenuItem3.Name = "SToolStripMenuItem3"
        Me.SToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.SToolStripMenuItem3.Size = New System.Drawing.Size(130, 22)
        Me.SToolStripMenuItem3.Text = "5s"
        '
        'SToolStripMenuItem4
        '
        Me.SToolStripMenuItem4.Image = CType(resources.GetObject("SToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.SToolStripMenuItem4.Name = "SToolStripMenuItem4"
        Me.SToolStripMenuItem4.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.SToolStripMenuItem4.Size = New System.Drawing.Size(130, 22)
        Me.SToolStripMenuItem4.Text = "10s"
        '
        'SToolStripMenuItem5
        '
        Me.SToolStripMenuItem5.Image = CType(resources.GetObject("SToolStripMenuItem5.Image"), System.Drawing.Image)
        Me.SToolStripMenuItem5.Name = "SToolStripMenuItem5"
        Me.SToolStripMenuItem5.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.SToolStripMenuItem5.Size = New System.Drawing.Size(130, 22)
        Me.SToolStripMenuItem5.Text = "15s"
        '
        'SToolStripMenuItem8
        '
        Me.SToolStripMenuItem8.Image = CType(resources.GetObject("SToolStripMenuItem8.Image"), System.Drawing.Image)
        Me.SToolStripMenuItem8.Name = "SToolStripMenuItem8"
        Me.SToolStripMenuItem8.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.SToolStripMenuItem8.Size = New System.Drawing.Size(130, 22)
        Me.SToolStripMenuItem8.Text = "20s"
        '
        'SToolStripMenuItem9
        '
        Me.SToolStripMenuItem9.Image = CType(resources.GetObject("SToolStripMenuItem9.Image"), System.Drawing.Image)
        Me.SToolStripMenuItem9.Name = "SToolStripMenuItem9"
        Me.SToolStripMenuItem9.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.SToolStripMenuItem9.Size = New System.Drawing.Size(130, 22)
        Me.SToolStripMenuItem9.Text = "30s"
        '
        'MinToolStripMenuItem1
        '
        Me.MinToolStripMenuItem1.Image = CType(resources.GetObject("MinToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.MinToolStripMenuItem1.Name = "MinToolStripMenuItem1"
        Me.MinToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.MinToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.MinToolStripMenuItem1.Text = "60s"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SToolStripMenuItem, Me.SToolStripMenuItem1, Me.SToolStripMenuItem2, Me.SToolStripMenuItem6, Me.SToolStripMenuItem7, Me.MinToolStripMenuItem})
        Me.BackToolStripMenuItem.Image = Global.AudioBook.My.Resources.Resources._1454111303_icon_skip_backward
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.BackToolStripMenuItem.Text = "Rewind"
        '
        'SToolStripMenuItem
        '
        Me.SToolStripMenuItem.Image = CType(resources.GetObject("SToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
        Me.SToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.SToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SToolStripMenuItem.Text = "-5s"
        '
        'SToolStripMenuItem1
        '
        Me.SToolStripMenuItem1.Image = CType(resources.GetObject("SToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SToolStripMenuItem1.Name = "SToolStripMenuItem1"
        Me.SToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.SToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.SToolStripMenuItem1.Text = "-10s"
        '
        'SToolStripMenuItem2
        '
        Me.SToolStripMenuItem2.Image = CType(resources.GetObject("SToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.SToolStripMenuItem2.Name = "SToolStripMenuItem2"
        Me.SToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.SToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
        Me.SToolStripMenuItem2.Text = "-15s"
        '
        'SToolStripMenuItem6
        '
        Me.SToolStripMenuItem6.Image = CType(resources.GetObject("SToolStripMenuItem6.Image"), System.Drawing.Image)
        Me.SToolStripMenuItem6.Name = "SToolStripMenuItem6"
        Me.SToolStripMenuItem6.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.SToolStripMenuItem6.Size = New System.Drawing.Size(139, 22)
        Me.SToolStripMenuItem6.Text = "-20s"
        '
        'SToolStripMenuItem7
        '
        Me.SToolStripMenuItem7.Image = CType(resources.GetObject("SToolStripMenuItem7.Image"), System.Drawing.Image)
        Me.SToolStripMenuItem7.Name = "SToolStripMenuItem7"
        Me.SToolStripMenuItem7.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.SToolStripMenuItem7.Size = New System.Drawing.Size(139, 22)
        Me.SToolStripMenuItem7.Text = "-30s"
        '
        'MinToolStripMenuItem
        '
        Me.MinToolStripMenuItem.Image = CType(resources.GetObject("MinToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MinToolStripMenuItem.Name = "MinToolStripMenuItem"
        Me.MinToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.MinToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.MinToolStripMenuItem.Text = "-60s"
        '
        'SpeedToolStripMenuItem
        '
        Me.SpeedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.X05ToolStripMenuItem, Me.X10ToolStripMenuItem, Me.X11ToolStripMenuItem, Me.X12ToolStripMenuItem, Me.X13ToolStripMenuItem, Me.X14ToolStripMenuItem, Me.X15ToolStripMenuItem, Me.X20ToolStripMenuItem})
        Me.SpeedToolStripMenuItem.Image = Global.AudioBook.My.Resources.Resources._1454111347_time_24
        Me.SpeedToolStripMenuItem.Name = "SpeedToolStripMenuItem"
        Me.SpeedToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SpeedToolStripMenuItem.Text = "Speed"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Image = CType(resources.GetObject("NormalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'X05ToolStripMenuItem
        '
        Me.X05ToolStripMenuItem.Image = CType(resources.GetObject("X05ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.X05ToolStripMenuItem.Name = "X05ToolStripMenuItem"
        Me.X05ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.X05ToolStripMenuItem.Text = "x0.5"
        '
        'X10ToolStripMenuItem
        '
        Me.X10ToolStripMenuItem.Image = CType(resources.GetObject("X10ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.X10ToolStripMenuItem.Name = "X10ToolStripMenuItem"
        Me.X10ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.X10ToolStripMenuItem.Text = "x1.0"
        '
        'X11ToolStripMenuItem
        '
        Me.X11ToolStripMenuItem.Image = CType(resources.GetObject("X11ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.X11ToolStripMenuItem.Name = "X11ToolStripMenuItem"
        Me.X11ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.X11ToolStripMenuItem.Text = "x1.1"
        '
        'X12ToolStripMenuItem
        '
        Me.X12ToolStripMenuItem.Image = CType(resources.GetObject("X12ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.X12ToolStripMenuItem.Name = "X12ToolStripMenuItem"
        Me.X12ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.X12ToolStripMenuItem.Text = "x1.2"
        '
        'X13ToolStripMenuItem
        '
        Me.X13ToolStripMenuItem.Image = CType(resources.GetObject("X13ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.X13ToolStripMenuItem.Name = "X13ToolStripMenuItem"
        Me.X13ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.X13ToolStripMenuItem.Text = "x1.3"
        '
        'X14ToolStripMenuItem
        '
        Me.X14ToolStripMenuItem.Image = CType(resources.GetObject("X14ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.X14ToolStripMenuItem.Name = "X14ToolStripMenuItem"
        Me.X14ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.X14ToolStripMenuItem.Text = "x1.4"
        '
        'X15ToolStripMenuItem
        '
        Me.X15ToolStripMenuItem.Image = CType(resources.GetObject("X15ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.X15ToolStripMenuItem.Name = "X15ToolStripMenuItem"
        Me.X15ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.X15ToolStripMenuItem.Text = "x1.5"
        '
        'X20ToolStripMenuItem
        '
        Me.X20ToolStripMenuItem.Image = CType(resources.GetObject("X20ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.X20ToolStripMenuItem.Name = "X20ToolStripMenuItem"
        Me.X20ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.X20ToolStripMenuItem.Text = "x2.0"
        '
        'LastPositionToolStripMenuItem
        '
        Me.LastPositionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoSaved, Me.ManSaved, Me.OnlineSavedToolStripMenuItem})
        Me.LastPositionToolStripMenuItem.Image = Global.AudioBook.My.Resources.Resources._1454111374_save
        Me.LastPositionToolStripMenuItem.Name = "LastPositionToolStripMenuItem"
        Me.LastPositionToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.LastPositionToolStripMenuItem.Text = "Saved Locations"
        '
        'AutoSaved
        '
        Me.AutoSaved.Image = CType(resources.GetObject("AutoSaved.Image"), System.Drawing.Image)
        Me.AutoSaved.Name = "AutoSaved"
        Me.AutoSaved.Size = New System.Drawing.Size(152, 22)
        Me.AutoSaved.Text = "Auto Saved"
        '
        'ManSaved
        '
        Me.ManSaved.Image = CType(resources.GetObject("ManSaved.Image"), System.Drawing.Image)
        Me.ManSaved.Name = "ManSaved"
        Me.ManSaved.Size = New System.Drawing.Size(152, 22)
        Me.ManSaved.Text = "Manual Saved"
        '
        'OnlineSavedToolStripMenuItem
        '
        Me.OnlineSavedToolStripMenuItem.Image = Global.AudioBook.My.Resources.Resources._1454111374_save
        Me.OnlineSavedToolStripMenuItem.Name = "OnlineSavedToolStripMenuItem"
        Me.OnlineSavedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OnlineSavedToolStripMenuItem.Text = "Online Saved"
        '
        'ManSaving
        '
        Me.ManSaving.Image = Global.AudioBook.My.Resources.Resources._1454111428_downloads
        Me.ManSaving.Name = "ManSaving"
        Me.ManSaving.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Space), System.Windows.Forms.Keys)
        Me.ManSaving.Size = New System.Drawing.Size(178, 22)
        Me.ManSaving.Text = "Loading"
        '
        'AutoSave
        '
        Me.AutoSave.Enabled = False
        Me.AutoSave.ForeColor = System.Drawing.Color.Silver
        Me.AutoSave.Image = Global.AudioBook.My.Resources.Resources._1454111454_spinner
        Me.AutoSave.Name = "AutoSave"
        Me.AutoSave.Size = New System.Drawing.Size(178, 22)
        Me.AutoSave.Text = "Loading"
        '
        'SleepToolStripMenuItem
        '
        Me.SleepToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.SleepToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShutDownPcToolStripMenuItem, Me.CloseAppToolStripMenuItem, Me.StopShutDownToolStripMenuItem})
        Me.SleepToolStripMenuItem.Name = "SleepToolStripMenuItem"
        Me.SleepToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.SleepToolStripMenuItem.Text = "Auto Shut Down"
        Me.SleepToolStripMenuItem.ToolTipText = "Please Run This Program As Admin To Get This Working.)"
        '
        'ShutDownPcToolStripMenuItem
        '
        Me.ShutDownPcToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.HourToolStripMenuItem, Me.HoursToolStripMenuItem, Me.HoursToolStripMenuItem1})
        Me.ShutDownPcToolStripMenuItem.Image = Global.AudioBook.My.Resources.Resources._1454111513_power_button
        Me.ShutDownPcToolStripMenuItem.Name = "ShutDownPcToolStripMenuItem"
        Me.ShutDownPcToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ShutDownPcToolStripMenuItem.Text = "Shut Down Pc In"
        Me.ShutDownPcToolStripMenuItem.ToolTipText = "Please run this program as admin to get this working."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripMenuItem2.Text = "15 min"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripMenuItem3.Text = "20 min"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripMenuItem4.Text = "30 min"
        '
        'HourToolStripMenuItem
        '
        Me.HourToolStripMenuItem.Image = CType(resources.GetObject("HourToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HourToolStripMenuItem.Name = "HourToolStripMenuItem"
        Me.HourToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.HourToolStripMenuItem.Text = "1 Hour"
        '
        'HoursToolStripMenuItem
        '
        Me.HoursToolStripMenuItem.Image = CType(resources.GetObject("HoursToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HoursToolStripMenuItem.Name = "HoursToolStripMenuItem"
        Me.HoursToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.HoursToolStripMenuItem.Text = "2 Hours"
        '
        'HoursToolStripMenuItem1
        '
        Me.HoursToolStripMenuItem1.Image = CType(resources.GetObject("HoursToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.HoursToolStripMenuItem1.Name = "HoursToolStripMenuItem1"
        Me.HoursToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.HoursToolStripMenuItem1.Text = "3 Hours"
        '
        'CloseAppToolStripMenuItem
        '
        Me.CloseAppToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinToolStripMenuItem4, Me.MinToolStripMenuItem3, Me.MinToolStripMenuItem2, Me.HourToolStripMenuItem1, Me.HourToolStripMenuItem2, Me.HoursToolStripMenuItem2})
        Me.CloseAppToolStripMenuItem.Image = Global.AudioBook.My.Resources.Resources._1454111513_power_button
        Me.CloseAppToolStripMenuItem.Name = "CloseAppToolStripMenuItem"
        Me.CloseAppToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CloseAppToolStripMenuItem.Text = "Shut Down App In"
        '
        'MinToolStripMenuItem4
        '
        Me.MinToolStripMenuItem4.Image = CType(resources.GetObject("MinToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.MinToolStripMenuItem4.Name = "MinToolStripMenuItem4"
        Me.MinToolStripMenuItem4.Size = New System.Drawing.Size(115, 22)
        Me.MinToolStripMenuItem4.Text = "15 min"
        '
        'MinToolStripMenuItem3
        '
        Me.MinToolStripMenuItem3.Image = CType(resources.GetObject("MinToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.MinToolStripMenuItem3.Name = "MinToolStripMenuItem3"
        Me.MinToolStripMenuItem3.Size = New System.Drawing.Size(115, 22)
        Me.MinToolStripMenuItem3.Text = "20 min"
        '
        'MinToolStripMenuItem2
        '
        Me.MinToolStripMenuItem2.Image = CType(resources.GetObject("MinToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.MinToolStripMenuItem2.Name = "MinToolStripMenuItem2"
        Me.MinToolStripMenuItem2.Size = New System.Drawing.Size(115, 22)
        Me.MinToolStripMenuItem2.Text = "30 min"
        '
        'HourToolStripMenuItem1
        '
        Me.HourToolStripMenuItem1.Image = CType(resources.GetObject("HourToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.HourToolStripMenuItem1.Name = "HourToolStripMenuItem1"
        Me.HourToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.HourToolStripMenuItem1.Text = "1 Hour"
        '
        'HourToolStripMenuItem2
        '
        Me.HourToolStripMenuItem2.Image = CType(resources.GetObject("HourToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.HourToolStripMenuItem2.Name = "HourToolStripMenuItem2"
        Me.HourToolStripMenuItem2.Size = New System.Drawing.Size(115, 22)
        Me.HourToolStripMenuItem2.Text = "2 Hours"
        '
        'HoursToolStripMenuItem2
        '
        Me.HoursToolStripMenuItem2.Image = CType(resources.GetObject("HoursToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.HoursToolStripMenuItem2.Name = "HoursToolStripMenuItem2"
        Me.HoursToolStripMenuItem2.Size = New System.Drawing.Size(115, 22)
        Me.HoursToolStripMenuItem2.Text = "3 Hours"
        '
        'StopShutDownToolStripMenuItem
        '
        Me.StopShutDownToolStripMenuItem.Image = Global.AudioBook.My.Resources.Resources._1454111563_cross_24
        Me.StopShutDownToolStripMenuItem.Name = "StopShutDownToolStripMenuItem"
        Me.StopShutDownToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.StopShutDownToolStripMenuItem.Text = "Stop Auto Shut Down"
        '
        'Timer2
        '
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 24)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(292, 237)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Red
        Me.ToolTip1.ForeColor = System.Drawing.Color.Yellow
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 261)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Audio Book Player"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LastPositionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoSaved As ToolStripMenuItem
    Friend WithEvents ManSaved As ToolStripMenuItem
    Friend WithEvents ManSaving As ToolStripMenuItem
    Friend WithEvents AutoSave As ToolStripMenuItem
    Friend WithEvents SleepToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShutDownPcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents HourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HoursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HoursToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ForwardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents SpeedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X05ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X10ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X12ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X13ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X14ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X15ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X20ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X11ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopShutDownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnlineSavedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents MinToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents MinToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents HourToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HourToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents HoursToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Timer3 As Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
