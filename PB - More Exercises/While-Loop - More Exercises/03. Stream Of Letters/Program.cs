
char letter = ' ';
string input = " ", output = " ";
int letterC = 0;
int letterO = 0;
int letterN = 0;
bool space1 = false, space2 = false, space3 = false;
string word = string.Empty;
while (true)
{
    if (space1 && space2 && space3)
    {
        char letterSpace = ' ';
        word += letterSpace;
        output += word;
        word = string.Empty;
        space1 = false;
        space2 = false;
        space3 = false;
        letterC = 0;
        letterN = 0;
        letterO = 0;
        continue;
    }
    input = Console.ReadLine();
    if (input == "End")
    {
        break;
    }
    letter = char.Parse(input);

   
    if (letter == 'c' || letter == 'o' || letter == 'n')
    {
       if (letterC==0 && letter == 'c')
        {
            letterC++;
            space1 = true;
            continue;
        }
       if (letterO==0 && letter == 'o')
        {
            letterO++;
            space2 = true;
            continue;
        }
       if (letterN == 0 && letter == 'n')
        {
            letterN++;
            space3 = true;
            continue;
        }
    }

    if ((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z'))
    {
        word += letter;
    }

}
Console.WriteLine(output);