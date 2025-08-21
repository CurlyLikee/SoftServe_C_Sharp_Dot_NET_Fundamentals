using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class PersonManager
    {
        public static void ChangeName(Person[] persons)
        {
            foreach (var person in persons)
            {
                if (person.Age() < 16)
                {
                    person.ChangeName("Very Young");
                }
            }
        }

        public static void ComparePersons(Person[] persons)
        {
            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    string result = persons[i] == persons[j] ? "are equal" : "are not equal";
                    Console.WriteLine($"{persons[i]} and {persons[j]} {result}");
                }
            }
        }
    }
}
