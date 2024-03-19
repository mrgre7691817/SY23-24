Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ClickerControl
    Public Property increment As Integer = 1
    Dim u As New Clicker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        u.increment = increment
        u.click()
        TextBoxU.Text = u.Count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        u.reset()
        TextBoxU.Text = u.Count
    End Sub
End Class
