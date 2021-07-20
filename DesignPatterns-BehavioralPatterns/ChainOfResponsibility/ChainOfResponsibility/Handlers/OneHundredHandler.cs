using System;

namespace ChainOfResponsibility
{
   public class OneHundredHandler : Handler
    {
        public override void DispatchRequest(long requestedAmount)
        {
            long numberOfNotesToBeDispatched = requestedAmount / 100;
            if (numberOfNotesToBeDispatched > 0)
            {
                Console.WriteLine($"{numberOfNotesToBeDispatched} * one hundred notes are dispatched by OneHundredHandler");
            }

            long remainingAmount = requestedAmount % 100;

            if (remainingAmount > 0)
            {
                refNextHandler.DispatchRequest(remainingAmount); // remainingAmount for the next handler
            }
        }
    }
}
