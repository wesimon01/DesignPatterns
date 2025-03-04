using DesignPatterns.Core.Behavioral.Strategy;

namespace DesignPatterns.UI.Services
{
    public class StrategyService
    {
        public void Run()
        {
            ShoppingCart cartContext = new();

            cartContext.SetStrategy(new CreditCardStrategy(
                name: "John Doe",
                cardNumber: "123456789123456",
                cvv: "566",
                dateOfExpiry: "01/30"
            ));

            cartContext.Checkout(100.50m);

            cartContext.SetStrategy(new PayPalStrategy(
                email: "john@doe.com",
                password: "mypassword"
            ));

            cartContext.Checkout(300.3m);

            cartContext.SetStrategy(new BankTransferStrategy(
                bankName: "MyBank",
                accountNumber: "ABC123"
            ));

            cartContext.Checkout(1500m);
        }
    }
}
