<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetPage
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetPage))
        Me.grpPaper = New System.Windows.Forms.GroupBox()
        Me.cmbSource = New System.Windows.Forms.ComboBox()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.grpDistance = New System.Windows.Forms.GroupBox()
        Me.txtDown = New System.Windows.Forms.TextBox()
        Me.txtRight = New System.Windows.Forms.TextBox()
        Me.txtUp = New System.Windows.Forms.TextBox()
        Me.txtLeft = New System.Windows.Forms.TextBox()
        Me.lblDown = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.lblUp = New System.Windows.Forms.Label()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.grpPerview = New System.Windows.Forms.GroupBox()
        Me.picColumn = New System.Windows.Forms.PictureBox()
        Me.grpDirection = New System.Windows.Forms.GroupBox()
        Me.rbtLine = New System.Windows.Forms.RadioButton()
        Me.rbtColumn = New System.Windows.Forms.RadioButton()
        Me.butOK = New System.Windows.Forms.Button()
        Me.butClose = New System.Windows.Forms.Button()
        Me.lblHigh = New System.Windows.Forms.Label()
        Me.lblButom = New System.Windows.Forms.Label()
        Me.txtHigh = New System.Windows.Forms.TextBox()
        Me.txtButom = New System.Windows.Forms.TextBox()
        Me.grpPaper.SuspendLayout()
        Me.grpDistance.SuspendLayout()
        Me.grpPerview.SuspendLayout()
        CType(Me.picColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDirection.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPaper
        '
        Me.grpPaper.Controls.Add(Me.cmbSource)
        Me.grpPaper.Controls.Add(Me.cmbSize)
        Me.grpPaper.Controls.Add(Me.lblSource)
        Me.grpPaper.Controls.Add(Me.lblSize)
        Me.grpPaper.Location = New System.Drawing.Point(12, 12)
        Me.grpPaper.Name = "grpPaper"
        Me.grpPaper.Size = New System.Drawing.Size(390, 121)
        Me.grpPaper.TabIndex = 0
        Me.grpPaper.TabStop = False
        Me.grpPaper.Text = "纸张"
        '
        'cmbSource
        '
        Me.cmbSource.Enabled = False
        Me.cmbSource.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cmbSource.FormattingEnabled = True
        Me.cmbSource.Location = New System.Drawing.Point(92, 66)
        Me.cmbSource.Name = "cmbSource"
        Me.cmbSource.Size = New System.Drawing.Size(278, 22)
        Me.cmbSource.TabIndex = 3
        '
        'cmbSize
        '
        Me.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSize.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cmbSize.FormattingEnabled = True
        Me.cmbSize.Items.AddRange(New Object() {"A3", "A4", "A5", "B4", "B5", "信纸"})
        Me.cmbSize.Location = New System.Drawing.Point(92, 32)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(278, 22)
        Me.cmbSize.TabIndex = 2
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(23, 71)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(41, 12)
        Me.lblSource.TabIndex = 1
        Me.lblSource.Text = "来源："
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(23, 37)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(41, 12)
        Me.lblSize.TabIndex = 0
        Me.lblSize.Text = "大小："
        '
        'grpDistance
        '
        Me.grpDistance.Controls.Add(Me.txtDown)
        Me.grpDistance.Controls.Add(Me.txtRight)
        Me.grpDistance.Controls.Add(Me.txtUp)
        Me.grpDistance.Controls.Add(Me.txtLeft)
        Me.grpDistance.Controls.Add(Me.lblDown)
        Me.grpDistance.Controls.Add(Me.lblRight)
        Me.grpDistance.Controls.Add(Me.lblUp)
        Me.grpDistance.Controls.Add(Me.lblLeft)
        Me.grpDistance.Location = New System.Drawing.Point(134, 151)
        Me.grpDistance.Name = "grpDistance"
        Me.grpDistance.Size = New System.Drawing.Size(268, 116)
        Me.grpDistance.TabIndex = 0
        Me.grpDistance.TabStop = False
        Me.grpDistance.Text = "页边距(毫米)"
        '
        'txtDown
        '
        Me.txtDown.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtDown.Location = New System.Drawing.Point(175, 69)
        Me.txtDown.Name = "txtDown"
        Me.txtDown.Size = New System.Drawing.Size(63, 23)
        Me.txtDown.TabIndex = 7
        Me.txtDown.Text = "25"
        '
        'txtRight
        '
        Me.txtRight.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtRight.Location = New System.Drawing.Point(175, 29)
        Me.txtRight.Name = "txtRight"
        Me.txtRight.Size = New System.Drawing.Size(63, 23)
        Me.txtRight.TabIndex = 6
        Me.txtRight.Text = "20"
        '
        'txtUp
        '
        Me.txtUp.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtUp.Location = New System.Drawing.Point(62, 69)
        Me.txtUp.Name = "txtUp"
        Me.txtUp.Size = New System.Drawing.Size(63, 23)
        Me.txtUp.TabIndex = 5
        Me.txtUp.Text = "25"
        '
        'txtLeft
        '
        Me.txtLeft.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtLeft.Location = New System.Drawing.Point(62, 29)
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.Size = New System.Drawing.Size(63, 23)
        Me.txtLeft.TabIndex = 4
        Me.txtLeft.Text = "20"
        '
        'lblDown
        '
        Me.lblDown.AutoSize = True
        Me.lblDown.Location = New System.Drawing.Point(136, 75)
        Me.lblDown.Name = "lblDown"
        Me.lblDown.Size = New System.Drawing.Size(29, 12)
        Me.lblDown.TabIndex = 3
        Me.lblDown.Text = "下："
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.Location = New System.Drawing.Point(136, 35)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(29, 12)
        Me.lblRight.TabIndex = 2
        Me.lblRight.Text = "右："
        '
        'lblUp
        '
        Me.lblUp.AutoSize = True
        Me.lblUp.Location = New System.Drawing.Point(24, 75)
        Me.lblUp.Name = "lblUp"
        Me.lblUp.Size = New System.Drawing.Size(29, 12)
        Me.lblUp.TabIndex = 1
        Me.lblUp.Text = "上："
        '
        'lblLeft
        '
        Me.lblLeft.AutoSize = True
        Me.lblLeft.Location = New System.Drawing.Point(24, 35)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(29, 12)
        Me.lblLeft.TabIndex = 0
        Me.lblLeft.Text = "左："
        '
        'grpPerview
        '
        Me.grpPerview.Controls.Add(Me.picColumn)
        Me.grpPerview.Location = New System.Drawing.Point(419, 12)
        Me.grpPerview.Name = "grpPerview"
        Me.grpPerview.Size = New System.Drawing.Size(196, 345)
        Me.grpPerview.TabIndex = 0
        Me.grpPerview.TabStop = False
        Me.grpPerview.Text = "预览"
        '
        'picColumn
        '
        Me.picColumn.BackgroundImage = CType(resources.GetObject("picColumn.BackgroundImage"), System.Drawing.Image)
        Me.picColumn.InitialImage = CType(resources.GetObject("picColumn.InitialImage"), System.Drawing.Image)
        Me.picColumn.Location = New System.Drawing.Point(3, 17)
        Me.picColumn.Name = "picColumn"
        Me.picColumn.Size = New System.Drawing.Size(193, 328)
        Me.picColumn.TabIndex = 0
        Me.picColumn.TabStop = False
        '
        'grpDirection
        '
        Me.grpDirection.Controls.Add(Me.rbtLine)
        Me.grpDirection.Controls.Add(Me.rbtColumn)
        Me.grpDirection.Location = New System.Drawing.Point(12, 151)
        Me.grpDirection.Name = "grpDirection"
        Me.grpDirection.Size = New System.Drawing.Size(111, 116)
        Me.grpDirection.TabIndex = 0
        Me.grpDirection.TabStop = False
        Me.grpDirection.Text = "方向"
        '
        'rbtLine
        '
        Me.rbtLine.AutoSize = True
        Me.rbtLine.Enabled = False
        Me.rbtLine.Location = New System.Drawing.Point(23, 71)
        Me.rbtLine.Name = "rbtLine"
        Me.rbtLine.Size = New System.Drawing.Size(65, 16)
        Me.rbtLine.TabIndex = 1
        Me.rbtLine.Text = "横向(&A)"
        Me.rbtLine.UseVisualStyleBackColor = True
        '
        'rbtColumn
        '
        Me.rbtColumn.AutoSize = True
        Me.rbtColumn.Checked = True
        Me.rbtColumn.Location = New System.Drawing.Point(23, 37)
        Me.rbtColumn.Name = "rbtColumn"
        Me.rbtColumn.Size = New System.Drawing.Size(65, 16)
        Me.rbtColumn.TabIndex = 0
        Me.rbtColumn.TabStop = True
        Me.rbtColumn.Text = "纵向(&O)"
        Me.rbtColumn.UseVisualStyleBackColor = True
        '
        'butOK
        '
        Me.butOK.Location = New System.Drawing.Point(388, 373)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(99, 30)
        Me.butOK.TabIndex = 0
        Me.butOK.Text = "确定"
        Me.butOK.UseVisualStyleBackColor = True
        '
        'butClose
        '
        Me.butClose.Location = New System.Drawing.Point(503, 373)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(99, 30)
        Me.butClose.TabIndex = 1
        Me.butClose.Text = "取消"
        Me.butClose.UseVisualStyleBackColor = True
        '
        'lblHigh
        '
        Me.lblHigh.AutoSize = True
        Me.lblHigh.Location = New System.Drawing.Point(15, 293)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(41, 12)
        Me.lblHigh.TabIndex = 2
        Me.lblHigh.Text = "页眉："
        '
        'lblButom
        '
        Me.lblButom.AutoSize = True
        Me.lblButom.Location = New System.Drawing.Point(15, 332)
        Me.lblButom.Name = "lblButom"
        Me.lblButom.Size = New System.Drawing.Size(41, 12)
        Me.lblButom.TabIndex = 3
        Me.lblButom.Text = "页脚："
        '
        'txtHigh
        '
        Me.txtHigh.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtHigh.Location = New System.Drawing.Point(94, 288)
        Me.txtHigh.Name = "txtHigh"
        Me.txtHigh.Size = New System.Drawing.Size(308, 23)
        Me.txtHigh.TabIndex = 4
        '
        'txtButom
        '
        Me.txtButom.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtButom.Location = New System.Drawing.Point(94, 327)
        Me.txtButom.Name = "txtButom"
        Me.txtButom.Size = New System.Drawing.Size(308, 23)
        Me.txtButom.TabIndex = 5
        '
        'SetPage
        '
        Me.AcceptButton = Me.butOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 415)
        Me.Controls.Add(Me.txtButom)
        Me.Controls.Add(Me.txtHigh)
        Me.Controls.Add(Me.lblButom)
        Me.Controls.Add(Me.lblHigh)
        Me.Controls.Add(Me.grpPerview)
        Me.Controls.Add(Me.grpDistance)
        Me.Controls.Add(Me.grpDirection)
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.grpPaper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetPage"
        Me.ShowInTaskbar = False
        Me.Text = "页面设置"
        Me.grpPaper.ResumeLayout(False)
        Me.grpPaper.PerformLayout()
        Me.grpDistance.ResumeLayout(False)
        Me.grpDistance.PerformLayout()
        Me.grpPerview.ResumeLayout(False)
        CType(Me.picColumn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDirection.ResumeLayout(False)
        Me.grpDirection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpPaper As GroupBox
    Friend WithEvents grpDistance As GroupBox
    Friend WithEvents grpPerview As GroupBox
    Friend WithEvents grpDirection As GroupBox
    Friend WithEvents butOK As Button
    Friend WithEvents butClose As Button
    Friend WithEvents lblHigh As Label
    Friend WithEvents lblButom As Label
    Friend WithEvents txtHigh As TextBox
    Friend WithEvents txtButom As TextBox
    Friend WithEvents cmbSource As ComboBox
    Friend WithEvents cmbSize As ComboBox
    Friend WithEvents lblSource As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents txtDown As TextBox
    Friend WithEvents txtRight As TextBox
    Friend WithEvents txtUp As TextBox
    Friend WithEvents txtLeft As TextBox
    Friend WithEvents lblDown As Label
    Friend WithEvents lblRight As Label
    Friend WithEvents lblUp As Label
    Friend WithEvents lblLeft As Label
    Friend WithEvents rbtLine As RadioButton
    Friend WithEvents rbtColumn As RadioButton
    Friend WithEvents picColumn As PictureBox
End Class
