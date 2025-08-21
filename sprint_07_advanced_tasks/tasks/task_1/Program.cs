/* task_1
Create a method for calculating an area of a rectangle int GetRectangleArea(int a, int b), which should throw 
an ArgumentException if at least one of its arguments is negative and throw OverflowException if area bigger than Int32.MaxValue.

Create TryGetRectangleArea method which takes two parameters and calls GetRectangleArea to evaluate an area of a rectangle. 
Catch exceptions that can be generated and print the exception message if caught.

TryGetRectangleArea shouldn't generate any exceptions. In case when ArgumentException or OverflowException 
is caught the method should return 0;
*/


using System;
using System.Data;

namespace task_1
{
    public class Operation
    {
        public static int GetRectangleArea(int a, int b)
        {

            if (a < 0 || b < 0)
            {
                throw new ArgumentException("Value does not fall within the expected range.");
            }
            long area = (long)a * b;
            if (area > Int32.MaxValue)
            {
                throw new System.OverflowException("Arithmetic operation resulted in an overflow.");
            }
            return (int)area;
        }

        public static int TryGetRectangleArea(int a, int b)
        {
            try
            {
                int c;
                c = GetRectangleArea(a, b);
                return c;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
