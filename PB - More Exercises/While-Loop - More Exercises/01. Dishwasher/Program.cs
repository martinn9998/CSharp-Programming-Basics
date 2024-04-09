string input = string.Empty;
int bottles = int.Parse(Console.ReadLine());
int ammountSum = bottles * 750;
int count = 0, dishes = 0, pots = 0, ammount = 0;
bool left = false;
while (ammountSum >= 0)
{
    input = Console.ReadLine();
    if (input == "End")
    {
        left = true;
        break;
    }
    count++;
    ammount = int.Parse(input);
    if (count == 3)
    {
        pots += ammount;
        ammount *= 15;
        count = 0;


    }
    else
    {
        dishes += ammount;
        ammount *= 5;

    }
    ammountSum -= ammount;
}
if (left)
{
    Console.WriteLine($"Detergent was enough!");
    Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
    Console.WriteLine($"Leftover detergent {ammountSum} ml.");
}
else
{
    Console.WriteLine($"Not enough detergent, {Math.Abs(ammountSum)} ml. more necessary!");
}