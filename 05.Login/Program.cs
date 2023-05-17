namespace _05.Login
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string enteredPassword = string.Empty;
            string password = string.Empty;
            string usernameCopy = username;
            int failedCounter = 1;

            for (int i = usernameCopy.Length - 1; i >= 0; i--)
            {
                char passSymb = usernameCopy[i];
                password += passSymb;
            }



            while ((enteredPassword=Console.ReadLine()) != password)
            {
                if (failedCounter >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                failedCounter++;
            }

            if (enteredPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}