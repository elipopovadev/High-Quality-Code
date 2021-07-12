using System;

namespace CompositeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Leaf kitchen = new Leaf("kitchenFirstFloor", 20);
            Leaf diningRoom = new Leaf("Dining Room", 30);
            Leaf bathroomFirstFloor = new Leaf("Bathroom", 5);
            Composite firstFloor = new Composite("FirstFloor");
            firstFloor.AddComponent(kitchen);
            firstFloor.AddComponent(diningRoom);
            firstFloor.AddComponent(bathroomFirstFloor);
            Console.WriteLine("FirstFloor Area:");
            firstFloor.DisplayArea();
            Console.WriteLine();

            Leaf firstBedroom = new Leaf("George's bedroom", 15);
            Leaf secondBedroom = new Leaf("Anna's bedroom", 15);
            Leaf bathroomSecondFloor = new Leaf("BathroomSecondFloor", 5);
            Composite secondFloor = new Composite("SecondFloor");
            secondFloor.AddComponent(firstBedroom);
            secondFloor.AddComponent(secondBedroom);
            secondFloor.AddComponent(bathroomSecondFloor);
            Console.WriteLine("SecondFloor Area:");
            secondFloor.DisplayArea();           
        }
    }
}
