Imports System.IO

Public Class mainForm
    Private isSaved As Boolean = True
    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        txtTextArea.Undo() '实现撤销
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        txtTextArea.Cut() '实现剪切
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        txtTextArea.Copy()  '实现复制
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtTextArea.Paste() '实现粘贴
    End Sub

    Private Sub DelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DelToolStripMenuItem.Click
        txtTextArea.SelectedText = "" '实现删除
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        txtTextArea.SelectAll() '实现全选
    End Sub

    Private Sub DateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateToolStripMenuItem.Click
        txtTextArea.Text += Now '实现添加当前日期时间
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If fntFont.ShowDialog() = DialogResult.OK Then '显示设置字体窗体
            txtTextArea.Font = fntFont.Font  '设置文本框字体
        End If
    End Sub

    Private Sub ShowHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        Help.ShowDialog() '显示帮助窗体
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()  '显示关于窗体
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        FindNextForm.Show() '显示查找窗体
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click
        ReplaceForm.Show() '显示替换窗体
    End Sub

    Private Sub TurnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TurnToolStripMenuItem.Click
        TurnForm.ShowDialog() '显示转到窗体
    End Sub

    Private Sub PageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageToolStripMenuItem.Click
        SetPage.ShowDialog() '页面设置
    End Sub

    Private Sub StatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusToolStripMenuItem.Click
        sasStatus.Visible = StatusToolStripMenuItem.Checked
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If BeforeNewFile() = True Then '执行创建新文件前的方法
            Open() '执行打开新文件方法
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If savSave.FileName <> "" Then '判断是否已经保存过
            Save() '执行保存方法
        Else
            SaveAs() '执行另存为方法
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveAs() '执行另存为方法
    End Sub

    Private Sub NewEmptyFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEmptyFileToolStripMenuItem.Click
        If BeforeNewFile() = True Then '执行创建新文件前的方法
            NewEmptyFile() '执行创建新文本文件方法
            UndoToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close() '执行关闭
    End Sub

    Private Sub WarpAndStatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WrapToolStripMenuItem.Click
        WarpAndStatusBar()
        tslCInfo.Text = CheckRow()
    End Sub

    Private Function CheckRow() As String '获取光标当前行列的方法
        If txtTextArea.WordWrap = False Then
            Dim i As Integer
            Dim num As Integer
            While i < (txtTextArea.GetLineFromCharIndex(txtTextArea.SelectionStart)) '先循环获得之前所有行的字符长度
                num += txtTextArea.Lines(i).Length
                i += 1
            End While
            Return "第 " & txtTextArea.GetLineFromCharIndex(txtTextArea.SelectionStart) + 1 & " 行, 第 " & txtTextArea.SelectionStart - (num + 2 * i) + 1 & " 列                              "
        End If
    End Function

    Private Sub txtTextArea_TextChanged(sender As Object, e As EventArgs) Handles txtTextArea.TextChanged
        tslCInfo.Text = checkrow() '执行获取光标当前行列的方法，并在状态栏显示
        isSaved = False
        If txtTextArea.Text <> "" Then
            EnableOrUnEnableItem(True) '启用受影响功能
        Else
            EnableOrUnEnableItem(False) '禁用受影响功能
        End If
    End Sub

    Private Sub txtTextArea_Clicked(sender As Object, e As EventArgs) Handles txtTextArea.Click
        tslCInfo.Text = checkrow() '执行获取光标当前行列的方法，并在状态栏显示
    End Sub

    Private Sub txtTextArea_KeyDown(sender As Object, e As EventArgs) Handles txtTextArea.KeyUp
        tslCInfo.Text = checkrow() '执行获取光标当前行列的方法，并在状态栏显示
    End Sub

    Private Sub AskForExit(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If BeforeNewFile() = True Then '关闭前判断是否于要保存
            WarpAndStatusBarINI()
            Me.Dispose()
        Else
            e.Cancel = True '如果点了取消则取消关闭
        End If
    End Sub

    Private Sub FindNextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindNextToolStripMenuItem.Click
        If FindNextForm.txtTextFound.Text <> "" Then
            FindNextForm.Find() '执行查找窗体中的查找下一个方法
        End If
    End Sub

    Private Sub NewEmptyFile() '新建文件
        txtTextArea.Clear() '清空文本框
        savSave.FileName = "" '清空filename属性
        Me.Text = "无标题 - 记事本" '改改标题
        EnableOrUnEnableItem(False) '禁用受影响功能
        isSaved = True
    End Sub

    Private Function Save() As Boolean
        Try
            Dim srmOutput As New StreamWriter(savSave.FileName, False, System.Text.Encoding.Default) '输出流
            srmOutput.Write(txtTextArea.Text) '保存文件，若存在则替换
            srmOutput.Close() '关闭输出流
            isSaved = True
            Return True
        Catch ex As Exception '处理捕获的异常
            catchException(ex)
        End Try
        Return False
    End Function

    Private Function SaveAs() As Boolean
        Dim flag As Integer = savSave.ShowDialog
        If flag = DialogResult.OK And savSave.FileName <> "" Then '弹出另存为对话框
            Save() '执行保存方法
            Me.Text = My.Computer.FileSystem.GetName(savSave.FileName) & " - 记事本" '更改标题
            Return True
        End If
        Return False
    End Function

    Private Function SaveOrSaveAs() As Boolean
        If savSave.FileName <> "" Then '判断是否保存过
            Save() '执行保存方法
        Else
            If SaveAs() = False Then '执行另存为方法
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub Open()
        If opnOpen.ShowDialog <> DialogResult.Cancel And opnOpen.FileName <> "" Then '弹出打开文件对话框
            OpenDirectly(opnOpen.FileName)
        End If
        opnOpen.FileName = "" '清空filename属性
    End Sub

    Private Sub OpenDirectly(path As String)
        Try
            Dim srmInput As New StreamReader(path, System.Text.Encoding.Default) '输入流
            txtTextArea.Text = srmInput.ReadToEnd() '读取
            srmInput.Close() '关闭输入流
            txtTextArea.SelectionStart = 0
            isSaved = True
            savSave.FileName = path '设置filename属性
            Me.Text = My.Computer.FileSystem.GetName(savSave.FileName) & " - 记事本" '更改标题
            If txtTextArea.Text <> "" Then
                EnableOrUnEnableItem(True) '启用受影响功能呢
            End If
        Catch ex As Exception '处理捕获的异常
            catchException(ex)
        End Try
    End Sub

    Private Function BeforeNewFile() As Boolean '打开或新建文件前的处理
        Dim iFlag As Integer
        Dim sPath As String
        If txtTextArea.Text <> "" Or savSave.FileName <> "" Then '是否存在可能未保存的文件
            If savSave.FileName = "" Then
                sPath = "无标题"
            Else
                sPath = savSave.FileName
            End If
            If isSaved = False Then
                iFlag = MessageBox.Show("是否将更改保存到 " + sPath + " ？", “记事本”, MessageBoxButtons.YesNoCancel)
                If iFlag = DialogResult.Cancel Then '是否保存未保存的文件
                    Return False '不允许打开或新建文件
                ElseIf iFlag = DialogResult.Yes Then
                    If SaveOrSaveAs() = False Then
                        Return False '不允许打开或新建文件
                    End If
                End If
            End If
        End If
        Return True '允许打开或新建文件
    End Function

    Private Sub WarpAndStatusBar()
        txtTextArea.WordWrap = WrapToolStripMenuItem.Checked '修改文本框属性
        TurnToolStripMenuItem.Enabled = Not WrapToolStripMenuItem.Checked '设置受影响功能是否可用
        StatusToolStripMenuItem.Enabled = Not WrapToolStripMenuItem.Checked
        sasStatus.Visible = (StatusToolStripMenuItem.Checked And (Not WrapToolStripMenuItem.Checked) And StatusToolStripMenuItem.Enabled)
    End Sub

    Private Sub WarpAndStatusBarINI()
        On Error Resume Next
        Dim sIniPath, sInfo As String
        sIniPath = Application.StartupPath() + "\nodepad.ini" '获取配置文件位置
        Dim fileInfo As New FileInfo(sIniPath)
        sInfo = "Wrap=" & WrapToolStripMenuItem.Checked & vbCrLf & "StatusBar=" & StatusToolStripMenuItem.Checked & vbCrLf & "Size=#" & Me.Size.Width & "#" & Me.Size.Height
        fileInfo.Attributes = FileAttributes.Normal
        My.Computer.FileSystem.WriteAllText(sIniPath, sInfo, False) '写入配置信息
        fileInfo.Attributes = FileAttributes.Hidden
    End Sub

    Private Sub catchException(ex As Exception) '处理捕获的异常
        Try
            Throw ex
        Catch exNew As UnauthorizedAccessException
            MsgBox("没有文件的访问权限！")
        Catch exNew As System.Text.EncoderFallbackException
            MsgBox("当前编码不支持显示半个 Unicode 代理项对！")
        Catch exNew As ArgumentNullException
            MsgBox("文件被占用或文件路径不存在！")
        Catch exNew As ArgumentException
            MsgBox("路径由于以下原因之一而无效：是零长度字符串；仅包含空白；包含无效字符；是一个设备路径（开头字符为 \\.\)；它以尾部斜杠结尾！")
        Catch exNew As FileNotFoundException
            MsgBox("该文件不存在！")
        Catch exNew As PathTooLongException
            MsgBox("路径超过了系统定义的最大长度！")
        Catch exNew As NotSupportedException
            MsgBox("路径格式无效或缓冲区已满！")
        Catch exNew As OutOfMemoryException
            MsgBox("内存不足，无法将字符串写入缓冲区！")
        Catch exNew As Security.SecurityException
            MsgBox("该用户缺少查看该路径所必需的权限！")
        Catch exNew As DirectoryNotFoundException
            MsgBox("指定的路径无效，比如在未映射的驱动器上！")
        Catch exNew As ObjectDisposedException
            MsgBox("System.IO.StreamWriter.AutoFlush 为 true 或 System.IO.StreamWriter 缓冲区已满，并且当前编写器已关闭！")
        Catch exNew As IOException
            MsgBox("文件被占用，或者出现未知读写错误！")
        Catch exNew As Exception
            MsgBox("未知错误！请联系作者！")
        End Try
    End Sub

    Private Sub EnableOrUnEnableItem(flag As Boolean) '启用/禁用文本框中存在文本才能使用的功能
        FindToolStripMenuItem.Enabled = flag
        FindNextToolStripMenuItem.Enabled = flag
        ReplaceToolStripMenuItem.Enabled = flag
        UndoToolStripMenuItem.Enabled = flag
        CutToolStripMenuItem.Enabled = flag
        CopyToolStripMenuItem.Enabled = flag
        DelToolStripMenuItem.Enabled = flag
    End Sub

    Private Sub txtTextArea_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles txtTextArea.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub txtTextArea_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtTextArea.DragDrop
        Dim files As String()
        Try
            files = CType(e.Data.GetData(DataFormats.FileDrop), String())
            BeforeNewFile()
            OpenDirectly(files(files.Length - 1))
        Catch ex As Exception
            catchException(ex)
        End Try
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Parameters() As String '用以保存数组参数
        Parameters = Environment.GetCommandLineArgs() '读取环境变量
        If Parameters.Length > 1 Then
            For num = 2 To Parameters.Length - 1
                Process.Start(Application.ExecutablePath, Parameters(num)) '有多组环境变量时打开多个记事本
            Next
            OpenDirectly(Parameters(1))
            txtTextArea.SelectionStart = 0
            'If Parameters(1).EndsWith(".txt") Or Parameters(1).EndsWith(".ini") Or Parameters(1).EndsWith(".xml") Or Parameters(1).EndsWith(".htm") Or Parameters(1).EndsWith(".dat") Or Parameters(1).EndsWith(".php") _
            '   Or Parameters(1).EndsWith(".html") Or Parameters(1).EndsWith(".bat") Or Parameters(1).EndsWith(".cmd") Or Parameters(1).EndsWith(".config") Or Parameters(1).EndsWith(".js") Or Parameters(1).EndsWith(".css") _
            '   Or Parameters(1).EndsWith(".manifest") Or Parameters(1).EndsWith(".application") Or Parameters(1).EndsWith(".sln") Or Parameters(1).EndsWith(".settings") Or Parameters(1).EndsWith(".reg") _
            '   Or Parameters(1).EndsWith(".vb") Or Parameters(1).EndsWith(".vbproj") Or Parameters(1).EndsWith(".resx") Or Parameters(1).EndsWith(".user") _
            '   Or Parameters(1).EndsWith(".xsl") Or Parameters(1).EndsWith(".prefs") Or Parameters(1).EndsWith(".opml") Or Parameters(1).EndsWith(".java") Then

            'Else
            '   MsgBox("不支持打开此类型文件！")
            '   End
            'End If
        End If
        On Error GoTo cuowu
        Dim sIniPath, sInfo As String
        sIniPath = Application.StartupPath() + "\nodepad.ini" '获取配置文件位置
        If File.Exists(sIniPath) Then '如果文件存在
            If FileLen(sIniPath) > 50 Or FileLen(sIniPath) < 39 Then
                Kill(sIniPath)
                Exit Sub
            End If
            Dim srmInput As New StreamReader(sIniPath, System.Text.Encoding.Default) '输入流
            sInfo = srmInput.ReadToEnd '读取信息
            srmInput.Close() '关闭输入流
            If sInfo.Contains("Wrap=True") Then '根据配置信息设置状态栏和自动换行
                WrapToolStripMenuItem.Checked = True
            Else
                WrapToolStripMenuItem.Checked = False
            End If
            If sInfo.Contains("StatusBar=True") Then
                StatusToolStripMenuItem.Checked = True
            Else
                StatusToolStripMenuItem.Checked = False
            End If
            WarpAndStatusBar() '更改显示效果
            If sInfo.Contains("Size=#") Then
                Me.Size = New Size(sInfo.Split("#")(1), sInfo.Split("#")(2))
            End If
        End If
        Exit Sub
cuowu:
        On Error Resume Next
        Kill(sIniPath) '配置文件被更改则删除文件
        Exit Sub
    End Sub

End Class
