using Mediator.Colleague;

namespace Mediator.Mediator
{
   public interface IFacebookGroupMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }
}
