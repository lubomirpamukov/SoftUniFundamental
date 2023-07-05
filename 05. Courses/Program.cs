namespace _05._Courses
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> listOfCourses = // creating dictionary
                new Dictionary<string, List<string>>();

            string command;

            while ((command = Console.ReadLine()) !="end")// iterates until "end" command is given
            {
                string[] cmdArgs = command // breaks input into array to extract data
                    .Split(":", StringSplitOptions.TrimEntries);
                string course = cmdArgs[0];
                string student = cmdArgs[1];

                StudentListManipulation(listOfCourses, course, student); // use custom method to add new students to the course

            }
            PrintCourseList(listOfCourses); // custom metod that print course and students
        }

        public static void StudentListManipulation(Dictionary<string, List<string>> listOfCourses, string course, string student)
        {
            if (!listOfCourses.ContainsKey(course)) // checks if course alredy exist if NOT
            {
                listOfCourses.Add(course, new List<string>()); // creates course and initialize empty list for the students
            }
            listOfCourses[course].Add(student); // add students to the list
        }

        public static void PrintCourseList(Dictionary<string, List<string>> listofCourses) 
        {
            foreach (KeyValuePair<string, List<string>> course in listofCourses) // iterates through the courses
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}"); // prints course:Name and students count
                foreach (string name in course.Value) // itterates trough the list of students
                {
                    Console.WriteLine($"-- {name}"); // print every student in the course
                }
            }
        }
    }
}