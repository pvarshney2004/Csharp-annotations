using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.LoggingMethod
{
    // Apply LogExecutionTime to a method
    public class Work
    {
        [LogExecutionTime]
        public void FastTask()
        {
            Thread.Sleep(500);
        }

        [LogExecutionTime]
        public void SlowTask()
        {
            Thread.Sleep(1000);
        }
    }
}