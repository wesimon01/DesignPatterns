namespace DesignPatterns.Core.Behavioral.Strategy
{
    public class PayPalStrategy(string email, string password) : IPaymentStrategy
    {
        private readonly string _email = email;
        private readonly string _password = password;

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using paypal");
        }
    }
}
