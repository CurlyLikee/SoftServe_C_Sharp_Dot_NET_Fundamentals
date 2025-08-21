using System;

namespace circle_calculations
{
    public class CircleCalculations
    {
        public static void StudentMain()
        {
            double r, pi = 3.14, length, areaValue, volumeValue;

            try
            {
                r = Convert.ToDouble(Console.ReadLine());

                length = Math.Round(2 * pi * r, 2);
                areaValue = Math.Round(pi * r * r, 2);
                volumeValue = Math.Round(4.0 / 3 * pi * r * r * r, 2);

                Console.WriteLine($"length: {length}");
                Console.WriteLine($"area: {areaValue}");
                Console.WriteLine($"volume: {volumeValue}");
            }

            catch (FormatException)
            {
                Console.WriteLine("Please, enter a double value");
            }
        }
    }
}
