Public Class Change
    Private Sub Change_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i
        For Each i In Dw
            English.Items.Add(i)
        Next
        For Each i In Dc
            Chinese.Items.Add(i)
        Next
    End Sub

    Private Sub Change(sender As ComboBox)
        Dim i As String
        i = InputBox("您要将" & Chr(34) & sender.SelectedItem & Chr(34) & "改为:")
        If Find(i, Dw) Then
            Erro("词典中已有该项目。")
        ElseIf i = "vbDw" Or i = "vbDc" Or i = "vbRw" Or i = "vbRc" Then
            Erro("无法添加该内容。")
        ElseIf i.length = 0 Then
            Exit Sub
        Else
            sender.Items.Item(sender.SelectedIndex) = i
        End If
    End Sub

    Private Sub English_KeyDown(sender As Object, e As KeyEventArgs) Handles English.KeyDown
        If e.KeyCode = Keys.Enter Then
            Change(English)
        End If
    End Sub
    Private Sub Chinese_KeyDown(sender As Object, e As KeyEventArgs) Handles Chinese.KeyDown
        If e.KeyCode = Keys.Enter Then
            Change(Chinese)
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub Yes_Click(sender As Object, e As EventArgs) Handles Yes.Click
        For Each i In Dw
            If English.Items.Item(Find(i, Dw) - 1) <> i Then
                Dim j = Find(i, Dw)
                Dw.Remove(j)
                Dw.Add(English.Items.Item(j - 1), English.Items.Item(j - 1), j)
                If CBool(Find(i, Rw)) Then
                    Dim h = Find(i, Rw)
                    Rw.Remove(h)
                    Rw.Add(English.Items.Item(j - 1), English.Items.Item(j - 1), h)
                End If
            End If
        Next
        For Each i In Dc
            If Chinese.Items.Item(Find(i, Dc) - 1) <> i Then
                Dim j = Find(i, Dc)
                Dc.Remove(j)
                Dc.Add(Chinese.Items.Item(j - 1), Chinese.Items.Item(j - 1), j)
                If CBool(Find(i, Rc)) Then
                    Dim h = Find(i, Rc)
                    Rc.Remove(h)
                    Rc.Add(Chinese.Items.Item(j - 1), Chinese.Items.Item(j - 1), h)
                End If
            End If
        Next
        havechange = True
        Close()
    End Sub

    Private Sub Change_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        English.Items.Clear()
        Chinese.Items.Clear()
    End Sub
End Class