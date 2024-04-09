int n = int.Parse(Console.ReadLine());
int multiply = 0, sum = 0;
bool found = false;

for  (int a = 1; a <= 9; a++)
{
    for (int b = 9; b >= a; b--)
    {
        for (int c = 0; c <= 9; c++)
        {
            for (int d = 9; d >= c; d--)
            {
                multiply = a * b * c * d;
                sum = a + b + c + d;
                if (sum==multiply && n % 10 == 5)
                {
                    Console.WriteLine($"{a}{b}{c}{d}");
                    found = true;
                    break;
                }
                if (multiply/sum==3 && n%3==0)
                {
                    Console.WriteLine($"{d}{c}{b}{a}");
                    found = true;
                        break;
                }
            }
            if (found)
            {
                break;
            }
        }
        if (found)
        {
            break;
        }

    }
    if (found)
    {
        break;
    }

}

if  (found)
{

}
else
{
    Console.WriteLine("Nothing found");
}