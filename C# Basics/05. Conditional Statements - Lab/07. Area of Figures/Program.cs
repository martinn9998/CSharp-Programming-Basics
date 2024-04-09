string figure = Console.ReadLine();
if (figure == "square")
{
    double lenght = double.Parse(Console.ReadLine());
    Console.WriteLine($"{lenght * lenght}");
}
if (figure == "rectangle")
{
    double lenght = double.Parse(Console.ReadLine());
    double widtht = double.Parse(Console.ReadLine());
    Console.WriteLine($"{lenght * widtht}");
}
if (figure == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    double result = Math.Round(Math.Pow(radius, 2) * Math.PI, 3);
    Console.WriteLine(result);
}
if (figure == "triangle")
{
    double lenght = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());
    double result = Math.Round((0.5 * lenght) * height, 3);
    Console.WriteLine($"{result}");
}