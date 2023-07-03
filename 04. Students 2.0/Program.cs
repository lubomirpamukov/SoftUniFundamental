namespace _04._Students_2._0
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Student> students = new List<Student> (); // creating list of students

            int numberOfStudents = int.Parse(Console.ReadLine()); // reading number of students from the console

            for (int i = 0; i < numberOfStudents; i++) // on each iteration we create and add a new student to the list
            {
                string[] studentData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); // reading data for the student from the console and spliting it into array
                string firstName = studentData[0];
                string lastName = studentData[1];
                double grade = double.Parse(studentData[2]);

                Student student = new Student(firstName, lastName, grade); // creating a new instance of a student

                students.Add(student);// adds the student to the list of students
            }

            foreach (Student student in students.OrderByDescending(s => s.Grade)) // foreach loop that orders the students by decending grade
            {
                Console.WriteLine(student); // prints the students
            }
        }
    }

    public class Student // creating student class
    {
        public Student(string firstName, string lastName, double grade) // crating constructor for the student
        {
            FirstName = firstName; // giving data to the Property
            LastName = lastName; // giving data to the Property
            Grade = grade; // giving data to the Property
        }
        public string FirstName { get; private set; } // creating a property

        public string LastName { get; private set;} //creating a property

        public double Grade { get; private set; }// creating a property

        public override string ToString() // creating a custom ToString method
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }

}