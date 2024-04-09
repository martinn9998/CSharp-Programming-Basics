double value = double.Parse(Console.ReadLine());

if (value <= 100)
{
    double bonus = 5;
    if (value % 2 == 0)
    {
        double bonusSum = bonus + 1;
        double sum = bonusSum + value;
        Console.WriteLine(bonusSum);
        Console.WriteLine(sum);
    }
    else if (value % 10 == 5)
    {
        double bonusSum = bonus + 2;
        double sum = bonusSum + value;
        Console.WriteLine(bonusSum);
        Console.WriteLine(sum);
    }
    else
    {
        Console.WriteLine(bonus);
        Console.WriteLine(value + bonus);
    }
}
else if (value > 1000)
{
    double bonus = value * 0.1;
    if (value % 2 == 0)
    {
        double bonusSum = bonus + 1;
        double sum = bonusSum + value;
        Console.WriteLine(bonusSum);
        Console.WriteLine(sum);
    }
    else if (value % 10 == 5)
    {
        double bonusSum = bonus + 2;
        double sum = bonusSum + value;
        Console.WriteLine(bonusSum);
        Console.WriteLine(sum);
    }
    else
    {
        Console.WriteLine(bonus);
        Console.WriteLine(value + bonus);
    }
}
else
{
    double bonus = value * 0.2;
    if (value % 2 == 0)
    {
        double bonusSum = bonus + 1;
        double sum = bonusSum + value;
        Console.WriteLine(bonusSum);
        Console.WriteLine(sum);
    }
    else if (value % 10 == 5)
    {
        double bonusSum = bonus + 2;
        double sum = bonusSum + value;
        Console.WriteLine(bonusSum);
        Console.WriteLine(sum);
    }
    else
    {
        Console.WriteLine(bonus);
        Console.WriteLine(bonus + value);
    }
}

