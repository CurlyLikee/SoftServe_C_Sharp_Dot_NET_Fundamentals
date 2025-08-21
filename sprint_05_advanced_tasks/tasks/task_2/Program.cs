/* task_2
Please, implement CreateCommonList method.
It takes Queue of strings as a first parameter and Stack of strings as a second. 
The method should return a List of strings that consists of elements from both collections
that do not belong to both collections simultaneously:
 */

using System;
using System.Collections.Generic;

namespace task_2
{
    public class Program
    {
        public static List<string> CreateCommonList (Queue<string> queue, Stack<string> stack)
        {
            List<string> result = new List<string>();

            foreach (string item in stack)
            {
                if (!queue.Contains(item))
                {
                    result.Add(item);
                }
            }


            foreach (string item in queue)
            {
                if (!stack.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
