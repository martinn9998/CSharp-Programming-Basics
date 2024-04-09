int input = int.Parse(Console.ReadLine());
int sum = 0;
int num = 0;
int value = 0;
for (int i = 0; i < input; i++)
{
    num = int.Parse(Console.ReadLine());
    switch (i)
    {
        case 0:
            value = num + value;
            break;
        case 1:
            value = num + value;
            break;
        case 2:
            value = num + value;
            break;
        case 3:
            value = num + value;
            break;
        case 4:
            value = num + value;
            break;

    }
}
Console.WriteLine(value);