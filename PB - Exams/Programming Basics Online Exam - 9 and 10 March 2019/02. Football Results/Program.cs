

string resultFirstMatch = Console.ReadLine();
string resiltSecondMatch = Console.ReadLine();
string resultThirdMatch = Console.ReadLine();
int i = 0;
char letter = ' ';
int a1 = 0;
int a2 = 0;
int b1 = 0;
int b2 = 0;
int c1 = 0;
int c2 = 0;
int wonGame = 0;
int lostGame = 0;
int drawnGame = 0;

for (; i < resultFirstMatch.Length; i++)
{
    letter = resultFirstMatch[i];
    if (i == 0)
    {
        a1 = letter - '0';
    }
    else if (i == 2)
    {
        a2 = letter - '0';
    }
    
}
i = 0;

for (; i < resiltSecondMatch.Length; i++)
{
    letter = resiltSecondMatch[i];
    if (i == 0)
    {
        b1 = letter - '0';
    }
    else if (i == 2)
    {
        b2 = letter - '0';
    }

}
i = 0;
for (; i < resultThirdMatch.Length; i++)
{
    letter = resultThirdMatch[i];
    if (i == 0)
    {
        c1 = letter - '0';
    }
    else if (i == 2)
    {
        c2 = letter - '0';
    }

}
if (a1 > a2)
{
    ++wonGame; 
}
else if (a1<a2)
{
    ++lostGame;
}
else if (a1==a2)
{
    ++drawnGame;
}
if (b1 > b2)
{
    ++wonGame;
}
else if (b1 < b2)
{
    ++lostGame;
}
else if (b1 == b2)
{
    ++drawnGame;
}
if (c1 > c2)
{
    ++wonGame;
}
else if (c1 < c2)
{
    ++lostGame;
}
else if (c1 == c2)
{
    ++drawnGame;
}
Console.WriteLine($"Team won {wonGame} games.");
Console.WriteLine($"Team lost {lostGame} games.");
Console.WriteLine($"Drawn games: {drawnGame}");

