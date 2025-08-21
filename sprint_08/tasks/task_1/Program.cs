/* task_1
Prepare the file "phones.txt" with records as follows:
John Doe +380123456789
Jane Smith +380987654321
Alice Johnson +380234567890 
Bob Brown +380345678901 
Charlie Black +380456789012 
Diana White +380567890123
Evan Green +380678901234 
Fiona Grey +380789012345
George Blue +380890123456

Prepare the file "names.txt" with records as follows:
John Doe
Jannet Smith
Alice Johnson
Bobby Brown

Within FilesBehavior class define Main() method.

In Main() method declare Dictionary PhoneBook for keeping pairs PersonName-PhoneNumber.
From the file "phones.txt" read 9 pairs into PhoneBook. Write only PhoneNumbers into the 
file "onlyPhones.txt".

From the file "names.txt" read the names of people, find and print the phone number by 
the given name if it can be found in the PhoneBook.

Change all phone numbers, which are in format 80######### into new format +380#########. 
The result should be written into the file «newPhones.txt». 
*/

using System;
using System.Collections.Generic;
using System.IO;


namespace task_1
{
    public class FilesBehavior
    {
        public static void Main()
        {
            var phoneBook = new Dictionary<string, string>();

            foreach (var line in File.ReadAllLines("phones.txt"))
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                var text = line.Trim();
                int dash = text.IndexOf('-');
                string namePart;
                string phonePart;


                if (dash >= 0)
                {
                    namePart = text.Substring(0, dash).Trim();
                    phonePart = text.Substring(dash + 1).Trim();
                }
                else
                {
                    int lastSpace = text.LastIndexOf(' ');
                    if (lastSpace < 0) continue;

                    namePart = text.Substring(0, lastSpace).Trim();
                    phonePart = text.Substring(lastSpace + 1).Trim();
                }

                phoneBook[namePart] = phonePart;
            }

            using (StreamWriter writer = new StreamWriter("onlyPhones.txt"))
            {
                foreach (var phone in phoneBook.Values)
                {
                    writer.WriteLine(phone);
                }
            }


            foreach (var nameLine in File.ReadLines("names.txt"))
            {
                var queryName = nameLine.Trim();

                if (phoneBook.TryGetValue(queryName, out var phone))
                {
                    Console.WriteLine($"The phone number of {queryName} is: {phone}");
                }
                else
                {
                    Console.WriteLine($"Name {queryName} was not found in phone book.");
                }
            }


            using (StreamWriter phone_writer = new StreamWriter("newPhones.txt"))
            {
                foreach (var kv in phoneBook)
                {
                    var name = kv.Key;
                    var phone = kv.Value;
                    var p = phone.Trim();

                    if (p.StartsWith("80"))
                    {
                        p = "+380" + p.Substring(2);
                    }

                    phone_writer.WriteLine($"{name} - {p}");
                }

            }
        }
    }
}
