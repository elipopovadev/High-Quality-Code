using Proxy.RealObject;
using Proxy.Subject;
using System;

namespace Proxy.ProxyObject
{
    public class ProxySharedFolder : ISharedFolder
    {
        private ISharedFolder folder; // Real Object - shared folder
        private Employee employee; // employee can access this shared folder

        public ProxySharedFolder(Employee emp)
        {
            employee = emp;
        }

        public void PerformReadWriteOperations()
        {
            if (employee.Role.ToUpper().ToString() == "CEO" || employee.Role.ToUpper().ToString() == "MANAGER")
            {
                folder = new SharedFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformReadWriteOperations method'");
                folder.PerformReadWriteOperations();
            }

            else
            {
                Console.WriteLine("Shared Folder proxy says 'You don't have permission to access this folder'");
            }
        }
    }
}
