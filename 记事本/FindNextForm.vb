Public Class FindNextForm

    Public Istart As Integer = 1
    Private Sub butClose_Click(sender As Object, e As EventArgs) Handles butClose.Click
        Me.Hide() '隐藏窗体
        ReplaceForm.txtReplace.Text = ""
        txtTextFound.Text = "" '清空文本框
    End Sub

    Private Sub butNextKeyWord_Click(sender As Object, e As EventArgs) Handles butNextKeyWord.Click
        Find()
    End Sub

    Private Sub txtTextFound_TextChanged(sender As Object, e As EventArgs) Handles txtTextFound.TextChanged
        If txtTextFound.Text <> "" Then '根据文本框是否存在文本判断按钮是否启用
            butNextKeyWord.Enabled = True
        Else
            butNextKeyWord.Enabled = False
        End If
        ReplaceForm.txtReplaced.Text = txtTextFound.Text
    End Sub

    Private Sub MeExit(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True '阻止窗体关闭
        Me.Hide() '隐藏窗体
    End Sub

    Private Sub chbIsUpOrLow_CheckedChanged(sender As Object, e As EventArgs) Handles chbIsUpOrLow.CheckedChanged
        ReplaceForm.chbIsUpOrLow.Checked = chbIsUpOrLow.Checked '同步改变替换窗体中的选项
    End Sub

    Public Sub Find()
        Dim Ifind As Integer
        Ifind = Len(txtTextFound.Text)
        If rbuDirectionD.Checked = True Then
            FindNextD() '执行查找方法
        Else
            FindNextU()
        End If
        If Istart <> 0 Then '是否查找到
            mainForm.txtTextArea.SelectionStart = Istart - 1
            mainForm.txtTextArea.SelectionLength = Ifind '选中查找的内容
        Else
            MsgBox("已找不到：" & txtTextFound.Text) '提示未查找到
        End If
    End Sub

    Public Sub FindNextD()
        Istart = mainForm.txtTextArea.SelectionStart + 1
        If mainForm.txtTextArea.SelectionLength > 0 And ((chbIsUpOrLow.Checked = True And StrComp(mainForm.txtTextArea.SelectedText, txtTextFound.Text, CompareMethod.Binary) = 0) Or (chbIsUpOrLow.Checked = False And StrComp(mainForm.txtTextArea.SelectedText, txtTextFound.Text, CompareMethod.Text) = 0)) Then
            Istart += 1
        End If
        If chbIsUpOrLow.Checked = True And Istart <> 0 Then '根据是否开启匹配大小写来选择匹配方法
            Istart = InStr(Istart, mainForm.txtTextArea.Text, txtTextFound.Text, CompareMethod.Binary)
        ElseIf Istart <> 0 Then
            Istart = InStr(Istart, mainForm.txtTextArea.Text, txtTextFound.Text, CompareMethod.Text)
        End If
    End Sub

    Public Sub FindNextU()
        Istart = mainForm.txtTextArea.SelectionStart + mainForm.txtTextArea.SelectionLength
        If mainForm.txtTextArea.SelectionLength > 0 And ((chbIsUpOrLow.Checked = True And StrComp(mainForm.txtTextArea.SelectedText, txtTextFound.Text, CompareMethod.Binary) = 0) Or (chbIsUpOrLow.Checked = False And StrComp(mainForm.txtTextArea.SelectedText, txtTextFound.Text, CompareMethod.Text) = 0)) Then
            Istart -= 1
        End If
        If chbIsUpOrLow.Checked = True And Istart <> 0 Then '根据是否开启匹配大小写来选择匹配方法
            Istart = InStrRev(mainForm.txtTextArea.Text, txtTextFound.Text, Istart, CompareMethod.Binary)
        ElseIf Istart <> 0 Then
            Istart = InStrRev(mainForm.txtTextArea.Text, txtTextFound.Text, Istart, CompareMethod.Text)
        End If
    End Sub

End Class