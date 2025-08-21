/* task_1
Create a class StringChecker. In the method Main() of this class write code for solving the next task:

Read some string str.
Calculate the counts of characters ‘a’, ’o’, ’i’, ’e’  in this text.
Print those counts in separate line each.
 */

using System;


namespace task_1
{
    public class StringChecker
    {
        public static void Main()
        {
            int countA = 0, countO = 0, countI = 0, countE = 0;
            string s;
            s = Console.ReadLine();

            for (int i = 0; i<s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    countA++;
                }
                else if (s[i] == 'o')
                {
                    countO++;
                }
                else if (s[i] == 'i')
                {
                    countI++;
                }
                else if (s[i] == 'e')
                {
                    countE++;
                }
            }
            Console.WriteLine(countA);
            Console.WriteLine(countO);
            Console.WriteLine(countI);
            Console.WriteLine(countE);

        }
    }
}
