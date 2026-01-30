using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations
{
    public class LegacyAPI
    {
        /*
        Use Obsolete Attribute to Mark an Old Method
Problem Statement: Create a class LegacyAPI with an old method OldFeature(), which
should not be used anymore. Instead, introduce a new method NewFeature().
Steps to Follow:
1. Define a class LegacyAPI.
2. Mark OldFeature() as [Obsolete].
3. Call both methods and observe the warning.
        */
        [Obsolete("Use NewFeature Instead")]
        public static void OldFeature()
        {
            Console.WriteLine("This is an old feature");
        }

        public static void NewFeature()
        {
            Console.WriteLine("This is a new feature");
        }
    }
}