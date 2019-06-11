<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReplaceForm
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
        Me.butFindNext = New System.Windows.Forms.Button()
        Me.butReplace = New System.Windows.Forms.Button()
        Me.butReplaceAll = New System.Windows.Forms.Button()
        Me.butClose = New System.Windows.Forms.Button()
        Me.chbIsUpOrLow = New System.Windows.Forms.CheckBox()
        Me.lblFound = New System.Windows.Forms.Label()
        Me.lblReplaced = New System.Windows.Forms.Label()
        Me.txtReplaced = New System.Windows.Forms.TextBox()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'butFindNext
        '
        Me.butFindNext.Enabled = False
        Me.butFindNext.Location = New System.Drawing.Point(332, 12)
        Me.butFindNext.Name = "butFindNext"
        Me.butFindNext.Size = New System.Drawing.Size(98, 31)
        Me.butFindNext.TabIndex = 3
        Me.butFindNext.Text = "查找下一个(&F)"
        Me.butFindNext.UseVisualStyleBackColor = True
        '
        'butReplace
        '
        Me.butReplace.Enabled = False
        Me.butReplace.Location = New System.Drawing.Point(332, 49)
        Me.butReplace.Name = "butReplace"
        Me.butReplace.Size = New System.Drawing.Size(98, 31)
        Me.butReplace.TabIndex = 4
        Me.butReplace.Text = "替换(&R)"
        Me.butReplace.UseVisualStyleBackColor = True
        '
        'butReplaceAll
        '
        Me.butReplaceAll.Enabled = False
        Me.butReplaceAll.Location = New System.Drawing.Point(332, 86)
        Me.butReplaceAll.Name = "butReplaceAll"
        Me.butReplaceAll.Size = New System.Drawing.Size(98, 31)
        Me.butReplaceAll.TabIndex = 5
        Me.butReplaceAll.Text = "全部替换(&A)"
        Me.butReplaceAll.UseVisualStyleBackColor = True
        '
        'butClose
        '
        Me.butClose.Location = New System.Drawing.Point(332, 123)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(98, 31)
        Me.butClose.TabIndex = 6
        Me.butClose.Text = "取消"
        Me.butClose.UseVisualStyleBackColor = True
        '
        'chbIsUpOrLow
        '
        Me.chbIsUpOrLow.AutoSize = True
        Me.chbIsUpOrLow.Location = New System.Drawing.Point(14, 131)
        Me.chbIsUpOrLow.Name = "chbIsUpOrLow"
        Me.chbIsUpOrLow.Size = New System.Drawing.Size(102, 16)
        Me.chbIsUpOrLow.TabIndex = 2
        Me.chbIsUpOrLow.Text = "区分大小写(&C)"
        Me.chbIsUpOrLow.UseVisualStyleBackColor = True
        '
        'lblFound
        '
        Me.lblFound.AutoSize = True
        Me.lblFound.Location = New System.Drawing.Point(12, 18)
        Me.lblFound.Name = "lblFound"
        Me.lblFound.Size = New System.Drawing.Size(71, 12)
        Me.lblFound.TabIndex = 5
        Me.lblFound.Text = "查找的内容:"
        '
        'lblReplaced
        '
        Me.lblReplaced.AutoSize = True
        Me.lblReplaced.Location = New System.Drawing.Point(12, 55)
        Me.lblReplaced.Name = "lblReplaced"
        Me.lblReplaced.Size = New System.Drawing.Size(47, 12)
        Me.lblReplaced.TabIndex = 6
        Me.lblReplaced.Text = "替换为:"
        '
        'txtReplaced
        '
        Me.txtReplaced.Location = New System.Drawing.Point(111, 15)
        Me.txtReplaced.Name = "txtReplaced"
        Me.txtReplaced.Size = New System.Drawing.Size(199, 21)
        Me.txtReplaced.TabIndex = 0
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(111, 52)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(199, 21)
        Me.txtReplace.TabIndex = 1
        '
        'ReplaceForm
        '
        Me.AcceptButton = Me.butReplace
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 183)
        Me.Controls.Add(Me.txtReplace)
        Me.Controls.Add(Me.txtReplaced)
        Me.Controls.Add(Me.lblReplaced)
        Me.Controls.Add(Me.lblFound)
        Me.Controls.Add(Me.chbIsUpOrLow)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.butReplaceAll)
        Me.Controls.Add(Me.butReplace)
        Me.Controls.Add(Me.butFindNext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReplaceForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "替换"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtReplace As TextBox
    Friend WithEvents txtReplaced As TextBox
    Friend WithEvents lblReplaced As Label
    Friend WithEvents lblFound As Label
    Friend WithEvents chbIsUpOrLow As CheckBox
    Friend WithEvents butClose As Button
    Friend WithEvents butReplaceAll As Button
    Friend WithEvents butReplace As Button
    Friend WithEvents butFindNext As Button
End Class
