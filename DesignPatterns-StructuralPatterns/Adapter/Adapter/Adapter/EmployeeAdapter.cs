using Adapter.Adaptee;
using System;
using System.Collections.Generic;

namespace Adapter.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem(); // ThirdPartyBillingSystem
        public void ProcessCompanySalary(string[,] employeesArray) // accept array from Client
        {
            string Id = null;
            string Name = null;
            string Designation = null;
            string Salary = null;

            List<Employee> listEmployee = new List<Employee>();
            for (int row = 0; row < employeesArray.GetLength(0); row++)
            {
                for (int col = 0; col < employeesArray.GetLength(1); col++)
                {
                    if (col == 0)
                    {
                        Id = employeesArray[row, col];
                    }
                    else if (col == 1)
                    {
                        Name = employeesArray[row, col];
                    }
                    else if (col == 2)
                    {
                        Designation = employeesArray[row, col];
                    }
                    else
                    {
                        Salary = employeesArray[row, col];
                    }
                }

                listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
            }

            Console.WriteLine("Adapter converted Array of Employee to List of Employee");
            Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
            thirdPartyBillingSystem.ProcessSalary(listEmployee);
        }
    }
}
