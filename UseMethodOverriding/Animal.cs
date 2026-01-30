using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.UseMethodOverriding
{
    public class Animal
    {
        // Create a parent class Animal with a method MakeSound(). 
        // Define a MakeSound() method in the Animal class.
        public virtual void MakeSound()
        {
            System.Console.WriteLine("Animal makes sound");
        }
    }
}