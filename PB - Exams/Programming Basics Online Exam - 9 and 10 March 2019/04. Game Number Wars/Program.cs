string nameFirstPlayer = Console.ReadLine();
string nameSecondPlayer = Console.ReadLine();
int firstPlayerCard = 0;
int secondPlayerCard = 0;
int firstPlayerPoints = 0;
int secondPlayerPoints = 0;
bool numberWars = false;
string textInput = "";
int firstPlayerScore = 0;
int secondPlayerScore = 0;
int firstPlayerScoreNumberWar = 0;
int secondPlayerScoreNumberWar = 0;

for (; true; )
{
    textInput = Console.ReadLine();
    if (textInput=="End of game")
    {
        Console.WriteLine($"{nameFirstPlayer} has {firstPlayerScore} points");
        Console.WriteLine($"{nameSecondPlayer} has {secondPlayerScore} points");
        break;
    }
    firstPlayerCard = int.Parse(textInput);
    textInput = Console.ReadLine();
    if (textInput == "End of game")
    {
        Console.WriteLine($"{nameFirstPlayer} has {firstPlayerScore} points");
        Console.WriteLine($"{nameSecondPlayer} has {secondPlayerScore} points");
        break;
    }
    secondPlayerCard = int.Parse(textInput);
    if (firstPlayerCard>secondPlayerCard)
    {
        
        if (numberWars)
        {
            firstPlayerScoreNumberWar = firstPlayerCard - secondPlayerCard;
            Console.WriteLine($"{nameFirstPlayer} is winner with {firstPlayerScore} points");
            break;
        }
        else
        {
            firstPlayerPoints = firstPlayerCard - secondPlayerCard;
            firstPlayerScore += firstPlayerPoints;
        }
    }
    else if (firstPlayerCard<secondPlayerCard)
    {
        
        if (numberWars)
        {
            secondPlayerScoreNumberWar = secondPlayerCard - firstPlayerCard;
            Console.WriteLine($"{nameSecondPlayer} is winner with {secondPlayerScore} points");
            break;
        }
        else
        {
            secondPlayerPoints = secondPlayerCard - firstPlayerCard;
            secondPlayerScore += secondPlayerPoints;
        }
    }
    else if (firstPlayerCard==secondPlayerCard)
    {
        Console.WriteLine("Number wars!");
        numberWars = true;

        continue;
    }
}    