int numbeOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
string numberTextOne = numbeOne.ToString();
string numberTextTwo = numberTwo.ToString();
int a1 = 0;
int a2 = 0;
int b1 = 0;
int b2 = 0;
int c1 = 0;
int c2 = 0;
int d1 = 0;
int d2 = 0;
char letter = ' ';
int i = 0;


for (; i < numberTextOne.Length; i++)
{
    letter = numberTextOne[i];
    if (i == 0)
    {
        a1 = letter - '0';
    }
    else if (i == 1)
    {
        b1 = letter - '0';
    }
    else if (i == 2)
    {
        c1 = letter - '0';
    }
    else if (i == 3)
    {
        d1 = letter - '0';
    }
}

i = 0;

for (; i < numberTextTwo.Length; i++)
{
    letter = numberTextTwo[i];
    if (i == 0)
    {
        a2 = letter - '0';
    }
    else if (i == 1)
    {
        b2 = letter - '0';
    }
    else if (i == 2)
    {
        c2 = letter - '0';
    }
    else if (i == 3)
    {
        d2 = letter - '0';
    }
}

for (int t1 = a1; t1 <= a2; t1++)
{
    for (int t2 = b1; t2 <= b2; t2++)
    {
        for (int t3 = c1; t3 <= c2; t3++)
        {
            for (int t4 = d1; t4 <= d2; t4++)
            {
                if (t1 % 2 == 1)
                {
                    if (t2 % 2 == 1)
                    {
                        if (t3 % 2 == 1)
                        {
                            if (t4 % 2 == 1)
                            {
                                Console.Write($"{t1}{t2}{t3}{t4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}