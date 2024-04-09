int startFirstCouple = int.Parse(Console.ReadLine());
int startSecondCouple = int.Parse(Console.ReadLine());
int differenceFirstC = int.Parse(Console.ReadLine());
int differenceSecondC = int.Parse(Console.ReadLine());
int sX1, sX2, mX1 = 0, mX2 = 0, flagX1 = 0, flagX2 = 0;

int finalFirstCouple = startFirstCouple + differenceFirstC;
int finalSecondCouple = startSecondCouple + differenceSecondC;


for (int x1 = startFirstCouple; x1 <= finalFirstCouple; x1++)
{
    mX1 = x1 / 2;
    for (sX1 = 2; sX1 <= mX1; sX1++)
    {
        if (x1 % sX1 == 0)
        {
            flagX1 = 1;
            //nonpPrimeNumbersSum += n1;
            // d++;
            break;
        }
    }

    for (int x2 = startSecondCouple; x2 <= finalSecondCouple; x2++)
    {
        mX2 = x2 / 2;
        for (sX2 = 2; sX2 <= mX2; sX2++)
        {
            if (x2 % sX2 == 0)
            {
                flagX2 = 1;
                //nonpPrimeNumbersSum += n1;
                // d++;
                break;
            }
        }
        if (flagX2 == 0 && flagX1 == 0)
        {
            Console.WriteLine($"{x1}{x2}");
        }
        flagX2 = 0;

    }
    flagX1 = 0;
}








