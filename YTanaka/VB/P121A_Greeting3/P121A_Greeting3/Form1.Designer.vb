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
        Me.GreetingLabel = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Time3RadioButton = New System.Windows.Forms.RadioButton()
        Me.Time2RadioButton = New System.Windows.Forms.RadioButton()
        Me.Time1RadioButton = New System.Windows.Forms.RadioButton()
        Me.TimeGroupBox = New System.Windows.Forms.GroupBox()
        Me.LangGroupBox = New System.Windows.Forms.GroupBox()
        Me.Lang1RadioButton = New System.Windows.Forms.RadioButton()
        Me.Lang2RadioButton = New System.Windows.Forms.RadioButton()
        Me.TimeGroupBox.SuspendLayout()
        Me.LangGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GreetingLabel
        '
        Me.GreetingLabel.AutoSize = True
        Me.GreetingLabel.Font = New System.Drawing.Font("MS UI Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GreetingLabel.Location = New System.Drawing.Point(12, 9)
        Me.GreetingLabel.Name = "GreetingLabel"
        Me.GreetingLabel.Size = New System.Drawing.Size(187, 28)
        Me.GreetingLabel.TabIndex = 9
        Me.GreetingLabel.Text = "GreetingLabel"
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(239, 56)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 8
        Me.ShowButton.Text = "表示(&S)"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Time3RadioButton
        '
        Me.Time3RadioButton.AutoSize = True
        Me.Time3RadioButton.Location = New System.Drawing.Point(20, 71)
        Me.Time3RadioButton.Name = "Time3RadioButton"
        Me.Time3RadioButton.Size = New System.Drawing.Size(61, 19)
        Me.Time3RadioButton.TabIndex = 7
        Me.Time3RadioButton.TabStop = True
        Me.Time3RadioButton.Text = "夜(&E)"
        Me.Time3RadioButton.UseVisualStyleBackColor = True
        '
        'Time2RadioButton
        '
        Me.Time2RadioButton.AutoSize = True
        Me.Time2RadioButton.Location = New System.Drawing.Point(20, 46)
        Me.Time2RadioButton.Name = "Time2RadioButton"
        Me.Time2RadioButton.Size = New System.Drawing.Size(62, 19)
        Me.Time2RadioButton.TabIndex = 6
        Me.Time2RadioButton.TabStop = True
        Me.Time2RadioButton.Text = "昼(&A)"
        Me.Time2RadioButton.UseVisualStyleBackColor = True
        '
        'Time1RadioButton
        '
        Me.Time1RadioButton.AutoSize = True
        Me.Time1RadioButton.Location = New System.Drawing.Point(20, 21)
        Me.Time1RadioButton.Name = "Time1RadioButton"
        Me.Time1RadioButton.Size = New System.Drawing.Size(64, 19)
        Me.Time1RadioButton.TabIndex = 5
        Me.Time1RadioButton.TabStop = True
        Me.Time1RadioButton.Text = "朝(&M)"
        Me.Time1RadioButton.UseVisualStyleBackColor = True
        '
        'TimeGroupBox
        '
        Me.TimeGroupBox.Controls.Add(Me.Time1RadioButton)
        Me.TimeGroupBox.Controls.Add(Me.Time2RadioButton)
        Me.TimeGroupBox.Controls.Add(Me.Time3RadioButton)
        Me.TimeGroupBox.Location = New System.Drawing.Point(17, 56)
        Me.TimeGroupBox.Name = "TimeGroupBox"
        Me.TimeGroupBox.Size = New System.Drawing.Size(105, 100)
        Me.TimeGroupBox.TabIndex = 10
        Me.TimeGroupBox.TabStop = False
        Me.TimeGroupBox.Text = "時間"
        '
        'LangGroupBox
        '
        Me.LangGroupBox.Controls.Add(Me.Lang1RadioButton)
        Me.LangGroupBox.Controls.Add(Me.Lang2RadioButton)
        Me.LangGroupBox.Location = New System.Drawing.Point(128, 56)
        Me.LangGroupBox.Name = "LangGroupBox"
        Me.LangGroupBox.Size = New System.Drawing.Size(105, 100)
        Me.LangGroupBox.TabIndex = 11
        Me.LangGroupBox.TabStop = False
        Me.LangGroupBox.Text = "言語"
        '
        'Lang1RadioButton
        '
        Me.Lang1RadioButton.AutoSize = True
        Me.Lang1RadioButton.Location = New System.Drawing.Point(6, 21)
        Me.Lang1RadioButton.Name = "Lang1RadioButton"
        Me.Lang1RadioButton.Size = New System.Drawing.Size(91, 19)
        Me.Lang1RadioButton.TabIndex = 12
        Me.Lang1RadioButton.TabStop = True
        Me.Lang1RadioButton.Text = "日本語(&J)"
        Me.Lang1RadioButton.UseVisualStyleBackColor = True
        '
        'Lang2RadioButton
        '
        Me.Lang2RadioButton.AutoSize = True
        Me.Lang2RadioButton.Location = New System.Drawing.Point(6, 46)
        Me.Lang2RadioButton.Name = "Lang2RadioButton"
        Me.Lang2RadioButton.Size = New System.Drawing.Size(78, 19)
        Me.Lang2RadioButton.TabIndex = 13
        Me.Lang2RadioButton.TabStop = True
        Me.Lang2RadioButton.Text = "英語(&N)"
        Me.Lang2RadioButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.ShowButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 168)
        Me.Controls.Add(Me.LangGroupBox)
        Me.Controls.Add(Me.TimeGroupBox)
        Me.Controls.Add(Me.GreetingLabel)
        Me.Controls.Add(Me.ShowButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "あいさつ 3"
        Me.TimeGroupBox.ResumeLayout(False)
        Me.TimeGroupBox.PerformLayout()
        Me.LangGroupBox.ResumeLayout(False)
        Me.LangGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GreetingLabel As Label
    Friend WithEvents ShowButton As Button
    Friend WithEvents Time3RadioButton As RadioButton
    Friend WithEvents Time2RadioButton As RadioButton
    Friend WithEvents Time1RadioButton As RadioButton
    Friend WithEvents TimeGroupBox As GroupBox
    Friend WithEvents LangGroupBox As GroupBox
    Friend WithEvents Lang1RadioButton As RadioButton
    Friend WithEvents Lang2RadioButton As RadioButton
End Class
