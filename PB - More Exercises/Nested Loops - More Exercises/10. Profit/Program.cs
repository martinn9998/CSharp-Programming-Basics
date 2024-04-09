int oneLev = int.Parse(Console.ReadLine());
int twoLeva = int.Parse(Console.ReadLine());
int fiveLeva = int.Parse(Console.ReadLine());
int sum = int.Parse(Console.ReadLine());

for  (int x1 = 0; x1 <= oneLev; x1++)
{
    for (int x2 = 0; x2 <= twoLeva; x2++)
    {
        for (int x3 = 0; x3 <= fiveLeva; x3++)
        {
            if (x1 * 1 + x2 * 2 + x3 * 5 == sum)
            {
                Console.WriteLine($"{x1} * 1 lv. + {x2} * 2 lv. + {x3} * 5 lv. = {sum} lv.");
            }
        }
    }
}
    