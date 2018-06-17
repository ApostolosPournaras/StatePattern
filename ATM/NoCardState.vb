Public Class NoCardState
    Implements IATMState

    Private ATMMachine As ATMMachine

    Sub New(atm As ATMMachine)
        Me.ATMMachine = atm
    End Sub

    Public Sub ejectCard() Implements IATMState.ejectCard
        Console.WriteLine("Please insert a credid card first.")
    End Sub

    Public Sub insertCard(card As CreditCard) Implements IATMState.insertCard
        Me.ATMMachine.currentState = ATMMachine.yesCardState
        Me.ATMMachine.CreditCard = card
        Console.WriteLine("Credit card inserted.")
    End Sub

    Public Sub insertPIN(PINnumber As Integer) Implements IATMState.insertPIN
        Console.WriteLine("Please insert a credid card first.")
    End Sub

    Public Sub requestCash(amount As Integer) Implements IATMState.requestCash
        Console.WriteLine("Please insert a credid card first.")
    End Sub
End Class
