using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Annotations.MaxLengthAttributeDemo
{
    public class User
    {
        [MaxLength(10)]
        public string Username;
        // Validate length in the constructor.
        public User(string username)
        {
            FieldInfo? field = typeof(User).GetField("Username");
            MaxLengthAttribute? attr = field?.GetCustomAttribute<MaxLengthAttribute>();
            if (attr != null && username.Length > attr.Length)
            {
                // Throw ArgumentException if the limit is exceeded.
                throw new ArgumentException($"Username length exceeds maximum of {attr.Length}");
            }
            Username = username;
        }
    }
}