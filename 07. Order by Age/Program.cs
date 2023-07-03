namespace _07._Order_by_Age
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>(); // initializing a list of objects

            string personInfo; // declaring a string variable

            while ((personInfo = Console.ReadLine()) != "End") // while loop reading input from the console until End
            {
                string[] personData = personInfo.Split(" ", StringSplitOptions.TrimEntries); // spliut the console input into array to extract data
                string name = personData[0]; // 0 index data == name
                string personId = personData[1]; // 1 index data == ID
                int age = int.Parse(personData[2]); // 2 index data == age

                Person Person = list.FirstOrDefault(p => p.PersonId == personId); // searching if person exists by ID

                if (Person == null) // if person dosnt exist
                {
                    Person = new Person(name, personId, age);// initialize new object with person information from the console
                    list.Add(Person); // add the person object to the list of objects
                }
                else // if person is alredy in the list 
                {
                    Person.Name = name; //over write their name
                    Person.Age = age;// over write their age
                }
            }

            foreach (Person person in list.OrderBy(p => p.Age)) // foreach loop to print all the list objects
            {
                Console.WriteLine(person);
            }
        }
    }

    public class Person // declaring a class for person
    {
        public Person(string name, string personId, int age)// creating a class constructor for perosn
        {
            Name = name; // giving value to Name property
            PersonId = personId; // giving value to PersonID property
            Age = age;// giving value to Age property 
        }
        public string Name { get;  set; }// creating Name Property for the class

        public string PersonId { get; private set; }// crreating PersonID property for the class

        public int Age { get;  set; }// creating Age Property for the class

        public override string ToString() // over write the string method
        {
            return $"{Name} with ID: {PersonId} is {Age} years old.";
        }
    }
}