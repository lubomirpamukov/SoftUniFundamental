namespace _07_Christmas_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Лява част на елхата
            for (int row = 0; row < n; row++)
            {
                // Отпечатване на интервали
                for (int i = 0; i < n - row - 1; i++)
                {
                    Console.Write(" ");
                }

                // Отпечатване на звездички
                for (int j = 0; j <= row; j++)
                {
                    Console.Write("*");
                }

                // Отпечатване на вертикална черта
                Console.Write(" | ");

                // Отпечатване на звездички
                for (int j = 0; j <= row; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Дясна част на елхата
            for (int i = 0; i < n - 1; i++)
            {
                // Отпечатване на интервали
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write(" ");
                }

                // Отпечатване на звездички
                Console.WriteLine("* | *");
            }


        }
        
    }
}