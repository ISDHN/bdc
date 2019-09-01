Public Class Question
    Private isload As Boolean
    Private Sub Question_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each i In Dw
            QuestionBox.Items.Add(i)
            Input.AutoCompleteCustomSource.Add(i)
            If CBool(Find(i, Rw)) Then
                QuestionBox.SetItemChecked(Find(i, Dw) - 1, True)
            End If
        Next
        isload = True
        If QuestionBox.CheckedItems.Count = Dw.Count Then
            AllChoose.Checked = True
        Else
            AllChoose.Checked = False
        End If
        isload = False
    End Sub

    Private Sub Input_TextChanged(sender As Object, e As EventArgs) Handles Input.TextChanged
        If isload Then Exit Sub
        isload = True
        For Each i In QuestionBox.Items
            If Strings.Left(i, Input.TextLength) = Input.Text Then
                QuestionBox.SelectedItem = i
                Exit Sub
            End If
        Next
        isload = False
    End Sub

    Private Sub QuestionBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QuestionBox.SelectedIndexChanged
        If isload Then Exit Sub
        isload = True
        Input.Text = QuestionBox.Text
        isload = False
    End Sub

    Private Sub Question_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        QuestionBox.Items.Clear()
        Input.Text = ""
        Input.AutoCompleteCustomSource.Clear()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub Yes_Click(sender As Object, e As EventArgs) Handles Yes.Click
        Rc.Clear()
        Rw.Clear()
        For Each i In QuestionBox.CheckedItems
            Rw.Add(i)
            Rc.Add(Dc.Item(Find(i, Dw)))
        Next
        havechange = True
        havefinish = False
        Close()
    End Sub

    Private Sub AllChoose_CheckedChanged(sender As Object, e As EventArgs) Handles AllChoose.CheckedChanged
        If isload Then Exit Sub
        isload = True
        For i = 0 To QuestionBox.Items.Count - 1
            QuestionBox.SetItemChecked(i, AllChoose.Checked)
        Next
        isload = False
    End Sub

    Private Sub QuestionBox_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles QuestionBox.ItemCheck
        If isload Then Exit Sub
        isload = True
        If QuestionBox.CheckedItems.Count = Dw.Count - 1 And e.NewValue = CheckState.Checked Then
            AllChoose.Checked = True
        Else
            AllChoose.Checked = False
        End If
        isload = False
        '****************************************************************************************
        '如果不行用这个
        'For i = 0 To QuestionBox.Items.Count
        '  If i <> e.Index Then
        '       If QuestionBox.GetItemChecked(i) = False Then
        '           isload = True
        '           Choose.Checked = False
        '           isload = False
        '           Exit Sub
        '       End If
        '  End If
        'Next
        'If e.NewValue = CheckState.Checked Then
        '   isload = True
        '   AllChoose.Checked = True
        '   isload = False
        'Else
        '   isload = True
        '   AllChoose.Checked = False
        '   isload = False
        'End If
        '****************************************************************************************
    End Sub
End Class