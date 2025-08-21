using System;
using System.Linq;
using System.Text.Json;

namespace task_1
{
    public class Program
    {
        public static void Main()
        {
            List<Fruit> fruits = new List<Fruit>
            {
                new Fruit("Apple", "Red"),
                new Fruit("Banana", "Yellow"),
                new Fruit("Grapes", "Green"),
                new Fruit("Mango", "Yellow"),
                new Fruit("Blueberry", "Blue"),

                new Citrus("Orange", 53.2),
                new Citrus("Lemon", 77.0),
                new Fruit("Pineapple", "Brown"),
                new Citrus("Grapefruit", 38.0),
                new Fruit("Clementine", "Orange")
            };


            Console.WriteLine("Yellow fruits:");
            foreach (var fruit in fruits)
            {
                if (fruit.Color == "Yellow")
                {
                    fruit.Print();
                }
            }

            var sortedFruits = fruits.OrderBy(f => f.Name).ToList();

            using (var writer = new StreamWriter("sorted_fruits.txt"))
            {
                foreach (var fruit in sortedFruits)
                {
                    fruit.Print("sorted_fruits.txt", true);
                }
            }

            string jsonString = JsonSerializer.Serialize(fruits);
            File.WriteAllText("fruits.json", jsonString);

            string jsonStringFromFile = File.ReadAllText("fruits.json");
            List<Fruit> fruitsFromFile = JsonSerializer.Deserialize<List<Fruit>>(jsonStringFromFile);
        }
    }
}
