using Fruits_Finaly;

namespace FruitsTests
{
    [TestClass]
    public class FileInputFruitTests
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
        public void InputFile_FileExists_DoesNotThrow()
        {
            // Arrange
            File.WriteAllText(testFilePath, "Sample content");
            var fruit = new Fruit("Mango", "Green");
            fruit.path = testFilePath;

            using (var outputWriter = new StringWriter())
            {
                Console.SetOut(outputWriter);

                // Act
                fruit.InputFile();

                // Assert
                Assert.IsTrue(outputWriter.ToString().Length == 0, "Метод не повинен виводити помилки.");
            }
        }

        [TestMethod]
        public void InputFile_FileDoesNotExist_PrintsErrorMessage()
        {
            // Arrange
            var fruit = new Fruit();
            fruit.path = "NonExistentFile.txt";

            using (var outputWriter = new StringWriter())
            {
                Console.SetOut(outputWriter);

                // Act
                fruit.InputFile();

                // Assert
                StringAssert.Contains(outputWriter.ToString(), "Could not find file");
            }
        }
    }
}