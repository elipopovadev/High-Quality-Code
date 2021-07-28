using Observer.Subject;
using System;

namespace Observer.Observer
{
    public class Observer : IObserver
    {      
        public Observer(string userName, ISubject subject) // user
        {
            this.UserName = userName;
            subject.RegisterObserver(this);
        }

        public string UserName { get; set; }
        public string GetName()
        {
            return UserName;
        }

        public void SendMessageToObserver(string availability)
        {
            Console.WriteLine("Hello " + this.UserName + ", Product is now " + availability + " on Amazon");
        }
    }
}
