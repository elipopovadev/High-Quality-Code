using Proxy.ProxyObject;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Anurag", "Anurag123", "Developer"); // Dev can't access this shared folder
            ProxySharedFolder proxy = new ProxySharedFolder(emp1);
            proxy.PerformReadWriteOperations();
            Console.WriteLine();
            Employee emp2 = new Employee("Elena", "Elena123", "Manager"); //  Manager and CEO can access this shared folder 
            ProxySharedFolder proxy2 = new ProxySharedFolder(emp2);
            proxy2.PerformReadWriteOperations();
        }
    }
}
