<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumTextBox = New System.Windows.Forms.TextBox()
        Me.ExecButton = New System.Windows.Forms.Button()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "数字(&N)："
        '
        'NumTextBox
        '
        Me.NumTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.NumTextBox.Location = New System.Drawing.Point(89, 12)
        Me.NumTextBox.MaxLength = 10
        Me.NumTextBox.Name = "NumTextBox"
        Me.NumTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NumTextBox.TabIndex = 1
        '
        'ExecButton
        '
        Me.ExecButton.Location = New System.Drawing.Point(195, 12)
        Me.ExecButton.Name = "ExecButton"
        Me.ExecButton.Size = New System.Drawing.Size(75, 23)
        Me.ExecButton.TabIndex = 2
        Me.ExecButton.Text = "実行(&E)"
        Me.ExecButton.UseVisualStyleBackColor = True
        '
        'MsgLabel
        '
        Me.MsgLabel.AutoSize = True
        Me.MsgLabel.Location = New System.Drawing.Point(12, 50)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(0, 15)
        Me.MsgLabel.TabIndex = 3
        '
        'Form1
        '
        Me.AcceptButton = Me.ExecButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 74)
        Me.Controls.Add(Me.MsgLabel)
        Me.Controls.Add(Me.ExecButton)
        Me.Controls.Add(Me.NumTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "桁分解"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NumTextBox As TextBox
    Friend WithEvents ExecButton As Button
    Friend WithEvents MsgLabel As Label
End Class
