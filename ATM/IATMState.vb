Public Interface IATMState

    Sub insertCard(card As CreditCard)
    Sub insertPIN(PINnumber As Integer)
    Sub ejectCard()
    Sub requestCash(amount As Integer)

End Interface
