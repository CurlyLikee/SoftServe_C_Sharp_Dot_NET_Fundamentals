using Fruits_Finaly;

namespace FruitsTests
{
    [TestClass]
    public class FruitSerializerTests
    {
        private string xmlFilePath;
        private string jsonFilePath;

        [TestInitialize]
        public void SetUp()
        {
            xmlFilePath = Path.GetTempFileName(); // Тимчасовий файл для XML
            jsonFilePath = Path.GetTempFileName(); // Тимчасовий файл для JSON
        }

        [TestCleanup]
        public void TearDown()
        {
            // Видаляємо файли після тестів
            if (File.Exists(xmlFilePath)) File.Delete(xmlFilePath);
            if (File.Exists(jsonFilePath)) File.Delete(jsonFilePath);
        }

        [TestMethod]
        public void SerializeToXML_SerializesCorrectly()
        {
            // Arrange
            var fruits = new List<Fruit>
            {
                new Fruit("Apple", "Green"),
                new Fruit("Banana", "Yellow")
            };

            // Act
            FruitSerializer.SerializeToXML(fruits, xmlFilePath);

            // Assert
            Assert.IsTrue(File.Exists(xmlFilePath), "XML файл має бути створений.");
            string content = File.ReadAllText(xmlFilePath);
            StringAssert.Contains(content, "<Fruit>");
            StringAssert.Contains(content, "<Name>Apple</Name>");
            StringAssert.Contains(content, "<Color>Green</Color>");
        }

        [TestMethod]
        public void DeserializeFromXML_DeserializesCorrectly()
        {
            // Arrange
            var fruits = new List<Fruit>
            {
                new Fruit("Apple", "Green"),
                new Fruit("Banana", "Yellow")
            };
            FruitSerializer.SerializeToXML(fruits, xmlFilePath);

            // Act
            var deserializedFruits = FruitSerializer.DeserializeFromXML(xmlFilePath);

            // Assert
            Assert.AreEqual(2, deserializedFruits.Count, "Десеріалізація повинна повернути два фрукти.");
            Assert.AreEqual("Apple", deserializedFruits[0].Name);
            Assert.AreEqual("Green", deserializedFruits[0].Color);
        }

        [TestMethod]
        public void SerializeToJSON_SerializesCorrectly()
        {
            // Arrange
            var fruits = new List<Fruit>
            {
                new Fruit("Apple", "Green"),
                new Fruit("Banana", "Yellow")
            };

            // Act
            FruitSerializer.SerializeToJSON(fruits, jsonFilePath);

            // Assert
            Assert.IsTrue(File.Exists(jsonFilePath), "JSON файл має бути створений.");
            string content = File.ReadAllText(jsonFilePath);
            StringAssert.Contains(content, "\"Name\":\"Apple\"");
            StringAssert.Contains(content, "\"Color\":\"Green\"");
        }

        [TestMethod]
        public void DeserializeFromJSON_DeserializesCorrectly()
        {
            // Arrange
            var fruits = new List<Fruit>
            {
                new Fruit("Apple", "Green"),
                new Fruit("Banana", "Yellow")
            };
            FruitSerializer.SerializeToJSON(fruits, jsonFilePath);

            // Act
            var deserializedFruits = FruitSerializer.DeserializeFromJSON(jsonFilePath);

            // Assert
            Assert.AreEqual(2, deserializedFruits.Count, "Десеріалізація повинна повернути два фрукти.");
            Assert.AreEqual("Apple", deserializedFruits[0].Name);
            Assert.AreEqual("Green", deserializedFruits[0].Color);
        }

        [TestMethod]
        public void DeserializeFromXML_ReturnsEmptyListOnError()
        {
            // Arrange
            File.WriteAllText(xmlFilePath, "Некоректний XML вміст");

            // Act
            var deserializedFruits = FruitSerializer.DeserializeFromXML(xmlFilePath);

            // Assert
            Assert.AreEqual(0, deserializedFruits.Count, "Десеріалізація некоректного XML має повернути порожній список.");
        }

        [TestMethod]
        public void DeserializeFromJSON_ReturnsEmptyListOnError()
        {
            // Arrange
            File.WriteAllText(jsonFilePath, "Некоректний JSON вміст");

            // Act
            var deserializedFruits = FruitSerializer.DeserializeFromJSON(jsonFilePath);

            // Assert
            Assert.AreEqual(0, deserializedFruits.Count, "Десеріалізація некоректного JSON має повернути порожній список.");
        }
    }
}
