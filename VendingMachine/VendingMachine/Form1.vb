Public Class Form1
    Dim WithEvents cs As New CoinSlot
    Private Sub Nikel_Click(sender As Object, e As EventArgs) Handles Nikel.Click
        cs.InsertNikel()
        Label1.Text = cs.Total.ToString("C2")
    End Sub

    Private Sub Dime_Click(sender As Object, e As EventArgs) Handles Dime.Click
        cs.InsertDimes()
        Label1.Text = cs.Total.ToString("C2")
    End Sub

    Private Sub Quarter_Click(sender As Object, e As EventArgs) Handles Quarter.Click
        cs.InsertQuater()
        Label1.Text = cs.Total.ToString("C2")
    End Sub

    Private Sub Dollar_Click(sender As Object, e As EventArgs) Handles Dollar.Click
        cs.InsertDollar()
        Label1.Text = cs.Total.ToString("C2")
    End Sub
    Private Sub ButtonR_Click(sender As Object, e As EventArgs) Handles ButtonR.Click
        cs.CoinReturn()
        Label1.Text = cs.Total.ToString("C2")
    End Sub

    Private Sub cs_CoinReturnEvent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.CoinReturnEvent
        If d > 0 Then
            DollarPB.Visible = True
        Else
            DollarPB.Visible = False
        End If
        If q > 0 Then
            QuarterPB.Visible = True
        Else
            QuarterPB.Visible = False
        End If
        If di > 0 Then
            DimePB.Visible = True
        Else
            DimePB.Visible = False
        End If
        If n > 0 Then
            NIkelPB.Visible = True
        Else
            NIkelPB.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case IDTB.Text
            Case ProductControl1.ProductID
                cs.buy(ProductControl1)
            Case ProductControl2.ProductID
                cs.buy(ProductControl2)
            Case ProductControl3.ProductID
                cs.buy(ProductControl3)
            Case ProductControl4.ProductID
                cs.buy(ProductControl4)
            Case ProductControl5.ProductID
                cs.buy(ProductControl5)
            Case ProductControl6.ProductID
                cs.buy(ProductControl6)
            Case ProductControl7.ProductID
                cs.buy(ProductControl7)
            Case ProductControl8.ProductID
                cs.buy(ProductControl8)
            Case ProductControl9.ProductID
                cs.buy(ProductControl9)
            Case ProductControl10.ProductID
                cs.buy(ProductControl10)
            Case ProductControl11.ProductID
                cs.buy(ProductControl11)
            Case ProductControl12.ProductID
                cs.buy(ProductControl12)
            Case ProductControl13.ProductID
                cs.buy(ProductControl13)
            Case ProductControl14.ProductID
                cs.buy(ProductControl14)
            Case ProductControl15.ProductID
                cs.buy(ProductControl15)
            Case Else

        End Select
        Label1.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub ProductControl1_DispenseProduct(p As Image) Handles ProductControl1.DispenseProduct, ProductControl2.DispenseProduct, ProductControl3.DispenseProduct, ProductControl4.DispenseProduct, ProductControl5.DispenseProduct, ProductControl6.DispenseProduct, ProductControl7.DispenseProduct, ProductControl8.DispenseProduct, ProductControl9.DispenseProduct, ProductControl10.DispenseProduct, ProductControl11.DispenseProduct, ProductControl12.DispenseProduct, ProductControl13.DispenseProduct, ProductControl14.DispenseProduct, ProductControl15.DispenseProduct
        foodPB.Image = p
    End Sub
End Class
