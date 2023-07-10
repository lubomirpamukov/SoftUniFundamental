namespace _01._Valid_Usernames
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernameInputs = Console.ReadLine() //read input from the console and breaks it into array
                .Split(", ", StringSplitOptions.RemoveEmptyEntries); // split by ", "

            foreach (string user in usernameInputs) // loops that iterates through every username
            {
                bool valid = true; // making bool to help us check if the username is valid

                foreach (char charecter in user) // iterates through every char in the username 
                {
                    if (!char.IsLetterOrDigit(charecter) || charecter == '-' || charecter == '_') // if the char is Not one of these means there
                                                                                                  // are invalid symbols for hte username specification
                    {
                        valid = false; // valid bool becomse false so the user name won't be printed
                    }
                }

                if (valid && user.Length > 3 && user.Length < 16) // checks if the username is valid if it is it prints it
                {
                    Console.WriteLine(user); // printing valid username
                }
            }
        }
    }
}