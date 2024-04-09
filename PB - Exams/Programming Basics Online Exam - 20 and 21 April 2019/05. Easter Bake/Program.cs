double maxNumberFlour = double.MinValue;
double maxNumberSugar = double.MinValue;
double numberOfEasterBreads = double.Parse(Console.ReadLine());
double flourSum = 0;
double sugarSum = 0;
double packetsSugar = 0;
double packetsFlour = 0;

for (int i = 0; i < numberOfEasterBreads; i++)
{
    int ammountSugarUsed = int.Parse(Console.ReadLine());
    if (ammountSugarUsed>maxNumberSugar)
    {
        maxNumberSugar = ammountSugarUsed;
    }
    sugarSum += ammountSugarUsed;
    int ammountFlourUsed = int.Parse(Console.ReadLine());
    if (ammountFlourUsed>maxNumberFlour)
    {
        maxNumberFlour = ammountFlourUsed;
    }
    flourSum += ammountFlourUsed;
}
packetsSugar = Math.Ceiling(sugarSum / 950);
packetsFlour = Math.Ceiling(flourSum / 750);
Console.WriteLine($"Sugar: {packetsSugar}");
Console.WriteLine($"Flour: {packetsFlour}");
Console.WriteLine($"Max used flour is {maxNumberFlour} grams, max used sugar is {maxNumberSugar} grams.");