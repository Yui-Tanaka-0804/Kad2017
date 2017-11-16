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
        Me.CheckButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CheckButton
        '
        Me.CheckButton.Location = New System.Drawing.Point(195, 9)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckButton.TabIndex = 2
        Me.CheckButton.Text = "判定(&C)"
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "西暦年(&Y)："
        '
        'MsgLabel
        '
        Me.MsgLabel.AutoSize = True
        Me.MsgLabel.Location = New System.Drawing.Point(12, 45)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(0, 15)
        Me.MsgLabel.TabIndex = 3
        '
        'YearTextBox
        '
        Me.YearTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.YearTextBox.Location = New System.Drawing.Point(97, 9)
        Me.YearTextBox.MaxLength = 4
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(92, 22)
        Me.YearTextBox.TabIndex = 1
        '
        'Form1
        '
        Me.AcceptButton = Me.CheckButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 69)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(Me.MsgLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckButton)
        Me.Name = "Form1"
        Me.Text = "うるう年判定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MsgLabel As Label
    Friend WithEvents YearTextBox As TextBox
End Class
