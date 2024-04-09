int firstPlayerEggs = int.Parse(Console.ReadLine());
int secondPlayerEggs = int.Parse(Console.ReadLine());
string player = "";
for (; true;)
{
    player = Console.ReadLine();
    if (player == "End")
    {
        Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
        Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
        break;
    }
    else if (player == "one")
    {
        secondPlayerEggs--;
    }
    else if (player == "two")
    {
        firstPlayerEggs--;
    }

    if (firstPlayerEggs == 0)
    {
        Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
        break;
    }
    else if (secondPlayerEggs == 0)
    {
        Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
        break;
    }
}