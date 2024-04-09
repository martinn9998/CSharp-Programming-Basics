int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
char symbol1 = ' ';
int symbol2 = 0;
int symbol3 = 0;
int symbol4 = 0;

for (int i = a1; i <= a2 - 1; i++)
{
    
        
        symbol1 = (char)i;


    for (int j = 1; j <= n - 1; j++)
    {
        symbol2 = j;

        for (int k = 1; k <= n; k++)
        {
            if (k <= (n / 2) - 1)
            {
                symbol3 = k;

                symbol4 = symbol1;

                if (symbol4 % 2 == 1 && (symbol2 + symbol3 + symbol4) % 2 == 1)
                {
                    Console.WriteLine($"{symbol1}-{symbol2}{symbol3}{symbol4}");
                }
            }
        }
    }
}
    

    

    
    
    

