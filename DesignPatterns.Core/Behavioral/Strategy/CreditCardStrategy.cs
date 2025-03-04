namespace DesignPatterns.Core.Behavioral.Strategy
{
    public class CreditCardStrategy(
        string name,
        string cardNumber,
        string cvv,
        string dateOfExpiry) : IPaymentStrategy
    {
        private readonly string name = name;
        private readonly string cardNumber = cardNumber;
        private readonly string cvv = cvv;
        private readonly string dateOfExpiry = dateOfExpiry;

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using credit card");
        }
    }
}
