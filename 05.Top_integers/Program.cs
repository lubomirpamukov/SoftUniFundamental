int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();


for (int i = 0; i < array.Length; i++)
{
    bool isTrue = true;
    int currentNum = array[i];

    for (int j = i; j < array.Length - 1; j++)
    {
       

        if (currentNum <= array[j+1])
        {
            isTrue = false;
            break;
        }
    }

    if (isTrue == true)
    {
        Console.Write(array[i] + " ");
    }

}
