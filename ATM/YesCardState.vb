Public Class YesCardState
    Implements IATMState

    Private ATMMachine As ATMMachine

    Sub New(atm As ATMMachine)
        Me.ATMMachine = atm
    End Sub

    Public Sub ejectCard() Implements IATMState.ejectCard
        Console.WriteLine("Card ejected")
        Me.ATMMachine.currentState = ATMMachine.noCardState
        Me.ATMMachine.CreditCard = New NullCreditCard(0)
    End Sub

    Public Sub insertCard(card As CreditCard) Implements IATMState.insertCard
        Console.WriteLine("Card already inserted")
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
        Console.WriteLine("Please insert a valid PIN first.")
    End Sub
End Class
