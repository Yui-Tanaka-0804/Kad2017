'   Project: P110A_Grade
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/09/26


Public Class Form1
    Const Regular As Integer = 16

    Private Sub AttendanceTextBox_Enter(sender As Object, e As EventArgs) Handles AttendanceTextBox.Enter
        MsgLabel.Text = "出席日数(0～" & Regular & ")を入力してください。"
    End Sub

    Private Sub ScoreTextBox_Enter(sender As Object, e As EventArgs) Handles ScoreTextBox.Enter
        MsgLabel.Text = "総合得点（0～100）を入力して下さい。"
    End Sub

    Private Sub GradeButton_Click(sender As Object, e As EventArgs) Handles GradeButton.Click
        Dim Score As Integer = Val(ScoreTextBox.Text)

        Select Case Score
            Case 86 To 100
                MsgLabel.Text = "評価ランクは A です。"
            Case 66 To 85
                MsgLabel.Text = "評価ランクは B です。"
            Case 50 To 65
                MsgLabel.Text = "評価ランクは C です。"
            Case 0 To 49
                MsgLabel.Text = "評価ランクは F です。"
            Case Else
                MsgLabel.Text = "評価できません。"
        End Select

        Dim Attendance As Integer = Val(AttendanceTextBox.Text)
        Attendance = Attendance * 100 \ Regular

        Select Case Attendance
            Case 0 To 74
                MsgLabel.Text = "評価ランクは F です。"
            Case Is > 100, Is < 0
                MsgLabel.Text = "評価できません。"
        End Select

        ClearButton.Focus()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ScoreTextBox.Clear()
        AttendanceTextBox.Clear()
        ScoreTextBox.Focus()

    End Sub
End Class
