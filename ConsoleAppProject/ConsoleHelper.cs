using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {
        /// <summary>
        /// Ouputs the title for each app 
        /// </summary>
        public static void OutputHeading(string title)
        {
                Console.WriteLine();
                Console.WriteLine("\n --------------------------------- ");
                Console.WriteLine($"\t{title}                           ");
                Console.WriteLine("         by Tyronne Bradburn         ");
                Console.WriteLine(" ---------------------------------\n ");
                Console.WriteLine();
        }

        /// <summary>
        /// User will select their choice from the 
        /// list.
        /// </summary>
        public static int SelectChoice(string[] choices)
        {
            DisplayChoices(choices);

            int choiceNo = (int)InputNumber("\n Please enter your choice > ",
                                            1, choices.Length);
            return choiceNo;

        }

        /// <summary>
        /// Displays the choices for the user in the app 
        /// selector and the choices within the apps.
        /// </summary>
        private static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"    {choiceNo}.  {choice}");
            }
        }

        /// <summary>
        /// The user must use a number within the list 
        /// shown otherwise it will output invalid number
        /// message.
        /// </summary>
        public static double InputNumber(string prompt)
        {
            double number = 0;
            bool isvalid = false;

            do
            {
                Console.Write(prompt);
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    isvalid = true;
                }
                catch (Exception)
                {
                    isvalid = false;
                    Console.WriteLine(" Invalid Number !! ");
                }
            } while (!isvalid);

            return number;
        }

        /// <summary>
        /// The user cannot use a number lower than a set
        /// minimum number or a set maximum number.
        /// </summary>
        public static double InputNumber(string prompt, double min, double max)
        {
            bool isValid = false;
            double number;

            do
            {
                number = InputNumber(prompt);

                if (number < min || number > max)
                {
                    isValid = false;
                    Console.WriteLine($"Number must be between {min} and {max}");
                }
                else isValid = true;

            } while (!isValid);

            return number;
        }
    }
}
