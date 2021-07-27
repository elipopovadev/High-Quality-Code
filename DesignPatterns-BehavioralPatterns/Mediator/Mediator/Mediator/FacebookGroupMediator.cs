using Mediator.Colleague;
using System.Collections.Generic;

namespace Mediator.Mediator
{
    public class FacebookGroupMediator : IFacebookGroupMediator
    {
        private List<User> usersList = new List<User>();
        public void RegisterUser(User user)
        {
            usersList.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var u in usersList)
            {
                // message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
