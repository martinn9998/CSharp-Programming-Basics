int n = int.Parse(Console.ReadLine());
int star = n * 2;
int space = n;
int rows = n - 2;
int k = star - 2;
int rowCount = 0;
for (int i = 1; i <= star; i++)
{
    Console.Write('*');
}
for (int i = 1; i <= space; i++)
{
    Console.Write(' ');
}
for (int i = 1; i <= star; i++)
{
    Console.Write('*');
}
rowCount++;
Console.WriteLine();
for (int i = 1; i <= rows; i++)
{
    Console.Write('*');
    for (int j = 1; j <= k; j++)
    {
        Console.Write('/');
    }
    Console.Write('*');
    if (rowCount== (n - 1) / 2 )
    {
        for (int h = 1; h <= n; h++)
        {
            Console.Write('|');
        }
    }
    else
    {
        for (int h = 1; h <= n; h++)
        {
            Console.Write(' ');
        }
    }
    Console.Write('*');
    for (int j = 1; j <= k; j++)
    {
        Console.Write('/');
    }
    Console.Write('*');
    rowCount++;
    Console.WriteLine();
}
for (int i = 1; i <= star; i++)
{
    Console.Write('*');
}
for (int i = 1; i <= space; i++)
{
    Console.Write(' ');
}
for (int i = 1; i <= star; i++)
{
    Console.Write('*');
}
Console.WriteLine();