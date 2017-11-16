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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.GradeButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.AttendanceTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "総合得点:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "出席日数:"
        '
        'MsgLabel
        '
        Me.MsgLabel.AutoSize = True
        Me.MsgLabel.Location = New System.Drawing.Point(12, 81)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(0, 15)
        Me.MsgLabel.TabIndex = 2
        '
        'GradeButton
        '
        Me.GradeButton.Location = New System.Drawing.Point(195, 12)
        Me.GradeButton.Name = "GradeButton"
        Me.GradeButton.Size = New System.Drawing.Size(75, 23)
        Me.GradeButton.TabIndex = 3
        Me.GradeButton.Text = "評価"
        Me.GradeButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(195, 41)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "クリア"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ScoreTextBox
        '
        Me.ScoreTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ScoreTextBox.Location = New System.Drawing.Point(89, 13)
        Me.ScoreTextBox.MaxLength = 3
        Me.ScoreTextBox.Name = "ScoreTextBox"
        Me.ScoreTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ScoreTextBox.TabIndex = 5
        '
        'AttendanceTextBox
        '
        Me.AttendanceTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.AttendanceTextBox.Location = New System.Drawing.Point(89, 42)
        Me.AttendanceTextBox.MaxLength = 2
        Me.AttendanceTextBox.Name = "AttendanceTextBox"
        Me.AttendanceTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AttendanceTextBox.TabIndex = 6
        '
        'Form1
        '
        Me.AcceptButton = Me.GradeButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 112)
        Me.Controls.Add(Me.AttendanceTextBox)
        Me.Controls.Add(Me.ScoreTextBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.GradeButton)
        Me.Controls.Add(Me.MsgLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "成績評価"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MsgLabel As Label
    Friend WithEvents GradeButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ScoreTextBox As TextBox
    Friend WithEvents AttendanceTextBox As TextBox
End Class
