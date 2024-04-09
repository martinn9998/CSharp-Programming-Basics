int numberOfMaleCustormers = int.Parse(Console.ReadLine());
int numberOfFemaleCustormers = int.Parse(Console.ReadLine());
int maximumNumberOfTables = int.Parse(Console.ReadLine());
int count = 0;

for  (int i = 1; i <= numberOfMaleCustormers; i++)
{
    for (int j = 1; j <= numberOfFemaleCustormers; j++)
    {
        if (count >= maximumNumberOfTables)
        {
            break;
        }
        Console.Write($"({i} <-> {j}) ");
            count++;
    }
}
