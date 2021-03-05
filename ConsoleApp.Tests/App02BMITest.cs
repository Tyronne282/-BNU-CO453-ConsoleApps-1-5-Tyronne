using ConsoleAppProject.App02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestBMICalculator
    {
        [TestMethod]
        public void TestLowestUnderweightMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 45.5;
            bmi.Centimetres = 193;

            bmi.CalculateMetricBMI();

            double expectedBMI = 12;

            /// Rounding BMI down to the nearest integer as the tests
            /// based on the BMI chart are all in integers
            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestLowestUnderweightImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Pounds = 100;
            bmi.Feet = 6;
            bmi.Inches = 4;

            bmi.CalculateImperialBMI();

            double expectedBMI = 12;

            /// Rounding BMI down to the nearest integer as the tests
            /// based on the BMI chart are all in integers
            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestHighestUnderweightMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 68.2;
            bmi.Centimetres = 193;

            bmi.CalculateMetricBMI();

            double expectedBMI = 18;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestHighestUnderweightImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Pounds = 150;
            bmi.Feet = 6;
            bmi.Inches = 4;

            bmi.CalculateImperialBMI();

            double expectedBMI = 18;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestLowestNormalMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 47.1;
            bmi.Centimetres = 160;

            bmi.CalculateMetricBMI();

            double expectedBMI = 18;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestLowestNormalImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Pounds = 105;
            bmi.Feet = 5;
            bmi.Inches = 3;

            bmi.CalculateImperialBMI();

            double expectedBMI = 18;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestHighestNormalMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 63.6;
            bmi.Centimetres = 160;

            bmi.CalculateMetricBMI();

            double expectedBMI = 24;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestHighestNormalImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Pounds = 140;
            bmi.Feet = 5;
            bmi.Inches = 3;

            bmi.CalculateImperialBMI();

            double expectedBMI = 24;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestLowestOverweightMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 65.9;
            bmi.Centimetres = 160;

            bmi.CalculateMetricBMI();

            double expectedBMI = 25;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestLowestOverweightImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Pounds = 145;
            bmi.Feet = 5;
            bmi.Inches = 3;

            bmi.CalculateImperialBMI();

            double expectedBMI = 25;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestHighestOverweightMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 75;
            bmi.Centimetres = 160;

            bmi.CalculateMetricBMI();

            double expectedBMI = 29;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestHighestOverweightImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Pounds = 165;
            bmi.Feet = 5;
            bmi.Inches = 3;

            bmi.CalculateImperialBMI();

            double expectedBMI = 29;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestLowestObeseFirstMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 77.3;
            bmi.Centimetres = 160;

            bmi.CalculateMetricBMI();

            double expectedBMI = 30;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestLowestObeseFirstImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Pounds = 170;
            bmi.Feet = 5;
            bmi.Inches = 3;

            bmi.CalculateImperialBMI();

            double expectedBMI = 30;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestHighestObeseFirstMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 88.6;
            bmi.Centimetres = 160;

            bmi.CalculateMetricBMI();

            double expectedBMI = 34;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestHighestObeseFirstImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Pounds = 195;
            bmi.Feet = 5;
            bmi.Inches = 3;

            bmi.CalculateImperialBMI();

            double expectedBMI = 34;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestLowestObeseSecondMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 90.9;
            bmi.Centimetres = 160;

            bmi.CalculateMetricBMI();

            double expectedBMI = 35;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestLowestObeseSecondImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Pounds = 200;
            bmi.Feet = 5;
            bmi.Inches = 3;

            bmi.CalculateImperialBMI();

            double expectedBMI = 35;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestHighestObeseSecondMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 90.9;
            bmi.Centimetres = 152;

            bmi.CalculateMetricBMI();

            double expectedBMI = 39;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestHighestObeseSecondImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Pounds = 200;
            bmi.Feet = 5;
            bmi.Inches = 0;

            bmi.CalculateImperialBMI();

            double expectedBMI = 39;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestLowestObeseThirdMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 93.2;
            bmi.Centimetres = 152;

            bmi.CalculateMetricBMI();

            double expectedBMI = 40;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestLowestObeseThirdImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Pounds = 205;
            bmi.Feet = 5;
            bmi.Inches = 0;

            bmi.CalculateImperialBMI();

            double expectedBMI = 40;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestHighestObeseThirdMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 97.7;
            bmi.Centimetres = 152;

            bmi.CalculateMetricBMI();

            double expectedBMI = 42;

            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }

        [TestMethod]
        public void TestHighestObeseThirdImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Pounds = 215;
            bmi.Feet = 5;
            bmi.Inches = 0;

            bmi.CalculateImperialBMI();

            double expectedBMI = 41;

            /// Actual value is 41.9 and the BMI chart has this
            /// rounded up to 42, so this will be rounded up
            /// instead of down.
            Assert.AreEqual(expectedBMI, System.Math.Floor(bmi.Index));
        }
    }
}

