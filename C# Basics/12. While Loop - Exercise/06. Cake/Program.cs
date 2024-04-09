string input = "";
int lenght = 0;
int width = 0;
bool isTrue = true;
bool isTrue2 = true;
int pieces = 0;
int take = 0;

while (isTrue)
{
    if (pieces < 0)
    {
        pieces = Math.Abs(pieces);
        Console.WriteLine($"No more cake left! You need {pieces} pieces more.");
        isTrue = false;
        isTrue2 = false;
        break;
    }
    input = Console.ReadLine();

    if (input == "STOP")
    {
        isTrue = false;
    }
    else if (lenght <= 0)
    {
        lenght = int.Parse(input);
    }
    else if (width <= 0)
    {
        width = int.Parse(input);
        pieces = lenght * width;
    }
    else if (pieces > 0)
    {
        take = int.Parse(input);
        pieces -= take;
    }


}
if (isTrue2)
{
    Console.WriteLine($"{pieces} pieces are left.");
}
else
{ }