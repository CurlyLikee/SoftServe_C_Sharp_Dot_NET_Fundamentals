using Fruits_Finaly;

namespace FruitsTests
{
    [TestClass]
    public class FileInputCytrusTests
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
        public void InputFile_ReadsFromFileWithoutErrors()
        {
            // Arrange
            File.WriteAllText(testFilePath, "Test content");
            Cytrus cytrus = new Cytrus { path = testFilePath };

            // Act
            cytrus.InputFile();

            // Assert
            Assert.IsTrue(true, "Метод InputFile завершився без виключень.");
        }
        [TestMethod]
        public void InputFile_InvalidPath_CatchesException()
        {
            // Arrange
            Cytrus cytrus = new Cytrus { path = @"Z:\InvalidPath\file.txt" }; // Неправильний шлях

            using (var outputWriter = new StringWriter())
            {
                Console.SetOut(outputWriter);

                // Act
                cytrus.InputFile();

                // Assert
                StringAssert.Contains(outputWriter.ToString(), "Could not find a part of the path");
            }
        }
    }
}
