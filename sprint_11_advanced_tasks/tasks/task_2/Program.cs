/* task_2
Please, create a method that takes a sentence with words separated by space.
The method should return the longest word that starts with an 'a' letter.
If there are no words that start with an 'a' in the sentence, the method should return an empty string
 */

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace task_2
{
    public class Program
    {
        public static string SearchLongestWordStartingWithA(string sentence)
        {
            var longest = sentence
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(word => word.Length)
                .FirstOrDefault();

            return longest ?? string.Empty;
        }
    }
}
