Public Class Form1
    Public Shared Sub ConSplash(s As String)
        If s = "CLose" Then
            Splash.Close()
        Else
            Splash.lblPro.Text = s
        End If
    End Sub
    Public Sub Loadform()
        If picpath.Length <> 0 Then
            Try
                BackgroundImage = Image.FromFile(picpath)
            Catch e As FileNotFoundException
                Erro("找不到图片。")
                My.Computer.Registry.LocalMachine.DeleteValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\background\path")
            Catch e As OutOfMemoryException
                Erro("图片格式错误。")
                My.Computer.Registry.LocalMachine.DeleteValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\background\path")
            End Try
        End If
        Player.settings.volume = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\music", "volume", 50)
        Player.settings.setMode("loop", My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\music", "loop", True))
        If play Then
            If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\music", "path", "") <> Player.URL Then
                Player.Ctlcontrols.stop()
                Player.URL = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\music", "path", "")
                Player.Ctlcontrols.play()
            End If
        Else
            Player.Ctlcontrols.stop()
        End If
        OpenRecent.Visible = showrecent
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If havechange Then
            If e.CloseReason <> CloseReason.WindowsShutDown Or e.CloseReason <> CloseReason.TaskManagerClosing Then
                Select Case MsgBox("文件已更改，是否保存文件?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation)
                    Case MsgBoxResult.Yes
                        SaveFile(1)
                    Case MsgBoxResult.Cancel
                        e.Cancel = True
                        Exit Sub
                End Select
                If MsgBox("您真的要退出吗？", 36) = MsgBoxResult.No Then
                    e.Cancel = True
                    Exit Sub
                End If
            Else
                SaveFile(1)
            End If
        End If
        autosavetdover = True
    End Sub
    Delegate Sub Dg(text As String)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ControlSplash As New Dg(AddressOf ConSplash)
        Randomize()
        Invoke(ControlSplash, "正在设置...")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\背单词", "Publisher", "杨承岳", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\背单词", "AppPath", Application.StartupPath & "\", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\背单词", "UninstallString", Application.StartupPath & "\Uninstall.exe", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\背单词", "DisplayIcon", Application.StartupPath & "\" & My.Application.Info.Title & ".exe", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\背单词", "DisplayName", My.Application.Info.Title, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\背单词", "DisplayVersion", My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\.wdf", "", "单词数据文件", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\单词数据文件\DefaultIcon", "", Application.StartupPath & "\" & My.Application.Info.Title & ".exe" & ",0", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\单词数据文件", "", "单词数据文件", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\单词数据文件\shell\open", "", "导入背单词", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\单词数据文件\shell\open", "FriendlyApplicationName", My.Application.Info.Title, Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\单词数据文件\shell\open\command", "", Application.StartupPath & "\" & Application.ProductName & ".exe %1", Microsoft.Win32.RegistryValueKind.String)
        Invoke(ControlSplash, "正在读取设置...")
        Loadsetting()
        Invoke(ControlSplash, "正在启动...")
        Show()
        Invoke(ControlSplash, "close")
        If fname.Length <> 0 Then
            If MsgBox("是否打开上次使用的文件?", 36) = MsgBoxResult.Yes Then
                OpenFile(fname)
                Exit Sub
            Else
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\背单词\file", True).DeleteValue("fname")
                fname = ""
            End If
        End If
        If My.Application.CommandLineArgs.Count <> 0 Then
            Dim i = My.Application.CommandLineArgs.First
            If i.Length = 0 Then
                Exit Sub
            ElseIf Strings.Right(i, 4) <> ".wdf" Then
                Erro("错误的文件后缀名。")
            Else
                fname = i
                OpenFile(i)
            End If
        End If
    End Sub
    Private Sub SaveAs_Click(sender As Object, e As EventArgs) Handles SaveAs.Click

        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        Else
            fname = SaveFileDialog1.FileName
            If Find(fname, filelist) Then filelist.Remove(Find(fname, filelist))
            filelist.Add(fname,, 1)
            ChangeFileList()
        End If
        SaveFile(fname)
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If fname.Length = 0 Then
            If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then
                Exit Sub
            Else
                fname = SaveFileDialog1.FileName
                If Find(fname, filelist) Then filelist.Remove(Find(fname, filelist))
                filelist.Add(fname,, 1)
                ChangeFileList()
            End If
        End If
        SaveFile(fname)
    End Sub

    Private Sub Unload_Click(sender As Object, e As EventArgs) Handles Unload.Click
        Close()
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Width = 793
        Height = 473
    End Sub

    Private Sub MnuAdd_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim h = 0
        Dim i As String
        Do Until h = 1
            i = InputBox("请输入添加的单词。")
            If Find(i, Dw) Then
                Erro("词典中已有该单词。")
            ElseIf i = "vbDw" Or i = "vbDc" Or i = "vbRw" Or i = "vbRc" Then
                Erro("无法添加该内容。")
            ElseIf i.Length = 0 Then
                Exit Do
            Else
                Player.Ctlcontrols.pause()
                Speech.SpeakAsync(i)
                Player.Ctlcontrols.play()
                Dw.Add(i, i)
                Rw.Add(i, i)
                i = InputBox("请输入" & Chr(34) & Dw.Item(Dw.Count) & Chr(34) & "的中文。")
                If Find(i, Dc) Then
                    Erro("词典中已有该中文释义。")
                    Dw.Remove(Dw.Count)
                    Rw.Remove(Rw.Count)
                ElseIf i = "vbDw" Or i = "vbDc" Or i = "vbRw" Or i = "vbRc" Then
                    Erro("无法添加该内容。")
                    Dw.Remove(Dw.Count)
                    Rw.Remove(Rw.Count)
                ElseIf i.Length = 0 Then
                    Dw.Remove(Dw.Count)
                    Rw.Remove(Rw.Count)
                    Exit Do
                Else
                    Player.Ctlcontrols.pause()
                    Speech.SpeakAsync(i)
                    Player.Ctlcontrols.play()
                    Dc.Add(i, i)
                    Rc.Add(i, i)
                    havechange = True
                End If
            End If
        Loop
        '重新排序
        Dim Dw3 As New ListBox
        Dim j As Object
        Dim Dc3 As New Collection
        Dw3.Items.Clear()
        Dc3.Clear()
        Dw3.Sorted = True
        For Each j In Dw
            Dw3.Items.Add(j)
        Next
        For Each j In Dw3.Items
            Dc3.Add(Dc(Find(j, Dw)))
        Next
        Dw.Clear()
        Dc.Clear()
        For Each j In Dw3.Items
            Dw.Add(j, j)
        Next
        For Each j In Dc3
            Dc.Add(j, j)
        Next
        Dw3.Dispose()
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub Prefer_Click(sender As Object, e As EventArgs) Handles Prefer.Click
        PerferBox.ShowDialog()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If Dw.Count = 0 Then
            Erro("词典为空。")
            Exit Sub
        End If
        DeleteWord.ShowDialog()
    End Sub

    Private Sub Revise_Click(sender As Object, e As EventArgs) Handles Revise.Click
        If Dw.Count = 0 Then
            Erro("词典为空。")
            Exit Sub
        End If
        Change.ShowDialog()
    End Sub

    Private Sub ChangeQues_Click(sender As Object, e As EventArgs) Handles ChangeQues.Click
        If Dw.Count = 0 Then
            Erro("词典为空。")
            Exit Sub
        End If
        Question.ShowDialog()
    End Sub
    Private Sub OpenFile(Name As String)
        If havechange Then
            Select Case MsgBox("是否保存文件？", 51)
                Case vbYes
                    SaveFile(1)
                Case vbNo
                    havechange = False
                Case vbCancel
                    Exit Sub
            End Select
        End If
        If Not My.Computer.FileSystem.FileExists(Name) Then
            Erro("文件不存在。")
            Exit Sub
        End If
        Dim t As Integer
        If Find(fname, filelist) Then filelist.Remove(Find(fname, filelist))
        filelist.Add(fname,, 1)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\file", "fname", Name)
        Dw.Clear()
        Dc.Clear()
        Rw.Clear()
        Rc.Clear()
        Dim file As New StreamReader(Name, False)
        Progress.ProgressBar1.Value = 0
        Progress.Show()
        Progress.ProgressBar1.Maximum = FileIO.FileSystem.GetFileInfo(Name).Length
        Dim i As String
        Dim inmode As String = ""
        Do Until file.EndOfStream
            i = file.ReadLine()
            Progress.ProgressBar1.Value += Len(i)
            Select Case i
                Case "vbdw"
                    inmode = "dw"
                    t += 1
                Case "vbdc"
                    inmode = "dc"
                    t += 1
                Case "vbrw"
                    inmode = "rw"
                    t += 1
                Case "vbrc"
                    inmode = "rc"
                    t += 1
                Case "havefinish"
                    inmode = "hf"
                    t += 1
                Case Else
                    Select Case inmode
                        Case "dw"
                            If Not CBool(Find(i, Dw)) Then Dw.Add(i, i)
                        Case "dc"
                            If Not CBool(Find(i, Dc)) Then Dc.Add(i, i)
                        Case "rw"
                            If Not CBool(Find(i, Rw)) Then Rw.Add(i, i)
                        Case "rc"
                            If Not CBool(Find(i, Rc)) Then Rc.Add(i, i)
                        Case "hf"
                            havefinish = i
                        Case Else
                            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\背单词\file", True).DeleteValue("fname")
                            Progress.Close()
                            Erro("文件格式错误。" & vbCrLf & "文件头出错。")
                            file.Close()
                            filelist.Remove(1)
                            Progress.Close()
                            Exit Sub
                    End Select
            End Select
        Loop
        file.Close()
        Progress.Close()
        If Rw.Count <> Rc.Count Or Dw.Count <> Dc.Count Then
            Erro("文件格式错误。" & vbCrLf & "中英文不匹配。")
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\背单词\file", True).DeleteValue("fname")
            Dw.Clear()
            Dc.Clear()
            Rw.Clear()
            Rc.Clear()
            filelist.Remove(1)
            Exit Sub
        End If
        For Each w In Rw
            If Not CBool(Find(w, Dw)) Then
                Erro("文件格式错误。" & vbCrLf & "词典与测试范围不匹配。")
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\背单词\file", True).DeleteValue("fname")
                Dw.Clear()
                Dc.Clear()
                Rw.Clear()
                Rc.Clear()
                filelist.Remove(1)
                Exit Sub
            End If
        Next
        If t <> 5 Then
            Erro("文件格式错误。" & vbCrLf & "文件区域划分错误。")
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\背单词\file", True).DeleteValue("fname")
            Dw.Clear()
            Dc.Clear()
            Rw.Clear()
            Rc.Clear()
            filelist.Remove(1)
            Exit Sub
        End If
        MsgBox("打开成功。", vbInformation)
        ChangeFileList()
    End Sub
    Private Sub Open_Click(sender As Object, e As EventArgs) Handles Open.Click
        If havechange Then
            Select Case MsgBox("是否保存文件？", 51)
                Case vbYes
                    SaveFile(1)
                Case MsgBoxResult.No
                    havechange = False
                Case vbCancel
                    Exit Sub
            End Select
        End If
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            fname = OpenFileDialog1.FileName
        Else
            Exit Sub
        End If
        OpenFile(fname)
    End Sub

    Private Sub Btnst_Click(sender As Object, e As EventArgs) Handles btnst.Click
        Dim i As Integer
        Dim j As String
        Dim watch As New Stopwatch
        Dim errortime As Integer
        Dim right As Integer
        Dim discribe As String = ""
        Dim name As String
        If usename.Length = 0 Then
            name = "你"
        Else
            name = usename
        End If
        If Not usespeech Then Speech.Volume = 0
        i = Fix(Rnd() * Rw.Count) + 1
        Player.Ctlcontrols.pause()
        Do Until Rw.Count = 0
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "/File/Run Time/Text-to Text/Audio")
            My.Computer.FileSystem.CreateDirectory(outputpath)
            Speech.SetOutputToWaveFile(My.Application.Info.DirectoryPath & "/File/Run Time/Text-to Text/Audio/Audio.wav")
            Speech.Speak(Rw(i))
            Speech.SetOutputToDefaultAudioDevice()
            Speech.Speak(Rw(i))
            watch.Restart()
            j = InputBox("请输入" & Chr(34) & Rc(i) & Chr(34) & "的英文。")
            watch.Stop()
            Select Case j
                Case ""
                    Player.Ctlcontrols.play()
                    My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/File/Run Time/Text-to Text/Audio/Audio.wav")
                    Speech.Volume = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\speech", "volume", 50))
                    Exit Sub
                Case "/again"

                Case Rw(i)
                    If CSng(watch.ElapsedMilliseconds) / 1000 < time Then
                        right += 1
                        Select Case right
                            Case 1 To 4
                                Speech.Speak("Good!")
                                discribe = name & "答对了，再接再厉哦！"
                            Case 5 To 9
                                Speech.Speak("Great!")
                                discribe = "哎哟，" & name & "不错哦！"
                            Case 10 To 19
                                Speech.Speak("Wonderful!")
                                discribe = "看来" & name & "记得挺牢哟！"
                            Case 20 To 49
                                Speech.Speak("Excellent!")
                                discribe = name & "记性真好，在下自叹不如！"
                            Case 50 To 99
                                Speech.Speak("Unbelievable!")
                                discribe = usename & "说，你是不是世界记忆锦标赛冠军？！"
                            Case Is >= 100
                                Speech.Speak("Are you kidding me?")
                                discribe = "难道" & usename & "注射了Z级记忆强化药剂？！"
                        End Select
                        MsgBox(discribe & vbCrLf & "耗时：" & CSng(watch.ElapsedMilliseconds) / 1000 & "秒" & vbCrLf & "连斩：" & right & Chr(10) & Chr(13) & "再看一眼：" & Rw(i), vbInformation)
                        havefinish = True
                        errortime = 0
                        If usespeech Then
                            My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "/File/Run Time/Text-to Text/Audio/Audio.wav", outputpath & Rw(i) & ".wav", True)
                        End If
                        i = Fix(Rnd() * Rw.Count) + 1
                        Rc.Remove(i)
                        Rw.Remove(i)
                    Else
                        If errortime = errorcount Then
                            Speech.Speak（"You are really bed!"）
                            MsgBox（name & "回答太久了，加油吧！" & vbCrLf & "回忆一下：" & Rw(i), 16）
                            right = 0
                            errortime = 0
                        Else
                            Speech.Speak("Oh,no!")
                            MsgBox(name & "回答太久了，再试一次吧！", 16)
                        End If
                    End If
                Case Else
                    If errortime = errorcount Then
                        Speech.Speak（"You are really bed!"）
                        MsgBox（name & "答错了，加油吧！" & vbCrLf & "回忆一下：" & Rw(i), 16）
                        errortime = 0
                        right = 0
                    Else
                        Speech.Speak("Oh,no!")
                        MsgBox(name & "答错了，再试一次吧！", 16)
                    End If
            End Select
        Loop
        If havefinish Then
            Speech.Speak（"Amazing"）
            MsgBox（name & "全部背完了，太棒了！", vbInformation）
            Speech.Volume = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\speech", "volume", 50))
            Player.Ctlcontrols.play()
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/File/Run Time/Text-to Text/Audio/Audio.wav")
        Else
            Erro("还没有划定出题范围。")
        End If
    End Sub

    Private Sub File1_Click(sender As Object, e As EventArgs) Handles File1.Click
        fname = File1.Text
        OpenFile(fname)
    End Sub

    Private Sub File10_Click(sender As Object, e As EventArgs) Handles File10.Click
        fname = File10.Text
        OpenFile(fname)
    End Sub

    Private Sub File2_Click(sender As Object, e As EventArgs) Handles File2.Click
        fname = File2.Text
        OpenFile(fname)
    End Sub

    Private Sub File3_Click(sender As Object, e As EventArgs) Handles File3.Click
        fname = File3.Text
        OpenFile(fname)
    End Sub

    Private Sub File4_Click(sender As Object, e As EventArgs) Handles File4.Click
        fname = File4.Text
        OpenFile(fname)
    End Sub

    Private Sub File5_Click(sender As Object, e As EventArgs) Handles File5.Click
        fname = File5.Text
        OpenFile(fname)
    End Sub

    Private Sub File6_Click(sender As Object, e As EventArgs) Handles File6.Click
        fname = File6.Text
        OpenFile(fname)
    End Sub

    Private Sub File7_Click(sender As Object, e As EventArgs) Handles File7.Click
        fname = File7.Text
        OpenFile(fname)
    End Sub

    Private Sub File8_Click(sender As Object, e As EventArgs) Handles File8.Click
        fname = File8.Text
        OpenFile(fname)
    End Sub

    Private Sub File9_Click(sender As Object, e As EventArgs) Handles File9.Click
        fname = File9.Text
        OpenFile(fname)
    End Sub
End Class
