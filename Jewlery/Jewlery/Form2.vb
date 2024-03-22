Public Class Form2
    Function TotalCost(Length As Decimal, Cost As Decimal, Size As Decimal, JCost As Decimal) As Decimal
        Return (Length * Cost) + (JCost * Size)
    End Function

    Private Sub MetalCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetalCB.SelectedIndexChanged
        If MetalCB.Text = "Gold " Then
            GoldPB.Visible = True
            MetalCostTB.Text = "2.99"
        Else
            GoldPB.Visible = False
        End If
        If MetalCB.Text = "Silver" Then
            SilverPB.Visible = True
            MetalCostTB.Text = "1.50"
        Else
            SilverPB.Visible = False
        End If
        If MetalCB.Text = "Rose Gold" Then
            RoseGoldPB.Visible = True
            MetalCostTB.Text = "1.00"
        Else
            RoseGoldPB.Visible = False
        End If
    End Sub

    Private Sub JewelCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JewelCB.SelectedIndexChanged
        If JewelCB.Text = "Emerald" Then
            EmeraldPB.Visible = True
            JewelCTB.Text = "350"
        Else
            EmeraldPB.Visible = False
        End If
        If JewelCB.Text = "Garnet" Then
            GarnetPB.Visible = True
            JewelCTB.Text = "550"
        Else
            GarnetPB.Visible = False
        End If
        If JewelCB.Text = "Amethyst" Then
            AmethystPB.Visible = True
            JewelCTB.Text = "50"
        Else
            AmethystPB.Visible = False
        End If
        If JewelCB.Text = "Diamond" Then
            DiamondPB.Visible = True
            JewelCTB.Text = "3400"
        Else
            DiamondPB.Visible = False
        End If
        If JewelCB.Text = "Aquamarine" Then
            AquamarinePB.Visible = True
            JewelCTB.Text = "675"
        Else
            AquamarinePB.Visible = False
        End If
    End Sub

    Private Sub SizeTB_TextChanged(sender As Object, e As EventArgs) Handles RingSizeCB.TextChanged, JewelCaratTB.TextChanged
        Dim r As Decimal
        Dim s As Decimal
        Dim c As Decimal
        Dim jc As Decimal
        Decimal.TryParse(RingSizeCB.Text, r)
        Decimal.TryParse(MetalCostTB.Text, c)
        Decimal.TryParse(JewelCaratTB.Text, s)
        Decimal.TryParse(JewelCostTB.Text, jc)
        TotalTB.Text = TotalCost(r, c, s, jc)
    End Sub
End Class