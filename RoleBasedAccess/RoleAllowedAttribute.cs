using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.RoleBasedAccess
{
    // Define a class-level attribute RoleAllowed to restrict method access based on roles.

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class RoleAllowedAttribute : Attribute
    {
        public string Role { get; }
        public RoleAllowedAttribute(string role)
        {
            Role = role;
        }
    }
}