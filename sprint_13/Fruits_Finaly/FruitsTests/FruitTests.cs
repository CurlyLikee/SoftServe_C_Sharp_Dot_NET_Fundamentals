using Fruits_Finaly;

namespace FruitsTests
{
    [TestClass]
    public class FruitTests
    {
        [TestMethod]
        public void Constructor_DefaultValues_AssignsNoNameAndNoColor()
        {
            // Arrange & Act
            Fruit fruit = new Fruit();

            // Assert
            Assert.AreEqual("No name", fruit.Name);
            Assert.AreEqual("No color", fruit.Color);
        }

        [TestMethod]
        public void Constructor_ValidParameters_AssignsCorrectValues()
        {
            // Arrange & Act
            Fruit fruit = new Fruit("Apple", "Red");

            // Assert
            Assert.AreEqual("Apple", fruit.Name);
            Assert.AreEqual("Red", fruit.Color);
        }

        [TestMethod]
        public void Output_ReturnsCorrectString()
        {
            // Arrange
            Fruit fruit = new Fruit("Banana", "Yellow");

            // Act
            string result = fruit.Output();

            // Assert
            Assert.AreEqual("Your fruit Banana  have Yellow color.", result);
        }

        [TestMethod]
        public void ToString_ReturnsNameOrBaseToString()
        {
            // Arrange
            Fruit fruitWithName = new Fruit("Mango", "Green");
            Fruit fruitWithoutName = new Fruit { Name = "No name" }; // За замовчуванням
            Fruit fruitWithNullName = new Fruit { Name = null };

            // Act
            string resultWithName = fruitWithName.ToString();
            string resultWithoutName = fruitWithoutName.ToString();
            string resultWithNullName = fruitWithNullName.ToString();

            // Assert
            Assert.AreEqual("Mango", resultWithName, "ToString повинен повернути ім'я фрукта, якщо воно задане.");
            Assert.AreEqual("No name", resultWithoutName, "ToString повинен повернути ім'я за замовчуванням.");
            Assert.AreEqual(fruitWithNullName.GetType().ToString(), resultWithNullName, "ToString повинен повернути base.ToString() для null-імені.");
        }

        [TestMethod]
        public void Input_ValidData_ReturnsCorrectFruit()
        {
            // Arrange
            string input = "Apple\nRed\n";
            using (var inputReader = new StringReader(input))
            using (var outputWriter = new StringWriter())
            {
                Console.SetIn(inputReader);
                Console.SetOut(outputWriter);

                // Act
                Fruit result = Fruit.Input();

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual("Apple", result.Name);
                Assert.AreEqual("Red", result.Color);
            }
        }

        [TestMethod]
        public void Input_EmptyNameAndColor_ReturnsFruitWithEmptyFields()
        {
            // Arrange
            string input = "\n\n";
            using (var inputReader = new StringReader(input))
            using (var outputWriter = new StringWriter())
            {
                Console.SetIn(inputReader);
                Console.SetOut(outputWriter);

                // Act
                Fruit result = Fruit.Input();

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(string.Empty, result.Name);
                Assert.AreEqual(string.Empty, result.Color);
            }
        }
    }
}
