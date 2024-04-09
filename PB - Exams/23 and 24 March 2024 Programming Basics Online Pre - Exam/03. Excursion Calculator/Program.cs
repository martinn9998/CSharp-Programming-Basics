int n = int.Parse(Console.ReadLine());
string season  = Console.ReadLine();
double price = 0;

switch (season)
{
    case "spring":
        if (n>=1 && n<=5)
        {
            price = 50.00;
        }
        else if (n>=6)
        {
            price = 48.00;
        }
        break;
    case "summer":
        if (n >= 1 && n <= 5)
        {
            price = 48.50;
        }
        else if (n >= 6)
        {
            price = 45.00;
        }
        break;
    case "autumn":
        if (n >= 1 && n <= 5)
        {
            price = 60.00;
        }
        else if (n >= 6)
        {
            price = 49.50;
        }
        break;
    case "winter":
        if (n >= 1 && n <= 5)
        {
            price = 86.00;
        }
        else if (n >= 6)
        {
            price = 85.00;
        }
        break;
}

double priceSum = price * n;

switch (season)
{
    case "summer":
        priceSum *= 0.85;
        break;
    case "winter":
        priceSum *= 1.08;
        break;
}

Console.WriteLine($"{priceSum:f2} leva.");