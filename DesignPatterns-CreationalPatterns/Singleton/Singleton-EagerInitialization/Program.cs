using System;
using System.Threading.Tasks;

namespace Singleton_EagerInitialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(()=> PrintInformationAboutEmployee(),() => PrintInformationAboutStudent());           
        }

        private static void PrintInformationAboutStudent()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("Message from student");
        }

        private static void PrintInformationAboutEmployee()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("Message from employee");
        }
    }
}
