using ShallowCopyOfEmployee;
using System;

namespace DeepCopyOfEmployee
{
   public class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee("Elena", "IT");
            firstEmployee.EmpAddress = new Address("Bulgaria");

            Employee secondEmployee = firstEmployee.GetClone();
            secondEmployee.Name = "Mariqn";
            secondEmployee.Department = "Sale Department";
            secondEmployee.EmpAddress.Adress = "UK"; // a new copy of the referred object is created

            Console.WriteLine(firstEmployee.Name); // Elena
            Console.WriteLine(secondEmployee.Name); // Mariqn

            Console.WriteLine(firstEmployee.EmpAddress.Adress); // is still Bulgaria
            Console.WriteLine(secondEmployee.EmpAddress.Adress); // UK
        }
    }
}
