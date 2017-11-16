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
        Me.ArrayLabel = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.EntryButton = New System.Windows.Forms.Button()
        Me.EntryTextBox = New System.Windows.Forms.TextBox()
        Me.DataLabel = New System.Windows.Forms.Label()
        Me.SortLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ArrayLabel
        '
        Me.ArrayLabel.AutoSize = True
        Me.ArrayLabel.Location = New System.Drawing.Point(12, 49)
        Me.ArrayLabel.Name = "ArrayLabel"
        Me.ArrayLabel.Size = New System.Drawing.Size(73, 15)
        Me.ArrayLabel.TabIndex = 9
        Me.ArrayLabel.Text = "ArrayLabel"
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(283, 14)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 8
        Me.ShowButton.Text = "表示(&S)"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'EntryButton
        '
        Me.EntryButton.Location = New System.Drawing.Point(202, 14)
        Me.EntryButton.Name = "EntryButton"
        Me.EntryButton.Size = New System.Drawing.Size(75, 23)
        Me.EntryButton.TabIndex = 7
        Me.EntryButton.Text = "入力(&E)"
        Me.EntryButton.UseVisualStyleBackColor = True
        '
        'EntryTextBox
        '
        Me.EntryTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.EntryTextBox.Location = New System.Drawing.Point(96, 15)
        Me.EntryTextBox.MaxLength = 6
        Me.EntryTextBox.Name = "EntryTextBox"
        Me.EntryTextBox.Size = New System.Drawing.Size(100, 22)
        Me.EntryTextBox.TabIndex = 6
        '
        'DataLabel
        '
        Me.DataLabel.AutoSize = True
        Me.DataLabel.Location = New System.Drawing.Point(12, 18)
        Me.DataLabel.Name = "DataLabel"
        Me.DataLabel.Size = New System.Drawing.Size(69, 15)
        Me.DataLabel.TabIndex = 5
        Me.DataLabel.Text = "DataLabel"
        '
        'SortLabel
        '
        Me.SortLabel.AutoSize = True
        Me.SortLabel.Location = New System.Drawing.Point(12, 73)
        Me.SortLabel.Name = "SortLabel"
        Me.SortLabel.Size = New System.Drawing.Size(67, 15)
        Me.SortLabel.TabIndex = 10
        Me.SortLabel.Text = "SortLabel"
        '
        'Form1
        '
        Me.AcceptButton = Me.EntryButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 97)
        Me.Controls.Add(Me.SortLabel)
        Me.Controls.Add(Me.ArrayLabel)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.EntryButton)
        Me.Controls.Add(Me.EntryTextBox)
        Me.Controls.Add(Me.DataLabel)
        Me.Name = "Form1"
        Me.Text = "配列 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArrayLabel As Label
    Friend WithEvents ShowButton As Button
    Friend WithEvents EntryButton As Button
    Friend WithEvents EntryTextBox As TextBox
    Friend WithEvents DataLabel As Label
    Friend WithEvents SortLabel As Label
End Class
