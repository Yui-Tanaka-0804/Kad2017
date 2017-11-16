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
        Me.Time1RadioButton = New System.Windows.Forms.RadioButton()
        Me.Time2RadioButton = New System.Windows.Forms.RadioButton()
        Me.Time3RadioButton = New System.Windows.Forms.RadioButton()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.GreetingLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Time1RadioButton
        '
        Me.Time1RadioButton.AutoSize = True
        Me.Time1RadioButton.Location = New System.Drawing.Point(17, 53)
        Me.Time1RadioButton.Name = "Time1RadioButton"
        Me.Time1RadioButton.Size = New System.Drawing.Size(64, 19)
        Me.Time1RadioButton.TabIndex = 0
        Me.Time1RadioButton.TabStop = True
        Me.Time1RadioButton.Text = "朝(&M)"
        Me.Time1RadioButton.UseVisualStyleBackColor = True
        '
        'Time2RadioButton
        '
        Me.Time2RadioButton.AutoSize = True
        Me.Time2RadioButton.Location = New System.Drawing.Point(17, 78)
        Me.Time2RadioButton.Name = "Time2RadioButton"
        Me.Time2RadioButton.Size = New System.Drawing.Size(62, 19)
        Me.Time2RadioButton.TabIndex = 1
        Me.Time2RadioButton.TabStop = True
        Me.Time2RadioButton.Text = "昼(&A)"
        Me.Time2RadioButton.UseVisualStyleBackColor = True
        '
        'Time3RadioButton
        '
        Me.Time3RadioButton.AutoSize = True
        Me.Time3RadioButton.Location = New System.Drawing.Point(17, 103)
        Me.Time3RadioButton.Name = "Time3RadioButton"
        Me.Time3RadioButton.Size = New System.Drawing.Size(61, 19)
        Me.Time3RadioButton.TabIndex = 2
        Me.Time3RadioButton.TabStop = True
        Me.Time3RadioButton.Text = "夜(&E)"
        Me.Time3RadioButton.UseVisualStyleBackColor = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(167, 53)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 3
        Me.ShowButton.Text = "表示(&S)"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'GreetingLabel
        '
        Me.GreetingLabel.AutoSize = True
        Me.GreetingLabel.Font = New System.Drawing.Font("MS UI Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GreetingLabel.Location = New System.Drawing.Point(12, 9)
        Me.GreetingLabel.Name = "GreetingLabel"
        Me.GreetingLabel.Size = New System.Drawing.Size(187, 28)
        Me.GreetingLabel.TabIndex = 4
        Me.GreetingLabel.Text = "GreetingLabel"
        '
        'Form1
        '
        Me.AcceptButton = Me.ShowButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 134)
        Me.Controls.Add(Me.GreetingLabel)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Time3RadioButton)
        Me.Controls.Add(Me.Time2RadioButton)
        Me.Controls.Add(Me.Time1RadioButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "あいさつ 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Time1RadioButton As RadioButton
    Friend WithEvents GreetingLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Time2RadioButton As RadioButton
    Friend WithEvents Time3RadioButton As RadioButton
    Friend WithEvents ShowButton As Button
End Class
