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
        public string Department{ get; set; } // value type
        public Address EmpAddress { get; set; } // ref type and we can copy only the ref, not the referred object itself

        public Employee GetClone()
        {
            return (Employee) this.MemberwiseClone();
        }
    }
}
