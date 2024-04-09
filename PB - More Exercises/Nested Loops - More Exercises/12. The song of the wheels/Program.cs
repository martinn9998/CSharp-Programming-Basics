int controlNumber = int.Parse(Console.ReadLine());
int count = 0;
string password = "";

for (int a = 1; a <= 9; a++)
{
    for (int b = 1; b <= 9; b++)
    {
        for (int c = 1; c <= 9; c++)
        {
            for (int d = 1; d <= 9; d++)
            {
                if (a * b + c * d == controlNumber && a < b && c > d)
                {
                    count++;
                    Console.Write($"{a}{b}{c}{d} ");
                    if (count == 4)
                        password = $"{a}{b}{c}{d}";
                }

            }
        }
    }
}
Console.WriteLine();
if (password != string.Empty)
{
    Console.WriteLine($"Password: {password}");
}
else
{
    Console.WriteLine("No!");
}