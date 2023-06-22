namespace _04._Students_2._0
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Student> students = new List<Student> ();

            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = studentData[0];
                string lastName = studentData[1];
                double grade = double.Parse(studentData[2]);

                Student student = new Student(firstName, lastName, grade);

                students.Add(student);
            }

            foreach (Student student in students.OrderByDescending(s => s.Grade))
            {
                Console.WriteLine(student);
            }
        }
    }

    public class Student 
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; private set; }

        public string LastName { get; private set;}

        public double Grade { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }

}