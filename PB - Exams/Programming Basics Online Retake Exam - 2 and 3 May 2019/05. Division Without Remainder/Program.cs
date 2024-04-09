int n = int.Parse(Console.ReadLine());
if (1 <= n && n <= 1000)
{
    int input = 0;
    int divideBy2 = 0;
    int divideBy3 = 0;
    int divideBy4 = 0;
    for (int i = 0; i < n; i++)
    {
        input = int.Parse((Console.ReadLine()));
        if (input % 3 == 0)
        {
            divideBy3++;
        }
        if (input % 4 == 0)
        {
            divideBy4++;
        }
        if (input % 2 == 0)
        {
            divideBy2++;
        }
    }
    double divideBy02 = divideBy2;
    double divideBy03 = divideBy3;
    double divideBy04 = divideBy4;

    double percentDividedBy2 = (divideBy02 / 10) * 100;
    double percentDividedBy3 = (divideBy03 / 10) * 100;
    double percentDividedBy4 = (divideBy04 / 10) * 100;
    Console.WriteLine($"{percentDividedBy2:f2}%");
    Console.WriteLine($"{percentDividedBy3:f2}%");
    Console.WriteLine($"{percentDividedBy4:f2}%");
}