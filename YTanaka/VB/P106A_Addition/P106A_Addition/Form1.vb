'   Project: P106A_Addition
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/09/25


Public Class Form1
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim N1, N2 As Double
        N1 = Val(TextBox1.Text)
        N2 = Val(TextBox2.Text)
        TextBox3.Text = N1 + N2
        ClearButton.Focus()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub
End Class
