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
        Me.CountButton = New System.Windows.Forms.Button()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.BarTextBox = New System.Windows.Forms.TextBox()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CountButton
        '
        Me.CountButton.Location = New System.Drawing.Point(12, 12)
        Me.CountButton.Name = "CountButton"
        Me.CountButton.Size = New System.Drawing.Size(96, 23)
        Me.CountButton.TabIndex = 0
        Me.CountButton.Text = "カウント(&C)"
        Me.CountButton.UseVisualStyleBackColor = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(117, 12)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(96, 23)
        Me.ShowButton.TabIndex = 1
        Me.ShowButton.Text = "表示(&S)"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(223, 12)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(96, 23)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "クリア(&L)"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'BarTextBox
        '
        Me.BarTextBox.BackColor = System.Drawing.Color.White
        Me.BarTextBox.ForeColor = System.Drawing.Color.Blue
        Me.BarTextBox.Location = New System.Drawing.Point(12, 41)
        Me.BarTextBox.Name = "BarTextBox"
        Me.BarTextBox.ReadOnly = True
        Me.BarTextBox.Size = New System.Drawing.Size(307, 22)
        Me.BarTextBox.TabIndex = 3
        Me.BarTextBox.TabStop = False
        '
        'MsgLabel
        '
        Me.MsgLabel.AutoSize = True
        Me.MsgLabel.Location = New System.Drawing.Point(12, 66)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(0, 15)
        Me.MsgLabel.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 97)
        Me.Controls.Add(Me.MsgLabel)
        Me.Controls.Add(Me.BarTextBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.CountButton)
        Me.Name = "Form1"
        Me.Text = "カウント"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CountButton As Button
    Friend WithEvents ShowButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents BarTextBox As TextBox
    Friend WithEvents MsgLabel As Label
End Class
