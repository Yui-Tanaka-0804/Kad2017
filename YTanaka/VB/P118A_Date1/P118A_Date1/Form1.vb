'   Project: P118A_Date1
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/10/17
Public Class Form1
    Dim MonthNo, DayNo As Integer

    Private Sub MonthTextBox_TextChanged(sender As Object, e As EventArgs) Handles MonthTextBox.TextChanged
        ShowButton.Enabled = False
        MsgLabel.Text = ""
    End Sub

    Private Sub DayTextBox_TextChanged(sender As Object, e As EventArgs) Handles DayTextBox.TextChanged
        ShowButton.Enabled = False
        MsgLabel.Text = ""
    End Sub

    Private Sub EntryButton_Click(sender As Object, e As EventArgs) Handles EntryButton.Click
        Dim Days() As Integer = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}

        If Date.IsLeapYear(Today.Year) Then
            Days(2) = 29
        End If
        MonthNo = Val(MonthTextBox.Text)
        DayNo = Val(DayTextBox.Text)
        If MonthNo < 1 Or MonthNo > 12 Then
            MsgLabel.Text = "月が不正です。"
            MonthTextBox.SelectAll()
            MonthTextBox.Focus()
        ElseIf DayNo < 1 Or DayNo > Days(Val(MonthTextBox.Text)) Then
            MsgLabel.Text = "日が不正です。"
            DayTextBox.SelectAll()
            DayTextBox.Focus()
        Else
            If MonthNo = Today.Month And DayNo = Today.Day Then
                MsgLabel.Text = "今日の日付が入力されました。"
            Else
                MsgLabel.Text = "日付が正しく入力されました。"
            End If
            ShowButton.Enabled = True
            ShowButton.Focus()
        End If
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        MsgLabel.Text = Today.Year & "年" & MonthNo & "月" & DayNo & "日"
        ShowButton.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowButton.Enabled = False
        MsgLabel.Text = ""
    End Sub
End Class
