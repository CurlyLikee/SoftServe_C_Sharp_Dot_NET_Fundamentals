using System;

namespace side_of_the_square
{
    internal class Evaluation
    {
        public static void StudentMain()
        {
            int a, area, perimeter;

            try
            {
                do
                {
                    a = Convert.ToInt32(Console.ReadLine());


                    if (a <= 0)
                    {
                        Console.WriteLine("Please, enter an integer value");
                    }

                } while (a <= 0);


                area = a * a;
                perimeter = a * 4;

                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");
            }

            catch (FormatException)
            {
                Console.WriteLine($"Please, enter an integer value");
            }

        }

    }

}