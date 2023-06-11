int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int evenSum = 0 ;

for (int i = 0; i < numbers.Length; i++)
{
	if (numbers[i] % 2 == 0)
	{
		evenSum += numbers[i];
	}
}
Console.WriteLine(evenSum);
