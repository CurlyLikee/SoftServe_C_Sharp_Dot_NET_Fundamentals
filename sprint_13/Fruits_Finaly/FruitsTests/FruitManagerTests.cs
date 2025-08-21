using Fruits_Finaly;

namespace FruitsTests
{
    [TestClass]
    public class FruitManagerTests
    {
        private FruitManager fruitManager;

        [TestInitialize]
        public void SetUp()
        {
            // Ініціалізація перед кожним тестом
            fruitManager = new FruitManager();
        }

        [TestMethod]
        public void AddFruit_AddsFruitToList()
        {
            // Arrange
            Fruit fruit = new Fruit("Apple", "Green");

            // Act
            fruitManager.AddFruit(fruit);

            // Assert
            Assert.AreEqual(1, fruitManager.Fruits.Count);
            Assert.AreEqual("Apple", fruitManager.Fruits[0].Name);
        }

        [TestMethod]
        public void GetFruitsByColor_ReturnsCorrectFruits()
        {
            // Arrange
            fruitManager.AddFruit(new Fruit("Apple", "Green"));
            fruitManager.AddFruit(new Fruit("Banana", "Yellow"));
            fruitManager.AddFruit(new Fruit("Lemon", "Yellow"));

            // Act
            var yellowFruits = fruitManager.GetFruitsByColor("yellow").ToList();

            // Assert
            Assert.AreEqual(2, yellowFruits.Count);
            Assert.IsTrue(yellowFruits.Any(f => f.Name == "Banana"));
            Assert.IsTrue(yellowFruits.Any(f => f.Name == "Lemon"));
        }

        [TestMethod]
        public void SortFruits_SortsFruitsByName()
        {
            // Arrange
            fruitManager.AddFruit(new Fruit("Peach", "Orange"));
            fruitManager.AddFruit(new Fruit("Apple", "Green"));
            fruitManager.AddFruit(new Fruit("Banana", "Yellow"));

            // Act
            fruitManager.SortFruits();

            // Assert
            Assert.AreEqual("Apple", fruitManager.Fruits[0].Name);
            Assert.AreEqual("Banana", fruitManager.Fruits[1].Name);
            Assert.AreEqual("Peach", fruitManager.Fruits[2].Name);
        }

        [TestMethod]
        public void SaveFruitsToFiles_SavesEachFruitToFile()
        {
            // Arrange
            var tempPath = Path.GetTempPath();
            var fruit1 = new Fruit("Apple", "Green") { path = Path.Combine(tempPath, "fruit1.txt") };
            var fruit2 = new Fruit("Banana", "Yellow") { path = Path.Combine(tempPath, "fruit2.txt") };

            fruitManager.AddFruit(fruit1);
            fruitManager.AddFruit(fruit2);

            // Act
            fruitManager.SaveFruitsToFiles();

            // Assert
            Assert.IsTrue(File.Exists(fruit1.path));
            Assert.IsTrue(File.Exists(fruit2.path));

            // Cleanup
            File.Delete(fruit1.path);
            File.Delete(fruit2.path);
        }

        [TestMethod]
        public void DisplayFruits_DisplaysAllFruits()
        {
            // Arrange
            fruitManager.AddFruit(new Fruit("Apple", "Green"));
            fruitManager.AddFruit(new Fruit("Banana", "Yellow"));

            using (var outputWriter = new StringWriter())
            {
                Console.SetOut(outputWriter);

                // Act
                fruitManager.DisplayFruits();

                // Assert
                string output = outputWriter.ToString().Trim();
                StringAssert.Contains(output, "Your fruit Apple  have Green color.");
                StringAssert.Contains(output, "Your fruit Banana  have Yellow color.");
            }
        }
        [TestMethod]
        public void DisplayFruits_DisplaysFilteredFruits()
        {
            // Arrange
            fruitManager.AddFruit(new Fruit("Apple", "Green"));
            fruitManager.AddFruit(new Fruit("Banana", "Yellow"));

            using (var outputWriter = new StringWriter())
            {
                Console.SetOut(outputWriter);

                // Act
                var greenFruits = fruitManager.GetFruitsByColor("Green");
                fruitManager.DisplayFruits(greenFruits);

                // Assert
                string output = outputWriter.ToString().Trim();
                StringAssert.Contains(output, "Your fruit Apple  have Green color.");
                Assert.IsFalse(output.Contains("Your fruit Banana  have Yellow color."), "Banana should not appear in the output.");
            }
        }


    }
}
