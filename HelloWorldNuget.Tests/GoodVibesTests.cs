namespace HelloWorldNuget.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System.Collections.Generic;
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
        [DataRow(1)]
        [DataRow(2)]
        [TestMethod("Test get many real good vibes")]
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
