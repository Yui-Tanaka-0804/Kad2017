'   Project: P104A_Text2
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/09/25

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label1.Text = TextBox1.Text

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TextBox1.Text = ""
        TextBox1.Focus()

    End Sub

    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        Me.Close()
    End Sub
End Class
