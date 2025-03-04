namespace DesignPatterns.Core.Behavioral.Strategy
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
