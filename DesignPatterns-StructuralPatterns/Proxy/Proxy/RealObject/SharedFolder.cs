using Proxy.Subject;
using System;
namespace Proxy.RealObject
{
    public class SharedFolder : ISharedFolder
    {
        public void PerformReadWriteOperations()
        {
            Console.WriteLine("Performing Read Write operation on the Shared Folder");
        }
    }
}
