<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FindNextForm
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
        Me.lblFound = New System.Windows.Forms.Label()
        Me.butNextKeyWord = New System.Windows.Forms.Button()
        Me.butClose = New System.Windows.Forms.Button()
        Me.txtTextFound = New System.Windows.Forms.TextBox()
        Me.chbIsUpOrLow = New System.Windows.Forms.CheckBox()
        Me.grpDirtection = New System.Windows.Forms.GroupBox()
        Me.rbuDirectionU = New System.Windows.Forms.RadioButton()
        Me.rbuDirectionD = New System.Windows.Forms.RadioButton()
        Me.grpDirtection.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFound
        '
        Me.lblFound.AutoSize = True
        Me.lblFound.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblFound.Location = New System.Drawing.Point(15, 28)
        Me.lblFound.Name = "lblFound"
        Me.lblFound.Size = New System.Drawing.Size(83, 12)
        Me.lblFound.TabIndex = 6
        Me.lblFound.Text = "查找内容(&N)："
        '
        'butNextKeyWord
        '
        Me.butNextKeyWord.Enabled = False
        Me.butNextKeyWord.Location = New System.Drawing.Point(332, 16)
        Me.butNextKeyWord.Name = "butNextKeyWord"
        Me.butNextKeyWord.Size = New System.Drawing.Size(100, 32)
        Me.butNextKeyWord.TabIndex = 1
        Me.butNextKeyWord.Text = "查找下一个(&F)"
        Me.butNextKeyWord.UseVisualStyleBackColor = True
        '
        'butClose
        '
        Me.butClose.Location = New System.Drawing.Point(332, 65)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(100, 32)
        Me.butClose.TabIndex = 2
        Me.butClose.Text = "取消"
        Me.butClose.UseVisualStyleBackColor = True
        '
        'txtTextFound
        '
        Me.txtTextFound.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtTextFound.Location = New System.Drawing.Point(109, 23)
        Me.txtTextFound.Name = "txtTextFound"
        Me.txtTextFound.Size = New System.Drawing.Size(212, 23)
        Me.txtTextFound.TabIndex = 0
        '
        'chbIsUpOrLow
        '
        Me.chbIsUpOrLow.AutoSize = True
        Me.chbIsUpOrLow.Location = New System.Drawing.Point(18, 94)
        Me.chbIsUpOrLow.Name = "chbIsUpOrLow"
        Me.chbIsUpOrLow.Size = New System.Drawing.Size(102, 16)
        Me.chbIsUpOrLow.TabIndex = 3
        Me.chbIsUpOrLow.Text = "区分大小写(&C)"
        Me.chbIsUpOrLow.UseVisualStyleBackColor = True
        '
        'grpDirtection
        '
        Me.grpDirtection.Controls.Add(Me.rbuDirectionU)
        Me.grpDirtection.Controls.Add(Me.rbuDirectionD)
        Me.grpDirtection.Location = New System.Drawing.Point(150, 61)
        Me.grpDirtection.Name = "grpDirtection"
        Me.grpDirtection.Size = New System.Drawing.Size(171, 57)
        Me.grpDirtection.TabIndex = 5
        Me.grpDirtection.TabStop = False
        Me.grpDirtection.Text = "方向"
        '
        'rbuDirectionU
        '
        Me.rbuDirectionU.AutoSize = True
        Me.rbuDirectionU.Location = New System.Drawing.Point(21, 25)
        Me.rbuDirectionU.Name = "rbuDirectionU"
        Me.rbuDirectionU.Size = New System.Drawing.Size(65, 16)
        Me.rbuDirectionU.TabIndex = 5
        Me.rbuDirectionU.TabStop = True
        Me.rbuDirectionU.Text = "向上(&U)"
        Me.rbuDirectionU.UseVisualStyleBackColor = True
        '
        'rbuDirectionD
        '
        Me.rbuDirectionD.AutoSize = True
        Me.rbuDirectionD.Checked = True
        Me.rbuDirectionD.Location = New System.Drawing.Point(92, 25)
        Me.rbuDirectionD.Name = "rbuDirectionD"
        Me.rbuDirectionD.Size = New System.Drawing.Size(65, 16)
        Me.rbuDirectionD.TabIndex = 4
        Me.rbuDirectionD.TabStop = True
        Me.rbuDirectionD.Text = "向下(&D)"
        Me.rbuDirectionD.UseVisualStyleBackColor = True
        '
        'FindNextForm
        '
        Me.AcceptButton = Me.butNextKeyWord
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 135)
        Me.Controls.Add(Me.grpDirtection)
        Me.Controls.Add(Me.chbIsUpOrLow)
        Me.Controls.Add(Me.txtTextFound)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.butNextKeyWord)
        Me.Controls.Add(Me.lblFound)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindNextForm"
        Me.ShowInTaskbar = False
        Me.Text = "查找"
        Me.TopMost = True
        Me.grpDirtection.ResumeLayout(False)
        Me.grpDirtection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFound As Label
    Friend WithEvents butNextKeyWord As Button
    Friend WithEvents butClose As Button
    Friend WithEvents txtTextFound As TextBox
    Friend WithEvents chbIsUpOrLow As CheckBox
    Friend WithEvents grpDirtection As GroupBox
    Friend WithEvents rbuDirectionD As RadioButton
    Friend WithEvents rbuDirectionU As RadioButton
End Class
