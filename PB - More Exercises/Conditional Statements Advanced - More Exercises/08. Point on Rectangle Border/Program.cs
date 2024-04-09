double x1 = double.Parse(Console.ReadLine()); //2
double y1 = double.Parse(Console.ReadLine()); //-3
double x2 = double.Parse(Console.ReadLine()); //12
double y2 = double.Parse(Console.ReadLine()); //3
double x = double.Parse(Console.ReadLine()); //8    12
double y = double.Parse(Console.ReadLine()); //-1   -1
if (x == x1 || x == x2)
{
    if (y > y1 && y < y2)
    {
        Console.WriteLine("Border");
    }
    else if (y == y1 || y == y2)
    {
        Console.WriteLine("Border");
    }
    else
    {
        Console.WriteLine("Inside / Outside");
    }
}

else if (y == y1 || y == y2)
{
    if (x > x1 && x < x2)
    {
        Console.WriteLine("Border");
    }
    else if (x == x1 || x == x2)
    {
        Console.WriteLine("Border");
    }
    else
    {
        Console.WriteLine("Inside / Outside");
    }
}
else
{
    Console.WriteLine("Inside / Outside");
}
