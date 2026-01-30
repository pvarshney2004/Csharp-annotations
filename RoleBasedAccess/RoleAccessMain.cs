using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Annotations.RoleBasedAccess
{
    public class RoleAccessMain
    {
        // Simulate user roles and validate access before invoking the method. If a non-admin tries to access it, print Access Denied!
        public static void Execute()
        {
            // string currentRole = "ADMIN";
            string currentRole = "USER";
            Admin admin = new Admin();
            Type type = typeof(Admin);
            MethodInfo? method = type.GetMethod("DeleteUser");
            RoleAllowedAttribute? roleAttribute = method?.GetCustomAttribute<RoleAllowedAttribute>();
            if (roleAttribute != null && roleAttribute.Role != currentRole)
            {
                Console.WriteLine("Access Denied!");
                return;
            }
            method?.Invoke(admin, null);
        }
    }
}