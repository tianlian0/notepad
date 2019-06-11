Public Class TurnForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles butClose.Click
        Me.Hide() '隐藏窗体
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles butJump.Click
        Dim i As Integer = 0
        Dim num As Integer = 0
        Try
            While i < (txtNumberOfJump.Text - 1) '文件头到循环获得指定行的字符数
                num += mainForm.txtTextArea.Lines(i).Length
                i += 1
            End While
            mainForm.txtTextArea.SelectionStart = num + 2 * i '加上每个回车算的两个字符
        Catch ex As Exception
            MsgBox("行数超过了总行数！")
            txtNumberOfJump.Text = i '在文本框上显示最大行数
            Exit Sub
        End Try
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumberOfJump.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = Chr(8) Then '只允许输入数字和退格
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNumberOfJump.TextChanged
        If txtNumberOfJump.Text <> "" Then '根据文本框是否为空判断按钮是否可用
            butJump.Enabled = True
        Else
            butJump.Enabled = False
        End If
    End Sub

    Private Sub 转到_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        e.Cancel = True '阻止窗体关闭
        Me.Hide() '隐藏窗体
    End Sub
End Class