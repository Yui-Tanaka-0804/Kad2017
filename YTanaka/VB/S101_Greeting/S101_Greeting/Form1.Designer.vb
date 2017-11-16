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
        Me.WhoButton = New System.Windows.Forms.Button()
        Me.WhereButton = New System.Windows.Forms.Button()
        Me.BirthdayButton = New System.Windows.Forms.Button()
        Me.ByeButton = New System.Windows.Forms.Button()
        Me.FukidashiLabel = New System.Windows.Forms.Label()
        Me.ImageLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WhoButton
        '
        Me.WhoButton.Location = New System.Drawing.Point(12, 9)
        Me.WhoButton.Name = "WhoButton"
        Me.WhoButton.Size = New System.Drawing.Size(222, 26)
        Me.WhoButton.TabIndex = 0
        Me.WhoButton.Text = "君はだれ？"
        Me.WhoButton.UseVisualStyleBackColor = True
        '
        'WhereButton
        '
        Me.WhereButton.Location = New System.Drawing.Point(12, 41)
        Me.WhereButton.Name = "WhereButton"
        Me.WhereButton.Size = New System.Drawing.Size(222, 26)
        Me.WhereButton.TabIndex = 1
        Me.WhereButton.Text = "どこから来たの？"
        Me.WhereButton.UseVisualStyleBackColor = True
        '
        'BirthdayButton
        '
        Me.BirthdayButton.Location = New System.Drawing.Point(12, 73)
        Me.BirthdayButton.Name = "BirthdayButton"
        Me.BirthdayButton.Size = New System.Drawing.Size(222, 26)
        Me.BirthdayButton.TabIndex = 2
        Me.BirthdayButton.Text = "いつからここにいるの？"
        Me.BirthdayButton.UseVisualStyleBackColor = True
        '
        'ByeButton
        '
        Me.ByeButton.Location = New System.Drawing.Point(12, 141)
        Me.ByeButton.Name = "ByeButton"
        Me.ByeButton.Size = New System.Drawing.Size(222, 26)
        Me.ByeButton.TabIndex = 3
        Me.ByeButton.Text = "それじゃあ、またあした。"
        Me.ByeButton.UseVisualStyleBackColor = True
        '
        'FukidashiLabel
        '
        Me.FukidashiLabel.BackColor = System.Drawing.Color.Transparent
        Me.FukidashiLabel.Image = Global.S101_Greeting.My.Resources.Resources._00359_1
        Me.FukidashiLabel.Location = New System.Drawing.Point(262, 9)
        Me.FukidashiLabel.Name = "FukidashiLabel"
        Me.FukidashiLabel.Size = New System.Drawing.Size(350, 227)
        Me.FukidashiLabel.TabIndex = 6
        Me.FukidashiLabel.Text = "あああああ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "あああああ"
        Me.FukidashiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageLabel
        '
        Me.ImageLabel.BackColor = System.Drawing.Color.Transparent
        Me.ImageLabel.Image = Global.S101_Greeting.My.Resources.Resources._8962
        Me.ImageLabel.Location = New System.Drawing.Point(110, 188)
        Me.ImageLabel.Name = "ImageLabel"
        Me.ImageLabel.Size = New System.Drawing.Size(200, 200)
        Me.ImageLabel.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 397)
        Me.Controls.Add(Me.FukidashiLabel)
        Me.Controls.Add(Me.ImageLabel)
        Me.Controls.Add(Me.ByeButton)
        Me.Controls.Add(Me.BirthdayButton)
        Me.Controls.Add(Me.WhereButton)
        Me.Controls.Add(Me.WhoButton)
        Me.Name = "Form1"
        Me.Text = "あいさつ"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WhoButton As Button
    Friend WithEvents WhereButton As Button
    Friend WithEvents BirthdayButton As Button
    Friend WithEvents ByeButton As Button
    Friend WithEvents ImageLabel As Label
    Friend WithEvents FukidashiLabel As Label
End Class
