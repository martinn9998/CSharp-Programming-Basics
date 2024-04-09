double budgetMovie = double.Parse(Console.ReadLine());
double actorsNumber = double.Parse(Console.ReadLine());
double priceClothes = double.Parse(Console.ReadLine());
if (actorsNumber >= 150)
{
    double decoration = budgetMovie * 0.1;
    double summClothes = actorsNumber * priceClothes;
    double summMovieExpence = decoration + (summClothes - (summClothes * 0.1));
    if (summMovieExpence > budgetMovie)
    {
        double result = Math.Round(summMovieExpence - budgetMovie, 2);
        string text = string.Format("{0:f2}", result);
        Console.WriteLine("Not enough money!");
        Console.WriteLine($"Wingard needs {text} leva more.");
    }
    else
    {
        double result = Math.Round(budgetMovie - summMovieExpence, 2);
        string text = string.Format("{0:f2}", result);
        Console.WriteLine("Action!");
        Console.WriteLine($"Wingard starts filming with {text} leva left.");
    }
}
else
{
    double decoration = budgetMovie * 0.1;
    double summClothes = actorsNumber * priceClothes;
    double summMovieExpence = decoration + summClothes;
    if (summMovieExpence > budgetMovie)
    {
        double result = Math.Round(summMovieExpence - budgetMovie, 2);
        string text = string.Format("{0:f2}", result);
        Console.WriteLine("Not enough money!");
        Console.WriteLine($"Wingard needs {text} leva more.");
    }
    else
    {
        double result = Math.Round(budgetMovie - summMovieExpence, 2);
        string text = string.Format("{0:f2}", result);
        Console.WriteLine("Action!");
        Console.WriteLine($"Wingard starts filming with {text} leva left.");
    }
}