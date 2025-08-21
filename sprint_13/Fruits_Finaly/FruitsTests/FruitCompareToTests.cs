using Fruits_Finaly;

namespace FruitsTests
{
    [TestClass]
    public class FruitCompareToTests
    {
        [TestMethod]
        public void CompareTo_DifferentNames_ReturnsCorrectOrder()
        {
            // Arrange
            var apple = new Fruit { Name = "Apple" };
            var banana = new Fruit { Name = "Banana" };

            // Act
            int result = apple.CompareTo(banana);

            // Assert
            Assert.IsTrue(result < 0, "Apple повинно бути менше н≥ж Banana.");
        }

        [TestMethod]
        public void CompareTo_SameNames_ReturnsZero()
        {
            // Arrange
            var fruit1 = new Fruit { Name = "Cherry" };
            var fruit2 = new Fruit { Name = "Cherry" };

            // Act
            int result = fruit1.CompareTo(fruit2);

            // Assert
            Assert.AreEqual(0, result, "ќб'Їкти з однаковими ≥менами повинн≥ повертати 0.");
        }

        [TestMethod]
        public void CompareTo_OneNameIsNull_ReturnsCorrectOrder()
        {
            // Arrange
            var fruitWithName = new Fruit { Name = "Apple" };
            var fruitWithoutName = new Fruit { Name = null };

            // Act
            int result = fruitWithName.CompareTo(fruitWithoutName);
            int reverseResult = fruitWithoutName.CompareTo(fruitWithName);

            // Assert
            Assert.IsTrue(result > 0, "ќб'Їкт з ≥менем повинен бути б≥льше об'Їкта без ≥мен≥.");
            Assert.IsTrue(reverseResult < 0, "ќб'Їкт без ≥мен≥ повинен бути менше об'Їкта з ≥менем.");
        }

        [TestMethod]
        public void CompareTo_BothNamesNull_ReturnsZero()
        {
            // Arrange
            var fruit1 = new Fruit { Name = null };
            var fruit2 = new Fruit { Name = null };

            // Act
            int result = fruit1.CompareTo(fruit2);

            // Assert
            Assert.AreEqual(0, result, "якщо обидва ≥мена null, пор≥вн€нн€ повинно повертати 0.");
        }
    }
}