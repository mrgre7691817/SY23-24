Public Class Spin
    Public Property ItemValue As Integer
    Public Property SpinTime As Integer
    Public Sub spin()
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub
    Private Sub Spin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = SpinTime
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim r As Integer
        r = ran
    End Sub
End Class
