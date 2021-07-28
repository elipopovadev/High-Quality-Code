using System;
using Visitor.ObjectStructure;
using Visitor.Visitors;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            var visitor1 = new Doctor("James");
            school.PerformOperation(visitor1);

            Console.WriteLine();
            var visitor2 = new Salesman("John");
            school.PerformOperation(visitor2);
        }
    }
}
