double boughtFoodInKg = double.Parse(Console.ReadLine());
boughtFoodInKg *= 1000;
string input = string.Empty;
double eaten = 0;
while (true)
{
    input = Console.ReadLine();
    if (input == "Adopted")
    {
        break;
    }
    eaten = double.Parse(input);
    boughtFoodInKg -= eaten;
}

if (boughtFoodInKg >= 0)
{
    Console.WriteLine($"Food is enough! Leftovers: {boughtFoodInKg} grams.");
}
else
{
    Console.WriteLine($"Food is not enough. You need {Math.Abs(boughtFoodInKg)} grams more.");
}