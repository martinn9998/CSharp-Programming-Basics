int n = int.Parse(Console.ReadLine());
int current = 1;
int cols = 1;
bool isBigger = false;
for (int rows = 1; rows <= n; rows++)
{
    for (; cols <= rows; cols++)
    {

        Console.Write("$" + " ");
        current++;

    }
    if (isBigger)
    {
        break;
    }
    Console.WriteLine();
    cols = 1;
}