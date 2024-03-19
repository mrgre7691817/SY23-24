Public Class CoinSlot
    Public Event CoinReturnEvent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Property Nikels As Integer
    Public Property Dimes As Integer
    Public Property Quarters As Integer
    Public Property Dollars As Integer

    Dim _total As Decimal
    Public ReadOnly Property Total As Decimal
        Get
            _total = Nikels * 0.05 + Dimes * 0.1 + Quarters * 0.25 + Dollars
            Return _total
        End Get
    End Property
    Public Sub InsertNikel()
        Nikels += 1
    End Sub
    Public Sub InsertDimes()
        Dimes += 1
    End Sub
    Public Sub InsertQuater()
        Quarters += 1
    End Sub
    Public Sub InsertDollar()
        Dollars += 1
    End Sub
    Public Sub CoinReturn()
        RaiseEvent CoinReturnEvent(Dollars, Quarters, Dimes, Nikels)
        Dollars = 0
        Quarters = 0
        Dimes = 0
        Nikels = 0
    End Sub
    Public Sub buy(p As ProductControl)
        If p.Productcount > 0 And p.ProductPrice <= _total Then
            _total = _total - p.ProductPrice
            p.buy()
            CoinReturn()
            Dollars = 0
            Quarters = 0
            Dimes = 0
            Nikels = _total / 0.05
        End If
    End Sub
End Class
