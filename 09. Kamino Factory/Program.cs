namespace _09._Kamino_Factory
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());

            int longestSequence = default;
            int[] longestSequanceArray= new int[arrayLength];
            int biggestSum = default;
            int sampleCounter = default;
            int bestSampleNumber = default;
            int sequenceStart = default;

            string end;
            while ((end = Console.ReadLine()) != "Clone them!")
            {
                int[] current = new int[arrayLength];

                current = end.Split("!").Select(int.Parse).ToArray();

                int counter = 1; 
                int currentSum = current[0];
                int currentSequenceStart = default;
                sampleCounter++;

                for (int i = 1; i < current.Length ; i++)
                {
                    currentSum += current[i];
                   
                    if (current[i - 1] == current[i] && current[i] == 1)
                    {
                        counter++;
                        
                    }
                   
                }

                if (counter > longestSequence 
                    || (counter == longestSequence && currentSequenceStart < sequenceStart)
                    || (counter == longestSequence && currentSequenceStart == sequenceStart && currentSum > biggestSum))
                {
                    longestSequanceArray = current;
                    longestSequence = counter;
                    biggestSum = currentSum;
                    bestSampleNumber = sampleCounter;
                    sequenceStart = currentSequenceStart;
                }
                
            }
                Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {biggestSum}.");
                Console.Write(string.Join(" ", longestSequanceArray));
                

            
        }
    }
}