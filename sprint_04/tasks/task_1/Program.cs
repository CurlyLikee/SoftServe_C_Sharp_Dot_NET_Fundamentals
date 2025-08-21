/*
Define class Person. Class Person should contain:

a) two private fields: name and birthYear (the birthday year, as a type for this field you may use DataTime type);

b) two properties for access to these fields (you may use only get);

c) default constructor (which would assign name = "Unknown" and  birthYear = DateTime.Now) and constructor with 2 parameters (name and birthYear);

 d) methods: 

Age() - to calculate the age of a person;
Input() - to enter data about a person from the console;
ChangeName() - to change the name of person;
ToString();
Output() - to provide the output of information about the person (call ToString());
operator== (equal by name).

In the class BehaviorCheck define method Main() within which:
Create 6 objects of Person type and input (with Input() function) the information about them.
Calculate and provide the output into the console with the name and age of each person.
Change the name of people, whose age is less than 16, to "Very Young".
Output information about all people on the console.
Find and output information about people with the same names (use ==). In case there are no such people, provide output of the word "absent"
 */







using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace task_1
{
    public class BehaviorCheck
    {
        public static void Main()
        {
            Person[] people = new Person[6];

            for (int i = 0; i < 6; i++)
            {
                people[i] = Person.Input(i);
            }


            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} is {person.Age()} years old.");
            }


            PersonManager.ChangeName(people);

            Console.WriteLine("\nInformation about all persons:");
            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }


            bool found = false;
            Console.WriteLine("\nPersons with the same names:");
            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"Name: {people[i].Name}, Year of Birth: {people[i].BirthYear.Year}");
                        Console.WriteLine($"Name: {people[j].Name}, Year of Birth: {people[j].BirthYear.Year}");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("\nabsent");
            }
        }
    }
}