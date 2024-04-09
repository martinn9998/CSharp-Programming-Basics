double degrees = double.Parse(Console.ReadLine());
string time = Console.ReadLine();
string outfit = "";
string shoes = "";
if (time == "Morning")
{
    if (10 <= degrees & degrees <= 18)
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }
    else if (18 < degrees & degrees <= 24)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }
    else if (25 <= degrees)
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }
}
else if (time == "Afternoon")
{
    if (10 <= degrees & degrees <= 18)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }
    else if (18 < degrees & degrees <= 24)
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }
    else if (25 <= degrees)
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }
}
else if (time == "Evening")
{
    if (10 <= degrees & degrees <= 18)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }
    else if (18 < degrees & degrees <= 24)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }
    else if (25 <= degrees)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }
}