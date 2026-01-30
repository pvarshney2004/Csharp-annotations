using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Annotations.CustomAttributes
{
    public class RetrieveAttribute
    {
        // Retrieve the attribute details using Reflection.
        public static void Execute()
        {
            Type type = typeof(TaskManager);
            MethodInfo? method = type.GetMethod("CompleteTask");
            TaskInfoAttribute? taskInfoAttribute = method?.GetCustomAttribute<TaskInfoAttribute>();
            if (taskInfoAttribute != null)
            {
                Console.WriteLine("Task Information:");
                Console.WriteLine($"Priority: {taskInfoAttribute.Priority}");
                Console.WriteLine($"Assigned To: {taskInfoAttribute.AssignedTo}");
            }

        }
    }
}