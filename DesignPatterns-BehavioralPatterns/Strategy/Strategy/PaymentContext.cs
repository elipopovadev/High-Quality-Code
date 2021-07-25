namespace Strategy
{
   public class PaymentContext
    {
        private IPaymentStrategy PaymentStrategy;
        // The user will set the PaymentStrategy by 
        // calling this method at runtime
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            this.PaymentStrategy = strategy;
        }
        public void Pay(decimal amount)
        {
            PaymentStrategy.Pay(amount);
        }
    }
}
