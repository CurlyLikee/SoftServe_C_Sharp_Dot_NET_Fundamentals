namespace Fruits_Finaly
{
    public class FruitManager
    {
        public List<Fruit> Fruits = new List<Fruit>();

        public void AddFruit(Fruit fruit)
        {
            Fruits.Add(fruit);
        }

        public IEnumerable<Fruit> GetFruitsByColor(string color)
        {
            return Fruits.Where(fruit => fruit.Color.Equals(color, StringComparison.OrdinalIgnoreCase));
        }

        public void SortFruits()
        {
            Fruits.Sort();
        }

        public void SaveFruitsToFiles()
        {
            foreach (var fruit in Fruits)
            {
                fruit.OutputFile();
            }
        }

        public void DisplayFruits(IEnumerable<Fruit> fruitsToDisplay = null)
        {
            var fruits = fruitsToDisplay ?? Fruits; // Якщо не передано параметр, використовуємо Fruits
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit.Output());
            }
        }
    }

}