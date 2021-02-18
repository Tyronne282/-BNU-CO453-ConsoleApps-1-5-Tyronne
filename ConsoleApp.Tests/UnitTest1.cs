using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            // Arrange stage - created converter, initialised all values

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 1.0;

            // Act stage

            converter.CalculateDistance();

            double expectedDistance = 5280;

            // Assert stage

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
}
