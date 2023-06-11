namespace _07._Max_Sequence_of_Equal_Elements
{
    using System;
   

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int lastNumber = 0;
            int count = 1;

            for (int i = 0; i < array.Length; i++)
            {
                int counter = 1;
                int curNumber = 0;

                if (array[i] == array[i+1])
                {
                    counter++;
                    curNumber = array[i];
                    if ( i> 0 && array[i] == array[i-1] )
                    {
                        counter++;
                    }
                }
                
                if (counter >= count)
                {
                    count= counter;
                    lastNumber = curNumber;
                }
            }

            int[] printArray = new int[count];

            foreach (int i in printArray) 
            {
                Console.Write(lastNumber + " ");
            }
        }
    }
}