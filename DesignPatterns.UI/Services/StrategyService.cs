using DesignPatterns.Core.Behavioral.Strategy;

namespace DesignPatterns.UI.Services
{
    public class StrategyService
    {
        public void Run()
        {
            ShoppingCart context = new();

            context.SetStrategy(new CreditCardStrategy(
                name: "John Doe",
                cardNumber: "123456789123456",
                cvv: "566",
                dateOfExpiry: "01/30"
            ));

            context.Checkout(100.50m);

            context.SetStrategy(new PayPalStrategy(
                email: "john@doe.com",
                password: "mypassword"
            ));

            context.Checkout(300.3m);

            context.SetStrategy(new BankTransferStrategy(
                bankName: "MyBank",
                accountNumber: "ABC123"
            ));

            context.Checkout(1500m);
        }
    }
}
