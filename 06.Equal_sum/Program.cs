int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();


bool equalSums = false;
int index = 0;

for (int i = 0; i < array.Length; i++)
{
    int leftSum = 0;
    int rightSum = 0;

    for (int left = 0; left < i; left++)
    {
        if (i-1 >= 0 )
        {
           int leftNumber = array[left];
            leftSum += leftNumber;
            
        }
    }

    for (int right = i; right < array.Length-1; right++)
    {
        if (right + 1 < array.Length)
        {
            int rightNumber = array[right + 1];
            rightSum += rightNumber;
            
        }
    }

    if (rightSum == leftSum)
    {
        equalSums = true;
        index = i;
        
    }
}

if (equalSums == true)
{
    Console.WriteLine(index);
}
else
    Console.WriteLine("no");

