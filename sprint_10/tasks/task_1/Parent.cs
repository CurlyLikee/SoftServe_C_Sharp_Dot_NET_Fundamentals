using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Parent
    {
        public void OnMarkChange(int someMark)
        {
            Console.WriteLine("Parent notified: Mark = " + someMark);
        }
    }
}
