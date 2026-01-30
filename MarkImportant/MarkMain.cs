using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Annotations.MarkImportant
{
    public class MarkMain
    {
        // Retrieve and print annotated methods using Reflection
        public static void Execute()
        {
            Type type = typeof(ApplyAttribute);
            Console.WriteLine("Important Methods:");
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (MethodInfo method in methods)
            {
                ImportantMethodAttribute? attr = method.GetCustomAttribute<ImportantMethodAttribute>();
                if (attr != null)
                {
                    Console.WriteLine($"- {method.Name} | Level: {attr.Level}");
                }
            }
        }
    }
}