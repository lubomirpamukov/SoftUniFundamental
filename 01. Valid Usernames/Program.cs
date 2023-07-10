namespace _01._Valid_Usernames
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernameInputs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in usernameInputs)
            {
                bool valid = true;

                foreach (char charecter in word) 
                {
                    if (!char.IsLetterOrDigit(charecter) || charecter == '-' || charecter == '_')
                    {
                        valid = false;
                    }
                }

                if (valid && word.Length > 3 && word.Length < 16)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}