namespace _05._Students_2._0
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>(); // creating collection of objects

            string studentData; // declaring empty string

            while ((studentData = Console.ReadLine()) != "end") 
            {
                string[] currPersonalInfo = studentData.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstName = currPersonalInfo[0];
                string lastName = currPersonalInfo[1];
                int age = int.Parse(currPersonalInfo[2]);
                string town = currPersonalInfo[3];

                Student student = studentList.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

                if (student != null)
                {
                    student.Age = age;
                    student.Town = town;
                }
                else
                {
                    student = new Student(firstName, lastName, age, town);
                    studentList.Add(student);
                }
                
            }

            string city = Console.ReadLine();// string with input for city data


            foreach (Student student in studentList.Where(x => x.Town == city)) // looping and printing every item in the filtered list
            {
                Console.WriteLine(string.Join(" ", student.FirstName, student.LastName + " is", student.Age + " years old."));
            }
        }
    }

    class Student // initializing student class
    {
        public Student(string firstName, string lastName, int age, string town) // class constructor 
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Town = town;
        }
        public string FirstName { get; set; } // declaring class property

        public string LastName { get; set; } // declaring class property

        public int Age { get; set; } // declaring class property

        public string Town { get; set; } // declaring class property
    }

}