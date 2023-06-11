string input = string.Empty;
string word = string.Empty;

bool flagC = true;
bool flagO = true;
bool flagN = true;

while ((input = Console.ReadLine()) != "End")
{
    char currentChar = char.Parse(input);

    if (currentChar < 'A' || currentChar > 'Z' && currentChar < 'a' || currentChar > 'z')
    {
        continue;
    }
   

    if (currentChar == 'c' && flagC == true)
    {
        flagC = false;
        currentChar = '\0';
    }
    else if (currentChar == 'o' && flagO == true)
    {
        flagO = false;
        currentChar = '\0';

    }
    else if (currentChar == 'n' && flagN == true)
    {
        flagN = false;
        currentChar = '\0';

    }

    if (flagC == false && flagO == false && flagN == false)
    {
        flagN= true;
        flagC= true;
        flagO = true;
        Console.WriteLine(word + " ");
        word = string.Empty;
    }
}
