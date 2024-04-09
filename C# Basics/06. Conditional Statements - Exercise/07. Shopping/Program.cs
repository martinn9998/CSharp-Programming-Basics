double budget = double.Parse(Console.ReadLine());
int videocards = int.Parse(Console.ReadLine());
int processors = int.Parse(Console.ReadLine());
int ramMemories = int.Parse(Console.ReadLine());
double sumVideocards = videocards * 250;
double processorPrice = sumVideocards * 0.35;
double sumProcessors = processors * processorPrice;
double ramMemoriesPrice = sumVideocards * 0.1;
double sumRamMemories = ramMemories * ramMemoriesPrice;
double sumAll = sumVideocards + sumProcessors + sumRamMemories;
if (videocards > processors) //discount
{
    double discount = sumAll * 0.15;
    double finalPrice = sumAll - discount;
    if (finalPrice <= budget)
    {
        double result = budget - finalPrice;
        double rounded = Math.Round(result, 2);
        string number = string.Format("{0:f2}", rounded);
        Console.WriteLine($"You have {number} leva left!");
    }
    else if (finalPrice > budget)
    {
        double result = finalPrice - budget;
        double rounded = Math.Round(result, 2);
        string number = string.Format("{0:f2}", rounded);
        Console.WriteLine($"Not enough money! You need {number} leva more!");
    }
}
else if (videocards <= processors)
{
    double finalPrice = sumAll;
    if (finalPrice <= budget)
    {
        double result = budget - finalPrice;
        double rounded = Math.Round(result, 2);
        string number = string.Format("{0:f2}", rounded);
        Console.WriteLine($"You have {number} leva left!");
    }
    else if (finalPrice > budget)
    {
        double result = finalPrice - budget;
        double rounded = Math.Round(result, 2);
        string number = string.Format("{0:f2}", rounded);
        Console.WriteLine($"Not enough money! You need {number} leva more!");
    }
}