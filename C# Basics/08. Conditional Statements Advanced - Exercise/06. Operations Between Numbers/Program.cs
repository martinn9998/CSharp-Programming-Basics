double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
char symbol = char.Parse(Console.ReadLine());
if (symbol == '/')
{
    if (num2 == 0)
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
    else
    {
        double result = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {result:f2}");
    }
}
else if (symbol == '%')
{
    if (num2 == 0)
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
    else
    {
        double result = num1 % num2;
        Console.WriteLine($"{num1} % {num2} = {result:f0}");
    }
}
else if (symbol == '+')
{
    if ((num1 + num2) % 2 == 0)
    {
        Console.WriteLine($"{num1} + {num2} = {(num1 + num2):f0} - even");
    }
    else
    {
        Console.WriteLine($"{num1} + {num2} = {(num1 + num2):f0} - odd");
    }
}
else if (symbol == '-')
{
    if ((num1 - num2) % 2 == 0)
    {
        Console.WriteLine($"{num1} - {num2} = {(num1 - num2):f0} - even");
    }
    else
    {
        Console.WriteLine($"{num1} - {num2} = {(num1 - num2):f0} - odd");
    }
}
else if (symbol == '*')
{
    if ((num1 * num2) % 2 == 0)
    {
        Console.WriteLine($"{num1} * {num2} = {(num1 * num2):f0} - even");
    }
    else
    {
        Console.WriteLine($"{num1} * {num2} = {(num1 * num2):f0} - odd");
    }
}
