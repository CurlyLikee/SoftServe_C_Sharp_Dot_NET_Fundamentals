/* task_2
Create class Meeting with private field people of type Dictionary<uint, string>.

Add method Initialize to the Meeting class which adds to Dictionary 7 pairs (ID, Name) of some persons from the console. (For each person method should ask "Please, enter Id", then read an Id from the console, then ask "Please, enter name" and read name from the console).

Add method FindPerson to the Meeting class. The method should ask user to enter Id, then find and write the corresponding Name from the people field to the console.
If this ID can't be found - "not found" should be printed.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public class Meeting
    {
        private Dictionary<uint, string> people;
        int n = 0;

        public void Initialize()
        {
            people = new Dictionary<uint, string>();
            do
            {
                Console.Write("Please, enter Id\n");
                uint id = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Please, enter name\n");
                string name = Console.ReadLine();
                people.Add(id, name);
                n++;
            } while (n <= 6);
        }

        public void FindPerson()
        {
            Console.Write("Please, enter Id");
            uint id = Convert.ToUInt32(Console.ReadLine());

            string value = "";
            if (people.TryGetValue(id, out value))
            {
                Console.WriteLine($"{value}");
            }
            else
            {
               Console.WriteLine("not found");
            }
        }
    }
}
