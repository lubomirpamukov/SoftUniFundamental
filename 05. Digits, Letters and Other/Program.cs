namespace _05._Digits__Letters_and_Other
{
    using System;
    using System.Diagnostics;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();


            string text = Console.ReadLine(); // takes input from the console line



            /* StringBuilder numbers = // creating a stringbuilder class for the numbers for better preformance
                 new StringBuilder();

             StringBuilder letters =   // creating StringBuilder class for the letters for better preformance
                 new StringBuilder();

             StringBuilder symbols =  // createing StringBuilder class for the symbols for better preformance
                  new StringBuilder();

             for (int i = 0; i < text.Length; i++) // loop that iterates through every char in the input
             {
                 char currchar = text[i]; // taking the current char for easy readability
                 if (char.IsDigit(currchar)) // checking if its digit
                 {
                     numbers.Append(currchar); // if its digit appends it to the numbres stringbuilder
                 }
                 else if (char.IsLetter(currchar)) // checks if it's letter , if it is appends it to the letters stringbuilder
                 {
                     letters.Append(currchar);
                 }
                 else  // if its not char or letter , its symbol appends it to the symbol stringbuilder 
                 {
                     symbols.Append(currchar);
                 }
             }
            */
            string numbers = new string(text.Where(char.IsDigit).ToArray());// iterates through the input and adds all the numbers to a new string variable
            string letters = new string(text.Where(char.IsLetter).ToArray());// iterates through the input and adds all the letters to a new string variable
            string symbols = new string(text.Where(c => !char.IsLetterOrDigit(c)).ToArray());// ittarates through the input, and if its NOT number or letter add it to the symbol string

             Console.WriteLine(numbers); // prints number
             Console.WriteLine(letters); // prints letters
             Console.WriteLine(symbols); // prints symbols
            
        }
    }
}