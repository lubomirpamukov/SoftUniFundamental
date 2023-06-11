string[] arrayA = Console.ReadLine()
    .Split()
    .ToArray();

string[] arrayB = Console.ReadLine()
    .Split()
    .ToArray();

string[] comparedArrays = new string[arrayA.Length];

for (int i = 0; i < arrayA.Length; i++)
{
    for (int j = 0; j < arrayB.Length; j++)
    {
        if (arrayA[i] == arrayB[j])
        {
            Console.Write(arrayA[i] + " ");
            break;
        }
    }
}

