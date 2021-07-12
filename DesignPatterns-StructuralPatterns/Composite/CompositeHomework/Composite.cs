using System;
using System.Collections.Generic;

namespace CompositeHomework
{
    public class Composite
    {
        private List<Leaf> listOfComponents = new List<Leaf>(); // list of components
        public Composite(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void AddComponent(Leaf component)
        {
            listOfComponents.Add(component);
        }

        public void DisplayArea()
        {
            Console.WriteLine(this.Name);
            foreach (var item in listOfComponents)
            {
                item.DisplayArea();
            }
        }
    }
}
