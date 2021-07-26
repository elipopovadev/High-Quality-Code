using Observer.Observer;
using System;
using System.Collections.Generic;

namespace Observer.Subject
{
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>(); // list of users
        public Subject(string productName, decimal productPrice, string availability)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.Availability = availability;
        }

        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string Availability { get; set; }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.SendMessageToObserver(this.Availability);
            }

            Console.WriteLine("Product Name: "
                + ProductName + ", product Price: "
                + ProductPrice + " is Now available. So notifying all Registered users ");
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
            Console.WriteLine($"Observer added {observer.GetName()}");           
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public string GetAvailability()
        {
            return this.Availability;
        }

        public void SetAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }
    }
}
