Public MustInherit Class AbstractCreditCard

    Protected isNullvalue As Boolean
    Public ReadOnly Property isNull() As Boolean
        Get
            Return isNullvalue
        End Get
    End Property

    Private PIN As Integer
    
    Sub New(PIN As Integer)
        Me.PIN = PIN
    End Sub

    Public Overridable Function validatePIN(inputPIN As Integer) As Boolean
        Return (Me.PIN = inputPIN)
    End Function

End Class
