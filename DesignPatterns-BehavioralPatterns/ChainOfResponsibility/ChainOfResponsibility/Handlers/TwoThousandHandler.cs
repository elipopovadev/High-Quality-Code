using System;

namespace ChainOfResponsibility
{
    public class TwoThousandHandler : Handler
    {
        public override void DispatchRequest(long requestedAmount)
        {
            long numberOfNotesToBeDispatched = requestedAmount / 2000;
            if(numberOfNotesToBeDispatched > 0)
            {
                Console.WriteLine($"{numberOfNotesToBeDispatched} * two thousand notes are dispatched by TwoThousandHandler");
            }

            long remainingAmount = requestedAmount % 2000;

            if(remainingAmount > 0)
            {
               refNextHandler.DispatchRequest(remainingAmount); // remainingAmount for the next handler
            }
        }
    }
}
