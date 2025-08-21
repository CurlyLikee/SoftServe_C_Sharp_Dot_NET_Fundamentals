using Fruits_Finaly;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FruitsTests
{
    [TestClass]
    public class FileOutputFruitTests
    {
        private string testFilePath;

        [TestInitialize]
        public void SetUp()
        {
            // Створюємо тимчасовий файл перед кожним тестом
            testFilePath = Path.GetTempFileName();
        }

        [TestCleanup]
        public void TearDown()
        {
            // Видаляємо тимчасовий файл після кожного тесту
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }

        [TestMethod]
        public void OutputFile_WritesCorrectDataToFile()
        {
            // Arrange
            Fruit fruit = new Fruit("Peach", "Orange") { path = testFilePath };

            // Act
            fruit.OutputFile();

            // Assert
            string lastLine = File.ReadAllLines(testFilePath)[^1];
            Assert.AreEqual("Name= Peach\tColor= Orange\t", lastLine);
        }

        [TestMethod]
        public void OutputFile_InvalidPath_ThrowsAndCatchesException()
        {
            // Arrange
            Fruit fruit = new Fruit("Peach", "Orange") { path = @"Z:\InvalidPath\file.txt" }; // Неправильний шлях

            using (var outputWriter = new StringWriter())
            {
                Console.SetOut(outputWriter);

                // Act
                fruit.OutputFile();

                // Assert
                StringAssert.Contains(outputWriter.ToString(), "Could not find a part of the path");
            }
        }
        [TestMethod]
        public void OutputFile_NullPath_CatchesException()
        {
            // Arrange
            Fruit fruit = new Fruit("Grape", "Purple") { path = null };

            using (var outputWriter = new StringWriter())
            {
                Console.SetOut(outputWriter);

                // Act
                fruit.OutputFile();

                // Assert
                string consoleOutput = outputWriter.ToString();
                StringAssert.Contains(consoleOutput, "Value cannot be null"); // Перевірка, що виняток було оброблено
            }
        }
        [TestMethod]
        public void OutputFile_NoAccess_CatchesException()
        {
            // Arrange
            string restrictedPath = @"C:\Windows\System32\protected.txt"; // Системна директорія
            Fruit fruit = new Fruit("Banana", "Yellow") { path = restrictedPath };

            using (var outputWriter = new StringWriter())
            {
                Console.SetOut(outputWriter);

                // Act
                fruit.OutputFile();

                // Assert
                string consoleOutput = outputWriter.ToString();
                StringAssert.Contains(consoleOutput, "Access to the path"); // Перевірка, що помилка оброблена
            }
        }
    }
}