using System;
using System.Collections.Generic;

namespace Memento.Caretaker
{
   public class Caretaker // STOREROOM
    {
        private List<Memento.Memento> ledTVList = new List<Memento.Memento>();
        public void AddMemento(Memento.Memento m)
        {
            ledTVList.Add(m);
            Console.WriteLine("LED TV's snapshots Maintained by CareTaker :" + m.GetDetails());
        }

        public Memento.Memento GetMemento(int index)
        {
            return ledTVList[index];
        }
    }
}
