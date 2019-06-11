<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewEmptyFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindNextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FomartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.savSave = New System.Windows.Forms.SaveFileDialog()
        Me.opnOpen = New System.Windows.Forms.OpenFileDialog()
        Me.fntFont = New System.Windows.Forms.FontDialog()
        Me.sasStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslCInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtTextArea = New System.Windows.Forms.TextBox()
        Me.mnsMenu.SuspendLayout()
        Me.sasStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsMenu
        '
        Me.mnsMenu.BackColor = System.Drawing.SystemColors.Window
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FomartToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(1086, 25)
        Me.mnsMenu.TabIndex = 1
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewEmptyFileToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem1, Me.PageToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ToolStripMenuItem5, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(58, 21)
        Me.FileToolStripMenuItem.Text = "文件(&F)"
        '
        'NewEmptyFileToolStripMenuItem
        '
        Me.NewEmptyFileToolStripMenuItem.Name = "NewEmptyFileToolStripMenuItem"
        Me.NewEmptyFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewEmptyFileToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.NewEmptyFileToolStripMenuItem.Text = "新建(&N)"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OpenToolStripMenuItem.Text = "打开(&O)..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SaveToolStripMenuItem.Text = "保存(&S)"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShowShortcutKeys = False
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SaveAsToolStripMenuItem.Text = "另存为(&A)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(171, 6)
        '
        'PageToolStripMenuItem
        '
        Me.PageToolStripMenuItem.Name = "PageToolStripMenuItem"
        Me.PageToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PageToolStripMenuItem.Text = "页面设置(&U)..."
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Enabled = False
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PrintToolStripMenuItem.Text = "打印(&P)..."
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(171, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShowShortcutKeys = False
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ExitToolStripMenuItem.Text = "退出(&X)"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.ToolStripMenuItem2, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DelToolStripMenuItem, Me.ToolStripMenuItem3, Me.FindToolStripMenuItem, Me.FindNextToolStripMenuItem, Me.ReplaceToolStripMenuItem, Me.TurnToolStripMenuItem, Me.ToolStripMenuItem4, Me.SelectAllToolStripMenuItem, Me.DateToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
        Me.EditToolStripMenuItem.Text = "编辑(&E)"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Enabled = False
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.UndoToolStripMenuItem.Text = "撤销(&U)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(172, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Enabled = False
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CutToolStripMenuItem.Text = "剪切(&T)"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Enabled = False
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CopyToolStripMenuItem.Text = "复制(&C)"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.PasteToolStripMenuItem.Text = "粘贴(&P)"
        '
        'DelToolStripMenuItem
        '
        Me.DelToolStripMenuItem.Enabled = False
        Me.DelToolStripMenuItem.Name = "DelToolStripMenuItem"
        Me.DelToolStripMenuItem.ShortcutKeyDisplayString = "Del"
        Me.DelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DelToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DelToolStripMenuItem.Text = "删除(&L)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(172, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Enabled = False
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.FindToolStripMenuItem.Text = "查找(&F)"
        '
        'FindNextToolStripMenuItem
        '
        Me.FindNextToolStripMenuItem.Enabled = False
        Me.FindNextToolStripMenuItem.Name = "FindNextToolStripMenuItem"
        Me.FindNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.FindNextToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.FindNextToolStripMenuItem.Text = "查找下一个(&N)"
        '
        'ReplaceToolStripMenuItem
        '
        Me.ReplaceToolStripMenuItem.Enabled = False
        Me.ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem"
        Me.ReplaceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.ReplaceToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ReplaceToolStripMenuItem.Text = "替换(&R)..."
        '
        'TurnToolStripMenuItem
        '
        Me.TurnToolStripMenuItem.Enabled = False
        Me.TurnToolStripMenuItem.Name = "TurnToolStripMenuItem"
        Me.TurnToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.TurnToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TurnToolStripMenuItem.Text = "转到(&G)..."
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(172, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SelectAllToolStripMenuItem.Text = "全选(&A)"
        '
        'DateToolStripMenuItem
        '
        Me.DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        Me.DateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.DateToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DateToolStripMenuItem.Text = "时间/日期(&D)"
        '
        'FomartToolStripMenuItem
        '
        Me.FomartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WrapToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.FomartToolStripMenuItem.Name = "FomartToolStripMenuItem"
        Me.FomartToolStripMenuItem.Size = New System.Drawing.Size(62, 21)
        Me.FomartToolStripMenuItem.Text = "格式(&O)"
        '
        'WrapToolStripMenuItem
        '
        Me.WrapToolStripMenuItem.Checked = True
        Me.WrapToolStripMenuItem.CheckOnClick = True
        Me.WrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WrapToolStripMenuItem.Name = "WrapToolStripMenuItem"
        Me.WrapToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.WrapToolStripMenuItem.Text = "自动换行(&W)"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.FontToolStripMenuItem.Text = "字体(&F)..."
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(60, 21)
        Me.ViewToolStripMenuItem.Text = "查看(&V)"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.CheckOnClick = True
        Me.StatusToolStripMenuItem.Enabled = False
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.StatusToolStripMenuItem.Text = "状态栏(&S)"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
        Me.HelpToolStripMenuItem.Text = "帮助(&H)"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ViewHelpToolStripMenuItem.Text = "查看帮助(&H)"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AboutToolStripMenuItem.Text = "关于(&A)"
        '
        'savSave
        '
        Me.savSave.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"
        '
        'opnOpen
        '
        Me.opnOpen.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"
        '
        'sasStatus
        '
        Me.sasStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslCInfo})
        Me.sasStatus.Location = New System.Drawing.Point(0, 626)
        Me.sasStatus.Name = "sasStatus"
        Me.sasStatus.Size = New System.Drawing.Size(1086, 22)
        Me.sasStatus.TabIndex = 2
        Me.sasStatus.Text = "StatusStrip1"
        Me.sasStatus.Visible = False
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(818, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'tslCInfo
        '
        Me.tslCInfo.Name = "tslCInfo"
        Me.tslCInfo.Size = New System.Drawing.Size(222, 17)
        Me.tslCInfo.Text = "第 1 行， 第 1 列                              "
        '
        'txtTextArea
        '
        Me.txtTextArea.AcceptsTab = True
        Me.txtTextArea.AllowDrop = True
        Me.txtTextArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTextArea.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtTextArea.HideSelection = False
        Me.txtTextArea.Location = New System.Drawing.Point(0, 25)
        Me.txtTextArea.MaxLength = 327679
        Me.txtTextArea.Multiline = True
        Me.txtTextArea.Name = "txtTextArea"
        Me.txtTextArea.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTextArea.Size = New System.Drawing.Size(1086, 601)
        Me.txtTextArea.TabIndex = 0
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 648)
        Me.Controls.Add(Me.txtTextArea)
        Me.Controls.Add(Me.sasStatus)
        Me.Controls.Add(Me.mnsMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "mainForm"
        Me.Text = "无标题 - 记事本"
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.sasStatus.ResumeLayout(False)
        Me.sasStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewEmptyFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TurnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FomartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WrapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents savSave As SaveFileDialog
    Friend WithEvents opnOpen As OpenFileDialog
    Friend WithEvents fntFont As FontDialog
    Friend WithEvents sasStatus As StatusStrip
    Friend WithEvents tslCInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents FindNextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents txtTextArea As TextBox
End Class
