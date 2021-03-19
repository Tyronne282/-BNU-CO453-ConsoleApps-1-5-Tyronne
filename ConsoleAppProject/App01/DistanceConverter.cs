using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The App will prompt the user to input a distance
    /// measured in one unit (fromUnit) and it will calculate to
    /// the equivalent distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Tyronne Bradburn 0.6
    /// </author>
    public class DistanceConverter
    {
        /// <summary>
        /// Constants (Conversion Numbers) 
        /// </summary>
        public const int FEET_IN_MILES = 5280;
        public const double METERS_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        /// <summary>
        /// Constants (Unit Names)
        /// </summary>
        public const string FEET = "feet";
        public const string METRES = "metres";
        public const string MILES = "miles";

        /// <summary>
        /// Distingush between what unit the user 
        /// is converting from to the new unit
        /// </summary>
        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        public DistanceUnits FromUnit { get; set; }
        public DistanceUnits ToUnit { get; set; }

        public DistanceConverter()
        {
            FromUnit = DistanceUnits.Miles;
            ToUnit = DistanceUnits.Feet;
        }

        /// <summary>
        /// This will run the program.
        /// </summary>
        public void Run()
        {
            ConvertDistance();
        }

        /// <summary>
        /// Lets the user see what units they have picked 
        /// </summary>
        public void ConvertDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter");

            FromUnit = SelectUnit(" Please select the distance unit > ");
            ToUnit = SelectUnit(" Please select the distance unit > ");

            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");

            FromDistance = ConsoleHelper.InputNumber($" Please enter the number of {FromUnit} > ");

            CalculateDistance();

            OutputDistance();

            QuitOption();
        }

        /// <summary>
        /// Calculates the chosen user units
        /// </summary>
        public void CalculateDistance()
        {
            if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance * METERS_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / METERS_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
        }

        /// <summary>
        /// Prompts the user to select a unit choice
        /// from one unit to another
        /// </summary>
        private DistanceUnits SelectUnit(string prompt)
        {
            Console.WriteLine(prompt);

            string[] choices = { $" {DistanceUnits.Feet}",
                                 $" {DistanceUnits.Metres}",
                                 $" {DistanceUnits.Miles}"};

            int choice = ConsoleHelper.SelectChoice(choices);

            DistanceUnits unit;

            if (choice == 1)
            {
                unit = DistanceUnits.Feet;
            }
            else if (choice == 2)
            {
                unit = DistanceUnits.Metres;
            }
            else
            {
                unit = DistanceUnits.Miles;
            }

            Console.WriteLine($"\n You have selected {unit}");
            Console.WriteLine();

            return unit;
        }

        /// <summary>
        /// Changes the text on screen depending on the conversion
        /// for example miles is X amount meters
        /// feet is X amount miles
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance}  {FromUnit}" +
                $" is {ToDistance:0.00} {ToUnit}!\n");
        }

        /// <summary>
        /// Lets the user to quit the App or to return to convert 
        /// another Distance.
        /// </summary>
        private void QuitOption()
        {
            Console.WriteLine("\n Do you want to quit the App? (y/n) > ");

            string choice = Console.ReadLine();

            if (choice == "y")
            {
                Console.WriteLine(" Thank you for using the Distance Converter");
                Environment.Exit(0);
            }

            else if (choice == "n")
            {
                ConvertDistance();
            }

            else
            {
                Console.WriteLine(" Invaild Input ");
                QuitOption();
            }
        }
    }
}
