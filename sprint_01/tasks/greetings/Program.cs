using System;

namespace greetings
{
    internal class Evaluation
    {
        public static void StudentMain()
        {
            int age;
            string name;

            Console.WriteLine("What is your name? ");
            name = Console.ReadLine();

            Console.WriteLine($"How old are you, {name}?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Hello {name}, you are {age} years old :)");

        }
    }
}
