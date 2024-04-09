double days = double.Parse(Console.ReadLine());
double hoursForADay = double.Parse(Console.ReadLine());
double taxForAHour = 0;
double sumDay = 0;
double total = 0;
double tax250 = 0;
double tax125 = 0;
double tax100 = 0;
for (int i = 1; i <= days; i++)
{
    for (int k = 1; k <= hoursForADay; k++)
    {
        if (i % 2 == 0)
        {
            if (k % 2 == 1)
            {
                tax250++;
            }
            else
            {
                tax100++;
            }
        }
        else if (i % 2 == 1)
        {
            if (k % 2 == 0)
            {
                tax125++;
            }
            else
            {
                tax100++;
            }
        }
        else
        {
            tax100++;
        }
        

    }
    tax100 = tax100 * 1;
    tax125 = tax125 * 1.25;
    tax250 = tax250 * 2.50;
    sumDay = tax100 + tax125 + tax250;
    total += sumDay;
    Console.WriteLine($"Day: {i} - {sumDay:f2} leva");
    tax100 = 0;
    tax125 = 0;
    tax250 = 0;
    sumDay = 0;
}

Console.WriteLine($"Total: {total:f2} leva");