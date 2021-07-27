using Mediator.Mediator;

namespace Mediator.Colleague
{
   public abstract class User
    {
        protected FacebookGroupMediator mediator;
        protected string name;
        protected User(FacebookGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
