int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());
int nComb = 0;
bool stopComb = false;

for (int x1 = 35; x1 <= 55; x1++)
{
    for (int x2 = 64; x2 <= 96; x2++)
    {
        for (int x3 = 1; x3 <= a; x3++)
        {
            for (int x4 = 1; x4 <= b; x4++)
            {
                Console.Write($"{Convert.ToChar(x1)}{Convert.ToChar(x2)}{x3}{x4}{Convert.ToChar(x2)}{Convert.ToChar(x1)}|");
                nComb++;
                x1++;
                x2++;
                if (x1 > 55)
                    x1 = 35;
                if (x2 > 96)
                    x2 = 64;
                if (nComb == max || (x3 == a && x4 == b))
                {
                    stopComb = true;
                    break;
                }
            }
            if (stopComb)
                break;
        }
        if (stopComb)
            break;
    }
    if (stopComb)
        break;
}