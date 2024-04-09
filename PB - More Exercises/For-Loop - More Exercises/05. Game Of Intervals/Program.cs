int number = int.Parse(Console.ReadLine());
double points = 0;
double pointsSum = 0, input = 0;
double number40 = 0, number30 = 0,
number20 = 0, number10 = 0, number0 = 0, invaid = 0;
for (int i = 0; i < number; i++)
{
    input = double.Parse(Console.ReadLine());
    if (input >= 40 && input <= 50)
    {
        number40++;
        points = 100;
        pointsSum += points;
    }
    else if (input >= 30 && input <= 39)
    {
        number30++;
        points = 50;
        pointsSum += points;
    }
    else if (input >= 20 && input <= 29)
    {
        number20++;
        points = input * 0.40;
        pointsSum += points;
    }
    else if (input >= 10 && input <= 19)
    {
        number10++;
        points = input * 0.30;
        pointsSum += points;
    }
    else if (input >= 0 && input <= 9)
    {
        number0++;
        points = input * 0.20;
        pointsSum += points;
    }
    else
    {
        invaid++;
        pointsSum = pointsSum / 2;
    }
}
double numberAll = number40 + number30 + number20 + number10 + number0 + invaid;
double number40Perc = (number40 / numberAll) * 100;
double number30Perc = (number30 / numberAll) * 100;
double number20Perc = (number20 / numberAll) * 100;
double number10Perc = (number10 / numberAll) * 100;
double number0Perc = (number0 / numberAll) * 100;
double invalidPerc = (invaid / numberAll) * 100;
Console.WriteLine($"{pointsSum:f2}");
Console.WriteLine($"From 0 to 9: {number0Perc:f2}%");
Console.WriteLine($"From 10 to 19: {number10Perc:f2}%");
Console.WriteLine($"From 20 to 29: {number20Perc:f2}%");
Console.WriteLine($"From 30 to 39: {number30Perc:f2}%");
Console.WriteLine($"From 40 to 50: {number40Perc:f2}%");
Console.WriteLine($"Invalid numbers: {invalidPerc:f2}%");
	