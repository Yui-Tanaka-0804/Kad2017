'   Project: P120A_Greeting2
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/10/17
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Time1RadioButton.Checked = True
        GreetingLabel.Text = "おはようございます"
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        If Time1RadioButton.Checked Then
            GreetingLabel.Text = "おはようございます"
        ElseIf Time2RadioButton.Checked Then
            GreetingLabel.Text = "こんにちは"
        ElseIf Time3RadioButton.Checked Then
            GreetingLabel.Text = "こんばんは"
        End If
    End Sub
End Class
