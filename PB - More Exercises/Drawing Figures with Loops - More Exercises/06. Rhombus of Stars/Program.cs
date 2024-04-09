int n = int.Parse(Console.ReadLine());
int s = n - 1;
int star = 1;
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= s; j++)
    {
        Console.Write(' ');
    }
    for (int k = 1; k <= star; k++)
    {
        Console.Write('*');
        Console.Write(" ");
    }
    for (int j = 1; j <= s-1; j++)
    {
        Console.Write(' ');
    }
    Console.WriteLine();
    star++;
    s--; 
}
star--;
star--;
s++;
s++;
for (int i = 1; i <= n ; i++)
{

    for (int j = 1; j <= s; j++)
    {
        Console.Write(' ');
    }
    for (int k = 1; k <= star; k++)
    {
        Console.Write('*');
        Console.Write(" ");
    }
    for (int j = 1; j <= s - 1; j++)
    {
        Console.Write(' ');
    }
    Console.WriteLine();
    star--;
    s++;
}