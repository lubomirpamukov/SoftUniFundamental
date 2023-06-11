int number = int.Parse(Console.ReadLine());

string[] dayOfWeek =
    {
        "Monday",
        "Tuesday",
        "Wednesday",
        "Thursday",
        "Friday",
        "Saturday",
        "Sunday",
    };

if (number >= 1 && number <= 7)
{
    
    Console.WriteLine($"{dayOfWeek[number - 1]}");
}
else
{
    Console.WriteLine($"Invalid day!");
}
