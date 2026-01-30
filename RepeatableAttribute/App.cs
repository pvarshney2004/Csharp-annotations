using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.RepeatableAttribute
{
    public class App
    {
        // Apply it twice on a method.
        [BugReport("Performance issue")]
        [BugReport("Null Refrence Exception")]
        public void Run()
        {
            System.Console.WriteLine("App is running");
        }
    }
}