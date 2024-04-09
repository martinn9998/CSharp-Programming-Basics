int n = int.Parse(Console.ReadLine());
int space = n;
int stars = 0;
for (int i = 1; i <= n + 1; i++)
{
    for (int j = 1; j <= space; j++)
    {
        Console.Write(' ');
    }
    for (int k = 1; k <= stars; k++)
    {
        Console.Write('*');
    }
    Console.Write(' ');
    Console.Write('|');
    Console.Write(' ');
    for (int k = 1; k <= stars; k++)
    {
        Console.Write('*');
    }
    for (int j = 1; j <= space; j++)
    {
        Console.Write(' ');
    }
    stars++;
    space--;
    Console.WriteLine();
}