using Mediator.Colleague;
using Mediator.Mediator;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            FacebookGroupMediator facebookMediator = new FacebookGroupMediator();

            User Ram = new ConcreteUser(facebookMediator, "Ram");
            User Dave = new ConcreteUser(facebookMediator, "Dave");
            User Smith = new ConcreteUser(facebookMediator, "Smith");

            facebookMediator.RegisterUser(Ram);
            facebookMediator.RegisterUser(Dave);
            facebookMediator.RegisterUser(Smith);

            Dave.Send("Hello, nice to meet you!");
            Console.WriteLine();
            Smith.Send("I'am Smith, nice to meet you!");
        }
    }
}
