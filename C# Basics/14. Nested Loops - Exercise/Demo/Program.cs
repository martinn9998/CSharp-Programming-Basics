
bool isTrue = false;
int primeNumbersSum = 0;
int nonpPrimeNumbersSum = 0;
int d = 1;
for (int i = 0; i < d ; i++)
{
    if (isTrue)
    {
        break;
    }
    string textn1 = "-2";
    int n1 = int.Parse(textn1);
    if (textn1=="stop")
    {
        isTrue = true;
        Console.WriteLine($"Sum of all prime numbers is: {primeNumbersSum}");
        Console.WriteLine($"Sum of all non prime numbers is: {nonpPrimeNumbersSum}");
        break;
    }
    if (n1 <= 0)
    {
        d++;
        d++;
        Console.WriteLine("Number is negative.");
        continue;

    }
    int  s, m = 0, flag = 0;
    
    m = n1 / 2;
    for (s = 2; s <= m; s++)
    {
        if (n1 % s == 0)
        {
            flag = 1;
            nonpPrimeNumbersSum += n1;
            d++;
            break;
        }
    }
    if (flag == 0)
        primeNumbersSum += n1;
    d++;
}