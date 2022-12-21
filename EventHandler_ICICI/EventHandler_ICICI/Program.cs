using EventHandler_ICICI;

CreditCard creditCard = new CreditCard("465465", "Aditi", 0, 50000);
creditCard.Transaction += SendSMS;
creditCard.MakePayment(100);
creditCard.MakePayment(1000);

Console.ReadLine();

static void SendSMS(string message)
{
    Console.WriteLine(message);
}