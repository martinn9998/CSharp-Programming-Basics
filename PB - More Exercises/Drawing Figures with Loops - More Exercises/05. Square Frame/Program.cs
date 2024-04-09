int n = int.Parse(Console.ReadLine());
n -= 2;
Console.Write('+');
Console.Write(' ');
for (int t = 1; t<=n;t++)
{
    Console.Write('-');
    Console.Write(' ');
}
Console.Write('+');
Console.WriteLine();
for (int rows=1; rows <= n; rows++)
{
    Console.Write('|');
    Console.Write(' ');
    for (int cols=1; cols <= n; cols++)
    {
        Console.Write('-');
        Console.Write(' ');
    }
    Console.Write('|');
    Console.WriteLine();
}
Console.Write('+');
Console.Write(' ');
for (int t = 1; t <= n; t++)
{
    Console.Write('-');
    Console.Write(' ');
}
Console.Write('+');