double budget = double.Parse(Console.ReadLine());
double littersFuelNeeded = double.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();
double FuelPrice = 2.1;
double tourGuide = 100;
double sumPrice = 0;
double sumFulePrice = littersFuelNeeded * FuelPrice;
sumPrice = sumFulePrice + tourGuide;
if (dayOfWeek == "Saturday")
{
    sumPrice = sumPrice * 0.9;
}
else if (dayOfWeek == "Sunday")
{
    sumPrice = sumPrice * 0.8;
}
if (budget>=sumPrice)
{
    double moneyLeft = budget - sumPrice;
    Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv.");
}
else
{
    double moneyNeeded = sumPrice - budget;
    Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
}