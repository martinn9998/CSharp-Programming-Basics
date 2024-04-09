double allSumCost = 0;
double budgetAvailable = double.Parse(Console.ReadLine());
double nightStays = double.Parse(Console.ReadLine());
double priceNightStay = double.Parse(Console.ReadLine());
double percentAdditionalCost = double.Parse(Console.ReadLine());
if (nightStays > 7)
{
    priceNightStay = priceNightStay * 0.95;
    allSumCost = (priceNightStay * nightStays) + (budgetAvailable * (percentAdditionalCost / 100));
    if (budgetAvailable >= allSumCost)
    {
        Console.WriteLine($"Ivanovi will be left with {budgetAvailable - allSumCost:f2} leva after vacation.");
    }
    else if (budgetAvailable < allSumCost)
    {
        Console.WriteLine($"{allSumCost - budgetAvailable:f2} leva needed.");
    }
}
else if (nightStays >= 7)

{
    allSumCost = (priceNightStay * nightStays) + (budgetAvailable * (percentAdditionalCost / 100));
    if (budgetAvailable >= allSumCost)
    {
        Console.WriteLine($"Ivanovi will be left with {budgetAvailable - allSumCost:f2} leva after vacation.");
    }
    else if (budgetAvailable < allSumCost)
    {
        Console.WriteLine($"{allSumCost - budgetAvailable:f2} leva needed.");
    }

}