'   Project: P117A_Array3
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/10/03

Public Class Form1
    Dim Numbers(-1) As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataLabel.Text = "データ [ 0 ] ："
        ArrayLabel.Text = ""
        SortLabel.Text = ""
    End Sub

    Private Sub EntryButton_Click(sender As Object, e As EventArgs) Handles EntryButton.Click
        If Numbers.Length = 0 Then
            ArrayLabel.Text = ""
            SortLabel.Text = ""
        End If

        If IsNumeric(EntryTextBox.Text) Then
            Dim Len As Integer = Numbers.Length
            ReDim Preserve Numbers(Len)
            Numbers(Len) = Val(EntryTextBox.Text)
            DataLabel.Text = "データ [ " & Len + 1 & " ]："
        End If

        EntryTextBox.SelectAll()
        EntryTextBox.Focus()

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        Dim Num As Double

        '入力順
        For Each Num In Numbers
            ArrayLabel.Text &= Num & " "
        Next

        '降順
        Array.Sort(Numbers)
        Array.Reverse(Numbers)
        For Each Num In Numbers
            SortLabel.Text &= Num & " "
        Next

        ReDim Numbers(-1)
        DataLabel.Text = "データ [ 0 ] ："
        EntryTextBox.Clear()
        EntryTextBox.Focus()

    End Sub
End Class
