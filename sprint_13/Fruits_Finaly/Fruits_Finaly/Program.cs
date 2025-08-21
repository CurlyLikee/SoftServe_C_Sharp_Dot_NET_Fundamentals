namespace Fruits_Finaly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FruitManager manager = new FruitManager();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("What type of fruit you want to add?");
                Console.Write("Type - f if you want to add fruit, or c - for cytrus: ");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "f":
                        manager.AddFruit(Fruit.Input());
                        break;
                    case "c":
                        manager.AddFruit(Cytrus.Input());
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        i--; // Повтор спроби
                        break;
                }
            }

            Console.WriteLine("\n********** Fruits List **********");
            manager.DisplayFruits();

            Console.WriteLine("\n********** Yellow Fruits **********");
            manager.DisplayFruits(manager.GetFruitsByColor("yellow"));

            Console.WriteLine("\n********** After Sorting **********");
            manager.SortFruits();
            manager.DisplayFruits();

            manager.SaveFruitsToFiles();

            string xmlPath = "fruits.xml";
            FruitSerializer.SerializeToXML(manager.Fruits, xmlPath);
            Console.WriteLine("\n********** XML Deserialization Result **********");
            var fruitsFromXML = FruitSerializer.DeserializeFromXML(xmlPath);
            manager.DisplayFruits(fruitsFromXML);

            string jsonPath = "fruits.json";
            FruitSerializer.SerializeToJSON(manager.Fruits, jsonPath);
            Console.WriteLine("\n********** JSON Deserialization Result **********");
            var fruitsFromJSON = FruitSerializer.DeserializeFromJSON(jsonPath);
            manager.DisplayFruits(fruitsFromJSON);
        }
    }
}