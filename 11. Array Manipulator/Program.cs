namespace _11._Array_Manipulator
{
    using System;
    using System.Diagnostics.Metrics;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string operation;

            while ((operation = Console.ReadLine()) != "end")
            {
                string[] currentOperation = operation.Split().ToArray();

                switch (currentOperation[0])
                {
                    case "exchange":
                        int index = int.Parse(currentOperation[1]);

                        if (index < 0 && index > arrayInput.Length)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        arrayInput = ExchangeMethod(arrayInput, index);
                        break;


                    case "max":

                        if (currentOperation[1] == "even")
                        {
                            Console.WriteLine(MaxEvenorOdd(arrayInput, currentOperation[1]));
                        }
                        else if (currentOperation[1] == "odd") 
                        {
                            Console.WriteLine(MaxEvenorOdd(arrayInput, currentOperation[1]));

                        }
                        break;


                    case "min":

                        if (currentOperation[1] == "even")
                        {
                            Console.WriteLine(MaxEvenorOdd(arrayInput, currentOperation[1]));
                        }
                        else if (currentOperation[1] == "odd")
                        {
                            Console.WriteLine(MaxEvenorOdd(arrayInput, currentOperation[1]));

                        }
                        break;


                    case "first":
                        int numbersCount = int.Parse(currentOperation[1]);

                        if (numbersCount >= arrayInput.Length)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }
                        else
                        {


                            if (currentOperation[2] == "even")
                            {
                                FirstEvenOdds(arrayInput, numbersCount, currentOperation[2]);
                            }
                            else if (currentOperation[2] == "odd")
                            {
                                FirstEvenOdds(arrayInput, numbersCount, currentOperation[2]);

                            }
                        }
                        break;

                    default:
                        break;
                }
               


            
            }
        }

        static int[] ExchangeMethod(int[] input, int index) 
        {
            int[] newArray = new int[input.Length];
            int startIndex = 0;

            for (int i = index + 1; i < input.Length; i++)
            {
                newArray[startIndex++] = input[i];  
            }

            for (int i = 0; i <= index; i++)
            {
                newArray[startIndex++] = input[i];
            }

            return newArray;
        }

        static int MaxEvenorOdd(int[] arrayInput, string evenOdd) 
        {
            int biggestNumber = int.MinValue;
            switch (evenOdd)
            {
                case "even":
                    for (int i = 0; i < arrayInput.Length; i++)
                    {
                        if (arrayInput[i] % 2 == 0 && arrayInput[i] >= biggestNumber)
                        {
                            biggestNumber = arrayInput[i];
                        }
                    }
                    break;
                case "odd":
                    for (int i = 0; i < arrayInput.Length; i++)
                    {
                        if (arrayInput[i] % 2 != 0 && arrayInput[i] >= biggestNumber)
                        {
                            biggestNumber = arrayInput[i];
                        }
                    }
                    break;
                default:
                    break;
            }

            return biggestNumber;
        }

        static int MinEvenorOdd(int[] arrayInput, string evenOdd)
        {
            int smallestNumber = int.MinValue;
            switch (evenOdd)
            {
                case "even":
                    for (int i = 0; i < arrayInput.Length; i++)
                    {
                        if (arrayInput[i] % 2 == 0 && arrayInput[i] >= smallestNumber)
                        {
                            smallestNumber = arrayInput[i];
                        }
                    }
                    break;
                case "odd":
                    for (int i = 0; i < arrayInput.Length; i++)
                    {
                        if (arrayInput[i] % 2 != 0 && arrayInput[i] >= smallestNumber)
                        {
                            smallestNumber = arrayInput[i];
                        }
                    }
                    break;
                default:
                    break;
            }

            return smallestNumber;
        }

        static int[] FirstEvenOdds(int[] arrayInput, int numberCount, string evenOdd) 
        {
                int counter= default;
                int[] array = new int[numberCount];

            if (evenOdd == "even")
            {

                for (int i = 0; i < arrayInput.Length; i++)
                {
                    if (counter == numberCount)
                    {
                        break;
                    }
                    if (arrayInput[i] % 2 == 0)
                    {
                        counter++;

                        array[i] = arrayInput[i];
                    }
                }
            }
            else if (evenOdd == "odd") 
            {
                for (int i = 0; i < arrayInput.Length; i++)
                {
                    if (counter == numberCount)
                    {
                        break;
                    }
                    if (arrayInput[i] % 2 != 0)
                    {
                        counter++;

                        array[i] = arrayInput[i];
                    }
                }
            }

            return array;
        }
    }
}