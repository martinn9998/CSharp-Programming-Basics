char begin = char.Parse(Console.ReadLine());
char end = char.Parse(Console.ReadLine());
char skip = char.Parse(Console.ReadLine());
int count = 0;

for (char i = begin; i <= end; i++)
{
    if (i == skip)
    {
        continue;
    }
    for (char j = begin; j <= end; j++)
    {
        if (j == skip)
        {
            continue;
        }
        for (char k = begin; k <= end; k++)
        {
            if (k == skip)
            {
                continue;
            }
            count++;
            Console.Write($"{i}{j}{k} ");
        }
    }
}
Console.Write(count);