namespace _02._Grades
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
           Grades(double.Parse(Console.ReadLine()));
        }

        static void Grades(double grade) 
        {
            string gradeInWords = string.Empty;
            if (grade >= 2.00 && grade < 3)
            {
                gradeInWords = "Fail";
                Console.WriteLine(gradeInWords);
            }
            else if (grade >= 3.00 && grade < 3.50)
            {
                gradeInWords = "Poor";
                Console.WriteLine(gradeInWords);
            }
            else if (grade >= 3.50 && grade < 4.50)
            {
                gradeInWords = "Good";
                Console.WriteLine(gradeInWords);
            }
            else if (grade >= 4.50 && grade < 5.50)
            {
                gradeInWords = "Very good";
                Console.WriteLine(gradeInWords);
            }
            else if (grade >= 5.50 && grade < 6.00) 
            {
                gradeInWords = "Excellent";
                Console.WriteLine(gradeInWords);
            }



        }
    }
}