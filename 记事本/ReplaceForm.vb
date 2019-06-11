Public Class ReplaceForm

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles butClose.Click
        Me.Hide() '隐藏
        FindNextForm.txtTextFound.Text = "" '清空文本框
        txtReplace.Text = ""
        txtReplaced.Text = ""
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles butReplaceAll.Click '全部替换
        If MessageBox.Show("确认要将 " & txtReplaced.Text & " 全部替换为 " & txtReplace.Text & " ？", "记事本", MessageBoxButtons.OKCancel) <> DialogResult.OK Then
            Exit Sub
        End If
        Dim sBuf As Integer = mainForm.txtTextArea.SelectionStart
        If FindNextForm.chbIsUpOrLow.Checked = True Then '判断是否区分大小写
            mainForm.txtTextArea.Text = Replace(mainForm.txtTextArea.Text, txtReplaced.Text, txtReplace.Text, 1, -1, CompareMethod.Binary)
        Else
            mainForm.txtTextArea.Text = Replace(mainForm.txtTextArea.Text, txtReplaced.Text, txtReplace.Text, 1, -1, CompareMethod.Text)
        End If
        mainForm.txtTextArea.SelectionStart = sBuf
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles butFindNext.Click
        FindNextForm.Find() '执行查找窗体中的查找方法
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles butReplace.Click
        If FindNextForm.chbIsUpOrLow.Checked = True And StrComp(mainForm.txtTextArea.SelectedText, txtReplaced.Text, CompareMethod.Binary) = 0 Then '判断条件
            mainForm.txtTextArea.SelectedText = txtReplace.Text '替换选中文字
        ElseIf FindNextForm.chbIsUpOrLow.Checked = False And StrComp(mainForm.txtTextArea.SelectedText, txtReplaced.Text, CompareMethod.Text) = 0 Then
            mainForm.txtTextArea.SelectedText = txtReplace.Text '替换选中文字
        ElseIf (FindNextForm.chbIsUpOrLow.Checked = True And StrComp(mainForm.txtTextArea.SelectedText, txtReplaced.Text, CompareMethod.Binary) <> 0) Or (FindNextForm.chbIsUpOrLow.Checked = False And StrComp(mainForm.txtTextArea.SelectedText, txtReplaced.Text, CompareMethod.Text) <> 0) Then
            FindNextForm.Find() '执行查找窗体中的查找方法
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtReplaced.TextChanged
        FindNextForm.txtTextFound.Text = txtReplaced.Text '同步改变查找窗体中文本框的内容
        If txtReplaced.Text <> "" Then '根据文本框是否存在文本判断按钮是否启用
            butFindNext.Enabled = True
            butReplace.Enabled = True
            butReplaceAll.Enabled = True
        Else
            butFindNext.Enabled = False
            butReplace.Enabled = False
            butReplaceAll.Enabled = False
        End If
    End Sub

    Private Sub MeExit(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True '阻止窗体关闭
        Me.Hide() '隐藏窗体
    End Sub

    Private Sub chbIsUpOrLow_CheckedChanged(sender As Object, e As EventArgs) Handles chbIsUpOrLow.CheckedChanged
        FindNextForm.chbIsUpOrLow.Checked = chbIsUpOrLow.Checked '同步改变替换窗体中的选项
    End Sub

End Class