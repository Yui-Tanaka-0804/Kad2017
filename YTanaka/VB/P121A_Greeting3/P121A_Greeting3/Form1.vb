'   Project: P121A_Greeting3
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/10/17
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Time1RadioButton.Checked = True
        Lang1RadioButton.Checked = True
        GreetingLabel.Text = "おはようございます"
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        Dim Time, Lang As Integer
        Dim Greeting() As String = {"おはようございます", "こんにちは", "こんばんは", "Good morning", "Good afternoon", "Good evening"}

        If Time1RadioButton.Checked Then
            Time = 0
        ElseIf Time2RadioButton.Checked Then
            Time = 1
        ElseIf Time3RadioButton.Checked Then
            Time = 2
        End If

        If Lang1RadioButton.Checked Then
            Lang = 0
        ElseIf Lang2RadioButton.Checked Then
            Lang = 3
        End If

        GreetingLabel.Text = Greeting(Time + Lang)

        '        If Time1RadioButton.Checked Then
        '           If Lang1RadioButton.Checked Then
        '               GreetingLabel.Text = "おはようございます"
        '           ElseIf Lang2RadioButton.Checked Then
        '               GreetingLabel.Text = "Good morning"
        '           End If
        '        End If
        '        ElseIf Time2RadioButton.Checked Then
        '           If Lang1RadioButton.Checked Then
        '               GreetingLabel.Text = "こんにちは"
        '           ElseIf Lang2RadioButton.Checked Then
        '               GreetingLabel.Text = "Good afternoon"
        '           End If
        '        End If
        '        ElseIf Time3RadioButton.Checked Then
        '           If Lang1RadioButton.Checked Then
        '               GreetingLabel.Text = "こんばんは"
        '           ElseIf Lang2RadioButton.Checked Then
        '               GreetingLabel.Text = "Good evening"
        '           End If
        '        End If

    End Sub
End Class
