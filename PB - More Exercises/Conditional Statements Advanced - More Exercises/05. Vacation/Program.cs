double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
double price = 0;
if (budget>3000)
{
    if (season=="Summer")
    {
        price = budget * 0.9;
        Console.WriteLine($"Alaska - Hotel - {price:f2}");
    }
    else if (season=="Winter")
    {
        price = budget * 0.9;
        Console.WriteLine($"Morocco - Hotel - {price:f2}");
    }
}
else if (budget>1000 && budget<=3000)
{
    if (season == "Summer")
    {
        price = budget * 0.8;
        Console.WriteLine($"Alaska - Hut - {price:f2}");
    }
    else if (season == "Winter")
    {
        price = budget * 0.6;
        Console.WriteLine($"Morocco - Hut - {price:f2}");
    }
}
else if (budget<=1000)
{
    if (season == "Summer")
    {
        price = budget * 0.65;
        Console.WriteLine($"Alaska - Camp - {price:f2}");
    }
    else if (season == "Winter")
    {
        price = budget * 0.45;
        Console.WriteLine($"Morocco - Camp - {price:f2}");
    }
}
