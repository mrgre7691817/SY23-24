Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReelControl1.spin()
        reelcontrol2.spin()
        reelcontrol3.spin()
        label1.text = reelcontrol1.itemvalue
        label2.text = reelcontrol1.itemvalue
        label3.text = reelcontrol1.itemvalue
    End Sub

End Class
