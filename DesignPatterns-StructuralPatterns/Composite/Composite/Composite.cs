using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : IComponent
    {
        private List<IComponent> listOfComponents = new List<IComponent>(); // list of components
        public Composite(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void AddComponent(IComponent component)
        {
            listOfComponents.Add(component);
        }

        public void DisplayPrice()
        {
            Console.WriteLine(Name);
            foreach (var item in listOfComponents)
            {
                item.DisplayPrice();
            }
        }
    }
}
