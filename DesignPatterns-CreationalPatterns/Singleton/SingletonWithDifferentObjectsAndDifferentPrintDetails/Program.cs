namespace SingletonWithDifferentObjectsAndDifferentPrintDetails
{
   public class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = new Singleton(); // first object with different print details
            fromEmployee.PrintDetails("Message from Employee");

            Singleton fromStudent = new Singleton(); // second object with different print details
            fromStudent.PrintDetails("Message from Student");
        }
    }
}
