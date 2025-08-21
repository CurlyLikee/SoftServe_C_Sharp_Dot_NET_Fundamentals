/* task_2
Create a class MonthChecker. In the method Main() of this class write code for solving the next task:

Ask the user to enter the number of month ("Please, enter the month number"). 
Read value and output the count of days in this month. Print the number of days to the console. For example, if the evaluated number of days is 30, 
the output should be: "The number of days in this month is 30"
 */

using System;

namespace task_2
{
    public class MonthChecker
    {
        public static void Main()
        {
            int number;

            Console.Write("Please, enter the month number");
            number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    number = 31;
                    break;
                case 2:
                    number = 28;
                    break;
                case 3:
                    number = 31;
                    break;
                case 4:
                    number = 30;
                    break;
                case 5:
                    number = 31;
                    break;
                case 6:
                    number = 30;
                    break;
                case 7:
                    number = 31;
                    break;
                case 8:
                    number = 31;
                    break;
                case 9:
                    number = 30;
                    break;
                case 10:
                    number = 31;
                    break;
                case 11:
                    number = 30;
                    break;
                case 12:
                    number = 31;
                    break;
            }

            if (number == 30)
            {
                Console.WriteLine("\nThe number of days in this month is 30");
            }
            else if (number == 31)
            {
                Console.WriteLine("\nThe number of days in this month is 31");
            }
            else if (number == 28)
            {
                Console.WriteLine("\nThe number of days in this month is 28");
            }
            else
            {
                Console.WriteLine("\nInvalid month number");
            }
        }
    }
}
