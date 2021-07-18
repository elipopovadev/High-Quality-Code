using AbstractFactory.Client;
using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutomobileFactory hondaFactory = new HondaFactory();
            AutomobileClient client = new AutomobileClient(hondaFactory, "window");
            Console.WriteLine(client.GetWindow().Size); // 40

            var vwFactory = new VWFactory();
            AutomobileClient secondClient = new AutomobileClient(vwFactory, "window");
            Console.WriteLine(secondClient.GetWindow().Size); // 10
        }
    }
}
