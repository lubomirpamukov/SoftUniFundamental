namespace _06._Cards_Game
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                int iteration = 1;

                for (int i = 0; i < iteration; i++)
                {
                    if (firstPlayer[i] > secondPlayer[i])
                    {
                        int currCard = firstPlayer[i];
                        firstPlayer.RemoveAt(i);
                        firstPlayer.Add(currCard);
                        int cardWon = secondPlayer[i];
                        secondPlayer.RemoveAt(i);
                        firstPlayer.Add(cardWon);

                    }
                    else if (firstPlayer[i] < secondPlayer[i])
                    {
                        int currCard = secondPlayer[i];
                        secondPlayer.RemoveAt(i);
                        secondPlayer.Add(currCard);
                        int cardWon = firstPlayer[i];
                        firstPlayer.RemoveAt(i);
                        secondPlayer.Add(cardWon);
                    }
                    else if (firstPlayer[i] == secondPlayer[i]) 
                    {
                        firstPlayer.RemoveAt(i);
                        secondPlayer.RemoveAt(i);
                    }

                    iteration = Math.Min(firstPlayer.Count, secondPlayer.Count);
                }
            }

            int firstPlayerSum = firstPlayer.Sum();
            int secondPlayerSum = secondPlayer.Sum();

            if (firstPlayerSum > secondPlayerSum)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerSum}");
            }
            else if (secondPlayerSum > firstPlayerSum) 
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerSum}");

            }

        }
        
    }
}