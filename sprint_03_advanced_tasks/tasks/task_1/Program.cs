/* task_1
Please, implement the method LeastCommonMultiple.

The method should take two unsigned integers as a parameters and return the least possible unsigned integer value that can be divided 
by each of arguments without remainder. 
 */

// Euclid's algorithm

using System;

namespace task_1
{
    public class Program
    {

        public static uint GreatestCommonDivisor(uint a, uint b)
        {
            uint value3;

            while (b != 0)
            {
                value3 = b;
                b = a % b;
                a = value3;
            }
            return a;
        }


        public static uint LeastCommonMultiple(uint value1, uint value2)
        {
            uint a = value1;
            uint b = value2;

            uint gcd = GreatestCommonDivisor(value1, value2);
            return (a * b) / gcd;

        }
    }
}
