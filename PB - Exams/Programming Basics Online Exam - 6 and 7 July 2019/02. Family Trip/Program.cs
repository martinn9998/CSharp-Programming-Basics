double budget = double.Parse(Console.ReadLine());
int nightsStay = int.Parse(Console.ReadLine());
double priceNightStay = double.Parse(Console.ReadLine());
double additionalCost = double.Parse(Console.ReadLine());
double stayPrice = 0;
double discount = 0;
double allSum = 0;
double percentCalculation = 0;
if (nightsStay > 7)
{
    discount = priceNightStay * 0.95;
    stayPrice = nightsStay * discount;
    percentCalculation = budget * (additionalCost / 100);
    allSum = stayPrice + percentCalculation;
    if (allSum <= budget)
    {
        double result = budget - allSum;
        Console.WriteLine($"Ivanovi will be left with {result:f2} leva after vacation.");
    }
    else
    {
        double result = allSum - budget;
        Console.WriteLine($"{result:f2} leva needed.");
    }
}
else if (nightsStay <= 7)
{
    stayPrice = nightsStay * priceNightStay;
    percentCalculation = budget * (additionalCost / 100);
    allSum = stayPrice + percentCalculation;
    if (allSum <= budget)
    {
        double result = budget - allSum;
        Console.WriteLine($"Ivanovi will be left with {result:f2} leva after vacation.");
    }
    else
    {
        double result = allSum - budget;
        Console.WriteLine($"{result:f2} leva needed.");
    }
}