/* task_2
Please, implement the SumOfTwoMaxValues method.

The method takes an array of integers with a length greater than on equal to 2.
It should return a sum of two max elements of the array
 */


namespace task_2
{
    public class Program
    {
        public static int SumOfTwoMaxElements(int[] array)
        {
            int max1 = array[0], max2 = array[1], sum = 0;
            foreach (int numbers in array)
            {
                if (numbers > max1)
                {
                    max2 = max1;
                    max1 = numbers;
                }
                else if (numbers > max2)
                {
                    max2 = numbers;
                }
            }
            sum += max1 + max2;
            return sum;
        }
    }
}
