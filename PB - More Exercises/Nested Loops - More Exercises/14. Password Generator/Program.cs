int n = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());

for (int x1 = 1; x1 <= n; x1++)
{
    for (int x2 = 1; x2 <= n; x2++)
    {
        for (int x3 = 97; x3 < 97 + l; x3++) // ASCII кодове за малките букви от 'a' до 'z'
        {
            for (int x4 = 97; x4 < 97 + l; x4++)
            {
                for (int x5 = Math.Max(x1, x2) + 1; x5 <= n; x5++)
                {
                    Console.Write($"{x1}{x2}{(char)x3}{(char)x4}{x5} ");
                }
            }
        }
    }
}
