namespace ChainOfResponsibility.ChainingTheHandlers
{
   public class ATM
    {
        private TwoThousandHandler twoThousandHandler = new TwoThousandHandler();
        private FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
        private TwoHundredHandler twoHundredHandler = new TwoHundredHandler();
        private OneHundredHandler oneHundredHandler = new OneHundredHandler();

        public ATM()
        {
            // Prepare the chain of Handlers
            twoThousandHandler.NextHandler(fiveHundredHandler);
            fiveHundredHandler.NextHandler(twoHundredHandler);
            twoHundredHandler.NextHandler(oneHundredHandler);
        }
        public void Withdraw(long requestedAmount) // Withdraw operation for client
        {
            twoThousandHandler.DispatchRequest(requestedAmount);
        }
    }
}
