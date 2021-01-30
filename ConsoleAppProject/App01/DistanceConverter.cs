using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The App will convert miles to feet and miles to metres
    /// </summary>
    /// <author>
    /// Tyronne Bradburn 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double miles;

        private double feet;

        /// <summary>
        /// This will run the program.
        /// </summary>
        public void Run()
        {
            ConvertMilesToFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("\n --------------------------------- ");
            Console.WriteLine("         Covert Miles to Feet      ");
            Console.WriteLine("         by Tyronne Bradburn       ");
            Console.WriteLine(" ---------------------------------\n ");
            Console.WriteLine();
        }

        public void ConvertMilesToFeet()
        {
            OutputHeading();
            InputMiles();

            feet = miles * FEET_IN_MILES;

            OutputFeet();
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
        /// This method will multiply the miles by feet(5280).
        /// </summary>

        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet! ");
        }
    }
}
