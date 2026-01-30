using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.CustomAttributes
{
    // Problem Statement: Create a custom attribute TaskInfo to mark tasks with priority and assigned person
    // Define an attribute TaskInfo with fields Priority and AssignedTo.
    [AttributeUsage(AttributeTargets.Method)]
    public class TaskInfoAttribute : Attribute
    {
        public int Priority { get; }
        public string? AssignedTo { get; set; }
        public TaskInfoAttribute(int priority, string assignedTo)
        {
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }
}