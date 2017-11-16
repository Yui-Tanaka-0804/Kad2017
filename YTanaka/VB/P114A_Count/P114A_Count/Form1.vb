'   Project: P114A_Count
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/10/24

Public Class Form1
    Dim Counter As Integer
    Private Sub CountButton_Click(sender As Object, e As EventArgs) Handles CountButton.Click
        Counter += 1
        MsgLabel.Text = Counter & "回"
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        If Counter <= 20 Then
            Dim N As Integer
            Dim Bar As String = ""

            For N = 1 To Counter
                Bar &= "■"
            Next

            BarTextBox.Text = Bar
        Else
            BarTextBox.Text = "表示できません"
        End If

        ClearButton.Focus()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Counter = 0
        BarTextBox.Clear()
        MsgLabel.Text = ""
        CountButton.Focus()

    End Sub
End Class
