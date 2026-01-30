using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Annotations.RepeatableAttribute
{
    public class DemoRepeatable
    {
        public static void Execute()
        {
            Type type = typeof(App);
            MethodInfo? method = type.GetMethod("Run");
            BugReportAttribute[] bugReports = (BugReportAttribute[])method.GetCustomAttributes(
                    typeof(BugReportAttribute), false);
            Console.WriteLine("Bug Reports:");
            foreach (BugReportAttribute bug in bugReports)
            {
                Console.WriteLine($"- {bug.Description}");
            }
        }
    }
}