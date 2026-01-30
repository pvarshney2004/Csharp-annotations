using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Annotations.LoggingMethod
{
    public class WorkMain
    {
        // Use Stopwatch before and after execution, Print execution time.
        public static void Execute()
        {
            Work worker = new Work();
            Type type = typeof(Work);

            foreach (MethodInfo method in type.GetMethods(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                if (method.GetCustomAttribute<LogExecutionTimeAttribute>() != null)
                {
                    Stopwatch sw = Stopwatch.StartNew();
                    method.Invoke(worker, null);
                    sw.Stop();
                    Console.WriteLine($"{method.Name} executed in {sw.ElapsedMilliseconds} ms");
                }
            }
        }
    }
}