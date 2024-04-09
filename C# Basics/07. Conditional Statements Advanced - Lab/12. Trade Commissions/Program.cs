string city = Console.ReadLine();
double valueSales = double.Parse(Console.ReadLine());

if (0 <= valueSales & valueSales <= 500)
{
    if (city == "Sofia")
    {
        double commission = valueSales * 0.05;
        Console.WriteLine($"{commission:f2}");
    }
    else if (city == "Varna")
    {
        double commission = valueSales * 0.045;
        Console.WriteLine($"{commission:f2}");
    }
    else if (city == "Plovdiv")
    {
        double commission = valueSales * 0.055;
        Console.WriteLine($"{commission:f2}");
    }
    else if ((city != "Sofia" | city != "Varna" | city != "Plovdiv") | valueSales < 0)
    {
        Console.WriteLine("error");
    }
}
else if (500 < valueSales & valueSales <= 1000)
{
    if (city == "Sofia")
    {
        double commission = valueSales * 0.07;
        Console.WriteLine($"{commission:f2}");
    }
    else if (city == "Varna")
    {
        double commission = valueSales * 0.075;
        Console.WriteLine($"{commission:f2}");
    }
    else if (city == "Plovdiv")
    {
        double commission = valueSales * 0.08;
        Console.WriteLine($"{commission:f2}");
    }
    else if ((city != "Sofia" | city != "Varna" | city != "Plovdiv") | valueSales < 0)
    {
        Console.WriteLine("error");
    }
}
else if (1000 < valueSales & valueSales <= 10000)
{
    if (city == "Sofia")
    {
        double commission = valueSales * 0.08;
        Console.WriteLine($"{commission:f2}");
    }
    else if (city == "Varna")
    {
        double commission = valueSales * 0.10;
        Console.WriteLine($"{commission:f2}");
    }
    else if (city == "Plovdiv")
    {
        double commission = valueSales * 0.12;
        Console.WriteLine($"{commission:f2}");
    }
    else if ((city != "Sofia" | city != "Varna" | city != "Plovdiv") | valueSales < 0)
    {
        Console.WriteLine("error");
    }
}
else if (valueSales > 10000)
{
    if (city == "Sofia")
    {
        double commission = valueSales * 0.12;
        Console.WriteLine($"{commission:f2}");
    }
    else if (city == "Varna")
    {
        double commission = valueSales * 0.13;
        Console.WriteLine($"{commission:f2}");
    }
    else if (city == "Plovdiv")
    {
        double commission = valueSales * 0.145;
        Console.WriteLine($"{commission:f2}");
    }
    else if ((city != "Sofia" | city != "Varna" | city != "Plovdiv") | valueSales < 0)
    {
        Console.WriteLine("error");
    }
}
else if (valueSales < 0)
{
    Console.WriteLine("error");
}