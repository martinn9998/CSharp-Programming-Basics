double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
double price = 0;
if (budget>500)
{
    Console.WriteLine($"Luxury class");
    price = budget * 0.9;
    Console.WriteLine($"Jeep - {price:f2}");
}
else if (budget>100 && budget <= 500)
{
    if (season=="Summer")
    {
        Console.WriteLine($"Compact class");
        price = budget * 0.45; 
        Console.WriteLine($"Cabrio - {price:f2}");
    }
    else if (season=="Winter")
    {
        Console.WriteLine($"Compact class");
        price = budget * 0.8;
        Console.WriteLine($"Jeep - {price:f2}");
    }
}
else if (budget<=100)
{
    Console.WriteLine($"Economy class");
    if (season == "Summer")
    {
        price = budget * 0.35;
        Console.WriteLine($"Cabrio - {price:f2}");
    }
    else if (season == "Winter")
    {
        price = budget * 0.65;
        Console.WriteLine($"Jeep - {price:f2}");
    }
}