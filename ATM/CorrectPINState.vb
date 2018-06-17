Public Class CorrectPINState
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
        Console.WriteLine("correct PIN already inserted")
    End Sub

    Public Sub requestCash(amount As Integer) Implements IATMState.requestCash

        If amount > Me.ATMMachine.availableATMCash Then
            Console.WriteLine("Not enought Cash in the ATM")
        Else
            Console.WriteLine(amount & "$ ejected.")
            Me.ATMMachine.availableATMCash -= amount

            If Me.ATMMachine.availableATMCash <= 0 Then
                Me.ATMMachine.currentState = ATMMachine.noCashState
            End If
        End If

    End Sub
End Class
