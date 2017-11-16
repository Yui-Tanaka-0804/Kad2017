'   Project: P115A_Array1
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/10/03

Public Class Form1
    Dim Counter As Integer
    Dim Numbers(9) As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataLabel.Text = "データ [ 0 ] ："
        ArrayLabel.Text = ""
    End Sub

    Private Sub EntryButton_Click(sender As Object, e As EventArgs) Handles EntryButton.Click
        If Counter = 0 Then
            ArrayLabel.Text = ""
        End If

        If Counter < 10 And IsNumeric(EntryTextBox.Text) Then
            Numbers(Counter) = Val(EntryTextBox.Text)
            Counter += 1
            DataLabel.Text = "データ [ " & Counter & " ]："
        End If

        If Counter < 10 Then
            EntryTextBox.SelectAll()
            EntryTextBox.Focus()
        Else
            ShowButton.Focus()
        End If
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        Dim N As Integer
        For N = 0 To Counter - 1
            ArrayLabel.Text &= Numbers(N) & " "
        Next

        Counter = 0
        DataLabel.Text = "データ [ 0 ] ："
        EntryTextBox.Clear()
        EntryTextBox.Focus()

    End Sub
End Class
