namespace _01._Count_Real_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> keyValuePairs = new SortedDictionary<double, int>();

            string command = Console.ReadLine();
            string[] cmdArgs = command.Split();

            for (int i = 0; i < cmdArgs.Length; i++)
            {
                double key = double.Parse(cmdArgs[i]);

                if (!keyValuePairs.ContainsKey(key))
                {
                    keyValuePairs.Add(key, 0);
                }

                keyValuePairs[key]++;
            }

            foreach (var key in keyValuePairs)
            {
                Console.WriteLine($"{key.Key} -> {key.Value}");
            }
        }


    }
}