﻿int n = int.Parse(Console.ReadLine());
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
for (int i = 0; i < n; i++)
{
    double currentNumber = double.Parse(Console.ReadLine());
    if (currentNumber < 200) //60
    {
        cntP1++;
    }
    else if (currentNumber >= 200 & currentNumber <= 399) //10
    {
        cntP2++;
    }
    else if (currentNumber >= 400 & currentNumber <= 599) //5
    {
        cntP3++;
    }
    else if (currentNumber >= 600 & currentNumber <= 799) //15
    {
        cntP4++;
    }
    else
    {
        cntP5++;
    }
}
p1Percentage = cntP1 * 100.0 / n;
p2Percentage = cntP2 * 100.0 / n;
p3Percentage = cntP3 * 100.0 / n;
p4Percentage = cntP4 * 100.0 / n;
p5Percentage = cntP5 * 100.0 / n;

Console.WriteLine($"{p1Percentage:f2}%");
Console.WriteLine($"{p2Percentage:f2}%");
Console.WriteLine($"{p3Percentage:f2}%");
Console.WriteLine($"{p4Percentage:f2}%");
Console.WriteLine($"{p5Percentage:f2}%");