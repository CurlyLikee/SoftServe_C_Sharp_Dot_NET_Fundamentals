/* task_1
Create class WorkWithExceptions.
Create static method Div, which takes 2 integer parameters and calculates the dividing the first 
by the second, and prints result to the console.

Also create a static Main method in this class.  
In Main() read two int numbers and call this method.
Catch corresponding exceptions.
Possible outputs when an exception occurs:
"Please, enter an integer value" or
"Cannot divide by 0".
 */


using System;

namespace task_1
{
    public class WorkWithExceptions
    {
        public static void Div(int number1, int number2)
        {
            double result;
            if (number2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by 0");
            }
            else
            {
                try
                {
                    result = number1 / number2;
                    Console.WriteLine($"{result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by 0");
                }
            }
        }

        public static void Main()
        {

            try
            {
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());
                Div(number1, number2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, enter an integer value");
            }
        }
    }
}
