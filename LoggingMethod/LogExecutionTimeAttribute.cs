using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.LoggingMethod
{
    //Define an attribute LogExecutionTime to measure method execution time
    [AttributeUsage(AttributeTargets.Method)]
    public class LogExecutionTimeAttribute : Attribute
    {

    }
}