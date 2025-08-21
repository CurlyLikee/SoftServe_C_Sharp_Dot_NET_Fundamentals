/* task_3
Create a class Calc. In the method Main() of this class write code for solving the next task:

Enter 10 integer numbers. (Ask the user to enter each of them with a phrase: "Please, enter an integer number")
Calculate the sum of the first 5 elements if they are positive
or the product of the last 5 elements in the other case.
Output the result with the phrase "The sum of the first 5 is " or "The product of the last 5 is ".
For example, "The sum of the first 5 is 13"
 */


using System;

namespace task_3
{
    public class Calc
    {
        public static void Main()
        {
            int[] numbers = new int[10];

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Please, enter an integer number");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                bool allFirstFiveArePositive = true;
                for (int i = 0; i < 5; i++)
                {
                    if (numbers[i] <= 0)
                    {
                        allFirstFiveArePositive = false;
                        break;
                    }
                }

                if (allFirstFiveArePositive)
                {
                    int sum = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine($"The sum of the first 5 is {sum}");
                }
                else
                {
                    long product = 1;
                    for (int i = 5; i < 10; i++)
                    {
                        product *= numbers[i];
                    }
                    Console.WriteLine($"The product of the last 5 is {product}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, enter an integer value");
            }
        }
    }
}
