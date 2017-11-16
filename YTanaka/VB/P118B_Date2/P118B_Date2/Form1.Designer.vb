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
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.EntryButton = New System.Windows.Forms.Button()
        Me.DayTextBox = New System.Windows.Forms.TextBox()
        Me.MonthTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'MsgLabel
        '
        Me.MsgLabel.AutoSize = True
        Me.MsgLabel.Location = New System.Drawing.Point(15, 53)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(65, 15)
        Me.MsgLabel.TabIndex = 13
        Me.MsgLabel.Text = "MsgLabel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "日"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "月"
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(300, 12)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 10
        Me.ShowButton.Text = "表示(&S)"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'EntryButton
        '
        Me.EntryButton.Location = New System.Drawing.Point(219, 12)
        Me.EntryButton.Name = "EntryButton"
        Me.EntryButton.Size = New System.Drawing.Size(75, 23)
        Me.EntryButton.TabIndex = 9
        Me.EntryButton.Text = "入力(&E)"
        Me.EntryButton.UseVisualStyleBackColor = True
        '
        'DayTextBox
        '
        Me.DayTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.DayTextBox.Location = New System.Drawing.Point(116, 13)
        Me.DayTextBox.MaxLength = 2
        Me.DayTextBox.Name = "DayTextBox"
        Me.DayTextBox.Size = New System.Drawing.Size(43, 22)
        Me.DayTextBox.TabIndex = 8
        '
        'MonthTextBox
        '
        Me.MonthTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MonthTextBox.Location = New System.Drawing.Point(13, 13)
        Me.MonthTextBox.MaxLength = 2
        Me.MonthTextBox.Name = "MonthTextBox"
        Me.MonthTextBox.Size = New System.Drawing.Size(43, 22)
        Me.MonthTextBox.TabIndex = 7
        '
        'Form1
        '
        Me.AcceptButton = Me.EntryButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 87)
        Me.Controls.Add(Me.MsgLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.EntryButton)
        Me.Controls.Add(Me.DayTextBox)
        Me.Controls.Add(Me.MonthTextBox)
        Me.Name = "Form1"
        Me.Text = "日付チェック 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MsgLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ShowButton As Button
    Friend WithEvents EntryButton As Button
    Friend WithEvents DayTextBox As TextBox
    Friend WithEvents MonthTextBox As TextBox
End Class
