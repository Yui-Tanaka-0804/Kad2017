'   Project: P113A_Figure
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/10/02

Public Class Form1
    Private Sub NumTextBox_TextChanged(sender As Object, e As EventArgs) Handles NumTextBox.TextChanged
        MsgLabel.Text = ""
    End Sub

    Private Sub ExecButton_Click(sender As Object, e As EventArgs) Handles ExecButton.Click
        Dim NumLong As Long = Val(NumTextBox.Text)
        Dim NumDouble As Double = Val(NumTextBox.Text)

        If NumLong = NumDouble And NumLong > 0 Then
            Dim Digit, Figure, Sum As Integer
            Dim Product As Integer = 1

            While NumLong > 0
                Digit = NumLong Mod 10
                Figure += 1
                Sum += Digit
                Product *= Digit
                NumLong \= 10
            End While

            MsgLabel.Text = Figure & "桁の各数字の和は " & Sum & ", 積は " & Product & " です。"
        Else
            MsgLabel.Text = "正の整数を入力してください。"
        End If

        NumTextBox.SelectAll()
        NumTextBox.Focus()

    End Sub
End Class
