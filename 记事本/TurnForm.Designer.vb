<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TurnForm
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
        Me.butJump = New System.Windows.Forms.Button()
        Me.butClose = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.txtNumberOfJump = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'butJump
        '
        Me.butJump.Location = New System.Drawing.Point(96, 82)
        Me.butJump.Name = "butJump"
        Me.butJump.Size = New System.Drawing.Size(85, 30)
        Me.butJump.TabIndex = 1
        Me.butJump.Text = "转到"
        Me.butJump.UseVisualStyleBackColor = True
        '
        'butClose
        '
        Me.butClose.Location = New System.Drawing.Point(197, 82)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(85, 30)
        Me.butClose.TabIndex = 2
        Me.butClose.Text = "取消"
        Me.butClose.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(12, 22)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(53, 12)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = "行号(&L):"
        '
        'txtNumberOfJump
        '
        Me.txtNumberOfJump.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtNumberOfJump.Location = New System.Drawing.Point(12, 41)
        Me.txtNumberOfJump.Name = "txtNumberOfJump"
        Me.txtNumberOfJump.Size = New System.Drawing.Size(270, 26)
        Me.txtNumberOfJump.TabIndex = 0
        Me.txtNumberOfJump.Text = "1"
        '
        'TurnForm
        '
        Me.AcceptButton = Me.butJump
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 124)
        Me.Controls.Add(Me.txtNumberOfJump)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.butJump)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TurnForm"
        Me.ShowInTaskbar = False
        Me.Text = "转到指定行"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents butJump As Button
    Friend WithEvents butClose As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents txtNumberOfJump As TextBox
End Class
