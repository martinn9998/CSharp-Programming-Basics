int n = int.Parse(Console.ReadLine());
int cntP1 = 0;
int cntP2 = 0;
int cntP3 = 0;
int cntP4 = 0;
int cntP5 = 0;
double p1Percentage = 0;
double p2Percentage = 0;
double p3Percentage = 0;
double p4Percentage = 0;
double p5Percentage = 0;
double sumOfPeople = 0;
for (int i = 0; i < n; i++)
{
    double currentNumber = double.Parse(Console.ReadLine());
    if (currentNumber <= 5)
    {
        cntP1++;
        sumOfPeople += currentNumber;
        p1Percentage += currentNumber;
    }
    else if (currentNumber >= 6 & currentNumber <= 12)
    {
        cntP2++;
        sumOfPeople += currentNumber;
        p2Percentage += currentNumber;
    }
    else if (currentNumber >= 13 & currentNumber <= 25)
    {
        cntP3++;
        sumOfPeople += currentNumber;
        p3Percentage += currentNumber;
    }
    else if (currentNumber >= 26 & currentNumber <= 40)
    {
        cntP4++;
        sumOfPeople += currentNumber;
        p4Percentage += currentNumber;
    }
    else if (currentNumber >= 41)
    {
        cntP5++;
        sumOfPeople += currentNumber;
        p5Percentage += currentNumber;
    }
}
double firstPercent = (p1Percentage / sumOfPeople) * 100;
double secondPercent = (p2Percentage / sumOfPeople) * 100;
double thirdPercent = (p3Percentage / sumOfPeople) * 100;
double fourthPercent = (p4Percentage / sumOfPeople) * 100;
double fifthPercent = (p5Percentage / sumOfPeople) * 100;

Console.WriteLine($"{firstPercent:f2}%");
Console.WriteLine($"{secondPercent:f2}%");
Console.WriteLine($"{thirdPercent:f2}%");
Console.WriteLine($"{fourthPercent:f2}%");
Console.WriteLine($"{fifthPercent:f2}%");

