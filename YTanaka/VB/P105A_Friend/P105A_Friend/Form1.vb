'   Project: P105A_Friend
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/09/25

Public Class Form1
    Private Sub ExecButton_Click(sender As Object, e As EventArgs) Handles ExecButton.Click
        MsgLabel.Text = TextBox1.Text & "さんと" & TextBox2.Text & "さんは友人です。"
        SelectNextControl(ExecButton, True, True, True, True)
        'ClearButton.Focus()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        SelectNextControl(ClearButton, True, True, True, True)
        'TextBox1.Focus()
    End Sub
End Class
