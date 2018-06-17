Public Class ATMMachine

    Private currentStateValue As IATMState
    Public Property currentState() As IATMState
        Get
            Return currentStateValue
        End Get
        Set(ByVal value As IATMState)
            currentStateValue = value
        End Set
    End Property

    Private noCardStateValue As NoCardState
    Public Property noCardState() As NoCardState
        Get
            Return noCardStateValue
        End Get
        Set(ByVal value As NoCardState)
            noCardStateValue = value
        End Set
    End Property

    Private yesCardStateValue As YesCardState
    Public Property yesCardState() As YesCardState
        Get
            Return yesCardStateValue
        End Get
        Set(ByVal value As YesCardState)
            yesCardStateValue = value
        End Set
    End Property

    Private correctPINStateValue As CorrectPINState
    Public Property correctPINState() As CorrectPINState
        Get
            Return correctPINStateValue
        End Get
        Set(ByVal value As CorrectPINState)
            correctPINStateValue = value
        End Set
    End Property

    Private noCashStateValue As NoCashState
    Public Property noCashState() As NoCashState
        Get
            Return noCashStateValue
        End Get
        Set(ByVal value As NoCashState)
            noCashStateValue = value
        End Set
    End Property

    Private availableATMCashValue As Integer = 2000
    Public Property availableATMCash() As Integer
        Get
            Return availableATMCashValue
        End Get
        Set(ByVal value As Integer)
            availableATMCashValue = value
        End Set
    End Property

    Private CreditCardValue As AbstractCreditCard
    Public Property CreditCard() As AbstractCreditCard
        Get
            Return CreditCardValue
        End Get
        Set(ByVal value As AbstractCreditCard)
            CreditCardValue = value
        End Set
    End Property

    Sub New(cash As Integer)
        Me.availableATMCashValue = cash
        Me.noCardState = New NoCardState(Me)
        Me.yesCardState = New yesCardState(Me)
        Me.correctPINState = New CorrectPINState(Me)
        Me.noCashState = New NoCashState(Me)

        Me.CreditCard = New NullCreditCard(0)

        Me.currentState = noCardState

        If Me.availableATMCash <= 0 Then
            Me.currentState = noCashState
        End If

    End Sub

    Sub insertCreditCard(card As CreditCard)
        Me.currentState.insertCard(card)
    End Sub

    Sub ejectCreditCard()
        Me.currentState.ejectCard()
    End Sub

    Sub insertPIN(pin As Integer)
        Me.currentState.insertPIN(pin)
    End Sub

    Sub requestCash(amount As Integer)
        Me.currentState.requestCash(amount)
    End Sub

End Class
