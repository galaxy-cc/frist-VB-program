<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lalName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.bntExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lalName
        '
        Me.lalName.AutoSize = True
        Me.lalName.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lalName.Location = New System.Drawing.Point(319, 128)
        Me.lalName.Name = "lalName"
        Me.lalName.Size = New System.Drawing.Size(154, 24)
        Me.lalName.TabIndex = 0
        Me.lalName.Text = "输入你的名字"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtName.Location = New System.Drawing.Point(323, 165)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(141, 35)
        Me.txtName.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnOk.Location = New System.Drawing.Point(16, 297)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 33)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'bntExit
        '
        Me.bntExit.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.bntExit.Location = New System.Drawing.Point(680, 297)
        Me.bntExit.Name = "bntExit"
        Me.bntExit.Size = New System.Drawing.Size(75, 33)
        Me.bntExit.TabIndex = 3
        Me.bntExit.Text = "E&xit"
        Me.bntExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(767, 450)
        Me.Controls.Add(Me.bntExit)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lalName)
        Me.Name = "Form1"
        Me.Text = " Hello from Visual Basic 2015"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lalName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents bntExit As Button
End Class
