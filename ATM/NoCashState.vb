Public Class NoCashState
    Implements IATMState

    Private ATMMachine As ATMMachine

    Sub New(atm As ATMMachine)
        Me.ATMMachine = atm
    End Sub

    Public Sub ejectCard() Implements IATMState.ejectCard
        If Not Me.ATMMachine.CreditCard.isNull Then
            Console.WriteLine("Card ejected")
            Me.ATMMachine.currentState = ATMMachine.noCardState
        Else
            Console.WriteLine("No oard inserted")
        End If

    End Sub

    Public Sub insertCard(card As CreditCard) Implements IATMState.insertCard
        Me.ATMMachine.currentState = ATMMachine.yesCardState
        Me.ATMMachine.CreditCard = card
        Console.WriteLine("Credit card inserted.")
    End Sub

    Public Sub insertPIN(PINnumber As Integer) Implements IATMState.insertPIN

        If Not Me.ATMMachine.CreditCard.validatePIN(PINnumber) Then
            Console.WriteLine("Wrong PIN. please Retry")
        Else
            Console.WriteLine("PIN accepted.")
            Me.ATMMachine.currentState = ATMMachine.correctPINState
        End If

    End Sub

    Public Sub requestCash(amount As Integer) Implements IATMState.requestCash
        Console.WriteLine("No available cash in the ATM.")
    End Sub
End Class
