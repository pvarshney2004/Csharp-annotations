using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.MaxLengthAttributeDemo
{
    public class MaxMain
    {
        public static void Execute()
        {
            try
            {
                User user1 = new User("Prashant");   // correct
                User user2 = new User("VeryLongUsername"); // Exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}