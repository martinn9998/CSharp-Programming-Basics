string product = Console.ReadLine();
string city = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
double price = 0;
if (city == "Sofia")
{
    if (product == "coffee")
    {
        price = quantity * 0.5;

        Console.WriteLine(Math.Round(price, 2));
    }


    if (product == "water")
    {
        price = quantity * 0.8;

        Console.WriteLine(Math.Round(price, 2));
    }


    if (product == "beer")
    {
        price = quantity * 1.20;

        Console.WriteLine(Math.Round(price, 2));
    }


    if (product == "sweets")
    {
        price = quantity * 1.45;

        Console.WriteLine(Math.Round(price, 4));
    }


    if (product == "peanuts")
    {
        price = quantity * 1.6;

        Console.WriteLine(Math.Round(price, 2));
    }


}

else if (city == "Plovdiv")
{
    if (product == "coffee")
    {
        price = quantity * 0.4;

        Console.WriteLine(Math.Round(price, 2));
    }


    if (product == "water")
    {
        price = quantity * 0.7;

        Console.WriteLine(Math.Round(price, 2));
    }


    if (product == "beer")
    {
        price = quantity * 1.15;

        Console.WriteLine(Math.Round(price, 2));
    }


    if (product == "sweets")
    {
        price = quantity * 1.3;

        Console.WriteLine(Math.Round(price, 2));
    }


    if (product == "peanuts")
    {
        price = quantity * 1.5;

        Console.WriteLine(Math.Round(price, 2));
    }

}
else if (city == "Varna")
{
    if (product == "coffee")
    {
        price = quantity * 0.45;

        Console.WriteLine(Math.Round(price, 2));
    }


    if (product == "water")
    {
        price = quantity * 0.7;

        Console.WriteLine(Math.Round(price, 2));
    }


    if (product == "beer")
    {
        price = quantity * 1.1;

        Console.WriteLine(Math.Round(price, 2));
    }


    if (product == "sweets")
    {
        price = quantity * 1.35;

        Console.WriteLine(Math.Round(price, 2));
    }


    if (product == "peanuts")
    {
        price = quantity * 1.55;

        Console.WriteLine(Math.Round(price, 2));
    }

}