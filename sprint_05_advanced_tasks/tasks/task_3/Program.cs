/* task_3
Please, implement FindValueByConditionOrDefault method that returns the first value in a dictionary that satisfies a condition.
If there is no such value in the dictionary, the default value should be returned.
Keys of the dictionary should be int and values - any type

Arguments of the method:
the dictionary
condition
the default value

 */


using System;
using System.Collections.Generic;

namespace task_3
{
    internal class Program
    {
        public static T FindValueByConditionOrDefault<T>(Dictionary<int, T> dictionary, Func<T, bool> predicate, T defaultValue)
        {
            foreach (T values in dictionary.Values)
            {
                if (predicate(values))
                {
                    return values;
                }

            }
            return defaultValue;
        }
    }
}
