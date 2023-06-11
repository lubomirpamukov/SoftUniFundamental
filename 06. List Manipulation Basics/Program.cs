namespace _06._List_Manipulation_Basics
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> originalList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool isChangeMade = false;
            string operation = string.Empty;

            while ((operation = Console.ReadLine()) != "end")
            {
                string[] currentOperation = operation
                    .Split()
                    .ToArray();

                if (currentOperation[0] == "Add")
                {
                    int add = int.Parse(currentOperation[1]);
                    originalList.Add(add);
                    isChangeMade = true;

                }
                else if (currentOperation[0] == "Remove")
                {
                    int remove = int.Parse(currentOperation[1]);
                    originalList.Remove(remove);
                    isChangeMade = true;

                }
                else if (currentOperation[0] == "RemoveAt")
                {
                    int removeAt = int.Parse(currentOperation[1]);
                    originalList.RemoveAt(removeAt);
                    isChangeMade = true;

                }
                else if (currentOperation[0] == "Insert")
                {
                    int number = int.Parse(currentOperation[1]);
                    int index = int.Parse(currentOperation[2]);
                    originalList.Insert(index, number);
                    isChangeMade = true;

                }
                else if (currentOperation[0] == "Contains")
                {
                    int compare = int.Parse(currentOperation[1]);
                    if (originalList.Contains(compare))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (currentOperation[0] == "PrintEven")
                {
                    for (int i = 0; i < originalList.Count; i++)
                    {
                        if (originalList[i] % 2 == 0)
                        {
                            Console.Write(originalList[i] + " ");
                        }
                    }
                }
                else if (currentOperation[0] == "PrintOdd")
                {
                    for (int i = 0; i < originalList.Count; i++)
                    {
                        if (originalList[i] % 2 != 0)
                        {
                            Console.Write(originalList[i] + " ");

                        }
                    }
                }
                else if (currentOperation[0] == "GetSum")
                {
                    int sum = default;

                    for (int i = 0; i < originalList.Count; i++)
                    {
                        sum += originalList[i];
                    }

                    Console.WriteLine(sum);
                }
                else if (currentOperation[0] == "Filter") 
                {
                    int number = int.Parse(currentOperation[2]);
                    string condition = currentOperation[1];

                    if (condition == "<")
                    {
                        for (int i = 0; i < originalList.Count; i++)
                        {
                            if (number > originalList[i])
                            {
                                Console.Write(originalList[i] + " " );
                            }
                        }
                    }
                   else if (condition == ">")
                    {
                        for (int i = 0; i < originalList.Count; i++)
                        {
                            if (number < originalList[i])
                            {
                                Console.Write(originalList[i] + " ");
                            }
                        }
                    }
                   else if (condition == ">=")
                    {
                        for (int i = 0; i < originalList.Count; i++)
                        {
                            if (originalList[i] >= number)
                            {
                                Console.Write(originalList[i] + " ");
                            }
                        }
                    }
                    else if (condition == "<=")
                    {
                        for (int i = 0; i < originalList.Count; i++)
                        {
                            if (number >= originalList[i])
                            {
                                Console.Write(originalList[i] + " ");
                            }
                        }
                    }
                }
            }

            if (isChangeMade) 
            {
            Console.WriteLine(string.Join(" ", originalList));
            }

            

            
        }
    }
}