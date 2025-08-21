using Fruits_Finaly;

namespace FruitsTests
{
    [TestClass]
    public class FileOutputCytrusTests
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
            Cytrus cytrus = new Cytrus("Lemon", "Yellow", 60.5) { path = testFilePath };

            // Act
            cytrus.OutputFile();

            // Assert
            string lastLine = File.ReadAllLines(testFilePath)[^1];
            Assert.AreEqual("Name= Lemon\tColor= Yellow\tCount of vytamin C= 60.5", lastLine);
        }
        [TestMethod]
        public void OutputFile_InvalidPath_ThrowsAndCatchesException()
        {
            // Arrange
            Cytrus cytrus = new Cytrus("Orange", "Orange", 70.0) { path = @"Z:\InvalidPath\file.txt" };

            using (var outputWriter = new StringWriter())
            {
                Console.SetOut(outputWriter);

                // Act
                cytrus.OutputFile();

                // Assert
                StringAssert.Contains(outputWriter.ToString(), "Could not find a part of the path");
            }
        }
        [TestMethod]
        public void OutputFile_NullPath_CatchesException()
        {
            // Arrange
            Cytrus cytrus = new Cytrus("Grapefruit", "Pink", 40.0) { path = null };

            using (var outputWriter = new StringWriter())
            {
                Console.SetOut(outputWriter);

                // Act
                cytrus.OutputFile();

                // Assert
                StringAssert.Contains(outputWriter.ToString(), "Value cannot be null");
            }
        }
        [TestMethod]
        public void OutputFile_NoAccess_CatchesException()
        {
            // Arrange
            string restrictedPath = @"C:\Windows\System32\protected.txt"; // Директорія, яка зазвичай вимагає привілеїв адміністратора
            Cytrus cytrus = new Cytrus("Lime", "Green", 30) { path = restrictedPath };

            using (var outputWriter = new StringWriter())
            {
                Console.SetOut(outputWriter);

                // Act
                cytrus.OutputFile();

                // Assert
                string consoleOutput = outputWriter.ToString();
                StringAssert.Contains(consoleOutput, "Error:"); // Перевіряємо, що помилка була оброблена
            }
        }

    }
}