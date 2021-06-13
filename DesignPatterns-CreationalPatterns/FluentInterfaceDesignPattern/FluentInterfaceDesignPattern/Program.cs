namespace FluentInterfaceDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            FluentEmployee fluentEmployee = new FluentEmployee();
            fluentEmployee.NameOfTheEmployee("Ivan Ivanov")
            .Born("10/10/1992")
            .SetDepartment("IT")
            .SetAddress("Sofiq, Bulgaria");
        }
    }
}
