Module Module1

    Sub Main()

        Dim ATM As New ATMMachine(3500)

        ATM.ejectCreditCard()
        ATM.insertCreditCard(New CreditCard(1234))
        ATM.requestCash(2000)
        ATM.insertPIN(1234)
        ATM.requestCash(1500)
        ATM.ejectCreditCard()
        ATM.insertPIN(1234)
        ATM.ejectCreditCard()
        ATM.requestCash(5000)
        ATM.insertCreditCard(New CreditCard(2222))
        ATM.insertPIN(1234)
        ATM.insertPIN(2222)
        ATM.requestCash(10500)
        ATM.requestCash(500)
        ATM.requestCash(11500)
        ATM.ejectCreditCard()


        Do Until (Console.ReadKey.Key = ConsoleKey.Escape)
            System.Threading.Thread.Sleep(1000)
        Loop


    End Sub

End Module
