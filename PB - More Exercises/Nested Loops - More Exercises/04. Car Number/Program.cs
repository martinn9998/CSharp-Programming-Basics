int s = int.Parse(Console.ReadLine());
int f = int.Parse(Console.ReadLine());
for  (int i = s;i<=f;i++)
{
    for (int j = s;j<=f;j++)
    {
        for (int k = s;k<=f;k++)
        {
            for (int l = s;l<=f;l++)
            {
                if (i % 2 == 0 && i > l)
                {
                    if (l%2 == 1 && (j + k) % 2 == 0 )
                    {
                        Console.Write($"{i}{j}{k}{l} ");
                    }
                }
                if (i % 2 == 1 && i > l)
                {
                    if (l % 2 == 0 && (j + k) % 2 == 0)
                    {
                        Console.Write($"{i}{j}{k}{l} ");
                    }
                }

            }
        }
    }
}