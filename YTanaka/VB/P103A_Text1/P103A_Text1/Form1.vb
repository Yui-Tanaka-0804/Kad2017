'   Project: P103A_Text1
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/09/19

Public Class Form1
    Private Sub ExecButton_Click(sender As Object, e As EventArgs) Handles ExecButton.Click
        Label1.Text = TextBox1.Text

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TextBox1.Clear()
        Label1.Text = ""

        TextBox1.Focus()

    End Sub

    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        Me.Close()

    End Sub
End Class
