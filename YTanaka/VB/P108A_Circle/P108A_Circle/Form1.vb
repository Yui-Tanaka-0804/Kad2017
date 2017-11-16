'   Project: P108A_Circle
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/09/26


Public Class Form1
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim Radius As Double = Val(RadiusTextBox.Text)
        Dim Area As Double = Radius ^ 2 * Math.PI

        Area = Math.Floor(Area + 0.5) / 100
        'Area = Int(Area + 0.5) / 100

        AreaTextBox.Text = Area
        MsgLabel.Text = ""
        ClearButton.Focus()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RadiusTextBox.Clear()
        AreaTextBox.Clear()
        MsgLabel.Text = "半径を入力して下さい。"
        RadiusTextBox.Focus()

    End Sub
End Class
