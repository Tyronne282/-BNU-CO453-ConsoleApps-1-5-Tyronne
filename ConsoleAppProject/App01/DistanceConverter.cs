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
        private double FromDistance;
        private double ToDistance;

        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;

        public DistanceConverter()
        {
            fromUnit = DistanceUnits.Miles;
            toUnit = DistanceUnits.Feet;
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

            fromUnit = SelectUnit(" Please select the distance unit > ");
            toUnit = SelectUnit(" Please select the distance unit > ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");
            
            FromDistance = ConsoleHelper.InputNumber($" Please enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// Calculates the chosen user units
        /// </summary>
        private void CalculateDistance()
        {
            if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance * METERS_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / METERS_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Metres)
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
            Console.WriteLine($"\n {FromDistance}  {fromUnit}" +
                $" is {ToDistance} {toUnit}!\n");
        }
    }
}
