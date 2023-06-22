namespace _03.Deck_of_Cards
{
    using System;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> deck = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (cmdArgs[0] == "Add")
                {
                    if (deck.Contains(cmdArgs[1]))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        deck.Add(cmdArgs[1]);
                        Console.WriteLine($"Card successfully added");
                    }
                }
                else if (cmdArgs[0] == "Remove")
                {
                    if (!deck.Contains(cmdArgs[1]))
                    {
                        Console.WriteLine("Card not found");
                    }
                    else
                    {
                        Console.WriteLine($"Card successfully removed");
                        deck.Remove(cmdArgs[1]);

                    }
                }
                else if (cmdArgs[0] == "Remove At")
                {
                    int index = int.Parse(cmdArgs[1]);

                    if (index >= 0 && index < deck.Count)
                    {
                        deck.RemoveAt(index);
                        Console.WriteLine($"Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (cmdArgs[0] == "Insert") 
                {
                    int index = int.Parse(cmdArgs[1]);

                    if (index < 0 || index >= deck.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else if (index >= 0 && index < deck.Count && deck.Contains(cmdArgs[2]))
                    {
                        Console.WriteLine("Card is already added");
                    }
                    else if (index >= 0 && index < deck.Count && !deck.Contains(cmdArgs[2])) 
                    {
                        deck.Insert(index, cmdArgs[2]);
                        Console.WriteLine("Card successfully added");

                    }
                }

            }

            Console.WriteLine(string.Join(", ", deck));
        }
    }
}