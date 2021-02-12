using System;
using System.Text;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// The user will enter thier hieght and weight 
    /// using the metric system or the imperial system
    /// then thw app will calculate their index and
    /// outputs a message if they are underweight, normal
    /// weight, overweight or obese.
    /// </summary>
    /// <author>
    /// Tyronne Bradburn 1.0
    /// </author>

    public enum UnitSystem
    {
        Metric,
        Imperial
    }

    public class BmiCalculator
    {
        public const double Underweight = 18.5;
        public const double NormalRange = 24.9;
        public const double Overweight = 29.9;

        public const double ObeseLevel1 = 34.9;
        public const double ObeseLevel2 = 39.9;
        public const double ObeseLevel3 = 40.0;

        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;

        public double Index { get; set; }

        // Metric Details

        public double Kilograms { get; set; }
        public int Centimetres { get; set; }

        // Imperial Details

        public int Pounds { get; set; }
        public int Stones { get; set; }

        public int Feet { get; set; }
        public int Inches { get; set; }

        public double Metres { get; set; }

        public UnitSystem UnitSystem
        {
            get => default;
        }

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

            Console.WriteLine(GetHealthMessage());
            Console.WriteLine(GetBameMessage());
        }

        /// <summary>
        /// Method to calculate BMI using the 
        /// metric system
        /// </summary>
        /// <returns></returns>
        public double CalculateMetricBMI()
        {
            Metres = Metres + (double)Centimetres / 100;
            Index = Kilograms / (Metres * Metres);

            return Index;
        }

        /// <summary>
        /// Method to calculate BMI using the 
        /// Imperial system 
        /// </summary>
        /// <returns></returns>
        public double CalculateImperialBMI()
        {
            Inches += Feet * InchesInFeet;
            Pounds += Stones * PoundsInStones;

            Index = (double)Pounds * 703 / (Inches * Inches);

            return Index;
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
            Console.WriteLine("\n Enter your height to the neareat feet and inches ");
            Console.WriteLine();

            Feet = (int)ConsoleHelper.InputNumber("\n Enter your height in feet > ");
            Inches = (int)ConsoleHelper.InputNumber("\n Enter your height in inches > ");

            Console.WriteLine();
            Console.WriteLine(" Enter your height to the neareat Stones and Pounds ");
            Console.WriteLine();

            Stones = (int)ConsoleHelper.InputNumber("\n Enter your height in stones > ");
            Pounds = (int)ConsoleHelper.InputNumber("\n Enter your height in pounds > ");
        }

        /// <summary>
        /// Input the users height in metres and
        /// their weight in kilograms
        /// </summary>
        private void InputMetricDetails()
        {
            Centimetres =(int) ConsoleHelper.InputNumber(
                "\n Enter your height in Centimetres > ");

            Kilograms = ConsoleHelper.InputNumber(
                "\n Enter your weight in kilograms > ");
        }

        /// <summary>
        /// Output the users BMI and their weight
        /// category from underweight to obese.
        /// </summary>
        public string GetHealthMessage()
        {
            StringBuilder message = new StringBuilder("\n");

            if (Index < Underweight)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $"You are underweight! ");
            }
            else if (Index <= NormalRange)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $"You are in the normal range! ");

            }
            else if (Index <= Overweight)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $"You are overweight! ");

            }
            else if (Index <= ObeseLevel1)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $"You are obese class I ");

            }
            else if (Index <= ObeseLevel2)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $"You are obese class II ");

            }
            else if (Index <= ObeseLevel3)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $"You are obese class III ");

            }

            return message.ToString();
            
        }

        /// <summary>
        /// Output a message for BAME users who are
        /// at higher risk
        /// </summary>
        public string GetBameMessage()
        {
            StringBuilder message = new StringBuilder("\n");
            
            message.Append(" If you are Black, Asian or other minority");
            message.Append("\n ethnic groups, you have a higher risk");
            message.Append("\n");
            message.Append("\n Adults 23.0 or more are at increased risk");
            message.Append("\n Adults 27.5 or more are at high risk");
            message.Append("\n");

            return message.ToString();
        }
    }
}
