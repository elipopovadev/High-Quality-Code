namespace ShallowCopyOfEmployee
{
    public class Employee
    {
        public Employee(string name, string department)
        {
            this.Name = name;
            this.Department = department;
        }

        public string Name { get; set; } // value type
        public string Department { get; set; } // value type
        public Address EmpAddress { get; set; } // ref type 

        public Employee GetClone()
        {
            Employee employee = (Employee)this.MemberwiseClone();
            employee.EmpAddress = EmpAddress.GetClone(); // a new copy of the referred object is created
            return employee;
        }
    }
}
