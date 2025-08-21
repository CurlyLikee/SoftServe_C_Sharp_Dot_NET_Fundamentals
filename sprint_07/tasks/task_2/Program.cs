/* task_2
Create class WorkWithNumbers.
Write static method ReadNumber(int start, int end), which reads an integer number from the console and returns it, if it is in the range [start...end]. If this number is invalid or non-number text is read, the method should throw an ArgumentException exception. 
Using this method write method Main(), which has to enter 10 numbers:
  a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100.

If all entered values satisfy the requirements, the Main method should print the last number to the console. 

If an entered value is not an integer "Please, enter an integer value" should be printed. 

Otherwise "Wrong value" should be printed.
 */

using System;
namespace task_2
{
    public class WorkWithNumbers
    {
        public static int ReadNumber(int start, int end)
        {
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input <= start || input >= end)
                {
                    throw new ArgumentException("Wrong value");
                }

                return input;
            }
            catch (FormatException)
            {
                throw new ArgumentException("Please, enter an integer value");
            }
        }


        public static void Main()
        {
            int previous = 1;

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int number = ReadNumber(previous, 100);
                    previous = number;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
            Console.WriteLine(previous);
        }
    }
}
