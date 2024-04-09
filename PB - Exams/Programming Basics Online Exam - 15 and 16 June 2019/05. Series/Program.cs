double budget = double.Parse(Console.ReadLine());
int numberOfSeries = int.Parse(Console.ReadLine());
string nameOfSeries = "";
double priceOfSeries = 0;
double sumPrice = 0;
for (int i = 0; i< numberOfSeries; i++)
{
    nameOfSeries = Console.ReadLine();
    priceOfSeries = double.Parse(Console.ReadLine());
    if (nameOfSeries == "Thrones")
    {
        priceOfSeries = priceOfSeries * 0.5;
    }
    else if (nameOfSeries == "Lucifer")
    {
        priceOfSeries = priceOfSeries * 0.6;
    }
    else if (nameOfSeries == "Protector")
    {
        priceOfSeries = priceOfSeries * 0.7;
    }
    else if (nameOfSeries == "TotalDrama")
    {
        priceOfSeries = priceOfSeries * 0.8;
    }
    else if (nameOfSeries == "Area")
    {
        priceOfSeries = priceOfSeries * 0.9;
    }
    sumPrice += priceOfSeries;
}

    if (budget >= sumPrice)
{
    Console.WriteLine($"You bought all the series and left with {budget - sumPrice:f2} lv.");
}
    else
{
    Console.WriteLine($"You need {sumPrice-budget:f2} lv. more to buy the series!");
}
