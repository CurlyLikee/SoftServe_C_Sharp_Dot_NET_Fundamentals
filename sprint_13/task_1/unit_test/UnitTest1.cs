using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Xunit;
using task_1;

namespace task_1.Tests
{
    public class FruitTests
    {
        [Fact]
        public void Constructor_SetsNameAndColor()
        {
            var fruit = new Fruit("Apple", "Red");

            Assert.Equal("Apple", fruit.Name);
            Assert.Equal("Red", fruit.Color);
        }

        [Fact]
        public void ToString_ReturnsCorrectFormat()
        {
            var fruit = new Fruit("Banana", "Yellow");

            string expected = "Name: Banana, Color: Yellow";
            Assert.Equal(expected, fruit.ToString());
        }
    }
}
