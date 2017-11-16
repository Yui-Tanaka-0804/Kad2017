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
        Me.RadiusTextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "半径[m]:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "面積[㎡]:"
        '
        'MsgLabel
        '
        Me.MsgLabel.AutoSize = True
        Me.MsgLabel.Location = New System.Drawing.Point(12, 79)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(148, 15)
        Me.MsgLabel.TabIndex = 6
        Me.MsgLabel.Text = "半径を入力して下さい。"
        '
        'RadiusTextBox
        '
        Me.RadiusTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.RadiusTextBox.Location = New System.Drawing.Point(79, 13)
        Me.RadiusTextBox.MaxLength = 4
        Me.RadiusTextBox.Name = "RadiusTextBox"
        Me.RadiusTextBox.Size = New System.Drawing.Size(57, 22)
        Me.RadiusTextBox.TabIndex = 0
        '
        'AreaTextBox
        '
        Me.AreaTextBox.Location = New System.Drawing.Point(79, 41)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.ReadOnly = True
        Me.AreaTextBox.Size = New System.Drawing.Size(110, 22)
        Me.AreaTextBox.TabIndex = 3
        Me.AreaTextBox.TabStop = False
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(195, 12)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 1
        Me.CalcButton.Text = "計算"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(195, 41)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "クリア"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.CalcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 111)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.AreaTextBox)
        Me.Controls.Add(Me.RadiusTextBox)
        Me.Controls.Add(Me.MsgLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "円の面積"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MsgLabel As Label
    Friend WithEvents RadiusTextBox As TextBox
    Friend WithEvents AreaTextBox As TextBox
    Friend WithEvents CalcButton As Button
    Friend WithEvents ClearButton As Button
End Class
