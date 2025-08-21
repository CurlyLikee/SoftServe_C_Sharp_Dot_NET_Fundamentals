using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Accountancy
    {
        public void PayingFellowship(int newMarks)
        {
            if(newMarks >= 72)
            {
                Console.WriteLine("Student will receive a scholarship.");
            }
            else
            {
                Console.WriteLine("Student will not receive a scholarship.");
            }

        }
    }
}
