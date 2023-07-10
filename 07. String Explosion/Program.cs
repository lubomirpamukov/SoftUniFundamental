namespace _07._String_Explosion
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();
            int bombPower = 0;
            

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == '>')
                {
                    if (char.IsDigit(input[i+1]))
                    {
                        int currBomb = (int)input[i + 1] - 48;
                        bombPower += currBomb;
                    }
                }

                if (bombPower > 0 && input[i+1] != '>')
                {
                    input = input.Remove(i+1, 1);
                    bombPower--;
                    i--;
                }

            }

            Console.WriteLine(input);
        }
    }
}