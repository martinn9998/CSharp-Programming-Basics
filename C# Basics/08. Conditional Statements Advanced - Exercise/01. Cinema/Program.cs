string projection = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int coloumns = int.Parse(Console.ReadLine());
if (projection == "Premiere")
{
    double result = (rows * coloumns) * 12;
    Console.WriteLine($"{result:f2}");
}
else if (projection == "Normal")
{
    double result = (rows * coloumns) * 7.5;
    Console.WriteLine($"{result:f2}");
}
else if (projection == "Discount")
{
    double result = (rows * coloumns) * 5;
    Console.WriteLine($"{result:f2}");
}