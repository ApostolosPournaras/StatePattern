Public Class CreditCard
    Inherits AbstractCreditCard

    Sub New(PIN As Integer)
        MyBase.New(PIN)
        Me.isNullvalue = False
    End Sub

End Class
