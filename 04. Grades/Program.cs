namespace _04._Grades
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());

            double gradeSum = 0.0;
            int weakStudentCounter = 0;
            int mediumStudentCounter = 0;
            int strongStudentCounter = 0;
            int topStudentCounter = 0;

            for (int i = 0; i < studentCount; i++)
            {
                double studentGrade = double.Parse(Console.ReadLine());
                gradeSum+= studentGrade;

                if (studentGrade >= 2.00 && studentGrade <= 2.99)
                {
                    weakStudentCounter++;
                }
                else if (studentGrade >= 3.00 && studentGrade <= 3.99)
                {
                    mediumStudentCounter++;
                }
                else if (studentGrade >= 4.00 && studentGrade <= 4.99)
                {
                    strongStudentCounter++;
                }
                else 
                {
                    topStudentCounter++;
                }
            }

            double avrageExamGrade = gradeSum / studentCount;

            double weakStudents = (double)weakStudentCounter / studentCount * 100;
            double mediumStudents = (double)mediumStudentCounter / studentCount * 100;
            double strongStudents = (double)strongStudentCounter / studentCount * 100;
            double topStudents = (double)topStudentCounter / studentCount * 100 ;

            Console.WriteLine($"Top students: {topStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {strongStudents:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {mediumStudents:f2}%");
            Console.WriteLine($"Fail: {weakStudents:f2}%");
            Console.WriteLine($"Average: {avrageExamGrade:f2}");


        }
    }
}