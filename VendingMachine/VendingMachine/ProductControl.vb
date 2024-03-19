Public Class ProductControl
    Public Property ProductName As String
    Public Property ProductID As String
    Public Property ProductPrice As Decimal
    Public Property ProductImage As Image
    Public Property Productcount As Integer



    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = ProductImage
        IDLabel.Text = ProductID
        PriceLabel.Text = ProductPrice.ToString("c2")
    End Sub
    Public Event DispenseProduct(p As Image)
    Public Sub buy()
        If Productcount > 0 Then
            Productcount = Productcount - 1
            RaiseEvent DispenseProduct(ProductImage)
        End If
        If Productcount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
