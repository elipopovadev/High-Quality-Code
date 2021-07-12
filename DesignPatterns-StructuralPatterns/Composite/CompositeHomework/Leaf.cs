using System;

namespace CompositeHomework
{
   public class Leaf
    {
        public Leaf(string name, double area)
        {
            this.Name = name;
            this.Area = area;
        }

        public string Name { get; set; }
        public double Area { get; set; }

        public void DisplayArea()
        {
            Console.WriteLine(Name + " : " + this.Area);
        }
    }
}
