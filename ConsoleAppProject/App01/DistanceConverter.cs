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
            OutputHeading();

            fromUnit = SelectUnit(" Please select the from distance unit > ");
            toUnit = SelectUnit(" Please select the to distance unit >.");

            Console.WriteLine($" Converting {fromUnit} to {toUnit}");
            
            FromDistance = InputDistance($" Please enter the number of {fromUnit} > ");

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
        /// <param name="prompt"></param>
        /// <returns></returns>
        private DistanceUnits SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            DistanceUnits unit = ExecutChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        /// <summary>
        /// Executes the user choice 
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        private static DistanceUnits ExecutChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return DistanceUnits.Feet;
            }
            else if (choice == "2")
            {
                return DistanceUnits.Metres;
            }
            else if (choice.Equals("3"))
            {
                return DistanceUnits.Miles;
            }

            return DistanceUnits.NoUnit;
        }

        /// <summary>
        /// Displays the choices for the user
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {DistanceUnits.Feet}");
            Console.WriteLine($" 2. {DistanceUnits.Metres}");
            Console.WriteLine($" 3. {DistanceUnits.Miles}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// Prompt the user to enter the distance amount. 
        /// Input the distance as a double number
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
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

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("\n --------------------------------- ");
            Console.WriteLine("      Coverting Miles/Feet/Metres    ");
            Console.WriteLine("          by Tyronne Bradburn        ");
            Console.WriteLine(" ---------------------------------\n ");
            Console.WriteLine();
        }
    }
}
