int heightWall = int.Parse(Console.ReadLine());
int widthWall = int.Parse(Console.ReadLine());
double percent = (100 - double.Parse(Console.ReadLine())) / 100;

double allSquareMeters = Math.Ceiling(heightWall * widthWall * 4 * percent);

while (true)
{
    string input = Console.ReadLine();
    if (input == "Tired!")
    {
        Console.WriteLine($"{allSquareMeters} quadratic m left.");
        break;
    }

    double paint = double.Parse(input);
    allSquareMeters -= paint;

    if (allSquareMeters == 0)
    {
        Console.WriteLine("All walls are painted! Great job, Pesho!");
        break;
    }
    else if (allSquareMeters < 0)
    {
        allSquareMeters = Math.Abs(allSquareMeters);
        Console.WriteLine($"All walls are painted and you have {allSquareMeters} l paint left!");
        break;
    }
}