int[] arrayA = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] arrayB = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sum = 0;
bool flag = true;

for (int i = 0; i < arrayA.Length; i++)
{
    if (arrayA[i] == arrayB[i])
        sum = sum + arrayA[i];
    else
    { Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        flag = false;
        break;
    }
}

if (flag== true)
    Console.WriteLine($"Arrays are identical. Sum: {sum}");