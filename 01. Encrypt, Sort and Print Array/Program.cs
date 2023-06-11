namespace _01._Encrypt__Sort_and_Print_Array
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfArrays = int.Parse(Console.ReadLine());
            int[] finalArray = new int[numberOfArrays];

            for (int i = 0; i < numberOfArrays; i++)
            {
                string currentName = Console.ReadLine();
                char[] nameArray = currentName.ToCharArray();


                for (int j = 0; j < nameArray.Length; j++)
                {
                    int sum = default;

                    if (nameArray[j] == 'a' || nameArray[j] == 'e' || nameArray[j] == 'i' || nameArray[j] == 'o' || nameArray[j] == 'u')
                    {
                        sum = nameArray[j] * nameArray.Length;
                        finalArray[i] += sum;

                    }
                    else
                    { 
                        sum = nameArray[j] / nameArray.Length;
                        finalArray[i] += sum;
                        
                    }
                }
            }

            Array.Sort(finalArray);
            for (int i = 0; i < finalArray.Length; i++)
            {
                Console.WriteLine(finalArray[i]);
            }
        }
    }
}