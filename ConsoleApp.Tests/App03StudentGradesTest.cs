using ConsoleAppProject.App03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades studentGrades = new StudentGrades();
        private readonly int[] testMarks = new int[]
        {
            10, 20, 30, 40, 50, 60, 70, 80, 90, 100
        };


        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            Grades expectedGrade = Grades.F;
            Grades actualGrade = studentGrades.ConvertToGrade(0);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert39ToGradeF()
        {
            Grades expectedGrade = Grades.F;
            Grades actualGrade = studentGrades.ConvertToGrade(39);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert40ToGradeD()
        {
            Grades expectedGrade = Grades.D;
            Grades actualGrade = studentGrades.ConvertToGrade(40);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert49ToGradeD()
        {
            Grades expectedGrade = Grades.D;
            Grades actualGrade = studentGrades.ConvertToGrade(40);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert50ToGradeC()
        {
            Grades expectedGrade = Grades.C;
            Grades actualGrade = studentGrades.ConvertToGrade(50);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert59ToGradeC()
        {
            Grades expectedGrade = Grades.C;
            Grades actualGrade = studentGrades.ConvertToGrade(59);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert60ToGradeB()
        {
            Grades expectedGrade = Grades.B;
            Grades actualGrade = studentGrades.ConvertToGrade(60);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert69ToGradeB()
        {
            Grades expectedGrade = Grades.B;
            Grades actualGrade = studentGrades.ConvertToGrade(60);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert70ToGradeA()
        {
            Grades expectedGrade = Grades.A;
            Grades actualGrade = studentGrades.ConvertToGrade(70);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert100ToGradeA()
        {
            Grades expectedGrade = Grades.A;
            Grades actualGrade = studentGrades.ConvertToGrade(100);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestCountStudentNo()
        {
            int expectedNo = 10;
            int actualNo = studentGrades.Students.Length;

            Assert.AreEqual(expectedNo, actualNo);
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            studentGrades.Marks = testMarks;
            double expectedMean = 55.0;

            studentGrades.CalculateStats();

            Assert.AreEqual(expectedMean, studentGrades.Mean);
        }

        [TestMethod]
        public void TestCalculateMin()
        {
            studentGrades.Marks = testMarks;
            int expectedMin = 10;

            studentGrades.CalculateStats();

            Assert.AreEqual(expectedMin, studentGrades.Minimum);
        }

        [TestMethod]
        public void TestCalculateMax()
        {
            studentGrades.Marks = testMarks;
            int expectedMax = 100;

            studentGrades.CalculateStats();

            Assert.AreEqual(expectedMax, studentGrades.Maximum);
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            studentGrades.Marks = testMarks;

            studentGrades.CalculateGradeProfile();

            bool expectedProfile;
            expectedProfile = ((studentGrades.GradeProfile[0] == 0) &&
                               (studentGrades.GradeProfile[1] == 3) &&
                               (studentGrades.GradeProfile[2] == 1) &&
                               (studentGrades.GradeProfile[3] == 1) &&
                               (studentGrades.GradeProfile[4] == 1) &&
                               (studentGrades.GradeProfile[5] == 4));

            Assert.IsTrue(expectedProfile);
        }
    }
}
