<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerferBox
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PerferBox))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.SpeechSet = New System.Windows.Forms.TabPage()
        Me.ChooseFolder = New System.Windows.Forms.Button()
        Me.Output = New System.Windows.Forms.CheckBox()
        Me.TryListen = New System.Windows.Forms.Button()
        Me.Volume = New System.Windows.Forms.TrackBar()
        Me.Rate = New System.Windows.Forms.TrackBar()
        Me.VoiceCombo = New System.Windows.Forms.ComboBox()
        Me.UseSpeech = New System.Windows.Forms.CheckBox()
        Me.Test = New System.Windows.Forms.TabPage()
        Me.AnswerTime = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SetAnswerTime = New System.Windows.Forms.NumericUpDown()
        Me.TryTme = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SetTryTime = New System.Windows.Forms.NumericUpDown()
        Me.MultiMedia = New System.Windows.Forms.TabPage()
        Me.Music = New System.Windows.Forms.GroupBox()
        Me.ChooseMusic = New System.Windows.Forms.Button()
        Me.PlayVolume = New System.Windows.Forms.TrackBar()
        Me.LoopPlay = New System.Windows.Forms.CheckBox()
        Me.UseMusic = New System.Windows.Forms.CheckBox()
        Me.BackGround = New System.Windows.Forms.GroupBox()
        Me.Stretch = New System.Windows.Forms.CheckBox()
        Me.ChooseBack = New System.Windows.Forms.Button()
        Me.ShowBack = New System.Windows.Forms.CheckBox()
        Me.Basic = New System.Windows.Forms.TabPage()
        Me.Recent = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FileNumber = New System.Windows.Forms.NumericUpDown()
        Me.ShowRecentFile = New System.Windows.Forms.CheckBox()
        Me.SetAutoSave = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SetAutoSaveTime = New System.Windows.Forms.NumericUpDown()
        Me.EnableAutoSave = New System.Windows.Forms.CheckBox()
        Me.NickName = New System.Windows.Forms.GroupBox()
        Me.InputNick = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Yes = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Use = New System.Windows.Forms.Button()
        Me.NoSomeApply = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.SpeechSet.SuspendLayout()
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Test.SuspendLayout()
        Me.AnswerTime.SuspendLayout()
        CType(Me.SetAnswerTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TryTme.SuspendLayout()
        CType(Me.SetTryTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MultiMedia.SuspendLayout()
        Me.Music.SuspendLayout()
        CType(Me.PlayVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackGround.SuspendLayout()
        Me.Basic.SuspendLayout()
        Me.Recent.SuspendLayout()
        CType(Me.FileNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SetAutoSave.SuspendLayout()
        CType(Me.SetAutoSaveTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NickName.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.SpeechSet)
        Me.TabControl1.Controls.Add(Me.Test)
        Me.TabControl1.Controls.Add(Me.MultiMedia)
        Me.TabControl1.Controls.Add(Me.Basic)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        '
        'SpeechSet
        '
        Me.SpeechSet.BackColor = System.Drawing.Color.White
        Me.SpeechSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SpeechSet.Controls.Add(Me.ChooseFolder)
        Me.SpeechSet.Controls.Add(Me.Output)
        Me.SpeechSet.Controls.Add(Me.TryListen)
        Me.SpeechSet.Controls.Add(Me.Volume)
        Me.SpeechSet.Controls.Add(Me.Rate)
        Me.SpeechSet.Controls.Add(Me.VoiceCombo)
        Me.SpeechSet.Controls.Add(Me.UseSpeech)
        resources.ApplyResources(Me.SpeechSet, "SpeechSet")
        Me.SpeechSet.Name = "SpeechSet"
        '
        'ChooseFolder
        '
        resources.ApplyResources(Me.ChooseFolder, "ChooseFolder")
        Me.ChooseFolder.Name = "ChooseFolder"
        Me.ChooseFolder.UseVisualStyleBackColor = True
        '
        'Output
        '
        resources.ApplyResources(Me.Output, "Output")
        Me.Output.Name = "Output"
        Me.Output.UseVisualStyleBackColor = True
        '
        'TryListen
        '
        resources.ApplyResources(Me.TryListen, "TryListen")
        Me.TryListen.Name = "TryListen"
        Me.TryListen.UseVisualStyleBackColor = True
        '
        'Volume
        '
        Me.Volume.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.Volume.LargeChange = 20
        resources.ApplyResources(Me.Volume, "Volume")
        Me.Volume.Maximum = 100
        Me.Volume.Name = "Volume"
        Me.Volume.SmallChange = 5
        Me.Volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.ToolTip1.SetToolTip(Me.Volume, resources.GetString("Volume.ToolTip"))
        Me.Volume.Value = 50
        '
        'Rate
        '
        Me.Rate.Cursor = System.Windows.Forms.Cursors.SizeWE
        resources.ApplyResources(Me.Rate, "Rate")
        Me.Rate.Minimum = -10
        Me.Rate.Name = "Rate"
        Me.Rate.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.ToolTip1.SetToolTip(Me.Rate, resources.GetString("Rate.ToolTip"))
        '
        'VoiceCombo
        '
        Me.VoiceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.VoiceCombo, "VoiceCombo")
        Me.VoiceCombo.FormattingEnabled = True
        Me.VoiceCombo.Name = "VoiceCombo"
        '
        'UseSpeech
        '
        resources.ApplyResources(Me.UseSpeech, "UseSpeech")
        Me.UseSpeech.Checked = True
        Me.UseSpeech.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UseSpeech.Name = "UseSpeech"
        Me.UseSpeech.UseVisualStyleBackColor = True
        '
        'Test
        '
        Me.Test.BackColor = System.Drawing.Color.White
        Me.Test.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Test.Controls.Add(Me.AnswerTime)
        Me.Test.Controls.Add(Me.TryTme)
        resources.ApplyResources(Me.Test, "Test")
        Me.Test.Name = "Test"
        '
        'AnswerTime
        '
        Me.AnswerTime.Controls.Add(Me.Label3)
        Me.AnswerTime.Controls.Add(Me.SetAnswerTime)
        resources.ApplyResources(Me.AnswerTime, "AnswerTime")
        Me.AnswerTime.Name = "AnswerTime"
        Me.AnswerTime.TabStop = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'SetAnswerTime
        '
        Me.SetAnswerTime.Cursor = System.Windows.Forms.Cursors.SizeWE
        resources.ApplyResources(Me.SetAnswerTime, "SetAnswerTime")
        Me.SetAnswerTime.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.SetAnswerTime.Name = "SetAnswerTime"
        Me.SetAnswerTime.ReadOnly = True
        Me.SetAnswerTime.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'TryTme
        '
        Me.TryTme.Controls.Add(Me.Label4)
        Me.TryTme.Controls.Add(Me.SetTryTime)
        resources.ApplyResources(Me.TryTme, "TryTme")
        Me.TryTme.Name = "TryTme"
        Me.TryTme.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'SetTryTime
        '
        Me.SetTryTime.Cursor = System.Windows.Forms.Cursors.SizeWE
        resources.ApplyResources(Me.SetTryTime, "SetTryTime")
        Me.SetTryTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SetTryTime.Name = "SetTryTime"
        Me.SetTryTime.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.SetTryTime, resources.GetString("SetTryTime.ToolTip"))
        Me.SetTryTime.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'MultiMedia
        '
        Me.MultiMedia.BackColor = System.Drawing.Color.White
        Me.MultiMedia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MultiMedia.Controls.Add(Me.Music)
        Me.MultiMedia.Controls.Add(Me.BackGround)
        resources.ApplyResources(Me.MultiMedia, "MultiMedia")
        Me.MultiMedia.Name = "MultiMedia"
        '
        'Music
        '
        Me.Music.Controls.Add(Me.ChooseMusic)
        Me.Music.Controls.Add(Me.PlayVolume)
        Me.Music.Controls.Add(Me.LoopPlay)
        Me.Music.Controls.Add(Me.UseMusic)
        resources.ApplyResources(Me.Music, "Music")
        Me.Music.Name = "Music"
        Me.Music.TabStop = False
        '
        'ChooseMusic
        '
        resources.ApplyResources(Me.ChooseMusic, "ChooseMusic")
        Me.ChooseMusic.Name = "ChooseMusic"
        Me.ChooseMusic.UseVisualStyleBackColor = True
        '
        'PlayVolume
        '
        Me.PlayVolume.LargeChange = 20
        resources.ApplyResources(Me.PlayVolume, "PlayVolume")
        Me.PlayVolume.Maximum = 100
        Me.PlayVolume.Name = "PlayVolume"
        Me.PlayVolume.SmallChange = 5
        Me.PlayVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.ToolTip1.SetToolTip(Me.PlayVolume, resources.GetString("PlayVolume.ToolTip"))
        '
        'LoopPlay
        '
        resources.ApplyResources(Me.LoopPlay, "LoopPlay")
        Me.LoopPlay.Name = "LoopPlay"
        Me.LoopPlay.UseVisualStyleBackColor = True
        '
        'UseMusic
        '
        resources.ApplyResources(Me.UseMusic, "UseMusic")
        Me.UseMusic.Name = "UseMusic"
        Me.UseMusic.UseVisualStyleBackColor = True
        '
        'BackGround
        '
        Me.BackGround.Controls.Add(Me.Stretch)
        Me.BackGround.Controls.Add(Me.ChooseBack)
        Me.BackGround.Controls.Add(Me.ShowBack)
        resources.ApplyResources(Me.BackGround, "BackGround")
        Me.BackGround.Name = "BackGround"
        Me.BackGround.TabStop = False
        '
        'Stretch
        '
        resources.ApplyResources(Me.Stretch, "Stretch")
        Me.Stretch.Name = "Stretch"
        Me.Stretch.UseVisualStyleBackColor = True
        '
        'ChooseBack
        '
        resources.ApplyResources(Me.ChooseBack, "ChooseBack")
        Me.ChooseBack.Name = "ChooseBack"
        Me.ChooseBack.UseVisualStyleBackColor = True
        '
        'ShowBack
        '
        resources.ApplyResources(Me.ShowBack, "ShowBack")
        Me.ShowBack.Name = "ShowBack"
        Me.ShowBack.UseVisualStyleBackColor = True
        '
        'Basic
        '
        Me.Basic.BackColor = System.Drawing.Color.White
        Me.Basic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Basic.Controls.Add(Me.Recent)
        Me.Basic.Controls.Add(Me.SetAutoSave)
        Me.Basic.Controls.Add(Me.NickName)
        resources.ApplyResources(Me.Basic, "Basic")
        Me.Basic.Name = "Basic"
        '
        'Recent
        '
        Me.Recent.Controls.Add(Me.Label2)
        Me.Recent.Controls.Add(Me.FileNumber)
        Me.Recent.Controls.Add(Me.ShowRecentFile)
        resources.ApplyResources(Me.Recent, "Recent")
        Me.Recent.Name = "Recent"
        Me.Recent.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'FileNumber
        '
        resources.ApplyResources(Me.FileNumber, "FileNumber")
        Me.FileNumber.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.FileNumber.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.FileNumber.Name = "FileNumber"
        Me.FileNumber.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.FileNumber, resources.GetString("FileNumber.ToolTip"))
        Me.FileNumber.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'ShowRecentFile
        '
        resources.ApplyResources(Me.ShowRecentFile, "ShowRecentFile")
        Me.ShowRecentFile.Name = "ShowRecentFile"
        Me.ShowRecentFile.UseVisualStyleBackColor = True
        '
        'SetAutoSave
        '
        Me.SetAutoSave.Controls.Add(Me.Label1)
        Me.SetAutoSave.Controls.Add(Me.SetAutoSaveTime)
        Me.SetAutoSave.Controls.Add(Me.EnableAutoSave)
        resources.ApplyResources(Me.SetAutoSave, "SetAutoSave")
        Me.SetAutoSave.Name = "SetAutoSave"
        Me.SetAutoSave.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'SetAutoSaveTime
        '
        resources.ApplyResources(Me.SetAutoSaveTime, "SetAutoSaveTime")
        Me.SetAutoSaveTime.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.SetAutoSaveTime.Name = "SetAutoSaveTime"
        Me.SetAutoSaveTime.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.SetAutoSaveTime, resources.GetString("SetAutoSaveTime.ToolTip"))
        Me.SetAutoSaveTime.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'EnableAutoSave
        '
        resources.ApplyResources(Me.EnableAutoSave, "EnableAutoSave")
        Me.EnableAutoSave.Name = "EnableAutoSave"
        Me.EnableAutoSave.UseVisualStyleBackColor = True
        '
        'NickName
        '
        Me.NickName.Controls.Add(Me.InputNick)
        resources.ApplyResources(Me.NickName, "NickName")
        Me.NickName.Name = "NickName"
        Me.NickName.TabStop = False
        '
        'InputNick
        '
        resources.ApplyResources(Me.InputNick, "InputNick")
        Me.InputNick.Name = "InputNick"
        Me.ToolTip1.SetToolTip(Me.InputNick, resources.GetString("InputNick.ToolTip"))
        '
        'FolderBrowserDialog1
        '
        resources.ApplyResources(Me.FolderBrowserDialog1, "FolderBrowserDialog1")
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'Yes
        '
        resources.ApplyResources(Me.Yes, "Yes")
        Me.Yes.Name = "Yes"
        Me.Yes.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.Cancel, "Cancel")
        Me.Cancel.Name = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Use
        '
        Me.Use.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Use.FlatAppearance.BorderSize = 5
        Me.Use.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.Use.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.Use, "Use")
        Me.Use.Name = "Use"
        Me.Use.UseVisualStyleBackColor = True
        '
        'NoSomeApply
        '
        resources.ApplyResources(Me.NoSomeApply, "NoSomeApply")
        Me.NoSomeApply.Name = "NoSomeApply"
        Me.NoSomeApply.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PerferBox
        '
        Me.AcceptButton = Me.Yes
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NoSomeApply)
        Me.Controls.Add(Me.Use)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Yes)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PerferBox"
        Me.TabControl1.ResumeLayout(False)
        Me.SpeechSet.ResumeLayout(False)
        Me.SpeechSet.PerformLayout()
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Test.ResumeLayout(False)
        Me.AnswerTime.ResumeLayout(False)
        Me.AnswerTime.PerformLayout()
        CType(Me.SetAnswerTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TryTme.ResumeLayout(False)
        Me.TryTme.PerformLayout()
        CType(Me.SetTryTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MultiMedia.ResumeLayout(False)
        Me.Music.ResumeLayout(False)
        Me.Music.PerformLayout()
        CType(Me.PlayVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackGround.ResumeLayout(False)
        Me.BackGround.PerformLayout()
        Me.Basic.ResumeLayout(False)
        Me.Recent.ResumeLayout(False)
        Me.Recent.PerformLayout()
        CType(Me.FileNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SetAutoSave.ResumeLayout(False)
        Me.SetAutoSave.PerformLayout()
        CType(Me.SetAutoSaveTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NickName.ResumeLayout(False)
        Me.NickName.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents SpeechSet As System.Windows.Forms.TabPage
    Friend WithEvents Test As System.Windows.Forms.TabPage
    Friend WithEvents Basic As System.Windows.Forms.TabPage
    Friend WithEvents ChooseFolder As System.Windows.Forms.Button
    Friend WithEvents Output As System.Windows.Forms.CheckBox
    Friend WithEvents TryListen As System.Windows.Forms.Button
    Friend WithEvents Volume As System.Windows.Forms.TrackBar
    Friend WithEvents Rate As System.Windows.Forms.TrackBar
    Friend WithEvents VoiceCombo As System.Windows.Forms.ComboBox
    Friend WithEvents UseSpeech As System.Windows.Forms.CheckBox
    Friend WithEvents MultiMedia As System.Windows.Forms.TabPage
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Yes As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Use As System.Windows.Forms.Button
    Friend WithEvents NoSomeApply As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AnswerTime As GroupBox
    Friend WithEvents SetAnswerTime As NumericUpDown
    Friend WithEvents TryTme As GroupBox
    Friend WithEvents SetTryTime As NumericUpDown
    Friend WithEvents Music As GroupBox
    Friend WithEvents ChooseMusic As Button
    Friend WithEvents PlayVolume As TrackBar
    Friend WithEvents LoopPlay As CheckBox
    Friend WithEvents UseMusic As CheckBox
    Friend WithEvents BackGround As GroupBox
    Friend WithEvents Stretch As CheckBox
    Friend WithEvents ChooseBack As Button
    Friend WithEvents ShowBack As CheckBox
    Friend WithEvents Recent As GroupBox
    Friend WithEvents SetAutoSave As GroupBox
    Friend WithEvents SetAutoSaveTime As NumericUpDown
    Friend WithEvents EnableAutoSave As CheckBox
    Friend WithEvents NickName As GroupBox
    Friend WithEvents InputNick As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FileNumber As NumericUpDown
    Friend WithEvents ShowRecentFile As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
