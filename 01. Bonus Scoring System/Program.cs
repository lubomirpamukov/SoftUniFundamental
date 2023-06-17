namespace _01._Bonus_Scoring_System
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            double lectureCount = double.Parse(Console.ReadLine());
            double additionalBonus= double.Parse(Console.ReadLine());

            double topStudentScore = 0;
            double topStudentAttendencies = 0;

            for (int i = 0; i < studentCount; i++)
            {
                double studentAttendances = double.Parse(Console.ReadLine());
                double studentScore = studentAttendances / lectureCount * (5.0 + additionalBonus);

                if (topStudentScore < studentScore)
                {
                    topStudentScore= studentScore;
                    topStudentAttendencies = studentAttendances;
                }

            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(topStudentScore):f0}.");
            Console.WriteLine($"The student has attended {topStudentAttendencies} lectures.");
        }
    }
}