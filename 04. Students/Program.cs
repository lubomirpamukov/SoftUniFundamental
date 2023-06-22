namespace _04._Students
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new  List<Student>(); // creating collection of objects

            string studentData; // declaring empty string

            while ((studentData = Console.ReadLine()) != "end") // while loops that loops until "end" command
            {
                string[] currPersonalInfo = studentData.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray(); //breaking the input into array to extract data
                int age = int.Parse(currPersonalInfo[2]); // parsing the string to int to use it for mathematical operation
                Student student = new Student(currPersonalInfo[0], currPersonalInfo[1], age, currPersonalInfo[3]); // filling up the object with the data for the propertys
                studentList.Add(student);//adding the object to the collection
            }

            string city = Console.ReadLine();// string with input for city data

            List<Student>filteredStudentList = studentList.Where(x => x.Town == city).ToList(); // filtered list with the objects from the same city

            foreach (Student student in filteredStudentList) // looping and printing every item in the filtered list
            {
                Console.WriteLine(string.Join(" ", student.FirstName, student.LastName + " is", student.Age +" years old."));
            }
        }
    }

    class Student // initializing student class
    {
        public Student(string firstName, string lastName, int age, string town) // class constructor 
        {
            FirstName= firstName;
            LastName= lastName;
            Age= age;
            Town= town;
        }
        public string FirstName { get; set; } // declaring class property

        public string LastName { get; set; } // declaring class property

        public int Age { get; set; } // declaring class property

        public string Town { get; set; } // declaring class property
    }
}