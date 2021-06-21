namespace Adapter
{
   public class Employee
    {
        public Employee(int id, string name, string designation, decimal salary)
        {
            this.ID = id;
            this.Name = name;
            this.Designation = designation;
            this.Salary = salary;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
    }
}
