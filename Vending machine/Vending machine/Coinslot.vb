Public Class Coinslot
    Public Event dispence(p As Image)
    Public Event coinreturnevent(d As Integer, q As Integer, dm As Integer, n As Integer)
    Public Property Quarters As Integer
    Public Property Nickles As Integer

    Public Property Dimes As Integer

    Public Property Dollars As Integer
    Dim _total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _total = Dollars * 1 + Quarters * 0.25 + Dimes * 0.1 + Nickles * 0.05
            Return _total
        End Get

    End Property
    Public Sub coinreturn()
        RaiseEvent coinreturnevent(Dollars, Quarters, Dimes, Nickles)
        Dollars = 0
        Quarters = 0
        Dimes = 0
        Nickles = 0
    End Sub

    Public Sub insertquarter()
        Quarters = Quarters + 1
    End Sub
    Public Sub inseertnickle()
        Nickles = Nickles + 1
    End Sub
    Public Sub insertdime()
        Dimes = Dimes + 1
    End Sub
    Public Sub insertdollar()
        Dollars = Dollars + 1
    End Sub
    Public Sub buy(p As productcontrol)
        If p.ProductCount > 0 And total >= p.price Then
            p.buy()
            _total = _total - p.price
            Dollars = 0
            Quarters = 0
            Dimes = 0
            Nickles = _total / 0.05
            RaiseEvent dispence(p.picture)
        End If
    End Sub
End Class
