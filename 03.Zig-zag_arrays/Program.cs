int numberOfLines = int.Parse(Console.ReadLine());

int[] firstArray = new int[numberOfLines];
int[] secondArray = new int[numberOfLines];


for (int i = 0; i < numberOfLines; i++)
{
    int[] currentLine = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    if (i % 2 == 0)
    {
        firstArray[i] = currentLine[0];
        secondArray[i] = currentLine[1];
    }
    else
    {
        firstArray[i] = currentLine[1];
        secondArray[i] = currentLine[0];
    }
}

Console.WriteLine(String.Join(" ", firstArray));
Console.WriteLine(String.Join(" ", secondArray));