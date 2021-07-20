using System;

namespace ChainOfResponsibility
{
   public class TwoHundredHandler : Handler
    {
        public override void DispatchRequest(long requestedAmount)
        {
            long numberOfNotesToBeDispatched = requestedAmount / 200;
            if (numberOfNotesToBeDispatched > 0)
            {
                Console.WriteLine($"{numberOfNotesToBeDispatched} * two hundred notes are dispatched by TwoHundredHandler");
            }

            long remainingAmount = requestedAmount % 200;

            if (remainingAmount > 0)
            {
                refNextHandler.DispatchRequest(remainingAmount); // remainingAmount for the next handler
            }
        }
    }
}
