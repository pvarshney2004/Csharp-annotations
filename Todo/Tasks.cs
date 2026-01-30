using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.Todo
{
    //Apply Todo attribute to multiple methods.
    public class Tasks
    {
        [Todo("Implement authentication", "Emma", "HIGH")]
        [Todo("Add input validation", "John")]
        public void Login()
        {
        }

        [Todo("Optimize database queries", "Sophia", "LOW")]
        public void DataModule()
        {
        }
    }
}