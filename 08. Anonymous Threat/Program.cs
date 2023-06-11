namespace _08._Anonymous_Threat
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split()
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArgs = command.Split().ToArray();

                if (cmdArgs[0] == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    
                }

            }
        }
    }
}