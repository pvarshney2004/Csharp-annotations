using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.MarkImportant
{
    // Problem Statement: Define a custom attribute ImportantMethod that can be applied to methods to indicate their importance.
    // Define ImportantMethod with an optional Level parameter (default: "HIGH")
    [AttributeUsage(AttributeTargets.Method)]
    public class ImportantMethodAttribute : Attribute
    {
        public string? Level;
        public ImportantMethodAttribute(string level = "HIGH")
        {
            Level = level;
        }
    }
}