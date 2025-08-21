using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Person
    {
        string name;
        DateTime birthYear;

        public string Name
        {
            get { return name; }
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public Person()
        {
            name = "Unknown";
            birthYear = DateTime.Now;
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthYear.Year;

            if (birthYear.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
        public void ChangeName(string name)
        {
            this.name = name;
        }

        public void Output()
        {
            Console.WriteLine($"{name} is {Age()} years old.");
        }


        public static Person Input(int i)
        {
            string name = Console.ReadLine();
            int year;
            int.TryParse(Console.ReadLine(), out year);
            DateTime birthYear = new DateTime(year, 1, 1);
            Person person = new Person(name, birthYear);
            return person;
        }

        public override string ToString()
        {
            return $"Name: {name}, Year of Birth: {birthYear.Year}";
        }


        public static bool operator ==(Person first, Person second)
        {
            return (first.name == second.name);
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Person other = (Person)obj;
            return this.name == other.name;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
}
