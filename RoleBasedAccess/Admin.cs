using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.RoleBasedAccess
{
    public class Admin
    {
        public void ViewUsers()
        {
            Console.WriteLine("Viewing Users");
        }
        // [RoleAllowed("ADMIN")] should only allow ADMIN users to execute the method.
        [RoleAllowed("ADMIN")]
        public void DeleteUser()
        {
            Console.WriteLine("User deleted successfully.");
        }
    }
}