int n = int.Parse(Console.ReadLine());
int ceiling = (n + 1) / 2;
int stars = 0;
int lowerDashes = 0;
int basis = n / 2;
if (n%2 == 0)
{
    stars = 2; 
}
else
{
    stars = 1;
}
lowerDashes = (n - stars)/2;
for  (int i = 1; i <= ceiling; i++)
{
    for (int j = 1; j <= lowerDashes; j++)
    {
        Console.Write('-');
    }
    for (int j = 1; j <= stars; j++)
    {
        Console.Write('*');
    }
    for (int j = 1; j <= lowerDashes; j++)
    {
        Console.Write('-');
    }
    lowerDashes--;
    stars++;
    stars++;
    Console.WriteLine();
}
stars = n - 2;

for (int i = 1; i <= basis; i++)
{
    Console.Write('|');
    for (int j = 1; j <= stars; j++)
    {
        Console.Write('*');
    }
    Console.Write('|');
    Console.WriteLine();
}