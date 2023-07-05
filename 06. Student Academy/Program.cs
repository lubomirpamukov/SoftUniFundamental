namespace _06._Student_Academy
{
    using System;
    using System.Diagnostics;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = //making dictionary
                 new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine()); // integer input from the console

            for (int i = 0; i < n; i++) // loop that adds students and grades
            {
                string name = Console.ReadLine(); // taking student name as input from the console
                double grade = double.Parse(Console.ReadLine()); // taking student grade as input from the console
                AddingStudentsAndGrades(students, name, grade); // custom method that adds students to the dictionary
            }

            FilterStudents(students); // custom filter metod that filters all students with grade >= 4.50
        }

        private static void AddingStudentsAndGrades(Dictionary<string, List<double>> students, string name, double grade)
        {
            if (!students.ContainsKey(name)) // checks if the student exist alredy in the list
            {
                students[name] = new List<double>(); // if it dont exist creates student, and empty list
            }
            students[name].Add(grade); // adds grades to the list
        }

        private static void FilterStudents(Dictionary<string, List<double>> students) 
        {
            Dictionary<string,double> filteredStudents // making filtered dictionary with the avrage grade >= 4.50
                = new Dictionary<string,double>();

            foreach (KeyValuePair<string, List<double>> student in students) // iterates thourgh every student
            {
                double avrageGrade = student.Value.Average(); // making double to store avrage grade

                if (avrageGrade >= 4.50) // grade >= 4.50
                {
                    filteredStudents[student.Key] = avrageGrade; // adds the student 
                }
            }

            foreach (KeyValuePair<string,double> student in filteredStudents) // prints the students with grade >= 4.50
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
            
        }
    }
}