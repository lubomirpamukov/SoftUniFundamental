namespace _02._Oldest_Family_Member
{
    using System;
    internal class Program
    {
        static void Main(string[] args) // main method
        {
            int numberOfPeople = int.Parse(Console.ReadLine()); // reading number of people form the consonle line
            Family family = new Family(); // initializing family object

            for (int i = 0; i < numberOfPeople; i++) // for loop to fill up the Family object with Person Objects
            {
                string[] PersonData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); // data extraction from input

                string name = PersonData[0]; // variables for easy readability
                int age = int.Parse(PersonData[1]); // varbiales for easy readability

                Person person = new Person(name, age); // initializing new Person object with the given input
                family.People.Add(person); // adding person Objects to Family object 
            }

            Person oldest = family.OldestMember(); // searching for the oldest person in the family using a custom metod

            Console.WriteLine($"{oldest.Name} {oldest.Age}"); // printing the oldest person

        }
    }

    public class Person // making class perosn
    {
        public Person(string name, int age) // class Person constructor
        {
            Name = name; // assigning value to Name property
            Age = age; // assigning value to Age property
        }

        public string Name { get; private set; }// creating Name Property
        public int Age { get; private set; } // creating Age property
    }

    public class Family // class family
    {

        public List<Person> People; // declaring a field

        public Family() // constructor
        {
            People = new List<Person>(); // initializing People property
        }

        void AddMember(Person person) // method that adds member
        {
            People.Add(person);
        }

        public Person OldestMember() // method that filters Members by age in a decending order and takes the first or defoult element.
        {
            Person oldestPerson = People.OrderByDescending(p => p.Age).FirstOrDefault();
            return oldestPerson;
        }
    }


}