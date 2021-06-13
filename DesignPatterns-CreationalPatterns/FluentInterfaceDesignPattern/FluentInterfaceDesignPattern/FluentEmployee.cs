using System;

namespace FluentInterfaceDesignPattern
{
   public class FluentEmployee
    {
        private Employee employee = new Employee();

        public FluentEmployee NameOfTheEmployee(string FullName)
        {
            employee.FullName = FullName;
            return this;
        }

        public FluentEmployee Born(string DateOfBirth)
        {
            employee.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            return this;
        }

        public FluentEmployee SetDepartment(string Department)
        {
            employee.Department = Department;
            return this;
        }

        public FluentEmployee SetAddress(string address)
        {
            employee.Address = address;
            return this;
        }
    }
}
