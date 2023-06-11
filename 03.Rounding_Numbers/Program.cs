double[] numbers = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToArray();


for (int i = 0; i < numbers.Length ; i++)
{
    Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");

}



