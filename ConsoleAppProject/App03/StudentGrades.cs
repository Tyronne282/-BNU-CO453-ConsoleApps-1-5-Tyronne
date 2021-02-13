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
        /// 
        /// </summary>
        public void InputMarks()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public void OutputMarks()
        {
            
        }

        /// <summary>
        /// This method will convert the marks to a grade
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
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
            else if (mark >= LowestGradeA && mark < HighestMark)
            {
                return Grades.A;
            }
            else if (mark == HighestMark)
            {
                return Grades.A;
            }
            else
            {
                return Grades.NULL;
            }
        }

        /// <summary>
        /// This method will calculate the mean mark
        /// for each student.
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;

            foreach(int mark in Marks)
            {
                total = total + mark;
            }

            Mean = total / Marks.Length;
        }
    }
}
