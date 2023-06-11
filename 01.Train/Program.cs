int numberOfWagons = int.Parse(Console.ReadLine());

int[] passangerInWagon = new int[numberOfWagons];

int totalPassangers = 0;

for (int i = 0; i < numberOfWagons; i++)
{
    passangerInWagon[i] = int.Parse((Console.ReadLine()));
    totalPassangers += passangerInWagon[i];
}

for (int i = 0; i < passangerInWagon.Length; i++)
{
    Console.Write(passangerInWagon[i]+ " ");
}
Console.WriteLine($"\n{totalPassangers}");
