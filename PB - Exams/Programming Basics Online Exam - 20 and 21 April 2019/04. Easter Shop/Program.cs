int initialNumberEggs = int.Parse(Console.ReadLine());
string input = "";
int numberRequiestedEggs = 0;
bool isTrue = true;
int countSold = 0;
double initialNumberEggs1 = 0;
while (true)
{
    input = Console.ReadLine();
    if (input== "Close")
    {
        Console.WriteLine($"Store is closed!");
        Console.WriteLine($"{countSold} eggs sold.");
        isTrue = false;
        break;
    }
    else if (input=="Buy")
    {
        numberRequiestedEggs = int.Parse(Console.ReadLine());
        initialNumberEggs1 = initialNumberEggs;
         initialNumberEggs1 -= numberRequiestedEggs;
        
        if (initialNumberEggs1<0)
        {
            
            break;
        }

        initialNumberEggs -= numberRequiestedEggs;
        countSold += numberRequiestedEggs;
    }
    else if (input=="Fill")
    {
        numberRequiestedEggs = int.Parse(Console.ReadLine());
        initialNumberEggs += numberRequiestedEggs;
    }
    

}
if (isTrue)
{
    Console.WriteLine($"Not enough eggs in store!");
    Console.WriteLine($"You can buy only {initialNumberEggs}.");
}
