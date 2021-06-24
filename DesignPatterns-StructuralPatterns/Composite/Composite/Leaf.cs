using System;

namespace Composite
{
   public class Leaf : IComponent
    {       
        public Leaf(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }      

        public void DisplayPrice()
        {
            Console.WriteLine(Name + " : " + Price);
        }
    }
}
