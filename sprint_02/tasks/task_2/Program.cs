/* task_2
Create a class Checker. In the method Main() of this class write code for solving the next task:

Read 3 integer numbers and output max and min of them.

For example, if the input is

1
2
3
the output should be:

max: 3
min: 1

 */


using System;

namespace task_2
{
    public class Checker
    {
        public static void Main()
        {
            int x, y, z;
            int max, min;


            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            max = Math.Max(x, Math.Max(y, z));
            min = Math.Min(x, Math.Min(y, z));

            Console.WriteLine($"max: {max}");
            Console.WriteLine($"min: {min}");
        }
    }
}
