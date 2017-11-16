'   Project: P118B_Date2
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/10/17
Public Class Form1
    Dim YMDay As Date
    Private Sub EntryButton_Click(sender As Object, e As EventArgs) Handles EntryButton.Click
        Dim Days() As Integer = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}

        If Date.IsLeapYear(Today.Year) Then
            Days(2) = 29
        End If

        Dim YMFirstString As String = Today.Year & "/" & MonthTextBox.Text & "/1"
        Dim YMDayString As String = Today.Year & "/" & MonthTextBox.Text & "/" & DayTextBox.Text

        If IsDate(YMFirstString) = False Then
            MsgLabel.Text = "月が不正です。"
            MonthTextBox.SelectAll()
            MonthTextBox.Focus()
        ElseIf IsDate(YMDayString) = False Then
            MsgLabel.Text = "日が不正です。"
            DayTextBox.SelectAll()
            DayTextBox.Focus()
        Else
            YMDay = CDate(YMDayString)
            If YMDay = Today Then
                MsgLabel.Text = "今日の日付が入力されました。"
            Else
                MsgLabel.Text = "日付が正しく入力されました。"
            End If
            ShowButton.Enabled = True
            ShowButton.Focus()
        End If

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        Dim Weeks() As String = {"日", "月", "火", "水", "木", "金", "土"}
        Dim WNo As Integer = Weekday(YMDay) - 1
        MsgLabel.Text = Format(YMDay, "yyyy年M月d日" & "は" & Weeks(WNo) & "曜日です。")
        ShowButton.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MonthTextBox.TextChanged, DayTextBox.TextChanged
        ShowButton.Enabled = False
        MsgLabel.Text = ""
    End Sub
End Class