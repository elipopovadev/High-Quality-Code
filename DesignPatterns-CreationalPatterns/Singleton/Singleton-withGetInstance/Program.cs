using System;

namespace Singleton_withGetInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("Message from employee");

            Singleton fromMentor = Singleton.GetInstance;
            fromMentor.PrintDetails("Message from mentor");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("Message from student");
        }
    }
}
