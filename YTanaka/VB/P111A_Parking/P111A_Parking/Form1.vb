'   Project: P111A_Parking
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/10/17

Public Class Form1
    Private Sub TimeTextBox_Enter(sender As Object, e As EventArgs) Handles TimeTextBox.Enter
        MsgLabel.Text = "60分まで300円、以降30分毎に100円加算されます。"
    End Sub

    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim ParkingTime As Integer = Val(TimeTextBox.Text)
        Dim ParkingFee As Integer = 300

        If ParkingTime > 0 Then
            If ParkingTime > 60 Then
                ParkingTime = (ParkingTime - 31) \ 30
                ParkingFee += ParkingTime * 100
            End If
            MsgLabel.Text = "駐車料金は " & ParkingFee & " 円です。"
        Else
            MsgLabel.Text = "時間を正しく入力して下さい"
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TimeTextBox.Clear()
        TimeTextBox.Focus()

    End Sub
End Class
