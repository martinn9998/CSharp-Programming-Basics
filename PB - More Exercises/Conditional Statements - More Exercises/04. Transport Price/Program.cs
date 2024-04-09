int n = int.Parse(Console.ReadLine());
string dayOrNight = Console.ReadLine();
double price = 0, priceCalculation = 0;
bool taxi = false;
if (n >= 100)
{
    switch (dayOrNight)
    {
        case "day":

            price = 0.06;
            break;
        case "night":

            price = 0.06;
            break;
    }
}
else if (n >= 20 && n<100)
{
    switch (dayOrNight)
    {
        case "day":

            price = 0.09;
            break;
        case "night":

            price = 0.09;
            break;
    }
}
else if (n >= 1 && n <20)
{
    switch (dayOrNight)
    {
        case "day":

            price = 0.79;
            taxi = true;
            break;
        case "night":

            price = 0.90;
            taxi = true;
            break;
    }
}
if (taxi)
{
    priceCalculation = (price * n) + 0.70;
    Console.WriteLine($"{priceCalculation:f2}");
}
else
{
    priceCalculation = price * n;
    Console.WriteLine($"{priceCalculation:f2}");
}