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

            converter.FromUnit = DistanceConverter.Miles;
            converter.ToUnit = DistanceConverter.Feet;

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

            converter.FromUnit = DistanceConverter.Feet;
            converter.ToUnit = DistanceConverter.Miles;

            converter.FromDistance = 5280;

            converter.CalculateDistance();

            double expectedDistance = 1.0;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestMilesToMetres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.Miles;
            converter.ToUnit = DistanceConverter.Metres;

            converter.FromDistance = 1.0;

            converter.CalculateDistance();

            double expectedDistance = 1609.34;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestMetresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.Metres;
            converter.ToUnit = DistanceConverter.Miles;

            converter.FromDistance = 1609.34;

            converter.CalculateDistance();

            double expectedDistance = 1.0;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.Metres;
            converter.ToUnit = DistanceConverter.Feet;

            converter.FromDistance = 1.0;

            converter.CalculateDistance();

            double expectedDistance = 3.28084;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestFeetToMetres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.Feet;
            converter.ToUnit = DistanceConverter.Metres;

            converter.FromDistance = 3.28084;

            converter.CalculateDistance();

            double expectedDistance = 1.0;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
}
