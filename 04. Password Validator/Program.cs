namespace _04._Password_Validator
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (PasswordLenghtCheck(password) && PasswordLettersAndDigitsCheck(password) && DigitCheck(password))
            {
                Console.WriteLine("Password is valid");
                return;
            }

            if (!PasswordLenghtCheck(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!PasswordLettersAndDigitsCheck(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!DigitCheck(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool PasswordLenghtCheck(string password) 
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool PasswordLettersAndDigitsCheck(string password) 
        {
            char[] chars = password.ToCharArray();
            bool charCheck = true;
            bool passCheck = true;

            for (int i = 0; i < chars.Length; i++)
            {
                int currChar = chars[i];
                if (currChar >= 48 && currChar <= 57 || currChar >= 65 && currChar <= 90 || currChar >= 97 && currChar <= 122)
                {
                    charCheck = true;
                }
                else 
                {
                    charCheck = false;
                }

                if (!charCheck)
                {
                    passCheck = false;
                }
            }

            if (passCheck)
            {
                return true;
            }
            else 
            {
                return false;
            }

        }

        static bool DigitCheck(string password) 
        {
            char[] chars = password.ToCharArray();
            int digitCounter = default;

            for (int i = 0; i < chars.Length; i++)
            {
                int currChar = chars[i];

                if (currChar >= 48 && currChar <= 57)
                {
                    digitCounter++;
                }
            }

            if (digitCounter >= 2)
            {
                return true;
            }
            else 
            {
                return false;
            }
           
        
        }
    }
}