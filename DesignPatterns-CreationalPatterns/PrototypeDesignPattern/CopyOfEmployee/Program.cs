using ShallowCopyOfEmployee;
using System;

namespace CopyOfEmployee
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
            secondEmployee.EmpAddress.Adress = "UK"; // ref type

            Console.WriteLine(firstEmployee.Name); // Elena
            Console.WriteLine(secondEmployee.Name); // Mariqn

            Console.WriteLine(firstEmployee.EmpAddress.Adress); // also is UK
            Console.WriteLine(secondEmployee.EmpAddress.Adress); // UK
        }
    }
}
