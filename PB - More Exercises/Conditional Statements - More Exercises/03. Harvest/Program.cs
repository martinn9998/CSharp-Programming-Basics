int x = int.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());
int workers = int.Parse(Console.ReadLine());
double wholeGrape = x * y;
double wine = (wholeGrape / 2.5) * 0.40;
if (wine >= z)
{
    double remaining = Math.Floor(wine - z);
    double remainingPerPerson = Math.Ceiling(remaining / workers);
    Console.WriteLine($"Good harvest this year! Total wine: {wine} liters.");
    Console.WriteLine($"{remaining} liters left -> {remainingPerPerson} liters per person.");
}
else
{
    double remaining = Math.Floor(z - wine);
    Console.WriteLine($"It will be a tough winter! More {remaining} liters wine needed.");
}