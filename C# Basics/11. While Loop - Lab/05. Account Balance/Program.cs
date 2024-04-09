double increase = 0;
double total = 0;
int cycles1 = 0;
int cycles2 = 0;
int cycles3 = 0;
int cycles4 = 0;
double number = 0;
double maxValue = double.MaxValue;
double minValue = double.MinValue;
string input = Console.ReadLine();
cycles1++;


while (input != "NoMoreMoney")
{
    if (cycles2 >= cycles1)
    {
        input = Console.ReadLine();
        if (input == "NoMoreMoney")
        {
            Console.WriteLine($"Total: {total:f2}");
            cycles4++;
            break;
        }

        else
        {
            number = double.Parse(input);

            cycles3++;
        }

    }
    else if (cycles2 < cycles1)
    {
        number = double.Parse(input);
        cycles2++;
        cycles3++;
    }
    else if (input == "NoMoreMoney")
    {
        Console.WriteLine($"Total: {total:f2}");
        cycles4++;
        break;
    }

    while (cycles2 == cycles3)
    {

        if (number < 0)
        {

            Console.WriteLine("Invalid operation!");
            input = "NoMoreMoney";
            break;
        }
        increase = number;
        total += increase;
        Console.WriteLine($"Increase: {increase:f2}");
        cycles3--;
    }
}
if (cycles4 == 1)
{
}
else if (cycles4 == 0)
{
    Console.WriteLine($"Total: {total:f2}");
}