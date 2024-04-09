while (true)
{
    
    double number = double.Parse(Console.ReadLine());
    if (number < 0)
    {
        break;
    }
    number *= 2;
    Console.WriteLine($"Result: {number:f2}");
}
Console.WriteLine("Negative number!");