/* task_2
Create static class FileAnalyzer with static methods.

Each method should:

   Read all lines of text from the file "client.test.js". 

And the methods should solve the next tasks:

   1) GetSumbolsCountInEachLine - Count and write the number of symbols in every line.

   2) GetLongestLine - Find the longest and the shortest line.

   3) GetShortestLine - Find the longest and the shortest line.

   4) GetLinesWithLet - Find and return only lines, that contain the word "let"
 */

using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public static class FileAnalyzer
{
    public static IEnumerable<int> GetSumbolsCountInEachLine()
    {
        var lines = File.ReadAllLines("client.test.js");
        foreach (var line in lines)
        {
            yield return line.Length;
        }
    }


    public static string GetLongestLine()
    {
        var lines = File.ReadAllLines("client.test.js");
        var longest = lines.OrderByDescending(x => x.Length).First();
        return longest;
    }

    public static string GetShortestLine()
    {
        var lines = File.ReadAllLines("client.test.js");
        var shortest = lines.OrderBy(x => x.Length).First();
        return shortest;
    }

    public static string[] GetLinesWithLet()
    {
        var lines = File.ReadAllLines("client.test.js");
        var result = new List<string>();


        foreach (var line in lines)
        {
            if (Regex.IsMatch(line, "let", RegexOptions.IgnoreCase))
            {
                result.Add(line);
            }
        }
        return result.ToArray();
    }
}