'   Project: P116A_Array2
'   Author:  fvb1a, No.04, 田中結衣
'   Date:    2017/10/03

Public Class Form1
    Dim Counter As Integer
    Dim Numbers(9) As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataLabel.Text = "データ [ 0 ] ："
        ArrayLabel.Text = ""
        TotalLabel.Text = ""
    End Sub

    Private Sub EntryButton_Click(sender As Object, e As EventArgs) Handles EntryButton.Click
        If Counter = 0 Then
            ArrayLabel.Text = ""
            TotalLabel.Text = ""
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
        If Counter >= 1 Then
            Dim N As Integer
            Dim Sum, Maximum, Minimum As Integer

            For N = 0 To Counter - 1
                ArrayLabel.Text &= Numbers(N) & " "
                Sum += Numbers(N)
            Next

            Maximum = Numbers(0)
            Minimum = Numbers(0)

            For N = 1 To Counter - 1
                Maximum = Math.Max(Maximum, Numbers(N))
                Minimum = Math.Min(Minimum, Numbers(N))
            Next

            TotalLabel.Text = "合計 = " & Sum & ", 最大値 = " & Maximum & ", 最小値 = " & Minimum

        End If

        Counter = 0
        DataLabel.Text = "データ [ 0 ] ："
        EntryTextBox.Clear()
        EntryTextBox.Focus()

    End Sub
End Class

