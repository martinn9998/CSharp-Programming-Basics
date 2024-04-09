while (true)
{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int n3 = int.Parse(Console.ReadLine());
    if (!(n1 >= 1 && n1 <= 9))
    {
        break;
    }
    if (!(n2 >= 1 && n2 <= 9))
    {
        break;
    }
    if (!(n3 >= 1 && n3 <= 9))
    {
        break;
    }
    for (int i = 1; i <= n1; i++)
    {
        for (int j = 1; j <= n2; j++)
        {
            for (int k = 1; k <= n3; k++)
            {
                if (i % 2 == 0 && j >= 2 && j <= 7 && k % 2 == 0)
                {
                    if (j == 2 || j == 3 || j == 5 || j == 7)
                    {
                        Console.WriteLine($"{i} {j} {k}");
                    }
                }
            }
        }
    }
    break;
}