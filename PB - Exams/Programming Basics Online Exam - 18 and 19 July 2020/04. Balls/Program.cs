double n = double.Parse(Console.ReadLine());
double points = 0;
string typeOfBall = string.Empty;
double red = 0;
double orange = 0;
double yellow = 0;
double white = 0 ;
double black = 0 ;
double others = 0 ;
for (int i = 0; i < n; i++)
{
    typeOfBall = Console.ReadLine();
    if (typeOfBall=="red")
    {
        points += 5;
        red++;
    }
    else if (typeOfBall == "orange")
    {
        points += 10;
        orange++;
    }
    else if (typeOfBall == "yellow")
    {
        points += 15;
        yellow++;
    }
    else if (typeOfBall == "white")
    {
        points += 20;
        white++;
    }
    else if (typeOfBall == "black")
    {
        points = Math.Floor(points / 2);
        black++;
    }
    else
    {
        others++;
    }
}

Console.WriteLine($"Total points: {points}");
Console.WriteLine($"Red balls: {red}");
Console.WriteLine($"Orange balls: {orange}");
Console.WriteLine($"Yellow balls: {yellow}");
Console.WriteLine($"White balls: {white}");
Console.WriteLine($"Other colors picked: {others}");
Console.WriteLine($"Divides from black balls: {black}");
