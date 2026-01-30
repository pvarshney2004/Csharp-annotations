using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.UseMethodOverriding
{
    public class Dog : Animal
    {
        //create a Dog class that overrides this method using override.
        public override void MakeSound()
        {
            System.Console.WriteLine("Dog barks");
        }
    }
}