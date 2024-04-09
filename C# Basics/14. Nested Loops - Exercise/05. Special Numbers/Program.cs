int n = int.Parse(Console.ReadLine());
int n1 = 0;
int n2 = 0;
int n3 = 0;
int n4 = 0;
for (int i = 1; i <= 9; i++)
{
    
    for (int j = 1; j <= 9; j++)
    {
        
        for (int k = 1; k <= 9; k++)
        {
            
            for (int l = 1; l <= 9; l++)
            {
                if (n % i == 0)
                {
                    n1 = i;

                    if (n % j == 0)
                    {
                        n2 = j;

                        if (n % k == 0)
                        {
                            n3 = k;


                            if (n % l == 0)
                            {
                                n4 = l;
                                Console.Write($"{n1}{n2}{n3}{n4} ");
                            }
                        }
                    }
                }
                
                
            }
        }
    }
}