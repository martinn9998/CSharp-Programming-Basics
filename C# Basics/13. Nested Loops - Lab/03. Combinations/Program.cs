int number = int.Parse(Console.ReadLine());
int combinations = 0;
int successfulCombinations = 0;
for (int i = 0; i <= number; i++)
{
    for (int j = 0; j <= number; j++)
    {
        for (int f = 0; f <= number; f++)
        { 
            combinations++;
        if (i + j + f == number)
        {          
            successfulCombinations++;
        }
        }
    }
}

    Console.WriteLine(successfulCombinations);
