int n = int.Parse(Console.ReadLine());
int stars = 0;
int dashes = 0;
int middleDashes = 0;
int halfN = 0;
if (n % 2 == 0)
{
    stars = 2;
    halfN = n / 2;
}
else
{
    stars = 1;
    halfN = n / 2 + 1;
}
dashes = (n - stars) / 2;
middleDashes = n - 2 * dashes - 2;
for (int i = 1; i <= halfN; i++)
{
    for (int j = 1; j <= dashes; j++)
    {
        Console.Write('-');
    }
    for (int j = 1; j <= stars; j++)
    {

        Console.Write('*');
    }
    stars = 1;
    if (middleDashes >= 0)
    {
        for (int j = 1; j <= middleDashes; j++)
        {
            Console.Write('-');
        }
        if (i > 1)
        {
            Console.Write('*');
        }
    }

    for (int j = 1; j <= dashes; j++)
    {
        Console.Write('-');
    }
    dashes--;
    middleDashes++;
    middleDashes++;
    Console.WriteLine();

}
dashes++;
dashes++;
middleDashes--;
middleDashes--;
middleDashes--;
middleDashes--;
for (int i = 1; i <= halfN-1; i++)
{
    for (int j = 1; j <= dashes; j++)
    {
        Console.Write('-');
    }
    for (int j = 1; j <= stars; j++)
    {
        Console.Write('*');
    }
    stars = 1;
    if (middleDashes >= 0)
    {
        for (int j = 1; j <= middleDashes; j++)
        {
            Console.Write('-');
        }
            Console.Write('*');
    }

    for (int j = 1; j <= dashes; j++)
    {
        Console.Write('-');
    }
    dashes++;
    middleDashes--;
    middleDashes--;
    Console.WriteLine();

}