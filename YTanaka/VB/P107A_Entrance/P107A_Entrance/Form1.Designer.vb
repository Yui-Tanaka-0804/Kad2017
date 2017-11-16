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
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.AdultTextBox = New System.Windows.Forms.TextBox()
        Me.ChildTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "大人[13歳以上]:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "小人[12歳以下]:"
        '
        'MsgLabel
        '
        Me.MsgLabel.AutoSize = True
        Me.MsgLabel.Location = New System.Drawing.Point(12, 88)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(148, 15)
        Me.MsgLabel.TabIndex = 6
        Me.MsgLabel.Text = "人数を入力して下さい。"
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(214, 12)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 2
        Me.CalcButton.Text = "計算"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(214, 48)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "クリア"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'AdultTextBox
        '
        Me.AdultTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.AdultTextBox.Location = New System.Drawing.Point(129, 13)
        Me.AdultTextBox.MaxLength = 4
        Me.AdultTextBox.Name = "AdultTextBox"
        Me.AdultTextBox.Size = New System.Drawing.Size(79, 22)
        Me.AdultTextBox.TabIndex = 0
        '
        'ChildTextBox
        '
        Me.ChildTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ChildTextBox.Location = New System.Drawing.Point(129, 49)
        Me.ChildTextBox.MaxLength = 4
        Me.ChildTextBox.Name = "ChildTextBox"
        Me.ChildTextBox.Size = New System.Drawing.Size(79, 22)
        Me.ChildTextBox.TabIndex = 1
        '
        'Form1
        '
        Me.AcceptButton = Me.CalcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 111)
        Me.Controls.Add(Me.ChildTextBox)
        Me.Controls.Add(Me.AdultTextBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.MsgLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "入場料金"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MsgLabel As Label
    Friend WithEvents CalcButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents AdultTextBox As TextBox
    Friend WithEvents ChildTextBox As TextBox
End Class
