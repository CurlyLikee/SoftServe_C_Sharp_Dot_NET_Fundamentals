using Fruits_Finaly;

namespace FruitsTests
{
    [TestClass]
    public class CytrusTests
    {
        [TestMethod]
        public void Constructor_ValidParameters_AssignsCorrectValues()
        {
            // Arrange & Act
            Cytrus cytrus = new Cytrus("Orange", "Orange", 50.5);

            // Assert
            Assert.AreEqual("Orange", cytrus.Name);
            Assert.AreEqual("Orange", cytrus.Color);
            Assert.AreEqual(50.5, cytrus.Count_Vytamin_C);
        }

        [TestMethod]
        public void Output_ReturnsCorrectString()
        {
            // Arrange
            Cytrus cytrus = new Cytrus("Lemon", "Yellow", 60);

            // Act
            string result = cytrus.Output();

            // Assert
            Assert.AreEqual("Name= Lemon\tColor= Yellow\tCount of vytamin C= 60", result);
        }

        [TestMethod]
        public void OutputFile_WritesCorrectDataToFile()
        {
            // Arrange
            Cytrus cytrus = new Cytrus("Grapefruit", "Pink", 70);
            string path = cytrus.path;

            // Act
            cytrus.OutputFile();

            // Assert
            string lastLine = File.ReadAllLines(path)[^1];
            Assert.AreEqual("Name= Grapefruit\tColor= Pink\tCount of vytamin C= 70", lastLine);
        }

        [TestMethod]
        public void Count_Vytamin_C_Setter_AssignsCorrectValue()
        {
            // Arrange
            Cytrus cytrus = new Cytrus();

            // Act
            cytrus.Count_Vytamin_C = 45.5;

            // Assert
            Assert.AreEqual(45.5, cytrus.Count_Vytamin_C);
        }

        [TestMethod]
        public void Input_ValidData_ReturnsCorrectCytrus()
        {
            // Arrange
            string input = "Lemon\nYellow\n50.5\n";
            using (var inputReader = new StringReader(input))
            {
                Console.SetIn(inputReader);

                // Act
                Cytrus result = Cytrus.Input();

                // Assert
                Assert.AreEqual("Lemon", result.Name);
                Assert.AreEqual("Yellow", result.Color);
                Assert.AreEqual(50.5, result.Count_Vytamin_C);
            }
        }
    }
}