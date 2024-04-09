int numberOfMongolias = int.Parse(Console.ReadLine());
int numberOfHyacinths = int.Parse(Console.ReadLine());
int numberOfRoses = int.Parse(Console.ReadLine());
int numberOfCacti = int.Parse(Console.ReadLine());
double priceOfTheGift = double.Parse(Console.ReadLine());

double sum = numberOfMongolias * 3.25 + numberOfHyacinths * 4 + numberOfRoses * 3.5 + numberOfCacti * 8;
double profit = sum * 0.95;

if (priceOfTheGift <= profit)
{
    double remaining = Math.Floor(profit - priceOfTheGift);
    Console.WriteLine($"She is left with {remaining} leva.");
}
else
{
    double remaining = Math.Ceiling(priceOfTheGift - profit);
    Console.WriteLine($"She will have to borrow {remaining} leva.");
}