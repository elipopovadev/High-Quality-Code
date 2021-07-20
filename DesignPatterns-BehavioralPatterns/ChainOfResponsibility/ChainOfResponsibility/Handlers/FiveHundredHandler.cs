using System;

namespace ChainOfResponsibility
{
    public class FiveHundredHandler : Handler
    {
        public override void DispatchRequest(long requestedAmount)
        {
            long numberOfNotesToBeDispatched = requestedAmount / 500;
            if (numberOfNotesToBeDispatched > 0)
            {
                Console.WriteLine($"{numberOfNotesToBeDispatched} * five hundred notes are dispatched by FiveHundredHandler");
            }

            long remainingAmount = requestedAmount % 500;

            if (remainingAmount > 0)
            {
                refNextHandler.DispatchRequest(remainingAmount); // remainingAmount for the next handler
            }
        }
    }
}
