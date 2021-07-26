using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Product with Out Of Stock Status
            Subject.Subject RedMI = new Subject.Subject("Red MI Mobile", 10000, "Out Of Stock");
          
            Observer.Observer user1 = new Observer.Observer("Eli", RedMI);
            Observer.Observer user2 = new Observer.Observer("Ivo", RedMI);
            Observer.Observer user3 = new Observer.Observer("Asen", RedMI);

            Console.WriteLine("Red MI Mobile current state: " + RedMI.GetAvailability()); // "out of stock"          
            RedMI.SetAvailability("Available");  // Now product is available
        }
    }
}
