using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>

    public enum UnitSystem
    {
        Metric,
        Imperial
    }

    public class BMI
    {
        public const double Underweight = 18.5;
        public const double NormalRange = 24.9;
        public const double Overweight = 29.9;

        public const double ObeseLevel1 = 34.9;
        public const double ObeseLevel2 = 39.9;
        public const double ObeseLevel3 = 40.0;

        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;

        private double index;

        // Metric Details

        private double kilograms;
        private double metres;

        // Imperial Details

        private double pounds;
        private int inches;

        /// <summary>
        /// The user will select either Metric or Imperial 
        /// measurements, input their height and weight and 
        /// then calculates their BMI. After it will show the 
        /// user which weight category they are in.
        /// </summary>
        public void CalculateIndex()
        {
            ConsoleHelper.OutputHeading("BMI Calculator");

            UnitSystem unitSystem = SelectUnits();

            if(unitSystem == UnitSystem.Metric)
            {
                InputMetricDetails();
                CalculateMetricBMI();
            }
            else
            {
                InputImperialDetails();
                CalculateImperialBMI();
            }

            OutputHealthMessage();
        }

        public double CalculateMetricBMI()
        {
            index = kilograms / (metres * metres);
            return index;
        }

        public double CalculateImperialBMI()
        {
            index = pounds * 703 / (inches * inches);
            return index;
        }

        /// <summary>
        /// Prompt the user to select imperial or metric
        /// units for entering their weight and height
        /// </summary>
        private UnitSystem SelectUnits()
        {
            string[] choices = new[]
            {
                "Metric Units",
                "Imperial Units"
            };

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                return UnitSystem.Metric;
            }
            else return UnitSystem.Imperial;
        }

        /// <summary>
        /// Input the users height in feet and inches and
        /// their weight in stones and pounds
        /// </summary>
        private void InputImperialDetails()
        {
            Console.WriteLine(
                " Enter your height in feet and inches ");
            double feet = ConsoleHelper.InputNumber(
                "\n Enter your height in feet > ");
            inches = (int)ConsoleHelper.InputNumber(
                " Enter your height in inches > ");

            inches += (int)feet * InchesInFeet;

            Console.WriteLine(
                " Enter your weight in stones and pounds");
            double stones = ConsoleHelper.InputNumber(
                " Enter your weight in stones > ");
            pounds = ConsoleHelper.InputNumber(
                " Enter your weight in pounds > ");

            pounds += stones * PoundsInStones;
        }

        /// <summary>
        /// Input the users height in metres and
        /// their weight in kilograms
        /// </summary>
        private void InputMetricDetails()
        {
            metres = ConsoleHelper.InputNumber(
                " \n Enter your height in metres > ");

            kilograms = ConsoleHelper.InputNumber(
                " Enter your weight in kilograms > ");
        }

        /// <summary>
        /// Output the users BMI and their weight
        /// category from underweight to obese.
        /// </summary>
        private void OutputHealthMessage()
        {
            if (index < Underweight)
            {
                Console.WriteLine($" Your BMI is {index}, " +
                    $"You are underweight! ");
            }
            else if (index <= NormalRange)
            {
                Console.WriteLine($" Your BMI is {index}, " +
                    $"You are in the normal range! ");

            }
            else if (index <= Overweight)
            {
                Console.WriteLine($" Your BMI is {index}, " +
                    $"You are overweight! ");

            }
            else if (index <= ObeseLevel1)
            {
                Console.WriteLine($" Your BMI is {index}, " +
                    $"You are obese class I ");

            }
            else if (index <= ObeseLevel2)
            {
                Console.WriteLine($" Your BMI is {index}, " +
                    $"You are obese class II ");

            }
            else if (index <= ObeseLevel3)
            {
                Console.WriteLine($" Your BMI is {index}, " +
                    $"You are obese class III ");

            }

            OutputBameMessage();
        }

        /// <summary>
        /// Output a message for BAME users who are
        /// at higher risk
        /// </summary>
        private void OutputBameMessage()
        {
            Console.WriteLine();
            Console.WriteLine(
                " If you are Black, Asian or other minority");
            Console.WriteLine(
                " ethnic groups, you have a higher risk");
            Console.WriteLine();
            Console.WriteLine(
                "\t Adults 23.0 or more are at increased risk");
            Console.WriteLine(
                "\t Adults 27.5 or more are at high risk");
            Console.WriteLine();
        }
    }
}
