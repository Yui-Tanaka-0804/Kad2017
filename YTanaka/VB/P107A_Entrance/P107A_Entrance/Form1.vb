'   Project: P107A_Entrance
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/09/26


Public Class Form1
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim AdultFee As Integer = 1000
        Dim ChildFee As Integer = 500
        Dim TotalFee As Integer

        AdultFee *= Val(AdultTextBox.Text)
        ChildFee *= Val(ChildTextBox.Text)
        TotalFee = AdultFee + ChildFee

        MsgLabel.Text = "料金は " & TotalFee & " 円です。"
        ClearButton.Focus()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        AdultTextBox.Clear()
        ChildTextBox.Clear()
        MsgLabel.Text = "人数を入力して下さい。"

        AdultTextBox.Focus()

    End Sub
End Class
