﻿namespace DesignPatterns.Core.Behavioral.Strategy
{
    public class ShoppingCart
    {
        private IPaymentStrategy? _strategy;

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Checkout(decimal amount)
        {
            _strategy?.Pay(amount);
        }
    }
}
