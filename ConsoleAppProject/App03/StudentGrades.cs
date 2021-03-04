using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// The App will prompt the user to input a mark
    /// for each student in the list and the user will
    /// be able to get a mean mark for each student.
    /// </summary>
    public class StudentGrades
    {
        // Constants (Grade Boundaries)

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        // Properties 

        public string [] Students { get; set; }

        public int[] Marks { get; set; }
        
        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
            {
                "Tyronne","Roche","Xavier",
                "Megan","Klaudia","Katy",
                "Einike","Goncalo","Josh",
                "Sakura"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        /// <summary>
        /// The User can select an option within the app.
        /// </summary>
        public void OutputMenu()
        {
            string[] choices =
            {
                "Input Marks",
                "Output Marks",
                "Output Stats",
                "Output Grade Profile",
                "Quit",
            };

            int choiceNo;

            do
            {
                ConsoleHelper.OutputHeading("Student Grades");

                choiceNo = ConsoleHelper.SelectChoice(choices);

                switch (choiceNo)
                {
                    case 1: InputMarks(); break;
                    case 2: OutputMarks(); break;
                    case 3:
                        CalculateStats();
                        OutputStats(); break;
                    case 4:
                        CalculateGradeProfile();
                        OutputGradeProfile(); break;

                    default: break;
                }

            } while (choiceNo != 5);
        }

        /// <summary>
        /// Lets the user input a number for the mark 
        /// between 0-100. If the number is more then 
        /// 100 or less then 0 an error is shown.
        /// </summary>
        public void InputMarks()
        {
            Console.WriteLine("\n Enter the mark for the student. ");

            for (int i = 0; i < Students.Length; i++)
            {
                Marks[i] = (int)ConsoleHelper.InputNumber($"\n\tMark for " +
                    $"{Students[i]} > ", 0, 100);
            }

        }

        /// <summary>
        /// Displays a list of the students, Marks and Grades.
        /// </summary>
        public void OutputMarks()
        {
            Console.WriteLine("\n\tName\tMarks\tGrade\n");

            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"\t{Students[i]}\t{Marks[i]}\t" +
                    $"{ConvertToGrade(Marks[i])}");
            }

        }

        /// <summary>
        /// This method will convert the marks to a grade
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }
            else
            {
                return Grades.UNGRADED;
            }
        }

        /// <summary>
        /// This method will calculate the mean mark
        /// for each student.
        /// </summary>
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];
            
            double total = 0;

            foreach(int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;

                total += mark;
            }

            Mean = total / Marks.Length;

        }

        /// <summary>
        /// Outputs the Mean, Max Mark and Min Mark
        /// for the Students
        /// </summary>
        public void OutputStats()
        {
            Console.WriteLine("\n\tStatistics\n");
            Console.WriteLine($"\tMean Mark = {Mean:0.0}");
            Console.WriteLine($"\tMinimum Mark = {Minimum}");
            Console.WriteLine($"\tMaximum Mark = {Maximum}");
        }

        /// <summary>
        /// This method will calculate and display 
        /// what students are achieving
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }

        /// <summary>
        /// This method will calculate the marks as a 
        /// percentage and a Grade.
        /// </summary>
        private void OutputGradeProfile()
        {
            Grades grade = Grades.UNGRADED;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }
        }
    }
}
