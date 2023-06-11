int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int rotationCount = int.Parse(Console.ReadLine());

int condenseCount = rotationCount % array.Length;

for (int i = 0; i < condenseCount; i++)
{

    int firstNumber = array[0];

    for (int j = 1; j < array.Length; j++)
    {
        array[j-1] = array[j];
    }

    array[array.Length - 1] = firstNumber;
}

Console.WriteLine(string.Join(" ", array));