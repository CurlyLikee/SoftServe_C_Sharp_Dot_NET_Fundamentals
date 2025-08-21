/* task_1
Please, implement the GetListOfPrimeNumbers method that returns a list of prime numbers from the argument list.
All numbers in the result list should be unique, duplicates should not be added to the result list.
The number is prime if its only dividers are 1 and this number itself.
 */

using System;


namespace task_1
{
    public class Program
    {
        public static List<int> GetListOfPrimeNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();


            foreach (int number in numbers)
            {
                if (number <= 1)
                {
                    continue;
                }

                bool isPrime = true;

                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime && !result.Contains(number))
                {
                    result.Add(number);
                }

            }
            return result;
        }
    }
}