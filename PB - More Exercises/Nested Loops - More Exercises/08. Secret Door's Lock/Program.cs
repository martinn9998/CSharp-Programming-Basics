int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

for (int x1 = 1; x1 <= a; x1++)
{
    for (int x2 = 1; x2 <= b; x2++)
    {
        for (int x3 = 1; x3 <= c; x3++)
        {
            if (x1%2==0&&x3%2==0)
            {
                if (x2==2 || x2 == 3 || x2 == 5 || x2==7)
                {
                    Console.WriteLine($"{x1} {x2} {x3}");
                }
            }
        }
    }
}    