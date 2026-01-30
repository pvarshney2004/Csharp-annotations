using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.MarkImportant
{
    // Apply ImportantMethod Attribute to at least two methods.
    public class ApplyAttribute
    {
        [ImportantMethod]
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }

        [ImportantMethod("LOW")]
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
}