/* task_1
Create a class Checker. In the method Main() of this class write code for solving the next task:

Read 3 float numbers and check if they are all in the range [-5.5]. Print True or False to the console depending on the result of checking.
 */


using System;


namespace Checker
{
    public class Checker
    {
        public static void Main()
        {
            float x, y, z;



            x = Convert.ToSingle(Console.ReadLine());
            y = Convert.ToSingle(Console.ReadLine());
            z = Convert.ToSingle(Console.ReadLine());


            bool result = x >= -5.0 && x <= 5.0 &&
              y >= -5.0 && y <= 5.0 &&
              z >= -5.0 && z <= 5.0;

            Console.WriteLine(result);

        }
    }
}
