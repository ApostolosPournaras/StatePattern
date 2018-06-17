Public Class NullCreditCard
Inherits AbstractCreditCard

    Sub New(PIN As Integer)
        MyBase.New(PIN)
        Me.isNullvalue = True
    End Sub

    Public Overrides Function validatePIN(inputPIN As Integer) As Boolean
        Return False
    End Function

End Class
