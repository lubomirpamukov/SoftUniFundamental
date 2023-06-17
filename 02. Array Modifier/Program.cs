namespace _02._Array_Modifier
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "end") 
            {
                string[] cmdArgs = command.Split().ToArray();

                if (cmdArgs[0] == "swap")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);

                    int number1 = array[index1];
                    int number2 = array[index2];

                    array.RemoveAt(index1);
                    array.Insert(index1, number2);
                    array.RemoveAt(index2);
                    array.Insert(index2, number1);

                }
                else if (cmdArgs[0] == "multiply")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);

                    int number1 = array[index1];
                    int number2 = array[index2];
                    int multiplyNumber = number1 * number2;

                    array.RemoveAt(index1);
                    array.Insert(index1, multiplyNumber);
                }
                else if (cmdArgs[0] == "decrease") 
                {
                    for (int i = 0; i < array.Count; i++)
                    {
                        array[i] -= 1;
                    }
                }

            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}