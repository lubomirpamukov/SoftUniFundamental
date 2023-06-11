namespace _02._Hospital
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int sumCheckedPatients = 0;
            int sumUncheckedPatients = 0;
            int doctors = 7;

            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0)
                {
                    if (sumUncheckedPatients > sumCheckedPatients)
                    {
                        doctors++;
                    }
                }
                int patiants = int.Parse(Console.ReadLine());
                int checkedPatients = 0;
                int uncheckedPatients = 0;
                if (doctors >= patiants)
                {
                    checkedPatients = patiants;
                    uncheckedPatients = 0;
                }
                else 
                {
                    uncheckedPatients = patiants - doctors;
                    checkedPatients = doctors;
                }

                sumCheckedPatients += checkedPatients;
                sumUncheckedPatients += uncheckedPatients;
            }

            Console.WriteLine($"Treated patients: {sumCheckedPatients}.");
            Console.WriteLine($"Untreated patients: {sumUncheckedPatients}.");
      
        }
    }
}