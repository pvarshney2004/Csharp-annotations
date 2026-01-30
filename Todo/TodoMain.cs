using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Annotations.Todo
{
    public class TodoMain
    {
        // Retrieve and print all pending tasks using Reflection.
        public static void Execute()
        {
            Type type = typeof(Tasks);
            MethodInfo[] methods = type.GetMethods(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            Console.WriteLine("Pending Tasks:");
            foreach (MethodInfo method in methods)
            {
                TodoAttribute[] todos = (TodoAttribute[])method.GetCustomAttributes(typeof(TodoAttribute), false);
                foreach (TodoAttribute todo in todos)
                {
                    Console.WriteLine(
                        $"Method: {method.Name} | Task: {todo.Task} | Assigned To: {todo.AssignedTo} | Priority: {todo.Priority}");
                }
            }
        }
    }
}