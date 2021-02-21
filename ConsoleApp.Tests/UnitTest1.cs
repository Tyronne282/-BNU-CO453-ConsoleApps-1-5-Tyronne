using ConsoleAppProject.App01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 5280;

            converter.CalculateDistance();

            double expectedDistance = 1.0;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestMilesToMetres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Metres;

            converter.FromDistance = 1.0;

            converter.CalculateDistance();

            double expectedDistance = 1609.34;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestMetresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 1609.34;

            converter.CalculateDistance();

            double expectedDistance = 1.0;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 1.0;

            converter.CalculateDistance();

            double expectedDistance = 3.28084;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestFeetToMetres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Metres;

            converter.FromDistance = 3.28084;

            converter.CalculateDistance();

            double expectedDistance = 1.0;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
}
