Public Class PerferBox
    Dim isload As Boolean = False
    Private Sub PerferBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As New Object
        Dim j As New EventArgs
        ShowBack.Checked = pictureuse
        Stretch.Checked = picturestr
        ChooseBack.Tag = picpath
        UseMusic.Checked = play
        LoopPlay.Checked = Form1.player.settings.getMode("loop")
        PlayVolume.Value = Form1.player.settings.volume
        ChooseMusic.Tag = Form1.player.URL
        InputNick.Text = usename
        SetAnswerTime.Value = time
        SetTryTime.Value = errorcount
        UseSpeech.Checked = Module1.usespeech
        Dim v As InstalledVoice
        VoiceCombo.Items.Clear()
        For Each v In Speech.GetInstalledVoices
            If v.Enabled Then
                VoiceCombo.Items.Add(v.VoiceInfo.Name)
            End If
            If v.VoiceInfo.Name = Speech.Voice.Name Then
                VoiceCombo.Text = v.VoiceInfo.Name
            End If
        Next
        Rate.Value = Speech.Rate
        Volume.Value = Speech.Volume
        Output.Checked = Module1.output
        ChooseFolder.Tag = outputpath
        EnableAutoSave.Checked = useautosave
        SetAutoSaveTime.Value = autosavetime
        ShowRecentFile.Checked = showrecent
        FileNumber.Value = recentnumber
        UseSpeech_CheckeDchanged(i, j)
        UseMusic_CheckeDchanged(i, j)
        ShowBack_CheckeDchanged(i, j)
        Output_CheckeDchanged(i, j)
        EnableAutoSave_CheckedChanged(i, j)
        ShowRecent_CheckedChanged(i, j)
        If Not IsNothing(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows", "paSsword", Nothing)) Then
            isload = True
            NoSomeApply.Checked = True
            isload = False
            ShowBack.Enabled = False
            UseMusic.Enabled = False
            InputNick.Enabled = False
        End If
    End Sub


    Private Sub UseSpeech_CheckeDchanged(sender As Object, e As EventArgs) Handles UseSpeech.CheckeDchanged
        Dim i As Control
        For Each i In SpeechSet.Controls
            If i.Name <> UseSpeech.Name And i.Name <> ChooseFolder.Name Then
                i.Enabled = UseSpeech.Checked
            End If
        Next
        Output.Checked = False
    End Sub

    Private Sub UseMusic_CheckeDchanged(sender As Object, e As EventArgs) Handles UseMusic.CheckeDchanged
        Dim i As Control
        For Each i In Music.Controls
            If i.Name <> UseMusic.Name Then
                i.Enabled = UseMusic.Checked
            End If
        Next
    End Sub



    Private Sub ShowBack_CheckeDchanged(sender As Object, e As EventArgs) Handles ShowBack.CheckeDchanged
        Dim i As Control
        For Each i In BackGround.Controls
            If i.Name <> ShowBack.Name Then
                i.Enabled = ShowBack.Checked
            End If
        Next
    End Sub


    Private Sub Output_CheckeDchanged(sender As Object, e As EventArgs) Handles Output.CheckedChanged
        ChooseFolder.Enabled = Output.Checked
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub Use_Click(sender As Object, e As EventArgs) Handles Use.Click
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\background", "usepicture", ShowBack.Checked)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\background", "stretch", Stretch.Checked)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\background", "path", ChooseBack.Tag)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\music", "play", UseMusic.Checked)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\music", "volume", PlayVolume.Value)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\music", "loop", LoopPlay.Checked)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\music", "path", ChooseMusic.Tag)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\name", "name", InputNick.Text)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\erroRcount", "erroRcount", SetTryTime.Value)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\answertime", "answertime", SetAnswerTime.Value)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\speech", "use", UseSpeech.Checked)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\speech", "volume", Volume.Value)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\speech", "rate", Rate.Value)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\speech", "voice", VoiceCombo.Text)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\speech", "output", Output.Checked)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\speech", "path", ChooseFolder.Tag)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\autosave", "use", EnableAutoSave.Checked)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\autosave", "time", SetAutoSaveTime.Value)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\recent", "show", ShowRecentFile.Checked)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\recent", "number", FileNumber.Value)
        Loadsetting()
    End Sub

    Private Sub Yes_Click(sender As Object, e As EventArgs) Handles Yes.Click
        Use.PerformClick()
        Close()
    End Sub

    Private Sub TryListen_Click(sender As Object, e As EventArgs) Handles TryListen.Click
        Dim i As New SpeechSynthesizer
        With i
            i.Volume = Volume.Value
            i.Rate = Rate.Value
            i.SelectVoice(VoiceCombo.Text)
        End With
        Form1.Player.Ctlcontrols.pause()
        i.Speak("欢迎使用背单词")
        i.Speak("Welcome to bei dan chie")
        Form1.Player.Ctlcontrols.play()
        i.Dispose()
    End Sub

    Private Sub ChooseFolder_Click(sender As Object, e As EventArgs) Handles ChooseFolder.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath.Length <> 0 Then
            Try
                Dim filetest As New StreamWriter(outputpath & "/test.txt")
                filetest.Close()
            Catch ex As UnauthorizedAccessException
                Erro("您没有访问该目录的权利。")
                Exit Sub
            Catch ex As SecurityException
                Erro("您没有访问该目录的权利。")
                Exit Sub
            End Try
            ChooseFolder.Tag = FolderBrowserDialog1.SelectedPath & "\"
        Else
            Erro("未选择文件夹。")
        End If

    End Sub

    Private Sub ChooseBack_Click(sender As Object, e As EventArgs) Handles ChooseBack.Click
        OpenFileDialog1.Filter = "图片文件（*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.Length <> 0 Then
            ChooseBack.Tag = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ChooseMusic_Click(sender As Object, e As EventArgs) Handles ChooseMusic.Click
        OpenFileDialog1.Filter = "所有文件(*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.Length <> 0 Then
            ChooseMusic.Tag = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub NoSomeApply_CheckeDchanged(sender As Object, e As EventArgs) Handles NoSomeApply.CheckedChanged
        If isload Then Exit Sub
        Dim i As String
        If NoSomeApply.Checked Then
            i = InputBox("请设置密码。")
            If i.Length <> 0 Then
                Dim b As String = ""
                For h = 1 To i.Length
                    b &= Asc(CChar(Mid(i, h, 1)))
                Next
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows", "paSsword", b)
                ShowBack.Enabled = False
                UseMusic.Enabled = False
                UseMusic.Checked = False
                ShowBack.Checked = False
            Else
                Erro("未设置密码。")
                isload = True
                NoSomeApply.Checked = False
                isload = False
            End If
        Else
            i = InputBox("请输入密码。")
            If i.Length <> 0 Then
                Dim b As String = ""
                For h = 1 To i.Length
                    b &= Asc(CChar(Mid(i, h, 1)))
                Next
                If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows", "paSsword", Nothing) = b Then
                    ShowBack.Enabled = True
                    UseMusic.Enabled = True
                    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows", True).DeleteValue("paSsword")
                Else
                    Erro("密码错误。")
                    isload = True
                    NoSomeApply.Checked = True
                    isload = False
                End If
            Else
                Erro("未输入密码。")
                isload = True
                NoSomeApply.Checked = True
                isload = False
            End If
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("您真的要恢复默认值吗？", 36) = MsgBoxResult.Yes Then
            Sleep(2000)
            If MsgBox("您真的要恢复默认值吗？", 36) = MsgBoxResult.Yes Then
                Sleep(2000)
                If MsgBox("您真的要恢复默认值吗？", 36) = MsgBoxResult.Yes Then
                    Sleep(2000)
                    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE", True).DeleteSubKeyTree("背单词")
                    Loadsetting()
                    Dim i As New Object
                    Dim j As New EventArgs
                    PerferBox_Load(i, j)
                End If
            End If
        End If
    End Sub

    Private Sub Rate_Scroll(sender As Object, e As EventArgs) Handles Rate.Scroll
        ToolTip1.SetToolTip(Rate, Rate.Value)
    End Sub

    Private Sub Rate_MouseLeave(sender As Object, e As EventArgs) Handles Rate.MouseLeave
        ToolTip1.SetToolTip(Rate, "更改语速")
    End Sub

    Private Sub Volume_Scroll(sender As Object, e As EventArgs) Handles Volume.Scroll
        ToolTip1.SetToolTip(Volume, Volume.Value)
    End Sub

    Private Sub Volume_MouseLeave(sender As Object, e As EventArgs) Handles Volume.MouseLeave
        ToolTip1.SetToolTip(Volume, "更改音量")
    End Sub
    Private Sub PlayVolume_Scroll(sender As Object, e As EventArgs) Handles PlayVolume.Scroll
        ToolTip1.SetToolTip(PlayVolume, PlayVolume.Value)
    End Sub

    Private Sub PlayVolume_MouseLeave(sender As Object, e As EventArgs) Handles PlayVolume.MouseLeave
        ToolTip1.SetToolTip(PlayVolume, "更改音量")
    End Sub

    Private Sub EnableAutoSave_CheckedChanged(sender As Object, e As EventArgs) Handles EnableAutoSave.CheckedChanged
        SetAutoSaveTime.Enabled = EnableAutoSave.Checked
    End Sub

    Private Sub ShowRecent_CheckedChanged(sender As Object, e As EventArgs) Handles ShowRecentFile.CheckedChanged
        FileNumber.Enabled = ShowRecentFile.Checked
    End Sub
End Class