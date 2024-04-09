int numberPaintedEggs = int.Parse(Console.ReadLine());
string colour = "";
int countRed = 0;
int countOrange = 0;
int countBlue = 0;
int countGreen = 0;
int compareValue = 0;
string maxValueString = "";
int maxValue = int.MinValue;
for  (int i = 0; i < numberPaintedEggs; i++)
{
    colour = Console.ReadLine();
    if (colour == "red")
    {
        countRed++;
        compareValue = countRed;
        if (compareValue>maxValue)
        {
            maxValue = compareValue;
            maxValueString = "red";
        }
        compareValue = 0;
    }
    else if (colour == "orange")
    {
        countOrange++;
        compareValue = countOrange;
        if (compareValue > maxValue)
        {
            maxValue = compareValue;
            maxValueString = "orange";
        }
        compareValue = 0;
    }
        else if (colour == "blue")
    {
        countBlue++;
        compareValue = countBlue;
        if (compareValue > maxValue)
        {
            maxValue = compareValue;
            maxValueString = "blue";
        }
        compareValue = 0;
    }
    else if(colour == "green")
    {
        countGreen++;
        compareValue = countGreen;
        if (compareValue > maxValue)
        {
            maxValue = compareValue;
            maxValueString = "green";
        }
        compareValue = 0;
    }
}

Console.WriteLine($"Red eggs: {countRed}");
Console.WriteLine($"Orange eggs: {countOrange}");
Console.WriteLine($"Blue eggs: {countBlue}");
Console.WriteLine($"Green eggs: {countGreen}");
Console.WriteLine($"Max eggs: {maxValue} -> {maxValueString}");
