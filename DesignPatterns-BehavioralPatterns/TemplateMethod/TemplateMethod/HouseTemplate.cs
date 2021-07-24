using System;

namespace TemplateMethod
{
   public abstract class HouseTemplate // always is abstract class
    {
        // Template method defines the sequence for building a house
        public void BuildHouse()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildWindows();
            Console.WriteLine("House is built");
        }

        // Methods to be implemented by subclasses
        protected abstract void BuildFoundation(); // abstract
        protected abstract void BuildPillars(); // abstract
        protected abstract void BuildWalls(); // abstract
        protected abstract void BuildWindows(); // abstract
    }
}
