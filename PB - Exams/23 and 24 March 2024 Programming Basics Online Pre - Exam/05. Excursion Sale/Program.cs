int seaVacations = int.Parse(Console.ReadLine());  //680
int mountainVacations = int.Parse(Console.ReadLine()); //499
int sum = 0, sea = 0, mountain = 0;
bool seaSold = false, mountainSold = false;
while (true)
{
    if (seaSold && mountainSold)
    {
        break;
    }
    string input = Console.ReadLine();
    if (input== "Stop")
    {
        break;
    }
    if (input == "sea" && sea < seaVacations)
    {
        sum += 680;
        sea++;
    }
    else if (input == "mountain" && mountain < mountainVacations)
    {
        sum += 499;
        mountain++;
    }
    

    if (mountain==mountainVacations)
    {
        mountainSold = true;
    }
    if (sea==seaVacations)
    {
        seaSold = true;
    }
}
if (seaSold && mountainSold)
{
    Console.WriteLine($" Good job! Everything is sold.");
}
Console.WriteLine($"Profit: {sum} leva.");