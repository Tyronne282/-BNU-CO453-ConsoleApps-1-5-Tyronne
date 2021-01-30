using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The App will convert miles to feet and miles to metres
    /// </summary>
    /// <author>
    /// Tyronne Bradburn 0.1
    /// </author>
    /// Feature 3 = convert miles to metres
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const int MILE_IN_METERS = 1609;

        private double miles;

        private double feet;

        private double meters; 

        /// <summary>
        /// This will run the program.
        /// </summary>
        public void Run()
        {
            ConvertMilesToFeet();
            ConvertFeetToMiles();
            ConvertMilesToMeters();
        }

        /// <summary>
        /// This method will mulitply miles by 5280 to get feet
        /// </summary>
        public void ConvertMilesToFeet()
        {
            OutputHeading();
            InputMiles();

            feet = miles * FEET_IN_MILES;

            OutputFeet();
        }

        /// <summary>
        /// This Method will divide feet by 5280 to get miles
        /// </summary>
        public void ConvertFeetToMiles()
        {
            OutputHeading();
            InputFeet();

            miles = feet / FEET_IN_MILES;

            OutputMiles();
        }

        public void ConvertMilesToMeters()
        {
            OutputHeading();
            InputMiles();

            meters = miles * MILE_IN_METERS;

            OutputMeters();
        }

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("\n --------------------------------- ");
            Console.WriteLine("      Coverting Miles/Feet/Meters    ");
            Console.WriteLine("         by Tyronne Bradburn         ");
            Console.WriteLine(" ---------------------------------\n ");
            Console.WriteLine();
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles. 
        /// Input the miles as a double number
        /// </summary>
        private void InputMiles() 
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// Prompt the user to enter the distance in feet. 
        /// Input feet as a double number
        /// </summary>
        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet! ");
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles! ");
        }

        private void OutputMeters()
        {
            Console.WriteLine(miles + " miles is " + meters + " meters! ");
        }
    }
}
