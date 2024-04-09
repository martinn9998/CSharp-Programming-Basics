double budgetOfMovie = double.Parse(Console.ReadLine());
string destination = Console.ReadLine();
string season = Console.ReadLine();
int daysNumber = int.Parse(Console.ReadLine());

double price = 0;
double finalPrice = 0;

if (destination == "Dubai")
{
    if  (season == "Winter")
    {
        price = 45000;
    }
    else if (season == "Summer")
    {
        price = 40000;
    }
}
else if (destination == "Sofia")
{
    if (season == "Winter")
    {
        price = 17000;
    }
    else if (season == "Summer")
    {
        price = 12500;
    }
}
else if (destination == "London")
{
    if (season == "Winter")
    {
        price = 24000;
    }
    else if (season == "Summer")
    {
        price = 20250;
    }
}

finalPrice = price * daysNumber;

if (destination == "Dubai")
{
   finalPrice = finalPrice * 0.7;
}

if (destination == "Sofia")
{
   finalPrice = finalPrice * 1.25;
}

if (budgetOfMovie>=finalPrice)
{
   Console.WriteLine($"The budget for the movie is enough! We have {budgetOfMovie-finalPrice:f2} leva left!");
}
else 
{
   Console.WriteLine($"The director needs {finalPrice-budgetOfMovie:f2} leva more!");
}