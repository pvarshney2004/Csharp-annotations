using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.RepeatableAttribute
{
    // Define an attribute BugReport that can be applied multiple times on a method.
    // Define BugReport with a Description field. Use (AllowMultiple = true) to allow multiple bug reports
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class BugReportAttribute : Attribute
    {
        public string? Description;
        public BugReportAttribute(string desc)
        {
            Description = desc;
        }
    }
}