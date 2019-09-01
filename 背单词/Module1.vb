Module Module1
    Public Rc As New Collection
    Public Rw As New Collection
    Public Dw As New Collection
    Public Dc As New Collection
    Public pictureuse As Boolean
    Public picturestr As Boolean
    Public play As Boolean
    Public usename As String
    Public picpath As String
    Public errorcount As Integer
    Public havefinish As Boolean
    Public havechange As Boolean
    Public fname As String
    Public time As Integer '回答时间
    Public WithEvents Speech As New SpeechSynthesizer
    Public usespeech As Boolean
    Public output As Boolean
    Public outputpath As String
    Public useautosave As Boolean
    Public autosavetime As Integer
    Public autosavetd As New Threading.Thread(AddressOf AutoSave)
    Public autosavetdover As Boolean = False
    Public showrecent As Boolean
    Public recentnumber As Integer
    Public filelist As New Collection
    Public Function Find(Thing As Object, Collect As Collection) As Integer
        Dim j, i
        i = 0
        For Each j In Collect
            i += 1
            If j = Thing Then
                Return i
            End If
        Next
        Return (0)
    End Function

    Public Function Find(Thing As Object, Collect As ComboBox) As Integer
        Dim j, i
        i = 0
        For Each j In Collect.Items
            i += 1
            If j = Thing Then
                Return i
            End If
        Next
        Return (0)
    End Function
    Public Sub Erro(Description As String)
        Call MsgBox("抱歉," & usename & vbCrLf & "无法完成操作。" & vbCrLf & Description, vbCritical, My.Application.Info.Title)
    End Sub
    Public Sub Loadsetting()
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\背单词\background")
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\背单词\music")
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\背单词\erroRcount")
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\背单词\name")
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\背单词\file")
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\背单词\answertime")
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\背单词\speech")
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\背单词\autosave")
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\背单词\recent\filename")
        pictureuse = CBool(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\background", "usepicture", False))
        picturestr = CBool(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\background", "stretch", True))
        picpath = CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\background", "path", ""))
        play = CBool(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\music", "play", False))
        '播放器音量设置在form1load
        '不然隐式加载
        usename = CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\name", "name", ""))
        errorcount = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\erroRcount", "erroRcount", 3))
        time = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\answertime", "answertime", 10))
        fname = CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\file", "fname", ""))
        usespeech = CBool(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\speech", "use", True))
        With Speech
            .Volume = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\speech", "volume", 50))
            .Rate = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\speech", "rate", 0))
            .SelectVoice(CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\speech", "voice", "Microsoft Lili")))
        End With
        output = CBool(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\speech", "output", True))
        outputpath = CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\speech", "path", Application.StartupPath & "\Audio\"))
        useautosave = CBool(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\autosave", "use", True))
        autosavetime = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\autosave", "time", 5))
        If useautosave Then
            If autosavetd.ThreadState <> Threading.ThreadState.Running Then
                autosavetd.SetApartmentState(Threading.ApartmentState.STA)
                autosavetd.Start()
            End If
        Else
            If autosavetd.ThreadState = Threading.ThreadState.Running Then
                autosavetdover = True
            End If
        End If
        showrecent = CBool(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\recent", "show", True))
        recentnumber = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\recent", "number", 5))
        For i = 0 To 9
            If i > recentnumber Then
                Form1.OpenRecent.DropDownItems(i).Visible = False
            Else
                Form1.OpenRecent.DropDownItems(i).Visible = True
            End If
        Next
        For Each i In My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\背单词\recent\filename").GetValueNames
            filelist.Add(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\recent\filename", i, ""))
        Next
        ChangeFileList()
        Form1.Loadform()
    End Sub
    Public Sub SaveFile(Name As String)
        Dim file As New StreamWriter(Name, False)
        Progress.ProgressBar1.Value = 0
        Progress.Show()
        Progress.ProgressBar1.Maximum = Dw.Count + Dc.Count + Rw.Count + Rc.Count
        file.WriteLine("vbDw")
        For Each i In Dw
            file.WriteLine(i)
            Progress.ProgressBar1.Value = Progress.ProgressBar1.Value + 1
        Next
        file.WriteLine("vbDc")
        For Each i In Dc
            file.WriteLine(i)
            Progress.ProgressBar1.Value = Progress.ProgressBar1.Value + 1
        Next
        file.WriteLine("vbRw")
        For Each i In Rw
            file.WriteLine(i)
            Progress.ProgressBar1.Value = Progress.ProgressBar1.Value + 1
        Next
        file.WriteLine("vbRc")
        For Each i In Rc
            file.WriteLine(i)
            Progress.ProgressBar1.Value = Progress.ProgressBar1.Value + 1
        Next
        file.WriteLine("havefinish")
        file.WriteLine(havefinish)
        Progress.Close()
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\file", "fname", fname)
        havechange = False
        file.Close()
        MsgBox("保存成功。", vbInformation)
    End Sub
    Public Sub AutoSave()
        Dim i As New Stopwatch
        i.Restart()
        Do Until 0
            If i.ElapsedMilliseconds / 60000 >= autosavetime Then
                If fname.Length = 0 Then
                    If Form1.SaveFileDialog1.ShowDialog() = DialogResult.OK  Then
                        fname = Form1.SaveFileDialog1.FileName
                        SaveFile(Left(fname, fname.Length - 4) & "_AutoSave")
                        i.Restart()
                    Else
                        i.Restart()
                    End If
                Else
                    SaveFile(Left(fname, fname.Length - 4) & "_AutoSave.wdf")
                    i.Restart()
                End If
            End If
            If autosavetdover Then
                autosavetdover = False
                Exit Sub
            End If
        Loop
    End Sub
    Public Sub ChangeFileList()
        Do Until filelist.Count <= 10
            filelist.Remove(11)
        Loop
        For i = 0 To recentnumber - 1
            Try
                Form1.OpenRecent.DropDownItems(i).Text = filelist(i + 1)
                Form1.OpenRecent.DropDownItems(i).Visible = True
            Catch ex As IndexOutOfRangeException
                Form1.OpenRecent.DropDownItems(i).Visible = False
            End Try
        Next
        For Each i In filelist
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\背单词\recent\filename", Find(i, filelist), i)
        Next
    End Sub
End Module
