'   Project: P112A_LeapYear
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/10/17

Public Class Form1
    Private Sub YearTextBox_TextChanged(sender As Object, e As EventArgs) Handles YearTextBox.TextChanged
        MsgLabel.Text = ""
    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        Dim Year As Integer = Val(YearTextBox.Text)

        If Year >= 1900 And Year <= 2200 Then
            If Year Mod 4 = 0 And Year Mod 100 <> 0 Or Year Mod 400 = 0 Then
                MsgLabel.Text = "うるう年です。"
            Else
                MsgLabel.Text = "うるう年ではありません。"
            End If
        Else
            MsgLabel.Text = "1900～2200 の数字を入力してください。"
        End If

        YearTextBox.SelectAll()
        YearTextBox.Focus()

    End Sub
End Class
