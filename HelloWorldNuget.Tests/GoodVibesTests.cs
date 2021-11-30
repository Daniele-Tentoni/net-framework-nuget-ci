namespace HelloWorldNuget.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System.Linq;

    [TestClass]
    public class GoodVibesTests
    {
        [TestMethod]
        public void TestGetARealGoodVibe()
        {
            // Arrange
            var expected = "Hello World!";

            // Act
            var vibe = GoodVibesFactory.GetAGoodVibe();

            // Assert
            Assert.AreEqual(expected, vibe);
        }

        [DataTestMethod]
        [DataRow(1, DisplayName = "Test only one good vibe")]
        [DataRow(2, DisplayName = "Test two good vibe")]
        public void TestGetManyRealGoodVides(int number)
        {
            // Arrange
            var expected = "Hello World!";

            // Act
            var vibes = GoodVibesFactory.GetManyGoodVibes(number).ToList();

            // Assert
            for (int i = 0; i < number; i++)
                Assert.AreEqual(expected, vibes[i]);
        }
    }
}
