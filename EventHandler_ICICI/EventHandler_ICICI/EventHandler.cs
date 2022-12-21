namespace EventHandler_ICICI
{
    public class CreditCard
    {
        private string creditCardNo;
        private string cardHolderName;
        private double balanceAmount;
        private double creditLimit;

        //public delegate void SendSMS(string message);

        public event Action<string> Transaction;

        public CreditCard(string creditCardNo, string cardHolderName, double balanceAmount, double creditLimit)
        {
            this.creditCardNo = creditCardNo;
            this.cardHolderName = cardHolderName;
            this.balanceAmount = balanceAmount;
            this.creditLimit = creditLimit;
        }

        public double GetBalance()
        {
            return balanceAmount;
        }

        public double GetCreditLimit()
        {
            return creditLimit;
        }

        public void MakePayment(double amount)
        {
            if (amount <= (creditLimit - balanceAmount))
            {
                this.balanceAmount += amount;
                if (Transaction != null)
                {
                    Transaction($"{this.cardHolderName} has made payment for amount {amount}. The balance is {this.balanceAmount} and available credit is {this.creditLimit - this.balanceAmount}");
                }
            }
        }


    }
}
