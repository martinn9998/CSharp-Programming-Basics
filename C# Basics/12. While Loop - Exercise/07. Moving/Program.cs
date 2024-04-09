string input = "";
int lenght = 0;
int width = 0;
int height = 0;
bool isTrue = true;
bool isTrue2 = true;
int availableCubicMeters = 0;
int luggageCubicMeters = 0;

while (isTrue)
{
    if (availableCubicMeters < 0)
    {
        availableCubicMeters = Math.Abs(availableCubicMeters);
        Console.WriteLine($"No more free space! You need {availableCubicMeters} Cubic meters more.");
        isTrue = false;
        isTrue2 = false;
        break;
    }
    input = Console.ReadLine();

    if (input == "Done")
    {
        isTrue = false;
    }
    else if (lenght <= 0)
    {
        lenght = int.Parse(input);
    }
    else if (width <= 0)
    {
        width = int.Parse(input);

    }
    else if (height <= 0)
    {
        height = int.Parse(input);
        availableCubicMeters = lenght * width * height;
    }
    else if (availableCubicMeters > 0)
    {
        luggageCubicMeters = int.Parse(input);
        availableCubicMeters -= luggageCubicMeters;
    }


}
if (isTrue2)
{
    Console.WriteLine($"{availableCubicMeters} Cubic meters left.");
}
else
{ }