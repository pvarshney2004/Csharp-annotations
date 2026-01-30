using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.CustomAttributes
{
    // Apply TaskInfo attribute to a method in TaskManager class.
    public class TaskManager
    {
        [TaskInfo(1, "Prashant")]
        public void CompleteTask()
        {
            Console.WriteLine("Task completed");
        }
    }
}