Public Class DeleteWord
    Private Sub DeleteWord_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dw1.Items.Clear()
    End Sub
    Private Sub DeleteWord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i
        For Each i In Dw
            Dw1.Items.Add(i)
        Next
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub
    Private Sub Yes_Click(sender As Object, e As EventArgs) Handles Yes.Click
        Dim i
        For Each i In Dw
            If Not CBool(Find(i, Dw1)) Then
                Dc.Remove(Find(i, Dw))
                Dw.Remove(i)
            End If
        Next
        For Each i In Rw
            If Not CBool(Find(i, Dw1)) Then
                Rc.Remove(Find(i, Rw))
                Rw.Remove(i)
            End If
        Next
        havefinish = False
        havechange = True
        Close()
    End Sub

    Private Sub Dw1_KeyDown(sender As Object, e As KeyEventArgs) Handles Dw1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim i
            For Each i In Dw1.Items
                If i = Dw1.Text Then
                    Dw1.Items.Remove(i)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        If MsgBox("您真的要删除全部单词吗？", 36) = MsgBoxResult.Yes Then
            Sleep(2000)
            If MsgBox("您真的要删除全部单词吗？", 36) = MsgBoxResult.Yes Then
                Sleep(2000)
                If MsgBox("您真的要删除全部单词吗？", 36) = MsgBoxResult.Yes Then
                    Sleep(2000)
                    Dw1.Items.Clear()
                End If
            End If
        End If
    End Sub
End Class