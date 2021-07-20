namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler refNextHandler;

        public void NextHandler(Handler refNextHandler) // nextHandler
        {
            this.refNextHandler = refNextHandler;
        }

        public abstract void DispatchRequest(long requestAmount); // abstract method for further processing
    }
}
